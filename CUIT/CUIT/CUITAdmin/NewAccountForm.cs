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
            this.SetBounds(350, 350, 650, 400);
        }

        private void NewAccountForm_Load(object sender, EventArgs e)
        {
            //NewAccount x = new NewAccount(this);
            NewAccountPanel myAcctForm = new NewAccountPanel(this);//, 0);
            //myAcctForm.Location = new Point(10, 10 + controlGroupIndex * controlGroupSizeY);
            //myAcctForm.Size = new Size(650, 400);
        }

        private void AddNew(int index)
        {

        }
    }
}
