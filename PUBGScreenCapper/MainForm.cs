using PUBGScreenCapper.Models;
using PUBGScreenCapper.Services;
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

namespace PUBGScreenCapper
{
    public partial class MainForm : Form
    {
        private ApplicationSettings applicationSettings;
        private Timer screenshotTimer;
        private int currentScreenshotCount = 0;

        public MainForm()
        {
            InitializeComponent();

            //Defaults
            btnStop.Enabled = false;

            applicationSettings = SettingsService.GetApplicationSettings();

            if (!String.IsNullOrEmpty(applicationSettings.OutputDirectory))
            {
                btnOutputDirectory.Text = applicationSettings.OutputDirectory;
            }
            txtInterval.Text = applicationSettings.Interval.ToString();
        }

        private void btnOutputDirectory_Click(object sender, EventArgs e)
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    applicationSettings.OutputDirectory = fldrDlg.SelectedPath;
                    btnOutputDirectory.Text = applicationSettings.OutputDirectory;
                    SettingsService.SaveApplicationSettings(applicationSettings);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            screenshotTimer = new Timer();
            screenshotTimer.Interval = applicationSettings.Interval;
            screenshotTimer.Tick += new EventHandler(TakeScreenshot);
            screenshotTimer.Start();

            btnStart.Enabled = false;
            btnOutputDirectory.Enabled = false;
            txtInterval.Enabled = false;

            btnStop.Enabled = true;
        }

        private void TakeScreenshot(object sender, EventArgs e)
        {
            Bitmap bmpScreenshot = new Bitmap(1000, 100);
            bmpScreenshot.SetResolution(300, 300);
            Graphics g = Graphics.FromImage(bmpScreenshot);

            int x = 500;
            int y = 700;

            g.CopyFromScreen(x, y, 0, 0, new Size(1000, 100));

            string fileName = String.Format("screencap{0}.jpg", currentScreenshotCount++);
            bmpScreenshot.Save(String.Format("{0}\\{1}", applicationSettings.OutputDirectory, fileName), System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            screenshotTimer.Stop();

            btnStart.Enabled = true;
            btnOutputDirectory.Enabled = true;
            txtInterval.Enabled = true;

            btnStop.Enabled = false;
        }

        private void TxtInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                applicationSettings.Interval = int.Parse(txtInterval.Text);
                SettingsService.SaveApplicationSettings(applicationSettings);
            }
            catch(Exception)
            {

            }
        }
    }
}
