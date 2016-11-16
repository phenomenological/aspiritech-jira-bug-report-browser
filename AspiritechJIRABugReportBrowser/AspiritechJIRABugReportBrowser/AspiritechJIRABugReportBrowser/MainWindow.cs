using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspiritechJIRABugReportBrowser
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.jira_reports' table. You can move, or remove it, as needed.
            this.jira_reportsTableAdapter.Fill(this.masterDataSet.jira_reports);

        }

        // Populate the Entry Details box when the user double-clicks a cell.
        private void datJiraSubmissions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lnkJiraEntry.Text = datJiraSubmissions[1, e.RowIndex].Value.ToString();
        }

        // Open JIRA in the default web browser if the link is clicked while it has text.
        private void lnkJiraEntry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkJiraEntry.Text != "")
            {
                System.Diagnostics.Process.Start("https://jirapro.bose.com/browse" + lnkJiraEntry.Text);
            }
        }
    }
}
