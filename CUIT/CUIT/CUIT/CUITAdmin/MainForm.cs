﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CUITAdmin
{
    public partial class frmCUITAdminMain : Form
    {
        public frmCUITAdminMain()
        {
            InitializeComponent();
        }

        private void time_LogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.time_LogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cUIT_TRIALDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cUIT_TRIALDataSet.UnapprovedTimeLogTable' table. You can move, or remove it, as needed.
            this.unapprovedTimeLogTableTableAdapter.FillDeniedTimeLog(this.cUIT_TRIALDataSet.UnapprovedTimeLogTable);
            // TODO: This line of code loads data into the 'cUIT_TRIALDataSet.Time_Log' table. You can move, or remove it, as needed.
            this.time_LogTableAdapter.Fill(this.cUIT_TRIALDataSet.Time_Log);

            
            cboAccountAdminNew.SelectedItem = "Instrument";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void tbpAccountAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountAdminNew_Click(object sender, EventArgs e)
        {
            Form newAccount = new NewAccountForm();
            newAccount.Show();
        }
        /*
        private void TypeSwitch(){
            switch (cboType.SelectedItem.ToString())
            {
                case "Instrument":
                    cboFundingSource.Enabled = false;
                    cboInstrument.Enabled = false;
                    break;
                case "Supply":

                    break;
            }*/
        }
    }

