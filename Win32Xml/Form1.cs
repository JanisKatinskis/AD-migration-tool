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
    public partial class Form1 : Form
    {
        public Form1()
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
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.destinationPath.Text = folderBrowserDialog1.SelectedPath;
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

        private void runProgram_Click(object sender, EventArgs e)
        {
            if(userCheckBox.Checked == true && groupCheckBox.Checked == true)
            {
                MessageBox.Show("Start!", "Note",
                   MessageBoxButtons.OK, MessageBoxIcon.None);
                AccountExport.QueryGroups(destinationPath.Text, exportName.Text);
                AccountExport.QueryUsers(destinationPath.Text, exportName.Text);
                AccountExport.GroupUser(destinationPath.Text, exportName.Text);
                MessageBox.Show("All done!", "Note",
                   MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if(userCheckBox.Checked == true)
            {
                MessageBox.Show("Start!", "Note",
                   MessageBoxButtons.OK, MessageBoxIcon.None);
                AccountExport.QueryUsers(destinationPath.Text, exportName.Text);
                MessageBox.Show("All done!", "Note",
                   MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (groupCheckBox.Checked == true)
            {
                MessageBox.Show("Start!", "Note",
                   MessageBoxButtons.OK, MessageBoxIcon.None);
                AccountExport.QueryGroups(destinationPath.Text, exportName.Text);
                MessageBox.Show("All done!", "Note",
                   MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("You have not selected anything WTF", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void importRunButton_Click(object sender, EventArgs e)
        {
            AccountImport.ReadFile(sourceFolder.Text);
        }

        private void sourceBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.sourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
