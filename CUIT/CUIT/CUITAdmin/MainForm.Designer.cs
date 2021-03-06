﻿namespace CUITAdmin
{
    partial class frmCUITAdminMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tbpBilling = new System.Windows.Forms.TabPage();
            this.grpManualEntries = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btmSupplyAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cboSupplyFunding = new System.Windows.Forms.ComboBox();
            this.lblSupplyFunding = new System.Windows.Forms.Label();
            this.cboSupplyName = new System.Windows.Forms.ComboBox();
            this.lblSupplyName = new System.Windows.Forms.Label();
            this.grpManualTimeLog = new System.Windows.Forms.GroupBox();
            this.dtpManualLog = new System.Windows.Forms.DateTimePicker();
            this.lblManualLogInstrument = new System.Windows.Forms.Label();
            this.lblManualLogUser = new System.Windows.Forms.Label();
            this.cboManualLogInstrument = new System.Windows.Forms.ComboBox();
            this.cboManualLogUser = new System.Windows.Forms.ComboBox();
            this.cboManualLogFunding = new System.Windows.Forms.ComboBox();
            this.txtManualLogDuration = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblManualLogDuration = new System.Windows.Forms.Label();
            this.lblManualLogFunding = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTimeLogRequests = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbpAccountAdmin = new System.Windows.Forms.TabPage();
            this.btnAccountAdminNew = new System.Windows.Forms.Button();
            this.cboAccountAdminNew = new System.Windows.Forms.ComboBox();
            this.btnAccountAdminSearch = new System.Windows.Forms.Button();
            this.lblAccountAdminView = new System.Windows.Forms.Label();
            this.cboAccountAdminView = new System.Windows.Forms.ComboBox();
            this.txtAccountAdminSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbpExports = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.unapprovedTimeLogTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUIT_TRIALDataSet = new CUITAdmin.CUIT_TRIALDataSet();
            this.time_LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.time_LogTableAdapter = new CUITAdmin.CUIT_TRIALDataSetTableAdapters.Time_LogTableAdapter();
            this.tableAdapterManager = new CUITAdmin.CUIT_TRIALDataSetTableAdapters.TableAdapterManager();
            this.unapprovedTimeLogTableTableAdapter = new CUITAdmin.CUIT_TRIALDataSetTableAdapters.UnapprovedTimeLogTableTableAdapter();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInstrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFundingSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain.SuspendLayout();
            this.tbpBilling.SuspendLayout();
            this.grpManualEntries.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpManualTimeLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLogRequests)).BeginInit();
            this.tbpAccountAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbpExports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unapprovedTimeLogTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUIT_TRIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_LogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tbpBilling);
            this.tabControlMain.Controls.Add(this.tbpAccountAdmin);
            this.tabControlMain.Controls.Add(this.tbpExports);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(691, 615);
            this.tabControlMain.TabIndex = 0;
            // 
            // tbpBilling
            // 
            this.tbpBilling.AutoScroll = true;
            this.tbpBilling.Controls.Add(this.grpManualEntries);
            this.tbpBilling.Controls.Add(this.groupBox1);
            this.tbpBilling.Location = new System.Drawing.Point(4, 22);
            this.tbpBilling.Name = "tbpBilling";
            this.tbpBilling.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBilling.Size = new System.Drawing.Size(683, 589);
            this.tbpBilling.TabIndex = 0;
            this.tbpBilling.Text = "Billing";
            this.tbpBilling.UseVisualStyleBackColor = true;
            // 
            // grpManualEntries
            // 
            this.grpManualEntries.Controls.Add(this.groupBox2);
            this.grpManualEntries.Controls.Add(this.grpManualTimeLog);
            this.grpManualEntries.Location = new System.Drawing.Point(6, 6);
            this.grpManualEntries.Name = "grpManualEntries";
            this.grpManualEntries.Size = new System.Drawing.Size(652, 220);
            this.grpManualEntries.TabIndex = 11;
            this.grpManualEntries.TabStop = false;
            this.grpManualEntries.Text = "Manual Entries";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btmSupplyAdd);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.cboSupplyFunding);
            this.groupBox2.Controls.Add(this.lblSupplyFunding);
            this.groupBox2.Controls.Add(this.cboSupplyName);
            this.groupBox2.Controls.Add(this.lblSupplyName);
            this.groupBox2.Location = new System.Drawing.Point(327, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 199);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplies";
            // 
            // btmSupplyAdd
            // 
            this.btmSupplyAdd.Location = new System.Drawing.Point(199, 88);
            this.btmSupplyAdd.Name = "btmSupplyAdd";
            this.btmSupplyAdd.Size = new System.Drawing.Size(75, 23);
            this.btmSupplyAdd.TabIndex = 11;
            this.btmSupplyAdd.Text = "Add";
            this.btmSupplyAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(36, 91);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cboSupplyFunding
            // 
            this.cboSupplyFunding.FormattingEnabled = true;
            this.cboSupplyFunding.Location = new System.Drawing.Point(126, 63);
            this.cboSupplyFunding.Name = "cboSupplyFunding";
            this.cboSupplyFunding.Size = new System.Drawing.Size(148, 21);
            this.cboSupplyFunding.TabIndex = 7;
            // 
            // lblSupplyFunding
            // 
            this.lblSupplyFunding.AutoSize = true;
            this.lblSupplyFunding.Location = new System.Drawing.Point(35, 66);
            this.lblSupplyFunding.Name = "lblSupplyFunding";
            this.lblSupplyFunding.Size = new System.Drawing.Size(85, 13);
            this.lblSupplyFunding.TabIndex = 8;
            this.lblSupplyFunding.Text = "Funding Source:";
            // 
            // cboSupplyName
            // 
            this.cboSupplyName.FormattingEnabled = true;
            this.cboSupplyName.Location = new System.Drawing.Point(126, 37);
            this.cboSupplyName.Name = "cboSupplyName";
            this.cboSupplyName.Size = new System.Drawing.Size(148, 21);
            this.cboSupplyName.TabIndex = 5;
            // 
            // lblSupplyName
            // 
            this.lblSupplyName.AutoSize = true;
            this.lblSupplyName.Location = new System.Drawing.Point(35, 40);
            this.lblSupplyName.Name = "lblSupplyName";
            this.lblSupplyName.Size = new System.Drawing.Size(61, 13);
            this.lblSupplyName.TabIndex = 6;
            this.lblSupplyName.Text = "Item Name:";
            // 
            // grpManualTimeLog
            // 
            this.grpManualTimeLog.Controls.Add(this.dtpManualLog);
            this.grpManualTimeLog.Controls.Add(this.lblManualLogInstrument);
            this.grpManualTimeLog.Controls.Add(this.lblManualLogUser);
            this.grpManualTimeLog.Controls.Add(this.cboManualLogInstrument);
            this.grpManualTimeLog.Controls.Add(this.cboManualLogUser);
            this.grpManualTimeLog.Controls.Add(this.cboManualLogFunding);
            this.grpManualTimeLog.Controls.Add(this.txtManualLogDuration);
            this.grpManualTimeLog.Controls.Add(this.btnAdd);
            this.grpManualTimeLog.Controls.Add(this.lblManualLogDuration);
            this.grpManualTimeLog.Controls.Add(this.lblManualLogFunding);
            this.grpManualTimeLog.Location = new System.Drawing.Point(7, 15);
            this.grpManualTimeLog.Name = "grpManualTimeLog";
            this.grpManualTimeLog.Size = new System.Drawing.Size(314, 199);
            this.grpManualTimeLog.TabIndex = 17;
            this.grpManualTimeLog.TabStop = false;
            this.grpManualTimeLog.Text = "Time Log";
            // 
            // dtpManualLog
            // 
            this.dtpManualLog.Location = new System.Drawing.Point(34, 118);
            this.dtpManualLog.Name = "dtpManualLog";
            this.dtpManualLog.Size = new System.Drawing.Size(236, 20);
            this.dtpManualLog.TabIndex = 3;
            // 
            // lblManualLogInstrument
            // 
            this.lblManualLogInstrument.AutoSize = true;
            this.lblManualLogInstrument.Location = new System.Drawing.Point(31, 93);
            this.lblManualLogInstrument.Name = "lblManualLogInstrument";
            this.lblManualLogInstrument.Size = new System.Drawing.Size(59, 13);
            this.lblManualLogInstrument.TabIndex = 5;
            this.lblManualLogInstrument.Text = "Instrument:";
            // 
            // lblManualLogUser
            // 
            this.lblManualLogUser.AutoSize = true;
            this.lblManualLogUser.Location = new System.Drawing.Point(31, 38);
            this.lblManualLogUser.Name = "lblManualLogUser";
            this.lblManualLogUser.Size = new System.Drawing.Size(58, 13);
            this.lblManualLogUser.TabIndex = 14;
            this.lblManualLogUser.Text = "Username:";
            // 
            // cboManualLogInstrument
            // 
            this.cboManualLogInstrument.FormattingEnabled = true;
            this.cboManualLogInstrument.Location = new System.Drawing.Point(122, 90);
            this.cboManualLogInstrument.Name = "cboManualLogInstrument";
            this.cboManualLogInstrument.Size = new System.Drawing.Size(148, 21);
            this.cboManualLogInstrument.TabIndex = 2;
            // 
            // cboManualLogUser
            // 
            this.cboManualLogUser.FormattingEnabled = true;
            this.cboManualLogUser.Location = new System.Drawing.Point(122, 35);
            this.cboManualLogUser.Name = "cboManualLogUser";
            this.cboManualLogUser.Size = new System.Drawing.Size(148, 21);
            this.cboManualLogUser.TabIndex = 13;
            // 
            // cboManualLogFunding
            // 
            this.cboManualLogFunding.FormattingEnabled = true;
            this.cboManualLogFunding.Location = new System.Drawing.Point(122, 62);
            this.cboManualLogFunding.Name = "cboManualLogFunding";
            this.cboManualLogFunding.Size = new System.Drawing.Size(148, 21);
            this.cboManualLogFunding.TabIndex = 1;
            // 
            // txtManualLogDuration
            // 
            this.txtManualLogDuration.Location = new System.Drawing.Point(122, 146);
            this.txtManualLogDuration.Name = "txtManualLogDuration";
            this.txtManualLogDuration.Size = new System.Drawing.Size(67, 20);
            this.txtManualLogDuration.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblManualLogDuration
            // 
            this.lblManualLogDuration.AutoSize = true;
            this.lblManualLogDuration.Location = new System.Drawing.Point(31, 149);
            this.lblManualLogDuration.Name = "lblManualLogDuration";
            this.lblManualLogDuration.Size = new System.Drawing.Size(50, 13);
            this.lblManualLogDuration.TabIndex = 9;
            this.lblManualLogDuration.Text = "Duration:";
            // 
            // lblManualLogFunding
            // 
            this.lblManualLogFunding.AutoSize = true;
            this.lblManualLogFunding.Location = new System.Drawing.Point(31, 65);
            this.lblManualLogFunding.Name = "lblManualLogFunding";
            this.lblManualLogFunding.Size = new System.Drawing.Size(85, 13);
            this.lblManualLogFunding.TabIndex = 4;
            this.lblManualLogFunding.Text = "Funding Source:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTimeLogRequests);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Location = new System.Drawing.Point(6, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 354);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Log Requests";
            // 
            // dgvTimeLogRequests
            // 
            this.dgvTimeLogRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeLogRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmInstrument,
            this.clmDate,
            this.clmTime,
            this.clmDuration,
            this.clmFundingSource,
            this.clmApprove});
            this.dgvTimeLogRequests.Location = new System.Drawing.Point(7, 20);
            this.dgvTimeLogRequests.Name = "dgvTimeLogRequests";
            this.dgvTimeLogRequests.Size = new System.Drawing.Size(639, 299);
            this.dgvTimeLogRequests.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(570, 325);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // tbpAccountAdmin
            // 
            this.tbpAccountAdmin.Controls.Add(this.btnAccountAdminNew);
            this.tbpAccountAdmin.Controls.Add(this.cboAccountAdminNew);
            this.tbpAccountAdmin.Controls.Add(this.btnAccountAdminSearch);
            this.tbpAccountAdmin.Controls.Add(this.lblAccountAdminView);
            this.tbpAccountAdmin.Controls.Add(this.cboAccountAdminView);
            this.tbpAccountAdmin.Controls.Add(this.txtAccountAdminSearch);
            this.tbpAccountAdmin.Controls.Add(this.dataGridView1);
            this.tbpAccountAdmin.Location = new System.Drawing.Point(4, 22);
            this.tbpAccountAdmin.Name = "tbpAccountAdmin";
            this.tbpAccountAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAccountAdmin.Size = new System.Drawing.Size(683, 589);
            this.tbpAccountAdmin.TabIndex = 1;
            this.tbpAccountAdmin.Text = "Account Admin";
            this.tbpAccountAdmin.UseVisualStyleBackColor = true;
            this.tbpAccountAdmin.Click += new System.EventHandler(this.tbpAccountAdmin_Click);
            // 
            // btnAccountAdminNew
            // 
            this.btnAccountAdminNew.Location = new System.Drawing.Point(475, 8);
            this.btnAccountAdminNew.Name = "btnAccountAdminNew";
            this.btnAccountAdminNew.Size = new System.Drawing.Size(75, 23);
            this.btnAccountAdminNew.TabIndex = 6;
            this.btnAccountAdminNew.Text = "Add New";
            this.btnAccountAdminNew.UseVisualStyleBackColor = true;
            this.btnAccountAdminNew.Click += new System.EventHandler(this.btnAccountAdminNew_Click);
            // 
            // cboAccountAdminNew
            // 
            this.cboAccountAdminNew.FormattingEnabled = true;
            this.cboAccountAdminNew.Items.AddRange(new object[] {
            "Account",
            "Account Manager",
            "Item",
            "User",
            "User Contact"});
            this.cboAccountAdminNew.Location = new System.Drawing.Point(556, 9);
            this.cboAccountAdminNew.Name = "cboAccountAdminNew";
            this.cboAccountAdminNew.Size = new System.Drawing.Size(121, 21);
            this.cboAccountAdminNew.TabIndex = 5;
            // 
            // btnAccountAdminSearch
            // 
            this.btnAccountAdminSearch.Location = new System.Drawing.Point(330, 8);
            this.btnAccountAdminSearch.Name = "btnAccountAdminSearch";
            this.btnAccountAdminSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAccountAdminSearch.TabIndex = 4;
            this.btnAccountAdminSearch.Text = "Search";
            this.btnAccountAdminSearch.UseVisualStyleBackColor = true;
            // 
            // lblAccountAdminView
            // 
            this.lblAccountAdminView.AutoSize = true;
            this.lblAccountAdminView.Location = new System.Drawing.Point(6, 12);
            this.lblAccountAdminView.Name = "lblAccountAdminView";
            this.lblAccountAdminView.Size = new System.Drawing.Size(33, 13);
            this.lblAccountAdminView.TabIndex = 3;
            this.lblAccountAdminView.Text = "View:";
            // 
            // cboAccountAdminView
            // 
            this.cboAccountAdminView.FormattingEnabled = true;
            this.cboAccountAdminView.Items.AddRange(new object[] {
            "Accounts",
            "Account Manager",
            "Contacts",
            "Users",
            "Items"});
            this.cboAccountAdminView.Location = new System.Drawing.Point(42, 9);
            this.cboAccountAdminView.Name = "cboAccountAdminView";
            this.cboAccountAdminView.Size = new System.Drawing.Size(121, 21);
            this.cboAccountAdminView.TabIndex = 2;
            // 
            // txtAccountAdminSearch
            // 
            this.txtAccountAdminSearch.Location = new System.Drawing.Point(224, 9);
            this.txtAccountAdminSearch.Name = "txtAccountAdminSearch";
            this.txtAccountAdminSearch.Size = new System.Drawing.Size(100, 20);
            this.txtAccountAdminSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(671, 546);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbpExports
            // 
            this.tbpExports.Controls.Add(this.button2);
            this.tbpExports.Controls.Add(this.button1);
            this.tbpExports.Location = new System.Drawing.Point(4, 22);
            this.tbpExports.Name = "tbpExports";
            this.tbpExports.Padding = new System.Windows.Forms.Padding(3);
            this.tbpExports.Size = new System.Drawing.Size(683, 589);
            this.tbpExports.TabIndex = 2;
            this.tbpExports.Text = "Exports";
            this.tbpExports.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // unapprovedTimeLogTableBindingSource
            // 
            this.unapprovedTimeLogTableBindingSource.DataMember = "UnapprovedTimeLogTable";
            this.unapprovedTimeLogTableBindingSource.DataSource = this.cUIT_TRIALDataSet;
            // 
            // cUIT_TRIALDataSet
            // 
            this.cUIT_TRIALDataSet.DataSetName = "CUIT_TRIALDataSet";
            this.cUIT_TRIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // time_LogBindingSource
            // 
            this.time_LogBindingSource.DataMember = "Time_Log";
            this.time_LogBindingSource.DataSource = this.cUIT_TRIALDataSet;
            // 
            // time_LogTableAdapter
            // 
            this.time_LogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Account_AccessTableAdapter = null;
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Instrument_RateTableAdapter = null;
            this.tableAdapterManager.InstrumentTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.Time_LogTableAdapter = this.time_LogTableAdapter;
            this.tableAdapterManager.UpdateOrder = CUITAdmin.CUIT_TRIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_ContactsTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // unapprovedTimeLogTableTableAdapter
            // 
            this.unapprovedTimeLogTableTableAdapter.ClearBeforeFill = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            // 
            // clmInstrument
            // 
            this.clmInstrument.HeaderText = "Instrument";
            this.clmInstrument.Name = "clmInstrument";
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Log Date";
            this.clmDate.Name = "clmDate";
            // 
            // clmTime
            // 
            this.clmTime.HeaderText = "Start Time";
            this.clmTime.Name = "clmTime";
            this.clmTime.Width = 75;
            // 
            // clmDuration
            // 
            this.clmDuration.HeaderText = "Duration";
            this.clmDuration.Name = "clmDuration";
            this.clmDuration.Width = 60;
            // 
            // clmFundingSource
            // 
            this.clmFundingSource.HeaderText = "Funding Source";
            this.clmFundingSource.Name = "clmFundingSource";
            // 
            // clmApprove
            // 
            this.clmApprove.HeaderText = "Approve?";
            this.clmApprove.Name = "clmApprove";
            this.clmApprove.Width = 60;
            // 
            // frmCUITAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 639);
            this.Controls.Add(this.tabControlMain);
            this.Name = "frmCUITAdminMain";
            this.Text = "CUITAdmin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tbpBilling.ResumeLayout(false);
            this.grpManualEntries.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpManualTimeLog.ResumeLayout(false);
            this.grpManualTimeLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLogRequests)).EndInit();
            this.tbpAccountAdmin.ResumeLayout(false);
            this.tbpAccountAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbpExports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unapprovedTimeLogTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUIT_TRIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_LogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tbpBilling;
        private System.Windows.Forms.TabPage tbpAccountAdmin;
        private System.Windows.Forms.DateTimePicker dtpManualLog;
        private System.Windows.Forms.ComboBox cboManualLogInstrument;
        private System.Windows.Forms.ComboBox cboManualLogFunding;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tbpExports;
        private System.Windows.Forms.Label lblManualLogInstrument;
        private System.Windows.Forms.Label lblManualLogFunding;
        private CUIT_TRIALDataSet cUIT_TRIALDataSet;
        private System.Windows.Forms.BindingSource time_LogBindingSource;
        private CUIT_TRIALDataSetTableAdapters.Time_LogTableAdapter time_LogTableAdapter;
        private CUIT_TRIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource unapprovedTimeLogTableBindingSource;
        private CUIT_TRIALDataSetTableAdapters.UnapprovedTimeLogTableTableAdapter unapprovedTimeLogTableTableAdapter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpManualEntries;
        private System.Windows.Forms.Label lblManualLogUser;
        private System.Windows.Forms.ComboBox cboManualLogUser;
        private System.Windows.Forms.TextBox txtManualLogDuration;
        private System.Windows.Forms.Label lblManualLogDuration;
        private System.Windows.Forms.GroupBox grpManualTimeLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboSupplyFunding;
        private System.Windows.Forms.Label lblSupplyFunding;
        private System.Windows.Forms.ComboBox cboSupplyName;
        private System.Windows.Forms.Label lblSupplyName;
        private System.Windows.Forms.Button btmSupplyAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAccountAdminNew;
        private System.Windows.Forms.ComboBox cboAccountAdminNew;
        private System.Windows.Forms.Button btnAccountAdminSearch;
        private System.Windows.Forms.Label lblAccountAdminView;
        private System.Windows.Forms.ComboBox cboAccountAdminView;
        private System.Windows.Forms.TextBox txtAccountAdminSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTimeLogRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstrument;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFundingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApprove;
    }
}

