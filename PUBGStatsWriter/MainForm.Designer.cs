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
            this.btnOCRDirectory = new System.Windows.Forms.Button();
            this.lblOCR = new System.Windows.Forms.Label();
            this.btnSelectLabelOutputDirectory = new System.Windows.Forms.Button();
            this.lblLabelOutputDirectory = new System.Windows.Forms.Label();
            this.lblPubgName = new System.Windows.Forms.Label();
            this.txtPubgName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTotalWins = new System.Windows.Forms.CheckBox();
            this.cbKillDeathRatio = new System.Windows.Forms.CheckBox();
            this.cbTotalGamesPlayed = new System.Windows.Forms.CheckBox();
            this.cbTotalDeaths = new System.Windows.Forms.CheckBox();
            this.cbTotalKills = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOCRDirectory);
            this.groupBox1.Controls.Add(this.lblOCR);
            this.groupBox1.Controls.Add(this.btnSelectLabelOutputDirectory);
            this.groupBox1.Controls.Add(this.lblLabelOutputDirectory);
            this.groupBox1.Controls.Add(this.lblPubgName);
            this.groupBox1.Controls.Add(this.txtPubgName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup (Required)";
            // 
            // btnOCRDirectory
            // 
            this.btnOCRDirectory.Location = new System.Drawing.Point(125, 82);
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
            this.lblOCR.Location = new System.Drawing.Point(6, 87);
            this.lblOCR.Name = "lblOCR";
            this.lblOCR.Size = new System.Drawing.Size(75, 13);
            this.lblOCR.TabIndex = 3;
            this.lblOCR.Text = "OCR Directory";
            // 
            // btnSelectLabelOutputDirectory
            // 
            this.btnSelectLabelOutputDirectory.Location = new System.Drawing.Point(125, 53);
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
            this.lblLabelOutputDirectory.Location = new System.Drawing.Point(6, 58);
            this.lblLabelOutputDirectory.Name = "lblLabelOutputDirectory";
            this.lblLabelOutputDirectory.Size = new System.Drawing.Size(84, 13);
            this.lblLabelOutputDirectory.TabIndex = 1;
            this.lblLabelOutputDirectory.Text = "Output Directory";
            // 
            // lblPubgName
            // 
            this.lblPubgName.AutoSize = true;
            this.lblPubgName.Location = new System.Drawing.Point(6, 29);
            this.lblPubgName.Name = "lblPubgName";
            this.lblPubgName.Size = new System.Drawing.Size(68, 13);
            this.lblPubgName.TabIndex = 1;
            this.lblPubgName.Text = "PUBG Name";
            // 
            // txtPubgName
            // 
            this.txtPubgName.Location = new System.Drawing.Point(125, 26);
            this.txtPubgName.Name = "txtPubgName";
            this.txtPubgName.Size = new System.Drawing.Size(188, 20);
            this.txtPubgName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTotalWins);
            this.groupBox2.Controls.Add(this.cbKillDeathRatio);
            this.groupBox2.Controls.Add(this.cbTotalGamesPlayed);
            this.groupBox2.Controls.Add(this.cbTotalDeaths);
            this.groupBox2.Controls.Add(this.cbTotalKills);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // cbTotalWins
            // 
            this.cbTotalWins.AutoSize = true;
            this.cbTotalWins.Location = new System.Drawing.Point(9, 111);
            this.cbTotalWins.Name = "cbTotalWins";
            this.cbTotalWins.Size = new System.Drawing.Size(77, 17);
            this.cbTotalWins.TabIndex = 3;
            this.cbTotalWins.Text = "Total Wins";
            this.cbTotalWins.UseVisualStyleBackColor = true;
            // 
            // cbKillDeathRatio
            // 
            this.cbKillDeathRatio.AutoSize = true;
            this.cbKillDeathRatio.Location = new System.Drawing.Point(9, 88);
            this.cbKillDeathRatio.Name = "cbKillDeathRatio";
            this.cbKillDeathRatio.Size = new System.Drawing.Size(99, 17);
            this.cbKillDeathRatio.TabIndex = 2;
            this.cbKillDeathRatio.Text = "Kill Death Ratio";
            this.cbKillDeathRatio.UseVisualStyleBackColor = true;
            // 
            // cbTotalGamesPlayed
            // 
            this.cbTotalGamesPlayed.AutoSize = true;
            this.cbTotalGamesPlayed.Location = new System.Drawing.Point(9, 65);
            this.cbTotalGamesPlayed.Name = "cbTotalGamesPlayed";
            this.cbTotalGamesPlayed.Size = new System.Drawing.Size(121, 17);
            this.cbTotalGamesPlayed.TabIndex = 4;
            this.cbTotalGamesPlayed.Text = "Total Games Played";
            this.cbTotalGamesPlayed.UseVisualStyleBackColor = true;
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
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(159, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(172, 141);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filenames";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(12, 286);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(225, 30);
            this.btnActivate.TabIndex = 3;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(243, 286);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 331);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectLabelOutputDirectory;
        private System.Windows.Forms.Label lblLabelOutputDirectory;
        private System.Windows.Forms.Label lblPubgName;
        private System.Windows.Forms.TextBox txtPubgName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTotalWins;
        private System.Windows.Forms.CheckBox cbKillDeathRatio;
        private System.Windows.Forms.CheckBox cbTotalGamesPlayed;
        private System.Windows.Forms.CheckBox cbTotalDeaths;
        private System.Windows.Forms.CheckBox cbTotalKills;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOCRDirectory;
        private System.Windows.Forms.Label lblOCR;
    }
}

