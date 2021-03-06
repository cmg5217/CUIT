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
    class NewAccount
    {
        private int controlGroupSizeY = 400;
        private int controlGroupIndex = 0;

        private NewAccount(Form passForm)
        {
            Panel formContainer = new Panel();
            formContainer.Location = new Point(10, 10 + controlGroupIndex * controlGroupSizeY);
            formContainer.Size = new Size(600, 400);
            passForm.Controls.Add(formContainer);

            Label lblAccountName = new Label();
            lblAccountName.Text = "Account Name:";
            lblAccountName.Location = new Point(10, 10);
            formContainer.Controls.Add(lblAccountName);

            TextBox accountName = new TextBox();
            accountName.Location = new Point(40, 10);
            formContainer.Controls.Add(accountName);
        }
    }
}
