using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;


namespace Win32Xml
{
    public partial class GuiForm : Form
    {
        public GuiForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.destinationPath.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DestinationPathLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// The run button on the "Export" tab.
        /// </summary>
        private void exportRunButton_Click(object sender, EventArgs e)
        {

            // If there is an attempt to run the program with no checkboxes selected
            if (userCheckBox.Checked == false && groupCheckBox.Checked == false && groupUserCheckBox.Checked == false)
            {
                MessageBox.Show("You have not selected any of the actions.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Sets wheter or not to generate report
            if (generateReportCheckBox.Checked == true)
            {
                Global.generateReport = true;
                Global.reportPath = destinationPath.Text;

                // Creates the report file
                AccountExport.generateExportReportFile(Global.reportPath);
            }
            else
            {
                Global.generateReport = false;
            }

            // Utility variable. Contains the last character of the folder path
            // that will be checked in the if statement below.
            char lastChar = destinationPath.Text[destinationPath.Text.Length - 1];

            // Adds an extra slash at the end of the folder path if there isn't one already. Avoids unnecessary problems.
            if (lastChar != '\\') destinationPath.Text = destinationPath.Text + "\\";

            // If the mention report path does not exist or is not selected
            if (Global.generateReport == true && (destinationPath.Text == string.Empty || Directory.Exists(destinationPath.Text) == false))
            {
                MessageBox.Show("Incorrect report path!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Checks if "Export users" checkbox is checked. If true, executes function
            // that will query and export Active Directory user info.
            if (userCheckBox.Checked == true)
            {
                ExportCurrentAction.Text = "Exporting users...";
                AccountExport.QueryPrincipalUsers(destinationPath.Text, userFileName.Text);
            }

            // Checks if "Export users" checkbox is checked. If true, executes function
            // that will query and export Active Directory user info.
            if (groupCheckBox.Checked == true)
            {
                ExportCurrentAction.Text = "Exporting groups...";
                AccountExport.QueryPrincipalGroups(destinationPath.Text, groupFileName.Text);
            }
            if (groupUserCheckBox.Checked == true && groupCheckBox.Checked == true && userCheckBox.Checked == true)
            {
                ExportCurrentAction.Text = "Exporting group membership info...";
                AccountExport.QueryGroupsMembers(destinationPath.Text, groupMemberFileName.Text);
            }

            ExportCurrentAction.Text = "All tasks finished!";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// The "Run" button on the "Import" tab.
        /// </summary>
        private void importRunButton_Click(object sender, EventArgs e)
        {

            if (importUsers.Checked == false && importGroups.Checked == false && importGroupUsers.Checked == false)
            {
                MessageBox.Show("You have not selected any actions!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Sets wheter or not to generate report
            if (generateReportCheckBox.Checked == true)
            {
                Global.generateReport = true;
                Global.reportPath = importReportPath.Text;

                // check if the report file path has entered and exists
                if (Global.generateReport == true && (importReportPath.Text == string.Empty || Directory.Exists(importReportPath.Text) == false))
                {
                    MessageBox.Show("Incorrect report path!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                // Create the report file
                AccountImport.generateImportReportFile(Global.reportPath);
            }
            else
            {
                Global.generateReport = false;
            }


            // Checks if "Export users" checkbox is checked. If true, executes function
            // that will query and export Active Directory user info.
            if (importUsers.Checked == true)
            {
                // Cheks if the correct file format is selected
                if (importUserPath.Text.EndsWith(".xml") == false)
                {
                    MessageBox.Show("Incorrect user file selected!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    Global.importUserPath = importUserPath.Text;
                    CurrentImportAction.Text = "Importing users...";
                    PasswordPrompt passwordPrompt = new PasswordPrompt();
                    passwordPrompt.ShowDialog();


                }

            }
            
            // Checks if "Export users" checkbox is checked. If true, executes function
            // that will query and export Active Directory user info.
            if (importGroups.Checked == true)
            {
                // Cheks if the correct file format is selected
                if (importGroupPath.Text.EndsWith(".xml") == false)
                {
                    MessageBox.Show("Incorrect group file selected!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                CurrentImportAction.Text = "Importing groups...";
                AccountImport.ReadGroups(importGroupPath.Text);

                }
            }

            if (importUsers.Checked == true && importGroups.Checked == true && importGroupUsers.Checked == true)
            {
                // Cheks if the correct file format is selected
                if (importGroupPath.Text.EndsWith(".xml") == false)
                {
                    MessageBox.Show("Incorrect group member file selected!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                CurrentImportAction.Text = "Adding users to groups...";
                AccountImport.UsersToGroups(importGroupMembersPath.Text);
                }
            }

            CurrentImportAction.Text = "All tasks finished!";

        }

        private void sourceBrowseButton_Click(object sender, EventArgs e)
        {

            if (importFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.importUserPath.Text = importFileDialog.FileName;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void generateReportCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Export groups-users checkbox
        private void groupUserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // disables this checkbox if either "Export groups" or "Export users" are not checked
            //if (userCheckBox.Checked == true || groupCheckBox.Checked && true) groupUserCheckBox.Enabled = true;
            //else if (userCheckBox.Checked == false || groupCheckBox.Checked == false) groupUserCheckBox.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExportProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void importGroupBrowse_Click(object sender, EventArgs e)
        {
            /**
            XDocument doc = XDocument.Load(importFileDialog.FileName);

            if (doc.FirstNode.ToString() != "group_list")
            {
                MessageBox.Show("This file does not contain apropriate XML tag!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            **/


            if (importFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.importGroupPath.Text = importFileDialog.FileName;
            }
        }

        private void importGroupMembersBrowse_Click(object sender, EventArgs e)
        {
            /**
            XDocument doc = XDocument.Load(importFileDialog.FileName);

            if (doc.FirstNode.ToString() != "groupsusers")
            {
                MessageBox.Show("This file does not contain apropriate XML tag!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            **/


            if (importFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.importGroupMembersPath.Text = importFileDialog.FileName;
            }
        }

        private void importFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.importReportPath.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
