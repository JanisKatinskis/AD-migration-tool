using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win32Xml
{
    public partial class PasswordPrompt : Form
    {
        public PasswordPrompt()
        {
            InitializeComponent();
        }

        private void passwordSubmitButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == passwordBox2.Text)
            {
                
                // Sets the initial password for the users
                Global.password = passwordBox.Text;

                // Closes the password form
                this.Close();

                // Executes the function to read users, which begins the user creation process
                AccountImport.ReadUsers(Global.importUserPath);

                
                Global.userPasswordSet = true;
            }
            else
            {
                MessageBox.Show("Please enter matching passwords!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
