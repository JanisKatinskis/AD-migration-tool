using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


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
            if (exportFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.destinationPath.Text = exportFolderBrowserDialog.SelectedPath;
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

            // Sets wheter or not to generate report
            if (generateReportCheckBox.Checked == true)
            {
                Global.generateReport = true;
                Global.reportPath = destinationPath.Text;
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

            // Checks if "Export users" checkbox is checked. If true, executes function
            // that will query and export Active Directory user info.
            if(userCheckBox.Checked == true)
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

            if (userCheckBox.Checked == false && groupCheckBox.Checked == false && groupUserCheckBox.Checked == false)
            {
                MessageBox.Show("You have not selected any of the actions.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ExportCurrentAction.Text = "Everything done!";

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

            // Checks if "Export users" checkbox is checked. If true, executes function
            // that will query and export Active Directory user info.
            if (importUsers.Checked == true)
            {
                ExportCurrentAction.Text = "Importing users...";
                AccountImport.ReadUsers(importUserPath.Text);
            }

            // Checks if "Export users" checkbox is checked. If true, executes function
            // that will query and export Active Directory user info.
            if (importGroups.Checked == true)
            {
                ExportCurrentAction.Text = "Importing groups...";
                AccountImport.ReadGroups(importGroupPath.Text);
            }
            if (importUsers.Checked == true && importGroups.Checked == true && importGroupUsers.Checked == true)
            {
                ExportCurrentAction.Text = "Adding users to groups...";
                AccountImport.UsersToGroups(importGroupMembersPath.Text);
            }

            if (importUsers.Checked == false && importGroups.Checked == false && importGroupUsers.Checked == false)
            {
                MessageBox.Show("You have not selected anything WTF", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("All done!", "Alldone!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ExportCurrentAction.Text = "Everything done!";
        }

        private void sourceBrowseButton_Click(object sender, EventArgs e)
        {
            //XDocument doc = XDocument.Load(importFileDialog.FileName);

            /**
            if(doc.FirstNode.ToString() != "account_list")
            {
                MessageBox.Show("This file does not contain apropriate XML tag!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            **/

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
            XDocument doc = XDocument.Load(importFileDialog.FileName);

            if (doc.FirstNode.ToString() != "group_list")
            {
                MessageBox.Show("This file does not contain apropriate XML tag!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            if (importFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.importGroupPath.Text = importFileDialog.FileName;
            }
        }

        private void importGroupMembersBrowse_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(importFileDialog.FileName);

            if (doc.FirstNode.ToString() != "groupsusers")
            {
                MessageBox.Show("This file does not contain apropriate XML tag!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            if (importFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.importGroupMembersPath.Text = importFileDialog.FileName;
            }
        }

        private void importFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
