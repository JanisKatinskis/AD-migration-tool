namespace Win32Xml
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.exportRunButton = new System.Windows.Forms.Button();
            this.pathBrowseButton = new System.Windows.Forms.Button();
            this.userCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationPathLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exportNameLabel = new System.Windows.Forms.Label();
            this.exportName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceFolder = new System.Windows.Forms.TextBox();
            this.sourceBrowseButton = new System.Windows.Forms.Button();
            this.importRunButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.somethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // exportRunButton
            // 
            this.exportRunButton.Location = new System.Drawing.Point(405, 150);
            this.exportRunButton.Name = "exportRunButton";
            this.exportRunButton.Size = new System.Drawing.Size(74, 20);
            this.exportRunButton.TabIndex = 3;
            this.exportRunButton.Text = "Run";
            this.exportRunButton.UseVisualStyleBackColor = true;
            this.exportRunButton.Click += new System.EventHandler(this.runProgram_Click);
            // 
            // pathBrowseButton
            // 
            this.pathBrowseButton.Location = new System.Drawing.Point(405, 50);
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
            this.userCheckBox.Location = new System.Drawing.Point(98, 77);
            this.userCheckBox.Name = "userCheckBox";
            this.userCheckBox.Size = new System.Drawing.Size(84, 17);
            this.userCheckBox.TabIndex = 4;
            this.userCheckBox.Text = "Export users";
            this.userCheckBox.UseVisualStyleBackColor = true;
            this.userCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(98, 51);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(301, 20);
            this.destinationPath.TabIndex = 0;
            this.destinationPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.Location = new System.Drawing.Point(98, 100);
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
            this.destinationPathLabel.Location = new System.Drawing.Point(8, 54);
            this.destinationPathLabel.Name = "destinationPathLabel";
            this.destinationPathLabel.Size = new System.Drawing.Size(87, 13);
            this.destinationPathLabel.TabIndex = 1;
            this.destinationPathLabel.Text = "Destination path:";
            this.destinationPathLabel.UseMnemonic = false;
            this.destinationPathLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 209);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exportNameLabel);
            this.tabPage1.Controls.Add(this.exportName);
            this.tabPage1.Controls.Add(this.destinationPathLabel);
            this.tabPage1.Controls.Add(this.groupCheckBox);
            this.tabPage1.Controls.Add(this.destinationPath);
            this.tabPage1.Controls.Add(this.userCheckBox);
            this.tabPage1.Controls.Add(this.pathBrowseButton);
            this.tabPage1.Controls.Add(this.exportRunButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Export";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // exportNameLabel
            // 
            this.exportNameLabel.AutoSize = true;
            this.exportNameLabel.Location = new System.Drawing.Point(57, 32);
            this.exportNameLabel.Name = "exportNameLabel";
            this.exportNameLabel.Size = new System.Drawing.Size(38, 13);
            this.exportNameLabel.TabIndex = 6;
            this.exportNameLabel.Text = "Name:";
            this.exportNameLabel.UseMnemonic = false;
            this.exportNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // exportName
            // 
            this.exportName.Location = new System.Drawing.Point(98, 29);
            this.exportName.Name = "exportName";
            this.exportName.Size = new System.Drawing.Size(301, 20);
            this.exportName.TabIndex = 5;
            this.exportName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sourceLabel);
            this.tabPage2.Controls.Add(this.sourceFolder);
            this.tabPage2.Controls.Add(this.sourceBrowseButton);
            this.tabPage2.Controls.Add(this.importRunButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(19, 32);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(73, 13);
            this.sourceLabel.TabIndex = 6;
            this.sourceLabel.Text = "Source folder:";
            this.sourceLabel.UseMnemonic = false;
            // 
            // sourceFolder
            // 
            this.sourceFolder.Location = new System.Drawing.Point(98, 29);
            this.sourceFolder.Name = "sourceFolder";
            this.sourceFolder.Size = new System.Drawing.Size(301, 20);
            this.sourceFolder.TabIndex = 5;
            this.sourceFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // sourceBrowseButton
            // 
            this.sourceBrowseButton.Location = new System.Drawing.Point(405, 29);
            this.sourceBrowseButton.Name = "sourceBrowseButton";
            this.sourceBrowseButton.Size = new System.Drawing.Size(74, 20);
            this.sourceBrowseButton.TabIndex = 7;
            this.sourceBrowseButton.Text = "Browse...";
            this.sourceBrowseButton.UseVisualStyleBackColor = true;
            this.sourceBrowseButton.Click += new System.EventHandler(this.sourceBrowseButton_Click);
            // 
            // importRunButton
            // 
            this.importRunButton.Location = new System.Drawing.Point(405, 150);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 231);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "User group migration thingy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label destinationPathLabel;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.CheckBox userCheckBox;
        private System.Windows.Forms.Button pathBrowseButton;
        private System.Windows.Forms.Button exportRunButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox sourceFolder;
        private System.Windows.Forms.Button sourceBrowseButton;
        private System.Windows.Forms.Button importRunButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem1;
        private System.Windows.Forms.Label exportNameLabel;
        private System.Windows.Forms.TextBox exportName;
    }
}

