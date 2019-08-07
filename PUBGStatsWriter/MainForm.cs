using PUBGStatsWriter.Models;
using PUBGStatsWriter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUBGStatsWriter
{
    public partial class MainForm : Form
    {
        private PUBGStats PUBGStats = new PUBGStats();
        private ApplicationSettings applicationSettings;
        private FileSystemWatcher directoryWatcher;

        private Stopwatch imageProcessingStopWatch = null;
        private int totalScreenProcessed = 0;
        private double totalProcessingTime = 0;

        delegate void SetTextCallback(string text); //for weird cross thready stuff

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Loads settings from text file
            //If settings dont exist, we need to create a default text file
            applicationSettings = SettingsService.GetApplicationSettings();

            //Default the form values
            this.cbTotalKills.Checked = applicationSettings.TotalKills;
            this.cbTotalDeaths.Checked = applicationSettings.TotalDeaths;
            this.cbKillDeathRatio.Checked = applicationSettings.KillDeathRatio;
            this.cbTotalWins.Checked = applicationSettings.TotalWins;
            this.btnStop.Enabled = false;

            if (!String.IsNullOrEmpty(applicationSettings.OutputDirectory))
            {
                btnSelectLabelOutputDirectory.Text = applicationSettings.OutputDirectory;
            }

            if (!String.IsNullOrEmpty(applicationSettings.ScreenshotDirectory))
            {
                btnOCRDirectory.Text = applicationSettings.ScreenshotDirectory;
            }

            this.SetFilenames();
        }

        /// <summary>
        /// Sets all the filename labels, call this when updating the labels output directory
        /// </summary>
        private void SetFilenames()
        {
            lblTotalKillsFilename.Text = applicationSettings.TotalKillsFilePath;
            lblTotalDeathsFilename.Text = applicationSettings.TotalDeathsFilePath;
            lblKillDeathRatioFilename.Text = applicationSettings.KillDeathRatioFilePath;
            lblTotalWinsFilename.Text = applicationSettings.TotalWinsFilePath;
        }

        private void btnSelectLabelOutputDirectory_Click(object sender, EventArgs e)
        {
            //Let the user select the directory where the stream labels will be generated
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    applicationSettings.OutputDirectory = fldrDlg.SelectedPath;
                    btnSelectLabelOutputDirectory.Text = applicationSettings.OutputDirectory;
                    SettingsService.SaveApplicationSettings(applicationSettings);
                }
            }
        }

        private void btnOCRDirectory_Click(object sender, EventArgs e)
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    applicationSettings.ScreenshotDirectory = fldrDlg.SelectedPath;
                    btnOCRDirectory.Text = applicationSettings.ScreenshotDirectory;
                    SettingsService.SaveApplicationSettings(applicationSettings);
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            this.btnStop.Enabled = true;
            this.btnActivate.Enabled = false;
            this.btnSelectLabelOutputDirectory.Enabled = false;
            this.btnOCRDirectory.Enabled = false;
            this.cbTotalKills.Enabled = false;
            this.cbTotalDeaths.Enabled = false;
            this.cbKillDeathRatio.Enabled = false;
            this.cbTotalWins.Enabled = false;

            /*
             * We basically need to watch the OCR directory now for any changes
             * Anytime an image is added, send it thru the OCR service and figure out what happened
             * Then delete the image after so we dont clog up disk space
             */
            directoryWatcher = new FileSystemWatcher();
            directoryWatcher.Path = applicationSettings.ScreenshotDirectory;
            directoryWatcher.NotifyFilter = NotifyFilters.LastWrite;
            directoryWatcher.Filter = "*.jpg";
            directoryWatcher.Changed += new FileSystemEventHandler(OnScreenshotDetected);
            directoryWatcher.EnableRaisingEvents = true;

            PUBGStats = new PUBGStats();
            SettingsService.WriteStatsToFiles(applicationSettings, PUBGStats);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;
            this.btnActivate.Enabled = true;
            this.btnSelectLabelOutputDirectory.Enabled = true;
            this.btnOCRDirectory.Enabled = true;
            this.cbTotalKills.Enabled = true;
            this.cbTotalDeaths.Enabled = true;
            this.cbKillDeathRatio.Enabled = true;
            this.cbTotalWins.Enabled = true;
        }

        private void SetTotalImagesScannedLabel(string text)
        {
            if (this.lblImagesScannedAmount.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTotalImagesScannedLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblImagesScannedAmount.Text = text;
            }
        }

        private void SetAverageProcessingTimeLabel(string text)
        {
            text = String.Format("{0} seconds", text);

            if (this.lblAverageImageScanTimeAmount.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetAverageProcessingTimeLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblAverageImageScanTimeAmount.Text = text;
            }
        }

        private void OnScreenshotDetected(object source, FileSystemEventArgs e)
        {
            bool writeOutStats = false;
            directoryWatcher.EnableRaisingEvents = false; //set this while we process

            imageProcessingStopWatch = new Stopwatch();
            imageProcessingStopWatch.Start();
            string imageText = OCRService.GetImageWords(e.FullPath);
            imageProcessingStopWatch.Stop();

            totalScreenProcessed++;
            SetTotalImagesScannedLabel(totalScreenProcessed.ToString());

            totalProcessingTime += imageProcessingStopWatch.Elapsed.TotalSeconds;
            SetAverageProcessingTimeLabel((totalProcessingTime / totalScreenProcessed).ToString());

            if (this.cbDeleteImagesAfterProcessing.Checked)
            {
                File.Delete(e.FullPath); //hard delete this mofo, we dont wanna lose space
            }

            /*
             * Some hacky ass processing right here, but whatever gets the job done, ya know/
             */
            List<string> textParts = imageText.Split(' ')
                .Select(z => z.ToLower())
                .ToList();

            if (textParts.Contains("kills"))
            {
                try
                {
                    int killsIndex = textParts.IndexOf("kills");
                    int killAmount = int.Parse(textParts[killsIndex - 1]);

                    if (killAmount > PUBGStats.LastTotalKills)
                    {
                        PUBGStats.Kills++;
                        writeOutStats = true;
                    }

                    PUBGStats.LastTotalKills = killAmount;
                }
                catch(Exception ex)
                {
                    //Meh
                }
            }
            else if (textParts.Contains("next") || textParts.Any(z => z.IndexOf("time!") > -1))
            {
                try
                {
                    if (DateTime.UtcNow.AddMinutes(-2) > PUBGStats.LastDeath)
                    {
                        //This death ocurred more than 2 minutes after the last, probs real
                        PUBGStats.Deaths++;
                        PUBGStats.LastDeath = DateTime.UtcNow;
                        writeOutStats = true;
                    }
                }
                catch(Exception ex)
                {

                }
            }
            else if (textParts.Contains("winner"))
            {
                try
                {
                    if (DateTime.UtcNow.AddMinutes(-20) > PUBGStats.LastWin)
                    {
                        //This win happened 20 mins after the last, probs real
                        PUBGStats.Wins++;
                        PUBGStats.LastWin = DateTime.UtcNow;
                        writeOutStats = true;
                    }
                }
                catch (Exception ex)
                {

                }
            }

            if (writeOutStats)
            {
                PUBGStats.KillDeathRatio = PUBGStats.Kills / PUBGStats.Deaths;
                SettingsService.WriteStatsToFiles(applicationSettings, PUBGStats);
            }

            directoryWatcher.EnableRaisingEvents = true;
        }

        private void CbTotalKills_CheckedChanged(object sender, EventArgs e)
        {
            applicationSettings.TotalKills = this.cbTotalKills.Checked;
            SettingsService.SaveApplicationSettings(applicationSettings);
        }

        private void CbTotalDeaths_CheckedChanged(object sender, EventArgs e)
        {
            applicationSettings.TotalDeaths = this.cbTotalDeaths.Checked;
            SettingsService.SaveApplicationSettings(applicationSettings);
        }

        private void CbKillDeathRatio_CheckedChanged(object sender, EventArgs e)
        {
            applicationSettings.KillDeathRatio = this.cbKillDeathRatio.Checked;
            SettingsService.SaveApplicationSettings(applicationSettings);
        }

        private void CbTotalWins_CheckedChanged(object sender, EventArgs e)
        {
            applicationSettings.TotalWins = this.cbTotalWins.Checked;
            SettingsService.SaveApplicationSettings(applicationSettings);
        }

        private void CbDeleteImagesAfterProcessing_CheckedChanged(object sender, EventArgs e)
        {
            applicationSettings.DeleteImagesAfterProcessing = this.cbDeleteImagesAfterProcessing.Checked;
            SettingsService.SaveApplicationSettings(applicationSettings);
        }
    }
}
