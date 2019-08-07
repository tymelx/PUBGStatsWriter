using PUBGStatsWriter.Models;
using PUBGStatsWriter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
