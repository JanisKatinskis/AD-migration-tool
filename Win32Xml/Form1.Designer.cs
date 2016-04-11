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
            this.runProgram = new System.Windows.Forms.Button();
            this.pathBrowseButton = new System.Windows.Forms.Button();
            this.userCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // runProgram
            // 
            this.runProgram.Location = new System.Drawing.Point(442, 148);
            this.runProgram.Name = "runProgram";
            this.runProgram.Size = new System.Drawing.Size(74, 20);
            this.runProgram.TabIndex = 3;
            this.runProgram.Text = "Run";
            this.runProgram.UseVisualStyleBackColor = true;
            this.runProgram.Click += new System.EventHandler(this.runProgram_Click);
            // 
            // pathBrowseButton
            // 
            this.pathBrowseButton.Location = new System.Drawing.Point(442, 48);
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
            this.userCheckBox.Location = new System.Drawing.Point(135, 83);
            this.userCheckBox.Name = "userCheckBox";
            this.userCheckBox.Size = new System.Drawing.Size(84, 17);
            this.userCheckBox.TabIndex = 4;
            this.userCheckBox.Text = "Export users";
            this.userCheckBox.UseVisualStyleBackColor = true;
            this.userCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(135, 48);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(301, 20);
            this.destinationPath.TabIndex = 0;
            this.destinationPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.Location = new System.Drawing.Point(135, 106);
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
            this.destinationPathLabel.Location = new System.Drawing.Point(45, 51);
            this.destinationPathLabel.Name = "destinationPathLabel";
            this.destinationPathLabel.Size = new System.Drawing.Size(87, 13);
            this.destinationPathLabel.TabIndex = 1;
            this.destinationPathLabel.Text = "Destination path:";
            this.destinationPathLabel.UseMnemonic = false;
            this.destinationPathLabel.Click += new System.EventHandler(this.DestinationPathLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 292);
            this.Controls.Add(this.groupCheckBox);
            this.Controls.Add(this.userCheckBox);
            this.Controls.Add(this.runProgram);
            this.Controls.Add(this.pathBrowseButton);
            this.Controls.Add(this.destinationPathLabel);
            this.Controls.Add(this.destinationPath);
            this.Name = "Form1";
            this.Text = "User group migration thingy";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button runProgram;
    }
}

