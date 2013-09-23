using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CUITAdmin
{
    public partial class NewAccountForm : Form
    {

        public NewAccountForm()
        {
            InitializeComponent();
            this.SetBounds(350, 350, 680, 400);
        }

        private void NewAccountForm_Load(object sender, EventArgs e)
        {
            NewAccount addAccountForm = new NewAccount(this);
        }

        private void AddNew(int index)
        {

        }
    }

    public class NewAccount
    {
        private int controlGroupSizeY = 400;
        private int controlGroupIndex = 0;

        public NewAccount(Form passForm)
        {
            Panel formContainer = new Panel();
            formContainer.Location = new Point(10, 10 + controlGroupIndex * controlGroupSizeY);
            formContainer.Size = new Size(650, 400);
            passForm.Controls.Add(formContainer);

            Label lblAccountName = new Label();
            lblAccountName.Text = "Account Name:";
            lblAccountName.Location = new Point(10, 10);
            formContainer.Controls.Add(lblAccountName);

            TextBox txtAccountName = new TextBox();
            txtAccountName.SetBounds(110, 10, 190, 20);
            formContainer.Controls.Add(txtAccountName);

            Label lblAccountNumber = new Label();
            lblAccountNumber.Text = "Account Number:";
            lblAccountNumber.Location = new Point(10, 40);
            formContainer.Controls.Add(lblAccountNumber);

            TextBox txtAccountNumber = new TextBox();
            txtAccountNumber.SetBounds(110, 40, 190, 20);
            formContainer.Controls.Add(txtAccountNumber);

            Label lblMaxCharge = new Label();
            lblMaxCharge.Text = "Max Charge Limit:";
            lblMaxCharge.Location = new Point(10, 70);
            formContainer.Controls.Add(lblMaxCharge);

            TextBox txtMaxCharge = new TextBox();
            txtAccountName.SetBounds(110, 70, 190, 20);
            formContainer.Controls.Add(txtMaxCharge);

            Label lblAccountExpiration = new Label();
            lblAccountExpiration.Text = "Account This is different:";
            lblAccountExpiration.Location = new Point(325, 10);
            formContainer.Controls.Add(lblAccountExpiration);

            //TextBox txtAccountExpiration = new TextBox();
            DateTimePicker dtpAccountExpiration = new DateTimePicker();
            dtpAccountExpiration.Location = new Point(425, 10);
            formContainer.Controls.Add(dtpAccountExpiration);

            Label lblRateType = new Label();
            lblRateType.Text = "Rate Type:";
            lblRateType.Location = new Point(10, 130);
            formContainer.Controls.Add(lblRateType);

            TextBox txtRateType = new TextBox();
            txtRateType.Location = new Point(110, 130);
            formContainer.Controls.Add(txtRateType);

            Label lblRate = new Label();
            lblRate.Text = "Rate:";
            lblRate.Location = new Point(10, 160);
            formContainer.Controls.Add(lblRate);

            TextBox txtRate = new TextBox();
            txtRate.Location = new Point(110, 160);
            formContainer.Controls.Add(txtRate);

            Label lblBalance = new Label();
            lblBalance.Text = "Balance:";
            lblBalance.Location = new Point(10, 190);
            formContainer.Controls.Add(lblBalance);

            TextBox txtBalance = new TextBox();
            txtBalance.Location = new Point(110, 190);
            formContainer.Controls.Add(txtBalance);

            Label lblNotes = new Label();
            lblNotes.Text = "Notes:";
            lblNotes.Location = new Point(10, 220);
            formContainer.Controls.Add(lblNotes);

            TextBox txtNotes = new TextBox();
            txtNotes.Location = new Point(110, 220);
            formContainer.Controls.Add(txtNotes);
        }
    }
}
