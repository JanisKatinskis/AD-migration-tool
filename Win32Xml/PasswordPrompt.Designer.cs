namespace Win32Xml
{
    partial class PasswordPrompt
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.enterPassword = new System.Windows.Forms.Label();
            this.enterPassword2 = new System.Windows.Forms.Label();
            this.passwordTitleText = new System.Windows.Forms.Label();
            this.passwordSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(113, 35);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(126, 20);
            this.passwordBox.TabIndex = 0;
            // 
            // passwordBox2
            // 
            this.passwordBox2.Location = new System.Drawing.Point(113, 61);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.PasswordChar = '*';
            this.passwordBox2.Size = new System.Drawing.Size(126, 20);
            this.passwordBox2.TabIndex = 0;
            // 
            // enterPassword
            // 
            this.enterPassword.AutoSize = true;
            this.enterPassword.Location = new System.Drawing.Point(51, 38);
            this.enterPassword.Name = "enterPassword";
            this.enterPassword.Size = new System.Drawing.Size(56, 13);
            this.enterPassword.TabIndex = 1;
            this.enterPassword.Text = "Password:";
            // 
            // enterPassword2
            // 
            this.enterPassword2.AutoSize = true;
            this.enterPassword2.Location = new System.Drawing.Point(12, 64);
            this.enterPassword2.Name = "enterPassword2";
            this.enterPassword2.Size = new System.Drawing.Size(95, 13);
            this.enterPassword2.TabIndex = 2;
            this.enterPassword2.Text = "Re-type password:";
            // 
            // passwordTitleText
            // 
            this.passwordTitleText.AutoSize = true;
            this.passwordTitleText.Location = new System.Drawing.Point(51, 9);
            this.passwordTitleText.Name = "passwordTitleText";
            this.passwordTitleText.Size = new System.Drawing.Size(151, 13);
            this.passwordTitleText.TabIndex = 3;
            this.passwordTitleText.Text = "Please set the initial password!";
            // 
            // passwordSubmitButton
            // 
            this.passwordSubmitButton.Location = new System.Drawing.Point(157, 96);
            this.passwordSubmitButton.Name = "passwordSubmitButton";
            this.passwordSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.passwordSubmitButton.TabIndex = 4;
            this.passwordSubmitButton.Text = "OK";
            this.passwordSubmitButton.UseVisualStyleBackColor = true;
            this.passwordSubmitButton.Click += new System.EventHandler(this.passwordSubmitButton_Click);
            // 
            // PasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 131);
            this.Controls.Add(this.passwordSubmitButton);
            this.Controls.Add(this.passwordTitleText);
            this.Controls.Add(this.enterPassword2);
            this.Controls.Add(this.enterPassword);
            this.Controls.Add(this.passwordBox2);
            this.Controls.Add(this.passwordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PasswordPrompt";
            this.Text = "Please set password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.Label enterPassword;
        private System.Windows.Forms.Label enterPassword2;
        private System.Windows.Forms.Label passwordTitleText;
        private System.Windows.Forms.Button passwordSubmitButton;
    }
}