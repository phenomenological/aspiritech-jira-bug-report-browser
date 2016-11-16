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
            txtEntryDetails.Text =
                "Date Reported: " + datJiraSubmissions[2, e.RowIndex].Value.ToString() + "\r\n"
                + "Summary: " + datJiraSubmissions[3, e.RowIndex].Value.ToString() + "\r\n"
                + "Reporter: " + datJiraSubmissions[4, e.RowIndex].Value.ToString() + "\r\n \r\n"
                + "*Test Case/Step:* \r\n" + datJiraSubmissions[5, e.RowIndex].Value.ToString() + "/" + datJiraSubmissions[6, e.RowIndex].Value.ToString() + "\r\n"
                + "*Homer/Gabbo version:* \r\n" + datJiraSubmissions[7, e.RowIndex].Value.ToString() + "\r\n"
                + "*Device Version:* \r\n" + datJiraSubmissions[8, e.RowIndex].Value.ToString() + "\r\n"
                + "*Connection:* \r\n" + datJiraSubmissions[9, e.RowIndex].Value.ToString() + "\r\n"
                + "*Test Environment:* \r\n" + datJiraSubmissions[10, e.RowIndex].Value.ToString() + "\r\n"
                + "*Steps to Reproduce:* \r\n" + datJiraSubmissions[11, e.RowIndex].Value.ToString() + "\r\n \r\n"
                + "*Expected Result:* \r\n" + datJiraSubmissions[12, e.RowIndex].Value.ToString() + "\r\n"
                + "*Actual Result:* \r\n" + datJiraSubmissions[13, e.RowIndex].Value.ToString() + "\r\n \r\n"
                + "*Times Repeatable:* \r\n" + datJiraSubmissions[14, e.RowIndex].Value.ToString() + " / " + datJiraSubmissions[15, e.RowIndex].Value.ToString() + " Times\r\n"
                + "*Test Machine Name(s):* \r\n" + datJiraSubmissions[16, e.RowIndex].Value.ToString() + "\r\n"
                + "*Workaround:* \r\n" + datJiraSubmissions[17, e.RowIndex].Value.ToString() + "\r\n"
                + "*Other Notes/Comments*: \r\n" + datJiraSubmissions[18, e.RowIndex].Value.ToString()
            ;
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
