namespace Win32Xml
{
    partial class GuiForm
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
            this.exportFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.exportRunButton = new System.Windows.Forms.Button();
            this.pathBrowseButton = new System.Windows.Forms.Button();
            this.userCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationPathLabel = new System.Windows.Forms.Label();
            this.ImportCurrentAction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ExportCurrentAction = new System.Windows.Forms.Label();
            this.ExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.generateReportCheckBox = new System.Windows.Forms.CheckBox();
            this.groupUserCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.importGroupMembersBrowse = new System.Windows.Forms.Button();
            this.importGroupBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportProgressBar = new System.Windows.Forms.ProgressBar();
            this.importReport = new System.Windows.Forms.CheckBox();
            this.importGroups = new System.Windows.Forms.CheckBox();
            this.importGroupUsers = new System.Windows.Forms.CheckBox();
            this.importUsers = new System.Windows.Forms.CheckBox();
            this.importGroupMembersLabel = new System.Windows.Forms.Label();
            this.importGroupLabel = new System.Windows.Forms.Label();
            this.importGroupMembersPath = new System.Windows.Forms.TextBox();
            this.importGroupPath = new System.Windows.Forms.TextBox();
            this.importUserLabel = new System.Windows.Forms.Label();
            this.importUserPath = new System.Windows.Forms.TextBox();
            this.importUserBrowse = new System.Windows.Forms.Button();
            this.importRunButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.somethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupMemberFileName = new System.Windows.Forms.TextBox();
            this.groupMembersFileNameLabel = new System.Windows.Forms.Label();
            this.groupFileName = new System.Windows.Forms.TextBox();
            this.GroupfileNameLabel = new System.Windows.Forms.Label();
            this.userFileName = new System.Windows.Forms.TextBox();
            this.userFileNameLabel = new System.Windows.Forms.Label();
            this.ImportCurrentAction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportFolderBrowserDialog
            // 
            this.exportFolderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // exportRunButton
            // 
            this.exportRunButton.Location = new System.Drawing.Point(405, 146);
            this.exportRunButton.Name = "exportRunButton";
            this.exportRunButton.Size = new System.Drawing.Size(74, 20);
            this.exportRunButton.TabIndex = 3;
            this.exportRunButton.Text = "Run";
            this.exportRunButton.UseVisualStyleBackColor = true;
            this.exportRunButton.Click += new System.EventHandler(this.exportRunButton_Click);
            // 
            // pathBrowseButton
            // 
            this.pathBrowseButton.Location = new System.Drawing.Point(405, 119);
            this.pathBrowseButton.Name = "pathBrowseButton";
            this.pathBrowseButton.Size = new System.Drawing.Size(74, 20);
            this.pathBrowseButton.TabIndex = 2;
            this.pathBrowseButton.Text = "Browse...";
            this.pathBrowseButton.UseVisualStyleBackColor = true;
            this.pathBrowseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userCheckBox
            // 
            this.userCheckBox.AutoSize = true;
            this.userCheckBox.Location = new System.Drawing.Point(98, 149);
            this.userCheckBox.Name = "userCheckBox";
            this.userCheckBox.Size = new System.Drawing.Size(84, 17);
            this.userCheckBox.TabIndex = 4;
            this.userCheckBox.Text = "Export users";
            this.userCheckBox.UseVisualStyleBackColor = true;
            this.userCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(98, 120);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(301, 20);
            this.destinationPath.TabIndex = 0;
            this.destinationPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.Location = new System.Drawing.Point(98, 172);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(91, 17);
            this.groupCheckBox.TabIndex = 4;
            this.groupCheckBox.Text = "Export groups";
            this.groupCheckBox.UseVisualStyleBackColor = true;
            this.groupCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // destinationPathLabel
            // 
            this.destinationPathLabel.AutoSize = true;
            this.destinationPathLabel.Location = new System.Drawing.Point(8, 123);
            this.destinationPathLabel.Name = "destinationPathLabel";
            this.destinationPathLabel.Size = new System.Drawing.Size(87, 13);
            this.destinationPathLabel.TabIndex = 1;
            this.destinationPathLabel.Text = "Destination path:";
            this.destinationPathLabel.UseMnemonic = false;
            this.destinationPathLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // ImportCurrentAction
            // 
            this.ImportCurrentAction.Controls.Add(this.tabPage1);
            this.ImportCurrentAction.Controls.Add(this.tabPage2);
            this.ImportCurrentAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportCurrentAction.Location = new System.Drawing.Point(0, 24);
            this.ImportCurrentAction.Name = "ImportCurrentAction";
            this.ImportCurrentAction.SelectedIndex = 0;
            this.ImportCurrentAction.Size = new System.Drawing.Size(520, 331);
            this.ImportCurrentAction.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ExportCurrentAction);
            this.tabPage1.Controls.Add(this.ExportProgressBar);
            this.tabPage1.Controls.Add(this.generateReportCheckBox);
            this.tabPage1.Controls.Add(this.groupUserCheckBox);
            this.tabPage1.Controls.Add(this.userFileNameLabel);
            this.tabPage1.Controls.Add(this.GroupfileNameLabel);
            this.tabPage1.Controls.Add(this.groupMembersFileNameLabel);
            this.tabPage1.Controls.Add(this.destinationPathLabel);
            this.tabPage1.Controls.Add(this.groupCheckBox);
            this.tabPage1.Controls.Add(this.userFileName);
            this.tabPage1.Controls.Add(this.groupFileName);
            this.tabPage1.Controls.Add(this.groupMemberFileName);
            this.tabPage1.Controls.Add(this.destinationPath);
            this.tabPage1.Controls.Add(this.userCheckBox);
            this.tabPage1.Controls.Add(this.pathBrowseButton);
            this.tabPage1.Controls.Add(this.exportRunButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Export";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // ExportCurrentAction
            // 
            this.ExportCurrentAction.AutoSize = true;
            this.ExportCurrentAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ExportCurrentAction.Location = new System.Drawing.Point(10, 258);
            this.ExportCurrentAction.Name = "ExportCurrentAction";
            this.ExportCurrentAction.Size = new System.Drawing.Size(103, 13);
            this.ExportCurrentAction.TabIndex = 11;
            this.ExportCurrentAction.Text = "Doing some thingy...";
            this.ExportCurrentAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExportProgressBar
            // 
            this.ExportProgressBar.Location = new System.Drawing.Point(8, 274);
            this.ExportProgressBar.Name = "ExportProgressBar";
            this.ExportProgressBar.Size = new System.Drawing.Size(498, 23);
            this.ExportProgressBar.TabIndex = 10;
            this.ExportProgressBar.Click += new System.EventHandler(this.ExportProgressBar_Click);
            // 
            // generateReportCheckBox
            // 
            this.generateReportCheckBox.AutoSize = true;
            this.generateReportCheckBox.Location = new System.Drawing.Point(98, 218);
            this.generateReportCheckBox.Name = "generateReportCheckBox";
            this.generateReportCheckBox.Size = new System.Drawing.Size(100, 17);
            this.generateReportCheckBox.TabIndex = 9;
            this.generateReportCheckBox.Text = "Generate report";
            this.generateReportCheckBox.UseVisualStyleBackColor = true;
            this.generateReportCheckBox.CheckedChanged += new System.EventHandler(this.generateReportCheckBox_CheckedChanged);
            // 
            // groupUserCheckBox
            // 
            this.groupUserCheckBox.AutoSize = true;
            this.groupUserCheckBox.Location = new System.Drawing.Point(98, 195);
            this.groupUserCheckBox.Name = "groupUserCheckBox";
            this.groupUserCheckBox.Size = new System.Drawing.Size(129, 17);
            this.groupUserCheckBox.TabIndex = 8;
            this.groupUserCheckBox.Text = "Export user-group info";
            this.groupUserCheckBox.UseVisualStyleBackColor = true;
            this.groupUserCheckBox.CheckedChanged += new System.EventHandler(this.groupUserCheckBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.importGroupMembersBrowse);
            this.tabPage2.Controls.Add(this.importGroupBrowse);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ImportProgressBar);
            this.tabPage2.Controls.Add(this.importReport);
            this.tabPage2.Controls.Add(this.importGroups);
            this.tabPage2.Controls.Add(this.importGroupUsers);
            this.tabPage2.Controls.Add(this.importUsers);
            this.tabPage2.Controls.Add(this.importGroupMembersLabel);
            this.tabPage2.Controls.Add(this.importGroupLabel);
            this.tabPage2.Controls.Add(this.importGroupMembersPath);
            this.tabPage2.Controls.Add(this.importGroupPath);
            this.tabPage2.Controls.Add(this.importUserLabel);
            this.tabPage2.Controls.Add(this.importUserPath);
            this.tabPage2.Controls.Add(this.importUserBrowse);
            this.tabPage2.Controls.Add(this.importRunButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // importGroupMembersBrowse
            // 
            this.importGroupMembersBrowse.Location = new System.Drawing.Point(415, 81);
            this.importGroupMembersBrowse.Name = "importGroupMembersBrowse";
            this.importGroupMembersBrowse.Size = new System.Drawing.Size(75, 23);
            this.importGroupMembersBrowse.TabIndex = 16;
            this.importGroupMembersBrowse.Text = "Browse...";
            this.importGroupMembersBrowse.UseVisualStyleBackColor = true;
            this.importGroupMembersBrowse.Click += new System.EventHandler(this.importGroupMembersBrowse_Click);
            // 
            // importGroupBrowse
            // 
            this.importGroupBrowse.Location = new System.Drawing.Point(415, 52);
            this.importGroupBrowse.Name = "importGroupBrowse";
            this.importGroupBrowse.Size = new System.Drawing.Size(75, 23);
            this.importGroupBrowse.TabIndex = 15;
            this.importGroupBrowse.Text = "Browse...";
            this.importGroupBrowse.UseVisualStyleBackColor = true;
            this.importGroupBrowse.Click += new System.EventHandler(this.importGroupBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(6, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Doing some thingy...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImportProgressBar
            // 
            this.ImportProgressBar.Location = new System.Drawing.Point(3, 276);
            this.ImportProgressBar.Name = "ImportProgressBar";
            this.ImportProgressBar.Size = new System.Drawing.Size(506, 23);
            this.ImportProgressBar.TabIndex = 13;
            // 
            // importReport
            // 
            this.importReport.AutoSize = true;
            this.importReport.Location = new System.Drawing.Point(108, 177);
            this.importReport.Name = "importReport";
            this.importReport.Size = new System.Drawing.Size(100, 17);
            this.importReport.TabIndex = 12;
            this.importReport.Text = "Generate report";
            this.importReport.UseVisualStyleBackColor = true;
            // 
            // importGroups
            // 
            this.importGroups.AutoSize = true;
            this.importGroups.Location = new System.Drawing.Point(108, 131);
            this.importGroups.Name = "importGroups";
            this.importGroups.Size = new System.Drawing.Size(90, 17);
            this.importGroups.TabIndex = 11;
            this.importGroups.Text = "Import groups";
            this.importGroups.UseVisualStyleBackColor = true;
            // 
            // importGroupUsers
            // 
            this.importGroupUsers.AutoSize = true;
            this.importGroupUsers.Location = new System.Drawing.Point(108, 154);
            this.importGroupUsers.Name = "importGroupUsers";
            this.importGroupUsers.Size = new System.Drawing.Size(120, 17);
            this.importGroupUsers.TabIndex = 10;
            this.importGroupUsers.Text = "Add users to groups";
            this.importGroupUsers.UseVisualStyleBackColor = true;
            // 
            // importUsers
            // 
            this.importUsers.AutoSize = true;
            this.importUsers.Location = new System.Drawing.Point(108, 108);
            this.importUsers.Name = "importUsers";
            this.importUsers.Size = new System.Drawing.Size(83, 17);
            this.importUsers.TabIndex = 9;
            this.importUsers.Text = "Import users";
            this.importUsers.UseVisualStyleBackColor = true;
            // 
            // importGroupMembersLabel
            // 
            this.importGroupMembersLabel.AutoSize = true;
            this.importGroupMembersLabel.Location = new System.Drawing.Point(2, 89);
            this.importGroupMembersLabel.Name = "importGroupMembersLabel";
            this.importGroupMembersLabel.Size = new System.Drawing.Size(100, 13);
            this.importGroupMembersLabel.TabIndex = 6;
            this.importGroupMembersLabel.Text = "Group member files:";
            this.importGroupMembersLabel.UseMnemonic = false;
            // 
            // importGroupLabel
            // 
            this.importGroupLabel.AutoSize = true;
            this.importGroupLabel.Location = new System.Drawing.Point(47, 63);
            this.importGroupLabel.Name = "importGroupLabel";
            this.importGroupLabel.Size = new System.Drawing.Size(55, 13);
            this.importGroupLabel.TabIndex = 6;
            this.importGroupLabel.Text = "Group file:";
            this.importGroupLabel.UseMnemonic = false;
            this.importGroupLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // importGroupMembersPath
            // 
            this.importGroupMembersPath.Location = new System.Drawing.Point(108, 82);
            this.importGroupMembersPath.Name = "importGroupMembersPath";
            this.importGroupMembersPath.Size = new System.Drawing.Size(301, 20);
            this.importGroupMembersPath.TabIndex = 5;
            this.importGroupMembersPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // importGroupPath
            // 
            this.importGroupPath.Location = new System.Drawing.Point(108, 56);
            this.importGroupPath.Name = "importGroupPath";
            this.importGroupPath.Size = new System.Drawing.Size(301, 20);
            this.importGroupPath.TabIndex = 5;
            this.importGroupPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // importUserLabel
            // 
            this.importUserLabel.AutoSize = true;
            this.importUserLabel.Location = new System.Drawing.Point(54, 37);
            this.importUserLabel.Name = "importUserLabel";
            this.importUserLabel.Size = new System.Drawing.Size(48, 13);
            this.importUserLabel.TabIndex = 6;
            this.importUserLabel.Text = "User file:";
            this.importUserLabel.UseMnemonic = false;
            // 
            // importUserPath
            // 
            this.importUserPath.Location = new System.Drawing.Point(108, 30);
            this.importUserPath.Name = "importUserPath";
            this.importUserPath.Size = new System.Drawing.Size(301, 20);
            this.importUserPath.TabIndex = 5;
            this.importUserPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // importUserBrowse
            // 
            this.importUserBrowse.Location = new System.Drawing.Point(415, 26);
            this.importUserBrowse.Name = "importUserBrowse";
            this.importUserBrowse.Size = new System.Drawing.Size(74, 20);
            this.importUserBrowse.TabIndex = 7;
            this.importUserBrowse.Text = "Browse...";
            this.importUserBrowse.UseVisualStyleBackColor = true;
            this.importUserBrowse.Click += new System.EventHandler(this.sourceBrowseButton_Click);
            // 
            // importRunButton
            // 
            this.importRunButton.Location = new System.Drawing.Point(415, 177);
            this.importRunButton.Name = "importRunButton";
            this.importRunButton.Size = new System.Drawing.Size(74, 20);
            this.importRunButton.TabIndex = 8;
            this.importRunButton.Text = "Run";
            this.importRunButton.UseVisualStyleBackColor = true;
            this.importRunButton.Click += new System.EventHandler(this.importRunButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // somethingToolStripMenuItem
            // 
            this.somethingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethingToolStripMenuItem1});
            this.somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            this.somethingToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.somethingToolStripMenuItem.Text = "Something";
            // 
            // somethingToolStripMenuItem1
            // 
            this.somethingToolStripMenuItem1.Name = "somethingToolStripMenuItem1";
            this.somethingToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.somethingToolStripMenuItem1.Text = "Something";
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // importFileDialog
            // 
            this.importFileDialog.DefaultExt = "xml";
            this.importFileDialog.FileName = "openFileDialog1";
            this.importFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.importFileDialog_FileOk);
            // 
            // groupMemberFileName
            // 
            this.groupMemberFileName.Location = new System.Drawing.Point(178, 71);
            this.groupMemberFileName.Name = "groupMemberFileName";
            this.groupMemberFileName.Size = new System.Drawing.Size(301, 20);
            this.groupMemberFileName.TabIndex = 0;
            this.groupMemberFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupMembersFileNameLabel
            // 
            this.groupMembersFileNameLabel.AutoSize = true;
            this.groupMembersFileNameLabel.Location = new System.Drawing.Point(8, 71);
            this.groupMembersFileNameLabel.Name = "groupMembersFileNameLabel";
            this.groupMembersFileNameLabel.Size = new System.Drawing.Size(160, 13);
            this.groupMembersFileNameLabel.TabIndex = 1;
            this.groupMembersFileNameLabel.Text = "Group members database name:";
            this.groupMembersFileNameLabel.UseMnemonic = false;
            this.groupMembersFileNameLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // groupFileName
            // 
            this.groupFileName.Location = new System.Drawing.Point(178, 45);
            this.groupFileName.Name = "groupFileName";
            this.groupFileName.Size = new System.Drawing.Size(301, 20);
            this.groupFileName.TabIndex = 0;
            this.groupFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GroupfileNameLabel
            // 
            this.GroupfileNameLabel.AutoSize = true;
            this.GroupfileNameLabel.Location = new System.Drawing.Point(8, 45);
            this.GroupfileNameLabel.Name = "GroupfileNameLabel";
            this.GroupfileNameLabel.Size = new System.Drawing.Size(131, 13);
            this.GroupfileNameLabel.TabIndex = 1;
            this.GroupfileNameLabel.Text = "Group database file name:";
            this.GroupfileNameLabel.UseMnemonic = false;
            this.GroupfileNameLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // userFileName
            // 
            this.userFileName.Location = new System.Drawing.Point(178, 19);
            this.userFileName.Name = "userFileName";
            this.userFileName.Size = new System.Drawing.Size(301, 20);
            this.userFileName.TabIndex = 0;
            this.userFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userFileNameLabel
            // 
            this.userFileNameLabel.AutoSize = true;
            this.userFileNameLabel.Location = new System.Drawing.Point(8, 19);
            this.userFileNameLabel.Name = "userFileNameLabel";
            this.userFileNameLabel.Size = new System.Drawing.Size(124, 13);
            this.userFileNameLabel.TabIndex = 1;
            this.userFileNameLabel.Text = "User database file name:";
            this.userFileNameLabel.UseMnemonic = false;
            this.userFileNameLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // GuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 355);
            this.Controls.Add(this.ImportCurrentAction);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GuiForm";
            this.Text = "User group migration thingy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ImportCurrentAction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog exportFolderBrowserDialog;
        private System.Windows.Forms.Label destinationPathLabel;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.CheckBox userCheckBox;
        private System.Windows.Forms.Button pathBrowseButton;
        private System.Windows.Forms.Button exportRunButton;
        private System.Windows.Forms.TabControl ImportCurrentAction;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label importUserLabel;
        private System.Windows.Forms.TextBox importUserPath;
        private System.Windows.Forms.Button importRunButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem1;
        private System.Windows.Forms.CheckBox groupUserCheckBox;
        private System.Windows.Forms.CheckBox generateReportCheckBox;
        private System.Windows.Forms.CheckBox importReport;
        private System.Windows.Forms.CheckBox importGroups;
        private System.Windows.Forms.CheckBox importGroupUsers;
        private System.Windows.Forms.CheckBox importUsers;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.ProgressBar ExportProgressBar;
        private System.Windows.Forms.Label ExportCurrentAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ImportProgressBar;
        private System.Windows.Forms.Label importGroupMembersLabel;
        private System.Windows.Forms.Label importGroupLabel;
        private System.Windows.Forms.TextBox importGroupMembersPath;
        private System.Windows.Forms.TextBox importGroupPath;
        private System.Windows.Forms.Button importUserBrowse;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.Button importGroupBrowse;
        private System.Windows.Forms.Button importGroupMembersBrowse;
        private System.Windows.Forms.Label userFileNameLabel;
        private System.Windows.Forms.Label GroupfileNameLabel;
        private System.Windows.Forms.Label groupMembersFileNameLabel;
        private System.Windows.Forms.TextBox userFileName;
        private System.Windows.Forms.TextBox groupFileName;
        private System.Windows.Forms.TextBox groupMemberFileName;
    }
}

