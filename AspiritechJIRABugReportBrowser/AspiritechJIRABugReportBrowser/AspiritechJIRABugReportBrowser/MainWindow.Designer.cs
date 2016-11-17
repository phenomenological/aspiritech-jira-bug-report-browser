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
            this.jirareportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new AspiritechJIRABugReportBrowser.masterDataSet();
            this.jira_reportsTableAdapter = new AspiritechJIRABugReportBrowser.masterDataSetTableAdapters.jira_reportsTableAdapter();
            this.txtEntryDetails = new System.Windows.Forms.TextBox();
            this.lnkJiraEntry = new System.Windows.Forms.LinkLabel();
            this.btnDeleteSelectedRows = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiraidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timereportedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testcaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teststepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homergabboversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceversionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internet_connection_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_environment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steps_to_reproduce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expected_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actual_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.times_repeatable_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.times_repeatable_den = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_machine_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workaround = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other_notes_or_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datJiraSubmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jirareportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // datJiraSubmissions
            // 
            this.datJiraSubmissions.AllowUserToAddRows = false;
            this.datJiraSubmissions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.datJiraSubmissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datJiraSubmissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.deviceversionsDataGridViewTextBoxColumn,
            this.internet_connection_type,
            this.test_environment,
            this.steps_to_reproduce,
            this.expected_result,
            this.actual_result,
            this.times_repeatable_num,
            this.times_repeatable_den,
            this.test_machine_names,
            this.workaround,
            this.other_notes_or_comments});
            this.datJiraSubmissions.DataSource = this.jirareportsBindingSource;
            this.datJiraSubmissions.Location = new System.Drawing.Point(11, 12);
            this.datJiraSubmissions.Name = "datJiraSubmissions";
            this.datJiraSubmissions.ReadOnly = true;
            this.datJiraSubmissions.RowHeadersVisible = false;
            this.datJiraSubmissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datJiraSubmissions.Size = new System.Drawing.Size(894, 286);
            this.datJiraSubmissions.TabIndex = 0;
            this.datJiraSubmissions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datJiraSubmissions_CellDoubleClick);
            this.datJiraSubmissions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datJiraSubmissions_KeyDown);
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
            this.txtEntryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryDetails.Location = new System.Drawing.Point(11, 333);
            this.txtEntryDetails.Multiline = true;
            this.txtEntryDetails.Name = "txtEntryDetails";
            this.txtEntryDetails.ReadOnly = true;
            this.txtEntryDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntryDetails.Size = new System.Drawing.Size(894, 250);
            this.txtEntryDetails.TabIndex = 1;
            this.txtEntryDetails.TabStop = false;
            // 
            // lnkJiraEntry
            // 
            this.lnkJiraEntry.AutoSize = true;
            this.lnkJiraEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkJiraEntry.Location = new System.Drawing.Point(12, 301);
            this.lnkJiraEntry.Name = "lnkJiraEntry";
            this.lnkJiraEntry.Size = new System.Drawing.Size(0, 16);
            this.lnkJiraEntry.TabIndex = 2;
            this.lnkJiraEntry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkJiraEntry_LinkClicked);
            // 
            // btnDeleteSelectedRows
            // 
            this.btnDeleteSelectedRows.Location = new System.Drawing.Point(744, 304);
            this.btnDeleteSelectedRows.Name = "btnDeleteSelectedRows";
            this.btnDeleteSelectedRows.Size = new System.Drawing.Size(161, 23);
            this.btnDeleteSelectedRows.TabIndex = 3;
            this.btnDeleteSelectedRows.Text = "Delete Selected Row(s)";
            this.btnDeleteSelectedRows.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedRows.Click += new System.EventHandler(this.btnDeleteSelectedRows_Click);
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
            this.jiraidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timereportedDataGridViewTextBoxColumn
            // 
            this.timereportedDataGridViewTextBoxColumn.DataPropertyName = "time_reported";
            this.timereportedDataGridViewTextBoxColumn.HeaderText = "Date Reported";
            this.timereportedDataGridViewTextBoxColumn.Name = "timereportedDataGridViewTextBoxColumn";
            this.timereportedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            this.summaryDataGridViewTextBoxColumn.DataPropertyName = "summary";
            this.summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            this.summaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reporterDataGridViewTextBoxColumn
            // 
            this.reporterDataGridViewTextBoxColumn.DataPropertyName = "reporter";
            this.reporterDataGridViewTextBoxColumn.HeaderText = "Reporter";
            this.reporterDataGridViewTextBoxColumn.Name = "reporterDataGridViewTextBoxColumn";
            this.reporterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testcaseDataGridViewTextBoxColumn
            // 
            this.testcaseDataGridViewTextBoxColumn.DataPropertyName = "test_case";
            this.testcaseDataGridViewTextBoxColumn.HeaderText = "Test Case";
            this.testcaseDataGridViewTextBoxColumn.Name = "testcaseDataGridViewTextBoxColumn";
            this.testcaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teststepDataGridViewTextBoxColumn
            // 
            this.teststepDataGridViewTextBoxColumn.DataPropertyName = "test_step";
            this.teststepDataGridViewTextBoxColumn.HeaderText = "Test Step";
            this.teststepDataGridViewTextBoxColumn.Name = "teststepDataGridViewTextBoxColumn";
            this.teststepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homergabboversionDataGridViewTextBoxColumn
            // 
            this.homergabboversionDataGridViewTextBoxColumn.DataPropertyName = "homer_gabbo_version";
            this.homergabboversionDataGridViewTextBoxColumn.HeaderText = "Homer / Gabbo Version";
            this.homergabboversionDataGridViewTextBoxColumn.Name = "homergabboversionDataGridViewTextBoxColumn";
            this.homergabboversionDataGridViewTextBoxColumn.ReadOnly = true;
            this.homergabboversionDataGridViewTextBoxColumn.Width = 120;
            // 
            // deviceversionsDataGridViewTextBoxColumn
            // 
            this.deviceversionsDataGridViewTextBoxColumn.DataPropertyName = "device_versions";
            this.deviceversionsDataGridViewTextBoxColumn.HeaderText = "Device Version(s)";
            this.deviceversionsDataGridViewTextBoxColumn.Name = "deviceversionsDataGridViewTextBoxColumn";
            this.deviceversionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceversionsDataGridViewTextBoxColumn.Width = 120;
            // 
            // internet_connection_type
            // 
            this.internet_connection_type.DataPropertyName = "internet_connection_type";
            this.internet_connection_type.HeaderText = "Internet Connection Type";
            this.internet_connection_type.Name = "internet_connection_type";
            this.internet_connection_type.ReadOnly = true;
            this.internet_connection_type.Visible = false;
            // 
            // test_environment
            // 
            this.test_environment.DataPropertyName = "test_environment";
            this.test_environment.HeaderText = "Test Environment";
            this.test_environment.Name = "test_environment";
            this.test_environment.ReadOnly = true;
            this.test_environment.Visible = false;
            // 
            // steps_to_reproduce
            // 
            this.steps_to_reproduce.DataPropertyName = "steps_to_reproduce";
            this.steps_to_reproduce.HeaderText = "Steps to Reproduce";
            this.steps_to_reproduce.Name = "steps_to_reproduce";
            this.steps_to_reproduce.ReadOnly = true;
            this.steps_to_reproduce.Visible = false;
            // 
            // expected_result
            // 
            this.expected_result.DataPropertyName = "expected_result";
            this.expected_result.HeaderText = "Expected Result";
            this.expected_result.Name = "expected_result";
            this.expected_result.ReadOnly = true;
            this.expected_result.Visible = false;
            // 
            // actual_result
            // 
            this.actual_result.DataPropertyName = "actual_result";
            this.actual_result.HeaderText = "Actual Result";
            this.actual_result.Name = "actual_result";
            this.actual_result.ReadOnly = true;
            this.actual_result.Visible = false;
            // 
            // times_repeatable_num
            // 
            this.times_repeatable_num.DataPropertyName = "times_repeatable_num";
            this.times_repeatable_num.HeaderText = "Times Repeatable Numerator";
            this.times_repeatable_num.Name = "times_repeatable_num";
            this.times_repeatable_num.ReadOnly = true;
            this.times_repeatable_num.Visible = false;
            // 
            // times_repeatable_den
            // 
            this.times_repeatable_den.DataPropertyName = "times_repeatable_den";
            this.times_repeatable_den.HeaderText = "Times Repeatable Denominator";
            this.times_repeatable_den.Name = "times_repeatable_den";
            this.times_repeatable_den.ReadOnly = true;
            this.times_repeatable_den.Visible = false;
            // 
            // test_machine_names
            // 
            this.test_machine_names.DataPropertyName = "test_machine_names";
            this.test_machine_names.HeaderText = "Test Machine Names";
            this.test_machine_names.Name = "test_machine_names";
            this.test_machine_names.ReadOnly = true;
            this.test_machine_names.Visible = false;
            // 
            // workaround
            // 
            this.workaround.DataPropertyName = "workaround";
            this.workaround.HeaderText = "Workaround";
            this.workaround.Name = "workaround";
            this.workaround.ReadOnly = true;
            this.workaround.Visible = false;
            // 
            // other_notes_or_comments
            // 
            this.other_notes_or_comments.DataPropertyName = "other_notes_or_comments";
            this.other_notes_or_comments.HeaderText = "Other Notes/Comments";
            this.other_notes_or_comments.Name = "other_notes_or_comments";
            this.other_notes_or_comments.ReadOnly = true;
            this.other_notes_or_comments.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 604);
            this.Controls.Add(this.btnDeleteSelectedRows);
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
        private System.Windows.Forms.TextBox txtEntryDetails;
        private System.Windows.Forms.LinkLabel lnkJiraEntry;
        private System.Windows.Forms.Button btnDeleteSelectedRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiraidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timereportedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testcaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teststepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homergabboversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceversionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internet_connection_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_environment;
        private System.Windows.Forms.DataGridViewTextBoxColumn steps_to_reproduce;
        private System.Windows.Forms.DataGridViewTextBoxColumn expected_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn actual_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn times_repeatable_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn times_repeatable_den;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_machine_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn workaround;
        private System.Windows.Forms.DataGridViewTextBoxColumn other_notes_or_comments;
    }
}

