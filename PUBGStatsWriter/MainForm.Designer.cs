namespace PUBGStatsWriter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDeleteImagesAfterProcessing = new System.Windows.Forms.CheckBox();
            this.btnOCRDirectory = new System.Windows.Forms.Button();
            this.lblOCR = new System.Windows.Forms.Label();
            this.btnSelectLabelOutputDirectory = new System.Windows.Forms.Button();
            this.lblLabelOutputDirectory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTotalWins = new System.Windows.Forms.CheckBox();
            this.cbKillDeathRatio = new System.Windows.Forms.CheckBox();
            this.cbTotalDeaths = new System.Windows.Forms.CheckBox();
            this.cbTotalKills = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalWinsFilename = new System.Windows.Forms.Label();
            this.lblKillDeathRatioFilename = new System.Windows.Forms.Label();
            this.lblTotalDeathsFilename = new System.Windows.Forms.Label();
            this.lblTotalKillsFilename = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblImagesScannedAmount = new System.Windows.Forms.Label();
            this.lblAverageImageScanTimeAmount = new System.Windows.Forms.Label();
            this.lblAverageImageScanTime = new System.Windows.Forms.Label();
            this.lblImagesScanned = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.lblKillsAmount = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.lblDeathsAmount = new System.Windows.Forms.Label();
            this.btnAddKill = new System.Windows.Forms.Button();
            this.btnRemoveKill = new System.Windows.Forms.Button();
            this.btnRemoveDeath = new System.Windows.Forms.Button();
            this.btnAddDeath = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDeleteImagesAfterProcessing);
            this.groupBox1.Controls.Add(this.btnOCRDirectory);
            this.groupBox1.Controls.Add(this.lblOCR);
            this.groupBox1.Controls.Add(this.btnSelectLabelOutputDirectory);
            this.groupBox1.Controls.Add(this.lblLabelOutputDirectory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup (Required)";
            // 
            // cbDeleteImagesAfterProcessing
            // 
            this.cbDeleteImagesAfterProcessing.AutoSize = true;
            this.cbDeleteImagesAfterProcessing.Location = new System.Drawing.Point(9, 82);
            this.cbDeleteImagesAfterProcessing.Name = "cbDeleteImagesAfterProcessing";
            this.cbDeleteImagesAfterProcessing.Size = new System.Drawing.Size(261, 17);
            this.cbDeleteImagesAfterProcessing.TabIndex = 4;
            this.cbDeleteImagesAfterProcessing.Text = "Delete Images After Processing? (Recommended)";
            this.cbDeleteImagesAfterProcessing.UseVisualStyleBackColor = true;
            this.cbDeleteImagesAfterProcessing.CheckedChanged += new System.EventHandler(this.CbDeleteImagesAfterProcessing_CheckedChanged);
            // 
            // btnOCRDirectory
            // 
            this.btnOCRDirectory.Location = new System.Drawing.Point(125, 48);
            this.btnOCRDirectory.Name = "btnOCRDirectory";
            this.btnOCRDirectory.Size = new System.Drawing.Size(188, 23);
            this.btnOCRDirectory.TabIndex = 2;
            this.btnOCRDirectory.Text = "Choose...";
            this.btnOCRDirectory.UseVisualStyleBackColor = true;
            this.btnOCRDirectory.Click += new System.EventHandler(this.btnOCRDirectory_Click);
            // 
            // lblOCR
            // 
            this.lblOCR.AutoSize = true;
            this.lblOCR.Location = new System.Drawing.Point(6, 53);
            this.lblOCR.Name = "lblOCR";
            this.lblOCR.Size = new System.Drawing.Size(75, 13);
            this.lblOCR.TabIndex = 3;
            this.lblOCR.Text = "OCR Directory";
            // 
            // btnSelectLabelOutputDirectory
            // 
            this.btnSelectLabelOutputDirectory.Location = new System.Drawing.Point(125, 19);
            this.btnSelectLabelOutputDirectory.Name = "btnSelectLabelOutputDirectory";
            this.btnSelectLabelOutputDirectory.Size = new System.Drawing.Size(188, 23);
            this.btnSelectLabelOutputDirectory.TabIndex = 1;
            this.btnSelectLabelOutputDirectory.Text = "Choose...";
            this.btnSelectLabelOutputDirectory.UseVisualStyleBackColor = true;
            this.btnSelectLabelOutputDirectory.Click += new System.EventHandler(this.btnSelectLabelOutputDirectory_Click);
            // 
            // lblLabelOutputDirectory
            // 
            this.lblLabelOutputDirectory.AutoSize = true;
            this.lblLabelOutputDirectory.Location = new System.Drawing.Point(6, 24);
            this.lblLabelOutputDirectory.Name = "lblLabelOutputDirectory";
            this.lblLabelOutputDirectory.Size = new System.Drawing.Size(84, 13);
            this.lblLabelOutputDirectory.TabIndex = 1;
            this.lblLabelOutputDirectory.Text = "Output Directory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTotalWins);
            this.groupBox2.Controls.Add(this.cbKillDeathRatio);
            this.groupBox2.Controls.Add(this.cbTotalDeaths);
            this.groupBox2.Controls.Add(this.cbTotalKills);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // cbTotalWins
            // 
            this.cbTotalWins.AutoSize = true;
            this.cbTotalWins.Location = new System.Drawing.Point(9, 88);
            this.cbTotalWins.Name = "cbTotalWins";
            this.cbTotalWins.Size = new System.Drawing.Size(77, 17);
            this.cbTotalWins.TabIndex = 3;
            this.cbTotalWins.Text = "Total Wins";
            this.cbTotalWins.UseVisualStyleBackColor = true;
            this.cbTotalWins.CheckedChanged += new System.EventHandler(this.CbTotalWins_CheckedChanged);
            // 
            // cbKillDeathRatio
            // 
            this.cbKillDeathRatio.AutoSize = true;
            this.cbKillDeathRatio.Location = new System.Drawing.Point(9, 65);
            this.cbKillDeathRatio.Name = "cbKillDeathRatio";
            this.cbKillDeathRatio.Size = new System.Drawing.Size(99, 17);
            this.cbKillDeathRatio.TabIndex = 2;
            this.cbKillDeathRatio.Text = "Kill Death Ratio";
            this.cbKillDeathRatio.UseVisualStyleBackColor = true;
            this.cbKillDeathRatio.CheckedChanged += new System.EventHandler(this.CbKillDeathRatio_CheckedChanged);
            // 
            // cbTotalDeaths
            // 
            this.cbTotalDeaths.AutoSize = true;
            this.cbTotalDeaths.Location = new System.Drawing.Point(9, 42);
            this.cbTotalDeaths.Name = "cbTotalDeaths";
            this.cbTotalDeaths.Size = new System.Drawing.Size(87, 17);
            this.cbTotalDeaths.TabIndex = 3;
            this.cbTotalDeaths.Text = "Total Deaths";
            this.cbTotalDeaths.UseVisualStyleBackColor = true;
            this.cbTotalDeaths.CheckedChanged += new System.EventHandler(this.CbTotalDeaths_CheckedChanged);
            // 
            // cbTotalKills
            // 
            this.cbTotalKills.AutoSize = true;
            this.cbTotalKills.Location = new System.Drawing.Point(9, 19);
            this.cbTotalKills.Name = "cbTotalKills";
            this.cbTotalKills.Size = new System.Drawing.Size(71, 17);
            this.cbTotalKills.TabIndex = 2;
            this.cbTotalKills.Text = "Total Kills";
            this.cbTotalKills.UseVisualStyleBackColor = true;
            this.cbTotalKills.CheckedChanged += new System.EventHandler(this.CbTotalKills_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalWinsFilename);
            this.groupBox3.Controls.Add(this.lblKillDeathRatioFilename);
            this.groupBox3.Controls.Add(this.lblTotalDeathsFilename);
            this.groupBox3.Controls.Add(this.lblTotalKillsFilename);
            this.groupBox3.Location = new System.Drawing.Point(159, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(172, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filenames";
            // 
            // lblTotalWinsFilename
            // 
            this.lblTotalWinsFilename.AutoSize = true;
            this.lblTotalWinsFilename.Location = new System.Drawing.Point(6, 89);
            this.lblTotalWinsFilename.Name = "lblTotalWinsFilename";
            this.lblTotalWinsFilename.Size = new System.Drawing.Size(27, 13);
            this.lblTotalWinsFilename.TabIndex = 5;
            this.lblTotalWinsFilename.Text = "N/A";
            // 
            // lblKillDeathRatioFilename
            // 
            this.lblKillDeathRatioFilename.AutoSize = true;
            this.lblKillDeathRatioFilename.Location = new System.Drawing.Point(6, 66);
            this.lblKillDeathRatioFilename.Name = "lblKillDeathRatioFilename";
            this.lblKillDeathRatioFilename.Size = new System.Drawing.Size(27, 13);
            this.lblKillDeathRatioFilename.TabIndex = 4;
            this.lblKillDeathRatioFilename.Text = "N/A";
            // 
            // lblTotalDeathsFilename
            // 
            this.lblTotalDeathsFilename.AutoSize = true;
            this.lblTotalDeathsFilename.Location = new System.Drawing.Point(6, 43);
            this.lblTotalDeathsFilename.Name = "lblTotalDeathsFilename";
            this.lblTotalDeathsFilename.Size = new System.Drawing.Size(27, 13);
            this.lblTotalDeathsFilename.TabIndex = 3;
            this.lblTotalDeathsFilename.Text = "N/A";
            // 
            // lblTotalKillsFilename
            // 
            this.lblTotalKillsFilename.AutoSize = true;
            this.lblTotalKillsFilename.Location = new System.Drawing.Point(6, 20);
            this.lblTotalKillsFilename.Name = "lblTotalKillsFilename";
            this.lblTotalKillsFilename.Size = new System.Drawing.Size(27, 13);
            this.lblTotalKillsFilename.TabIndex = 2;
            this.lblTotalKillsFilename.Text = "N/A";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(12, 283);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(225, 30);
            this.btnActivate.TabIndex = 3;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(243, 283);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveDeath);
            this.groupBox4.Controls.Add(this.btnAddDeath);
            this.groupBox4.Controls.Add(this.btnRemoveKill);
            this.groupBox4.Controls.Add(this.btnAddKill);
            this.groupBox4.Controls.Add(this.lblDeathsAmount);
            this.groupBox4.Controls.Add(this.lblDeaths);
            this.groupBox4.Controls.Add(this.lblKillsAmount);
            this.groupBox4.Controls.Add(this.lblKills);
            this.groupBox4.Controls.Add(this.lblImagesScannedAmount);
            this.groupBox4.Controls.Add(this.lblAverageImageScanTimeAmount);
            this.groupBox4.Controls.Add(this.lblAverageImageScanTime);
            this.groupBox4.Controls.Add(this.lblImagesScanned);
            this.groupBox4.Location = new System.Drawing.Point(12, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 110);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DEBUG";
            // 
            // lblImagesScannedAmount
            // 
            this.lblImagesScannedAmount.AutoSize = true;
            this.lblImagesScannedAmount.Location = new System.Drawing.Point(144, 23);
            this.lblImagesScannedAmount.Name = "lblImagesScannedAmount";
            this.lblImagesScannedAmount.Size = new System.Drawing.Size(13, 13);
            this.lblImagesScannedAmount.TabIndex = 3;
            this.lblImagesScannedAmount.Text = "0";
            // 
            // lblAverageImageScanTimeAmount
            // 
            this.lblAverageImageScanTimeAmount.AutoSize = true;
            this.lblAverageImageScanTimeAmount.Location = new System.Drawing.Point(144, 43);
            this.lblAverageImageScanTimeAmount.Name = "lblAverageImageScanTimeAmount";
            this.lblAverageImageScanTimeAmount.Size = new System.Drawing.Size(13, 13);
            this.lblAverageImageScanTimeAmount.TabIndex = 2;
            this.lblAverageImageScanTimeAmount.Text = "0";
            // 
            // lblAverageImageScanTime
            // 
            this.lblAverageImageScanTime.AutoSize = true;
            this.lblAverageImageScanTime.Location = new System.Drawing.Point(6, 43);
            this.lblAverageImageScanTime.Name = "lblAverageImageScanTime";
            this.lblAverageImageScanTime.Size = new System.Drawing.Size(133, 13);
            this.lblAverageImageScanTime.TabIndex = 1;
            this.lblAverageImageScanTime.Text = "Average Image Scan Time";
            // 
            // lblImagesScanned
            // 
            this.lblImagesScanned.AutoSize = true;
            this.lblImagesScanned.Location = new System.Drawing.Point(6, 23);
            this.lblImagesScanned.Name = "lblImagesScanned";
            this.lblImagesScanned.Size = new System.Drawing.Size(87, 13);
            this.lblImagesScanned.TabIndex = 0;
            this.lblImagesScanned.Text = "Images Scanned";
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.Location = new System.Drawing.Point(6, 64);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(25, 13);
            this.lblKills.TabIndex = 4;
            this.lblKills.Text = "Kills";
            // 
            // lblKillsAmount
            // 
            this.lblKillsAmount.AutoSize = true;
            this.lblKillsAmount.Location = new System.Drawing.Point(144, 64);
            this.lblKillsAmount.Name = "lblKillsAmount";
            this.lblKillsAmount.Size = new System.Drawing.Size(13, 13);
            this.lblKillsAmount.TabIndex = 5;
            this.lblKillsAmount.Text = "0";
            // 
            // lblDeaths
            // 
            this.lblDeaths.AutoSize = true;
            this.lblDeaths.Location = new System.Drawing.Point(6, 88);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(41, 13);
            this.lblDeaths.TabIndex = 6;
            this.lblDeaths.Text = "Deaths";
            // 
            // lblDeathsAmount
            // 
            this.lblDeathsAmount.AutoSize = true;
            this.lblDeathsAmount.Location = new System.Drawing.Point(144, 88);
            this.lblDeathsAmount.Name = "lblDeathsAmount";
            this.lblDeathsAmount.Size = new System.Drawing.Size(13, 13);
            this.lblDeathsAmount.TabIndex = 7;
            this.lblDeathsAmount.Text = "0";
            // 
            // btnAddKill
            // 
            this.btnAddKill.Location = new System.Drawing.Point(195, 59);
            this.btnAddKill.Name = "btnAddKill";
            this.btnAddKill.Size = new System.Drawing.Size(56, 23);
            this.btnAddKill.TabIndex = 6;
            this.btnAddKill.Text = "+";
            this.btnAddKill.UseVisualStyleBackColor = true;
            this.btnAddKill.Click += new System.EventHandler(this.BtnAddKill_Click);
            // 
            // btnRemoveKill
            // 
            this.btnRemoveKill.Location = new System.Drawing.Point(257, 59);
            this.btnRemoveKill.Name = "btnRemoveKill";
            this.btnRemoveKill.Size = new System.Drawing.Size(56, 23);
            this.btnRemoveKill.TabIndex = 8;
            this.btnRemoveKill.Text = "-";
            this.btnRemoveKill.UseVisualStyleBackColor = true;
            this.btnRemoveKill.Click += new System.EventHandler(this.BtnRemoveKill_Click);
            // 
            // btnRemoveDeath
            // 
            this.btnRemoveDeath.Location = new System.Drawing.Point(257, 83);
            this.btnRemoveDeath.Name = "btnRemoveDeath";
            this.btnRemoveDeath.Size = new System.Drawing.Size(56, 23);
            this.btnRemoveDeath.TabIndex = 10;
            this.btnRemoveDeath.Text = "-";
            this.btnRemoveDeath.UseVisualStyleBackColor = true;
            this.btnRemoveDeath.Click += new System.EventHandler(this.BtnRemoveDeath_Click);
            // 
            // btnAddDeath
            // 
            this.btnAddDeath.Location = new System.Drawing.Point(195, 83);
            this.btnAddDeath.Name = "btnAddDeath";
            this.btnAddDeath.Size = new System.Drawing.Size(56, 23);
            this.btnAddDeath.TabIndex = 9;
            this.btnAddDeath.Text = "+";
            this.btnAddDeath.UseVisualStyleBackColor = true;
            this.btnAddDeath.Click += new System.EventHandler(this.BtnAddDeath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 441);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "PUBG Stats Analyzer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectLabelOutputDirectory;
        private System.Windows.Forms.Label lblLabelOutputDirectory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTotalWins;
        private System.Windows.Forms.CheckBox cbKillDeathRatio;
        private System.Windows.Forms.CheckBox cbTotalDeaths;
        private System.Windows.Forms.CheckBox cbTotalKills;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOCRDirectory;
        private System.Windows.Forms.Label lblOCR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblImagesScannedAmount;
        private System.Windows.Forms.Label lblAverageImageScanTimeAmount;
        private System.Windows.Forms.Label lblAverageImageScanTime;
        private System.Windows.Forms.Label lblImagesScanned;
        private System.Windows.Forms.Label lblTotalWinsFilename;
        private System.Windows.Forms.Label lblKillDeathRatioFilename;
        private System.Windows.Forms.Label lblTotalDeathsFilename;
        private System.Windows.Forms.Label lblTotalKillsFilename;
        private System.Windows.Forms.CheckBox cbDeleteImagesAfterProcessing;
        private System.Windows.Forms.Label lblDeathsAmount;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.Label lblKillsAmount;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Button btnRemoveDeath;
        private System.Windows.Forms.Button btnAddDeath;
        private System.Windows.Forms.Button btnRemoveKill;
        private System.Windows.Forms.Button btnAddKill;
    }
}

