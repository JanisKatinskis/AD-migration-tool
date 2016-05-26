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
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.exportRunButton = new System.Windows.Forms.Button();
            this.pathBrowseButton = new System.Windows.Forms.Button();
            this.userCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationPathLabel = new System.Windows.Forms.Label();
            this.ImportCurrentAction = new System.Windows.Forms.TabControl();
            this.exportTab = new System.Windows.Forms.TabPage();
            this.ExportCurrentAction = new System.Windows.Forms.Label();
            this.generateReportCheckBox = new System.Windows.Forms.CheckBox();
            this.groupUserCheckBox = new System.Windows.Forms.CheckBox();
            this.userFileNameLabel = new System.Windows.Forms.Label();
            this.GroupfileNameLabel = new System.Windows.Forms.Label();
            this.groupMembersFileNameLabel = new System.Windows.Forms.Label();
            this.userFileName = new System.Windows.Forms.TextBox();
            this.groupFileName = new System.Windows.Forms.TextBox();
            this.groupMemberFileName = new System.Windows.Forms.TextBox();
            this.importTab = new System.Windows.Forms.TabPage();
            this.importReportPathLabel = new System.Windows.Forms.Label();
            this.importReportPath = new System.Windows.Forms.TextBox();
            this.importReportPathBrowseButton = new System.Windows.Forms.Button();
            this.importGroupMembersBrowse = new System.Windows.Forms.Button();
            this.importGroupBrowse = new System.Windows.Forms.Button();
            this.CurrentImportAction = new System.Windows.Forms.Label();
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
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImportCurrentAction.SuspendLayout();
            this.exportTab.SuspendLayout();
            this.importTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
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
            this.pathBrowseButton.Location = new System.Drawing.Point(405, 120);
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
            this.destinationPathLabel.Location = new System.Drawing.Point(8, 124);
            this.destinationPathLabel.Name = "destinationPathLabel";
            this.destinationPathLabel.Size = new System.Drawing.Size(87, 13);
            this.destinationPathLabel.TabIndex = 1;
            this.destinationPathLabel.Text = "Destination path:";
            this.destinationPathLabel.UseMnemonic = false;
            this.destinationPathLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // ImportCurrentAction
            // 
            this.ImportCurrentAction.Controls.Add(this.exportTab);
            this.ImportCurrentAction.Controls.Add(this.importTab);
            this.ImportCurrentAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportCurrentAction.Location = new System.Drawing.Point(0, 0);
            this.ImportCurrentAction.Name = "ImportCurrentAction";
            this.ImportCurrentAction.SelectedIndex = 0;
            this.ImportCurrentAction.Size = new System.Drawing.Size(520, 308);
            this.ImportCurrentAction.TabIndex = 5;
            // 
            // exportTab
            // 
            this.exportTab.Controls.Add(this.ExportCurrentAction);
            this.exportTab.Controls.Add(this.generateReportCheckBox);
            this.exportTab.Controls.Add(this.groupUserCheckBox);
            this.exportTab.Controls.Add(this.userFileNameLabel);
            this.exportTab.Controls.Add(this.GroupfileNameLabel);
            this.exportTab.Controls.Add(this.groupMembersFileNameLabel);
            this.exportTab.Controls.Add(this.destinationPathLabel);
            this.exportTab.Controls.Add(this.groupCheckBox);
            this.exportTab.Controls.Add(this.userFileName);
            this.exportTab.Controls.Add(this.groupFileName);
            this.exportTab.Controls.Add(this.groupMemberFileName);
            this.exportTab.Controls.Add(this.destinationPath);
            this.exportTab.Controls.Add(this.userCheckBox);
            this.exportTab.Controls.Add(this.pathBrowseButton);
            this.exportTab.Controls.Add(this.exportRunButton);
            this.exportTab.Location = new System.Drawing.Point(4, 22);
            this.exportTab.Name = "exportTab";
            this.exportTab.Padding = new System.Windows.Forms.Padding(3);
            this.exportTab.Size = new System.Drawing.Size(512, 282);
            this.exportTab.TabIndex = 0;
            this.exportTab.Text = "Export";
            this.exportTab.UseVisualStyleBackColor = true;
            this.exportTab.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // ExportCurrentAction
            // 
            this.ExportCurrentAction.AutoSize = true;
            this.ExportCurrentAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ExportCurrentAction.Location = new System.Drawing.Point(6, 264);
            this.ExportCurrentAction.Name = "ExportCurrentAction";
            this.ExportCurrentAction.Size = new System.Drawing.Size(79, 13);
            this.ExportCurrentAction.TabIndex = 11;
            this.ExportCurrentAction.Text = "Ready to work!";
            this.ExportCurrentAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generateReportCheckBox
            // 
            this.generateReportCheckBox.AutoSize = true;
            this.generateReportCheckBox.Checked = true;
            this.generateReportCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // userFileNameLabel
            // 
            this.userFileNameLabel.AutoSize = true;
            this.userFileNameLabel.Location = new System.Drawing.Point(48, 22);
            this.userFileNameLabel.Name = "userFileNameLabel";
            this.userFileNameLabel.Size = new System.Drawing.Size(124, 13);
            this.userFileNameLabel.TabIndex = 1;
            this.userFileNameLabel.Text = "User database file name:";
            this.userFileNameLabel.UseMnemonic = false;
            this.userFileNameLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // GroupfileNameLabel
            // 
            this.GroupfileNameLabel.AutoSize = true;
            this.GroupfileNameLabel.Location = new System.Drawing.Point(41, 48);
            this.GroupfileNameLabel.Name = "GroupfileNameLabel";
            this.GroupfileNameLabel.Size = new System.Drawing.Size(131, 13);
            this.GroupfileNameLabel.TabIndex = 1;
            this.GroupfileNameLabel.Text = "Group database file name:";
            this.GroupfileNameLabel.UseMnemonic = false;
            this.GroupfileNameLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // groupMembersFileNameLabel
            // 
            this.groupMembersFileNameLabel.AutoSize = true;
            this.groupMembersFileNameLabel.Location = new System.Drawing.Point(12, 74);
            this.groupMembersFileNameLabel.Name = "groupMembersFileNameLabel";
            this.groupMembersFileNameLabel.Size = new System.Drawing.Size(160, 13);
            this.groupMembersFileNameLabel.TabIndex = 1;
            this.groupMembersFileNameLabel.Text = "Group members database name:";
            this.groupMembersFileNameLabel.UseMnemonic = false;
            this.groupMembersFileNameLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // userFileName
            // 
            this.userFileName.Location = new System.Drawing.Point(178, 19);
            this.userFileName.Name = "userFileName";
            this.userFileName.Size = new System.Drawing.Size(301, 20);
            this.userFileName.TabIndex = 0;
            this.userFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupFileName
            // 
            this.groupFileName.Location = new System.Drawing.Point(178, 45);
            this.groupFileName.Name = "groupFileName";
            this.groupFileName.Size = new System.Drawing.Size(301, 20);
            this.groupFileName.TabIndex = 0;
            this.groupFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupMemberFileName
            // 
            this.groupMemberFileName.Location = new System.Drawing.Point(178, 71);
            this.groupMemberFileName.Name = "groupMemberFileName";
            this.groupMemberFileName.Size = new System.Drawing.Size(301, 20);
            this.groupMemberFileName.TabIndex = 0;
            this.groupMemberFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // importTab
            // 
            this.importTab.Controls.Add(this.importReportPathLabel);
            this.importTab.Controls.Add(this.importReportPath);
            this.importTab.Controls.Add(this.importReportPathBrowseButton);
            this.importTab.Controls.Add(this.importGroupMembersBrowse);
            this.importTab.Controls.Add(this.importGroupBrowse);
            this.importTab.Controls.Add(this.CurrentImportAction);
            this.importTab.Controls.Add(this.importReport);
            this.importTab.Controls.Add(this.importGroups);
            this.importTab.Controls.Add(this.importGroupUsers);
            this.importTab.Controls.Add(this.importUsers);
            this.importTab.Controls.Add(this.importGroupMembersLabel);
            this.importTab.Controls.Add(this.importGroupLabel);
            this.importTab.Controls.Add(this.importGroupMembersPath);
            this.importTab.Controls.Add(this.importGroupPath);
            this.importTab.Controls.Add(this.importUserLabel);
            this.importTab.Controls.Add(this.importUserPath);
            this.importTab.Controls.Add(this.importUserBrowse);
            this.importTab.Controls.Add(this.importRunButton);
            this.importTab.Location = new System.Drawing.Point(4, 22);
            this.importTab.Name = "importTab";
            this.importTab.Padding = new System.Windows.Forms.Padding(3);
            this.importTab.Size = new System.Drawing.Size(512, 282);
            this.importTab.TabIndex = 1;
            this.importTab.Text = "Import";
            this.importTab.UseVisualStyleBackColor = true;
            // 
            // importReportPathLabel
            // 
            this.importReportPathLabel.AutoSize = true;
            this.importReportPathLabel.Location = new System.Drawing.Point(36, 203);
            this.importReportPathLabel.Name = "importReportPathLabel";
            this.importReportPathLabel.Size = new System.Drawing.Size(66, 13);
            this.importReportPathLabel.TabIndex = 18;
            this.importReportPathLabel.Text = "Report path:";
            this.importReportPathLabel.UseMnemonic = false;
            // 
            // importReportPath
            // 
            this.importReportPath.Location = new System.Drawing.Point(108, 200);
            this.importReportPath.Name = "importReportPath";
            this.importReportPath.Size = new System.Drawing.Size(301, 20);
            this.importReportPath.TabIndex = 17;
            // 
            // importReportPathBrowseButton
            // 
            this.importReportPathBrowseButton.Location = new System.Drawing.Point(415, 200);
            this.importReportPathBrowseButton.Name = "importReportPathBrowseButton";
            this.importReportPathBrowseButton.Size = new System.Drawing.Size(74, 20);
            this.importReportPathBrowseButton.TabIndex = 19;
            this.importReportPathBrowseButton.Text = "Browse...";
            this.importReportPathBrowseButton.UseVisualStyleBackColor = true;
            this.importReportPathBrowseButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // importGroupMembersBrowse
            // 
            this.importGroupMembersBrowse.Location = new System.Drawing.Point(415, 82);
            this.importGroupMembersBrowse.Name = "importGroupMembersBrowse";
            this.importGroupMembersBrowse.Size = new System.Drawing.Size(75, 20);
            this.importGroupMembersBrowse.TabIndex = 16;
            this.importGroupMembersBrowse.Text = "Browse...";
            this.importGroupMembersBrowse.UseVisualStyleBackColor = true;
            this.importGroupMembersBrowse.Click += new System.EventHandler(this.importGroupMembersBrowse_Click);
            // 
            // importGroupBrowse
            // 
            this.importGroupBrowse.Location = new System.Drawing.Point(415, 56);
            this.importGroupBrowse.Name = "importGroupBrowse";
            this.importGroupBrowse.Size = new System.Drawing.Size(75, 20);
            this.importGroupBrowse.TabIndex = 15;
            this.importGroupBrowse.Text = "Browse...";
            this.importGroupBrowse.UseVisualStyleBackColor = true;
            this.importGroupBrowse.Click += new System.EventHandler(this.importGroupBrowse_Click);
            // 
            // CurrentImportAction
            // 
            this.CurrentImportAction.AutoSize = true;
            this.CurrentImportAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CurrentImportAction.Location = new System.Drawing.Point(6, 264);
            this.CurrentImportAction.Name = "CurrentImportAction";
            this.CurrentImportAction.Size = new System.Drawing.Size(79, 13);
            this.CurrentImportAction.TabIndex = 14;
            this.CurrentImportAction.Text = "Ready to work!";
            this.CurrentImportAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CurrentImportAction.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // importReport
            // 
            this.importReport.AutoSize = true;
            this.importReport.Checked = true;
            this.importReport.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.importGroupMembersLabel.Location = new System.Drawing.Point(2, 86);
            this.importGroupMembersLabel.Name = "importGroupMembersLabel";
            this.importGroupMembersLabel.Size = new System.Drawing.Size(100, 13);
            this.importGroupMembersLabel.TabIndex = 6;
            this.importGroupMembersLabel.Text = "Group member files:";
            this.importGroupMembersLabel.UseMnemonic = false;
            // 
            // importGroupLabel
            // 
            this.importGroupLabel.AutoSize = true;
            this.importGroupLabel.Location = new System.Drawing.Point(47, 59);
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
            this.importUserLabel.Location = new System.Drawing.Point(54, 33);
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
            this.importUserBrowse.Location = new System.Drawing.Point(416, 30);
            this.importUserBrowse.Name = "importUserBrowse";
            this.importUserBrowse.Size = new System.Drawing.Size(74, 20);
            this.importUserBrowse.TabIndex = 7;
            this.importUserBrowse.Text = "Browse...";
            this.importUserBrowse.UseVisualStyleBackColor = true;
            this.importUserBrowse.Click += new System.EventHandler(this.sourceBrowseButton_Click);
            // 
            // importRunButton
            // 
            this.importRunButton.Location = new System.Drawing.Point(415, 229);
            this.importRunButton.Name = "importRunButton";
            this.importRunButton.Size = new System.Drawing.Size(74, 20);
            this.importRunButton.TabIndex = 8;
            this.importRunButton.Text = "Run";
            this.importRunButton.UseVisualStyleBackColor = true;
            this.importRunButton.Click += new System.EventHandler(this.importRunButton_Click);
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
            // GuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 308);
            this.Controls.Add(this.ImportCurrentAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuiForm";
            this.Text = "Active Directory Migration Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ImportCurrentAction.ResumeLayout(false);
            this.exportTab.ResumeLayout(false);
            this.exportTab.PerformLayout();
            this.importTab.ResumeLayout(false);
            this.importTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label destinationPathLabel;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private System.Windows.Forms.CheckBox userCheckBox;
        private System.Windows.Forms.Button pathBrowseButton;
        private System.Windows.Forms.Button exportRunButton;
        private System.Windows.Forms.TabControl ImportCurrentAction;
        private System.Windows.Forms.TabPage exportTab;
        private System.Windows.Forms.TabPage importTab;
        private System.Windows.Forms.Label importUserLabel;
        private System.Windows.Forms.TextBox importUserPath;
        private System.Windows.Forms.Button importRunButton;
        private System.Windows.Forms.CheckBox groupUserCheckBox;
        private System.Windows.Forms.CheckBox importReport;
        private System.Windows.Forms.CheckBox importGroups;
        private System.Windows.Forms.CheckBox importGroupUsers;
        private System.Windows.Forms.CheckBox importUsers;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Label ExportCurrentAction;
        private System.Windows.Forms.Label CurrentImportAction;
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
        public System.Windows.Forms.CheckBox generateReportCheckBox;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.Label importReportPathLabel;
        private System.Windows.Forms.TextBox importReportPath;
        private System.Windows.Forms.Button importReportPathBrowseButton;
    }
}

