using PUBGStatsWriter.Models;
using PUBGStatsWriter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace PUBGStatsWriter
{
    public partial class MainForm : Form
    {
        private ApplicationSettings applicationSettings;
        private FileSystemWatcher directoryWatcher;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Loads settings from text file
            //If settings dont exist, we need to create a default text file
            applicationSettings = SettingsService.GetApplicationSettings();
            this.txtPubgName.Text = applicationSettings.PUBGName;
            this.cbTotalKills.Checked = applicationSettings.TotalKills;
            this.cbTotalDeaths.Checked = applicationSettings.TotalDeaths;
            this.cbTotalGamesPlayed.Checked = applicationSettings.TotalGamesPlayed;
            this.cbKillDeathRatio.Checked = applicationSettings.KillDeathRatio;
            this.cbTotalWins.Checked = applicationSettings.TotalWins;

            btnStop.Enabled = false;
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
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            this.btnStop.Enabled = true;
            this.btnActivate.Enabled = false;
            this.btnSelectLabelOutputDirectory.Enabled = false;
            this.btnOCRDirectory.Enabled = false;
            this.txtPubgName.Enabled = false;
            this.cbTotalKills.Enabled = false;
            this.cbTotalDeaths.Enabled = false;
            this.cbTotalGamesPlayed.Enabled = false;
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
            directoryWatcher.Filter = "*.*";
            directoryWatcher.Changed += new FileSystemEventHandler(OnScreenshotDetected);
            directoryWatcher.EnableRaisingEvents = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;
            this.btnActivate.Enabled = true;
            this.btnSelectLabelOutputDirectory.Enabled = true;
            this.btnOCRDirectory.Enabled = true;
            this.txtPubgName.Enabled = true;
            this.cbTotalKills.Enabled = true;
            this.cbTotalDeaths.Enabled = true;
            this.cbTotalGamesPlayed.Enabled = true;
            this.cbKillDeathRatio.Enabled = true;
            this.cbTotalWins.Enabled = true;
        }

        private void OnScreenshotDetected(object source, FileSystemEventArgs e)
        {
            directoryWatcher.EnableRaisingEvents = false; //set this while we process
            string imageText = OCRService.GetImageWords(e.FullPath);

            directoryWatcher.EnableRaisingEvents = true;
        }
    }
}
