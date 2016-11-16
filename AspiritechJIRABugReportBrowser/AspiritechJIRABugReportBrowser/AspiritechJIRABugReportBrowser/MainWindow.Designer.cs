namespace AspiritechJIRABugReportBrowser
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.datJiraSubmissions = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiraidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timereportedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testcaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teststepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homergabboversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceversionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jirareportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new AspiritechJIRABugReportBrowser.masterDataSet();
            this.jira_reportsTableAdapter = new AspiritechJIRABugReportBrowser.masterDataSetTableAdapters.jira_reportsTableAdapter();
            this.txtEntryDetails = new System.Windows.Forms.TextBox();
            this.lnkJiraEntry = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datJiraSubmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jirareportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // datJiraSubmissions
            // 
            this.datJiraSubmissions.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.datJiraSubmissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datJiraSubmissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.datJiraSubmissions.AutoGenerateColumns = false;
            this.datJiraSubmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datJiraSubmissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.jiraidDataGridViewTextBoxColumn,
            this.timereportedDataGridViewTextBoxColumn,
            this.summaryDataGridViewTextBoxColumn,
            this.reporterDataGridViewTextBoxColumn,
            this.testcaseDataGridViewTextBoxColumn,
            this.teststepDataGridViewTextBoxColumn,
            this.homergabboversionDataGridViewTextBoxColumn,
            this.deviceversionsDataGridViewTextBoxColumn});
            this.datJiraSubmissions.DataSource = this.jirareportsBindingSource;
            this.datJiraSubmissions.Location = new System.Drawing.Point(12, 12);
            this.datJiraSubmissions.Name = "datJiraSubmissions";
            this.datJiraSubmissions.RowHeadersVisible = false;
            this.datJiraSubmissions.Size = new System.Drawing.Size(894, 414);
            this.datJiraSubmissions.TabIndex = 0;
            this.datJiraSubmissions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datJiraSubmissions_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // jiraidDataGridViewTextBoxColumn
            // 
            this.jiraidDataGridViewTextBoxColumn.DataPropertyName = "jira_id";
            this.jiraidDataGridViewTextBoxColumn.HeaderText = "JIRA ID";
            this.jiraidDataGridViewTextBoxColumn.Name = "jiraidDataGridViewTextBoxColumn";
            // 
            // timereportedDataGridViewTextBoxColumn
            // 
            this.timereportedDataGridViewTextBoxColumn.DataPropertyName = "time_reported";
            this.timereportedDataGridViewTextBoxColumn.HeaderText = "Date Reported";
            this.timereportedDataGridViewTextBoxColumn.Name = "timereportedDataGridViewTextBoxColumn";
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            this.summaryDataGridViewTextBoxColumn.DataPropertyName = "summary";
            this.summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            // 
            // reporterDataGridViewTextBoxColumn
            // 
            this.reporterDataGridViewTextBoxColumn.DataPropertyName = "reporter";
            this.reporterDataGridViewTextBoxColumn.HeaderText = "Reporter";
            this.reporterDataGridViewTextBoxColumn.Name = "reporterDataGridViewTextBoxColumn";
            // 
            // testcaseDataGridViewTextBoxColumn
            // 
            this.testcaseDataGridViewTextBoxColumn.DataPropertyName = "test_case";
            this.testcaseDataGridViewTextBoxColumn.HeaderText = "Test Case";
            this.testcaseDataGridViewTextBoxColumn.Name = "testcaseDataGridViewTextBoxColumn";
            // 
            // teststepDataGridViewTextBoxColumn
            // 
            this.teststepDataGridViewTextBoxColumn.DataPropertyName = "test_step";
            this.teststepDataGridViewTextBoxColumn.HeaderText = "Test Step";
            this.teststepDataGridViewTextBoxColumn.Name = "teststepDataGridViewTextBoxColumn";
            // 
            // homergabboversionDataGridViewTextBoxColumn
            // 
            this.homergabboversionDataGridViewTextBoxColumn.DataPropertyName = "homer_gabbo_version";
            this.homergabboversionDataGridViewTextBoxColumn.HeaderText = "Homer / Gabbo Version";
            this.homergabboversionDataGridViewTextBoxColumn.Name = "homergabboversionDataGridViewTextBoxColumn";
            this.homergabboversionDataGridViewTextBoxColumn.Width = 120;
            // 
            // deviceversionsDataGridViewTextBoxColumn
            // 
            this.deviceversionsDataGridViewTextBoxColumn.DataPropertyName = "device_versions";
            this.deviceversionsDataGridViewTextBoxColumn.HeaderText = "Device Version(s)";
            this.deviceversionsDataGridViewTextBoxColumn.Name = "deviceversionsDataGridViewTextBoxColumn";
            this.deviceversionsDataGridViewTextBoxColumn.Width = 120;
            // 
            // jirareportsBindingSource
            // 
            this.jirareportsBindingSource.DataMember = "jira_reports";
            this.jirareportsBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jira_reportsTableAdapter
            // 
            this.jira_reportsTableAdapter.ClearBeforeFill = true;
            // 
            // txtEntryDetails
            // 
            this.txtEntryDetails.Location = new System.Drawing.Point(912, 45);
            this.txtEntryDetails.Multiline = true;
            this.txtEntryDetails.Name = "txtEntryDetails";
            this.txtEntryDetails.ReadOnly = true;
            this.txtEntryDetails.Size = new System.Drawing.Size(347, 381);
            this.txtEntryDetails.TabIndex = 1;
            this.txtEntryDetails.TabStop = false;
            // 
            // lnkJiraEntry
            // 
            this.lnkJiraEntry.AutoSize = true;
            this.lnkJiraEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkJiraEntry.Location = new System.Drawing.Point(912, 12);
            this.lnkJiraEntry.Name = "lnkJiraEntry";
            this.lnkJiraEntry.Size = new System.Drawing.Size(0, 16);
            this.lnkJiraEntry.TabIndex = 2;
            this.lnkJiraEntry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkJiraEntry_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 438);
            this.Controls.Add(this.lnkJiraEntry);
            this.Controls.Add(this.txtEntryDetails);
            this.Controls.Add(this.datJiraSubmissions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Aspiritech JIRA Bug Report Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datJiraSubmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jirareportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datJiraSubmissions;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource jirareportsBindingSource;
        private masterDataSetTableAdapters.jira_reportsTableAdapter jira_reportsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiraidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timereportedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testcaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teststepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homergabboversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceversionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtEntryDetails;
        private System.Windows.Forms.LinkLabel lnkJiraEntry;
    }
}

