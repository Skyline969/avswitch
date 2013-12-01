namespace AVSwitch
{
    partial class MainWindow
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
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tpSwitch = new System.Windows.Forms.TabPage();
			this.tpSetup = new System.Windows.Forms.TabPage();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuAVSwitch = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSwitchTo = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.gbSwitch = new System.Windows.Forms.GroupBox();
			this.cbConfigurations = new System.Windows.Forms.ComboBox();
			this.btnSwitch = new System.Windows.Forms.Button();
			this.gbNewConfiguration = new System.Windows.Forms.GroupBox();
			this.lbAudioSrc = new System.Windows.Forms.ListBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblVideoSrc = new System.Windows.Forms.Label();
			this.btnVideoTest = new System.Windows.Forms.Button();
			this.cbVideoSource = new System.Windows.Forms.ComboBox();
			this.lblAudioSrc = new System.Windows.Forms.Label();
			this.lblNirCmdPath = new System.Windows.Forms.Label();
			this.txtNirCmdPath = new System.Windows.Forms.TextBox();
			this.btnNirCmdBrowse = new System.Windows.Forms.Button();
			this.lblConfigurationSelect = new System.Windows.Forms.Label();
			this.lbExistingConfiguration = new System.Windows.Forms.ListBox();
			this.lblSelectedConfigName = new System.Windows.Forms.Label();
			this.txtSelectedConfigName = new System.Windows.Forms.TextBox();
			this.txtSelectedConfigAudioSrc = new System.Windows.Forms.TextBox();
			this.lblSelectedConfigAudioSrc = new System.Windows.Forms.Label();
			this.txtSelectedConfigVideoSrc = new System.Windows.Forms.TextBox();
			this.lblSelectedConfigVideoSrc = new System.Windows.Forms.Label();
			this.btnDeleteSelectedConfig = new System.Windows.Forms.Button();
			this.tcMain.SuspendLayout();
			this.tpSwitch.SuspendLayout();
			this.tpSetup.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.gbSwitch.SuspendLayout();
			this.gbNewConfiguration.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcMain
			// 
			this.tcMain.Controls.Add(this.tpSwitch);
			this.tcMain.Controls.Add(this.tpSetup);
			this.tcMain.Location = new System.Drawing.Point(12, 27);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(600, 403);
			this.tcMain.TabIndex = 0;
			// 
			// tpSwitch
			// 
			this.tpSwitch.Controls.Add(this.gbNewConfiguration);
			this.tpSwitch.Controls.Add(this.gbSwitch);
			this.tpSwitch.Location = new System.Drawing.Point(4, 22);
			this.tpSwitch.Name = "tpSwitch";
			this.tpSwitch.Padding = new System.Windows.Forms.Padding(3);
			this.tpSwitch.Size = new System.Drawing.Size(592, 377);
			this.tpSwitch.TabIndex = 0;
			this.tpSwitch.Text = "Switch";
			this.tpSwitch.UseVisualStyleBackColor = true;
			// 
			// tpSetup
			// 
			this.tpSetup.Controls.Add(this.btnDeleteSelectedConfig);
			this.tpSetup.Controls.Add(this.lblSelectedConfigVideoSrc);
			this.tpSetup.Controls.Add(this.txtSelectedConfigVideoSrc);
			this.tpSetup.Controls.Add(this.lblSelectedConfigAudioSrc);
			this.tpSetup.Controls.Add(this.txtSelectedConfigAudioSrc);
			this.tpSetup.Controls.Add(this.txtSelectedConfigName);
			this.tpSetup.Controls.Add(this.lblSelectedConfigName);
			this.tpSetup.Controls.Add(this.lbExistingConfiguration);
			this.tpSetup.Controls.Add(this.lblConfigurationSelect);
			this.tpSetup.Controls.Add(this.btnNirCmdBrowse);
			this.tpSetup.Controls.Add(this.txtNirCmdPath);
			this.tpSetup.Controls.Add(this.lblNirCmdPath);
			this.tpSetup.Location = new System.Drawing.Point(4, 22);
			this.tpSetup.Name = "tpSetup";
			this.tpSetup.Padding = new System.Windows.Forms.Padding(3);
			this.tpSetup.Size = new System.Drawing.Size(592, 377);
			this.tpSetup.TabIndex = 1;
			this.tpSetup.Text = "Setup";
			this.tpSetup.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAVSwitch,
            this.mnuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(624, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuAVSwitch
			// 
			this.mnuAVSwitch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSwitchTo,
            this.mnuExit});
			this.mnuAVSwitch.Name = "mnuAVSwitch";
			this.mnuAVSwitch.Size = new System.Drawing.Size(69, 20);
			this.mnuAVSwitch.Text = "AVSwitch";
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(44, 20);
			this.mnuHelp.Text = "Help";
			// 
			// mnuSwitchTo
			// 
			this.mnuSwitchTo.Name = "mnuSwitchTo";
			this.mnuSwitchTo.Size = new System.Drawing.Size(152, 22);
			this.mnuSwitchTo.Text = "Switch To";
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(152, 22);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(152, 22);
			this.mnuAbout.Text = "About";
			// 
			// gbSwitch
			// 
			this.gbSwitch.Controls.Add(this.btnSwitch);
			this.gbSwitch.Controls.Add(this.cbConfigurations);
			this.gbSwitch.Location = new System.Drawing.Point(6, 6);
			this.gbSwitch.Name = "gbSwitch";
			this.gbSwitch.Size = new System.Drawing.Size(580, 53);
			this.gbSwitch.TabIndex = 0;
			this.gbSwitch.TabStop = false;
			this.gbSwitch.Text = "Switch Display";
			// 
			// cbConfigurations
			// 
			this.cbConfigurations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbConfigurations.FormattingEnabled = true;
			this.cbConfigurations.Location = new System.Drawing.Point(6, 19);
			this.cbConfigurations.Name = "cbConfigurations";
			this.cbConfigurations.Size = new System.Drawing.Size(514, 21);
			this.cbConfigurations.Sorted = true;
			this.cbConfigurations.TabIndex = 0;
			// 
			// btnSwitch
			// 
			this.btnSwitch.Location = new System.Drawing.Point(526, 17);
			this.btnSwitch.Name = "btnSwitch";
			this.btnSwitch.Size = new System.Drawing.Size(48, 23);
			this.btnSwitch.TabIndex = 1;
			this.btnSwitch.Text = "Switch";
			this.btnSwitch.UseVisualStyleBackColor = true;
			this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
			// 
			// gbNewConfiguration
			// 
			this.gbNewConfiguration.Controls.Add(this.lblAudioSrc);
			this.gbNewConfiguration.Controls.Add(this.cbVideoSource);
			this.gbNewConfiguration.Controls.Add(this.btnVideoTest);
			this.gbNewConfiguration.Controls.Add(this.lblVideoSrc);
			this.gbNewConfiguration.Controls.Add(this.txtName);
			this.gbNewConfiguration.Controls.Add(this.lblName);
			this.gbNewConfiguration.Controls.Add(this.lbAudioSrc);
			this.gbNewConfiguration.Location = new System.Drawing.Point(6, 65);
			this.gbNewConfiguration.Name = "gbNewConfiguration";
			this.gbNewConfiguration.Size = new System.Drawing.Size(580, 306);
			this.gbNewConfiguration.TabIndex = 1;
			this.gbNewConfiguration.TabStop = false;
			this.gbNewConfiguration.Text = "Create Configuration";
			// 
			// lbAudioSrc
			// 
			this.lbAudioSrc.FormattingEnabled = true;
			this.lbAudioSrc.Location = new System.Drawing.Point(6, 75);
			this.lbAudioSrc.Name = "lbAudioSrc";
			this.lbAudioSrc.Size = new System.Drawing.Size(568, 225);
			this.lbAudioSrc.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(7, 23);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(48, 20);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(223, 20);
			this.txtName.TabIndex = 2;
			// 
			// lblVideoSrc
			// 
			this.lblVideoSrc.AutoSize = true;
			this.lblVideoSrc.Location = new System.Drawing.Point(296, 23);
			this.lblVideoSrc.Name = "lblVideoSrc";
			this.lblVideoSrc.Size = new System.Drawing.Size(71, 13);
			this.lblVideoSrc.TabIndex = 3;
			this.lblVideoSrc.Text = "Video Source";
			// 
			// btnVideoTest
			// 
			this.btnVideoTest.Location = new System.Drawing.Point(532, 17);
			this.btnVideoTest.Name = "btnVideoTest";
			this.btnVideoTest.Size = new System.Drawing.Size(42, 23);
			this.btnVideoTest.TabIndex = 5;
			this.btnVideoTest.Text = "Test";
			this.btnVideoTest.UseVisualStyleBackColor = true;
			this.btnVideoTest.Click += new System.EventHandler(this.btnVideoTest_Click);
			// 
			// cbVideoSource
			// 
			this.cbVideoSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbVideoSource.FormattingEnabled = true;
			this.cbVideoSource.Location = new System.Drawing.Point(373, 19);
			this.cbVideoSource.Name = "cbVideoSource";
			this.cbVideoSource.Size = new System.Drawing.Size(153, 21);
			this.cbVideoSource.TabIndex = 6;
			// 
			// lblAudioSrc
			// 
			this.lblAudioSrc.AutoSize = true;
			this.lblAudioSrc.Location = new System.Drawing.Point(7, 56);
			this.lblAudioSrc.Name = "lblAudioSrc";
			this.lblAudioSrc.Size = new System.Drawing.Size(71, 13);
			this.lblAudioSrc.TabIndex = 7;
			this.lblAudioSrc.Text = "Audio Source";
			// 
			// lblNirCmdPath
			// 
			this.lblNirCmdPath.AutoSize = true;
			this.lblNirCmdPath.Location = new System.Drawing.Point(6, 16);
			this.lblNirCmdPath.Name = "lblNirCmdPath";
			this.lblNirCmdPath.Size = new System.Drawing.Size(66, 13);
			this.lblNirCmdPath.TabIndex = 0;
			this.lblNirCmdPath.Text = "NirCmd Path";
			// 
			// txtNirCmdPath
			// 
			this.txtNirCmdPath.Location = new System.Drawing.Point(114, 13);
			this.txtNirCmdPath.Name = "txtNirCmdPath";
			this.txtNirCmdPath.ReadOnly = true;
			this.txtNirCmdPath.Size = new System.Drawing.Size(415, 20);
			this.txtNirCmdPath.TabIndex = 1;
			// 
			// btnNirCmdBrowse
			// 
			this.btnNirCmdBrowse.Location = new System.Drawing.Point(535, 11);
			this.btnNirCmdBrowse.Name = "btnNirCmdBrowse";
			this.btnNirCmdBrowse.Size = new System.Drawing.Size(51, 23);
			this.btnNirCmdBrowse.TabIndex = 2;
			this.btnNirCmdBrowse.Text = "Browse";
			this.btnNirCmdBrowse.UseVisualStyleBackColor = true;
			this.btnNirCmdBrowse.Click += new System.EventHandler(this.btnNirCmdBrowse_Click);
			// 
			// lblConfigurationSelect
			// 
			this.lblConfigurationSelect.AutoSize = true;
			this.lblConfigurationSelect.Location = new System.Drawing.Point(6, 48);
			this.lblConfigurationSelect.Name = "lblConfigurationSelect";
			this.lblConfigurationSelect.Size = new System.Drawing.Size(102, 13);
			this.lblConfigurationSelect.TabIndex = 3;
			this.lblConfigurationSelect.Text = "Select Configuration";
			// 
			// lbExistingConfiguration
			// 
			this.lbExistingConfiguration.FormattingEnabled = true;
			this.lbExistingConfiguration.Location = new System.Drawing.Point(9, 64);
			this.lbExistingConfiguration.Name = "lbExistingConfiguration";
			this.lbExistingConfiguration.Size = new System.Drawing.Size(277, 303);
			this.lbExistingConfiguration.TabIndex = 4;
			// 
			// lblSelectedConfigName
			// 
			this.lblSelectedConfigName.AutoSize = true;
			this.lblSelectedConfigName.Location = new System.Drawing.Point(292, 67);
			this.lblSelectedConfigName.Name = "lblSelectedConfigName";
			this.lblSelectedConfigName.Size = new System.Drawing.Size(35, 13);
			this.lblSelectedConfigName.TabIndex = 5;
			this.lblSelectedConfigName.Text = "Name";
			// 
			// txtSelectedConfigName
			// 
			this.txtSelectedConfigName.Location = new System.Drawing.Point(369, 64);
			this.txtSelectedConfigName.Name = "txtSelectedConfigName";
			this.txtSelectedConfigName.ReadOnly = true;
			this.txtSelectedConfigName.Size = new System.Drawing.Size(217, 20);
			this.txtSelectedConfigName.TabIndex = 6;
			// 
			// txtSelectedConfigAudioSrc
			// 
			this.txtSelectedConfigAudioSrc.Location = new System.Drawing.Point(369, 116);
			this.txtSelectedConfigAudioSrc.Name = "txtSelectedConfigAudioSrc";
			this.txtSelectedConfigAudioSrc.ReadOnly = true;
			this.txtSelectedConfigAudioSrc.Size = new System.Drawing.Size(217, 20);
			this.txtSelectedConfigAudioSrc.TabIndex = 7;
			// 
			// lblSelectedConfigAudioSrc
			// 
			this.lblSelectedConfigAudioSrc.AutoSize = true;
			this.lblSelectedConfigAudioSrc.Location = new System.Drawing.Point(292, 119);
			this.lblSelectedConfigAudioSrc.Name = "lblSelectedConfigAudioSrc";
			this.lblSelectedConfigAudioSrc.Size = new System.Drawing.Size(71, 13);
			this.lblSelectedConfigAudioSrc.TabIndex = 8;
			this.lblSelectedConfigAudioSrc.Text = "Audio Source";
			// 
			// txtSelectedConfigVideoSrc
			// 
			this.txtSelectedConfigVideoSrc.Location = new System.Drawing.Point(369, 90);
			this.txtSelectedConfigVideoSrc.Name = "txtSelectedConfigVideoSrc";
			this.txtSelectedConfigVideoSrc.ReadOnly = true;
			this.txtSelectedConfigVideoSrc.Size = new System.Drawing.Size(217, 20);
			this.txtSelectedConfigVideoSrc.TabIndex = 9;
			// 
			// lblSelectedConfigVideoSrc
			// 
			this.lblSelectedConfigVideoSrc.AutoSize = true;
			this.lblSelectedConfigVideoSrc.Location = new System.Drawing.Point(292, 93);
			this.lblSelectedConfigVideoSrc.Name = "lblSelectedConfigVideoSrc";
			this.lblSelectedConfigVideoSrc.Size = new System.Drawing.Size(71, 13);
			this.lblSelectedConfigVideoSrc.TabIndex = 10;
			this.lblSelectedConfigVideoSrc.Text = "Video Source";
			// 
			// btnDeleteSelectedConfig
			// 
			this.btnDeleteSelectedConfig.Location = new System.Drawing.Point(382, 152);
			this.btnDeleteSelectedConfig.Name = "btnDeleteSelectedConfig";
			this.btnDeleteSelectedConfig.Size = new System.Drawing.Size(122, 23);
			this.btnDeleteSelectedConfig.TabIndex = 11;
			this.btnDeleteSelectedConfig.Text = "Delete Configuration";
			this.btnDeleteSelectedConfig.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.tcMain);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AVSwitch";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.tcMain.ResumeLayout(false);
			this.tpSwitch.ResumeLayout(false);
			this.tpSetup.ResumeLayout(false);
			this.tpSetup.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gbSwitch.ResumeLayout(false);
			this.gbNewConfiguration.ResumeLayout(false);
			this.gbNewConfiguration.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSwitch;
        private System.Windows.Forms.TabPage tpSetup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAVSwitch;
        private System.Windows.Forms.ToolStripMenuItem mnuSwitchTo;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.GroupBox gbNewConfiguration;
        private System.Windows.Forms.Label lblAudioSrc;
        private System.Windows.Forms.ComboBox cbVideoSource;
        private System.Windows.Forms.Button btnVideoTest;
        private System.Windows.Forms.Label lblVideoSrc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbAudioSrc;
        private System.Windows.Forms.GroupBox gbSwitch;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.ComboBox cbConfigurations;
        private System.Windows.Forms.Button btnNirCmdBrowse;
        private System.Windows.Forms.TextBox txtNirCmdPath;
		private System.Windows.Forms.Label lblNirCmdPath;
		private System.Windows.Forms.Label lblConfigurationSelect;
		private System.Windows.Forms.Button btnDeleteSelectedConfig;
		private System.Windows.Forms.Label lblSelectedConfigVideoSrc;
		private System.Windows.Forms.TextBox txtSelectedConfigVideoSrc;
		private System.Windows.Forms.Label lblSelectedConfigAudioSrc;
		private System.Windows.Forms.TextBox txtSelectedConfigAudioSrc;
		private System.Windows.Forms.TextBox txtSelectedConfigName;
		private System.Windows.Forms.Label lblSelectedConfigName;
		private System.Windows.Forms.ListBox lbExistingConfiguration;
    }
}

