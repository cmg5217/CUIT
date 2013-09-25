﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CUITAdmin
{
    class NewAccountPanel : Panel
    {
        private int controlGroupSizeY = 400;
        private Button button1;
        private int controlGroupIndex = 0;

        public NewAccountPanel(Form pForm)
        {
            pForm.Controls.Add(this);
            this.Location = new Point(10, 10 + controlGroupIndex * controlGroupSizeY);
            this.Size = new Size(650, 400);

            Label lblAccountName = new Label();
            lblAccountName.Text = "Account Name:";
            lblAccountName.Location = new Point(10, 10);
            this.Controls.Add(lblAccountName);

            TextBox txtAccountName = new TextBox();
            txtAccountName.SetBounds(110, 10, 190, 20);
            this.Controls.Add(txtAccountName);

            Label lblAccountNumber = new Label();
            lblAccountNumber.Text = "Account Number:";
            lblAccountNumber.Location = new Point(10, 40);
            this.Controls.Add(lblAccountNumber);

            TextBox txtAccountNumber = new TextBox();
            txtAccountNumber.Location = new Point(110, 40);
            this.Controls.Add(txtAccountNumber);

            Label lblMaxCharge = new Label();
            lblMaxCharge.Text = "Max Charge Limit:";
            lblMaxCharge.Location = new Point(10, 70);
            this.Controls.Add(lblMaxCharge);

            TextBox txtMaxCharge = new TextBox();
            txtMaxCharge.Location = new Point(110, 70);
            this.Controls.Add(txtMaxCharge);

            Label lblAccountExpiration = new Label();
            lblAccountExpiration.Text = "Account Expiration:";
            lblAccountExpiration.Location = new Point(325, 10);
            this.Controls.Add(lblAccountExpiration);

            DateTimePicker dtpAccountExpiration = new DateTimePicker();
            dtpAccountExpiration.Location = new Point(425, 10);
            this.Controls.Add(dtpAccountExpiration);

            Label lblRateType = new Label();
            lblRateType.Text = "Rate Type:";
            lblRateType.Location = new Point(10, 130);
            this.Controls.Add(lblRateType);

            TextBox txtRateType = new TextBox();
            txtRateType.Location = new Point(110, 130);
            this.Controls.Add(txtRateType);

            Label lblRate = new Label();
            lblRate.Text = "Rate:";
            lblRate.Location = new Point(10, 160);
            this.Controls.Add(lblRate);

            TextBox txtRate = new TextBox();
            txtRate.Location = new Point(110, 160);
            this.Controls.Add(txtRate);

            Label lblBalance = new Label();
            lblBalance.Text = "Balance:";
            lblBalance.Location = new Point(10, 190);
            this.Controls.Add(lblBalance);

            TextBox txtBalance = new TextBox();
            txtBalance.Location = new Point(110, 190);
            this.Controls.Add(txtBalance);

            Label lblNotes = new Label();
            lblNotes.Text = "Notes:";
            lblNotes.Location = new Point(10, 220);
            this.Controls.Add(lblNotes);

            TextBox txtNotes = new TextBox();
            txtNotes.Location = new Point(110, 220);
            this.Controls.Add(txtNotes);
        }
    }
}
