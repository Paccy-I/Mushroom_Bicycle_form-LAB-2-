using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mashroom_bicycle_form
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int start = int.Parse(txtStart.Text);
                int end = int.Parse(txtEnd.Text);
                double total = 0;

                if (start < 0 || start > 23 || end < 1 || end > 24 || start >= end)
                {
                    MessageBox.Show("Invalid Time!\nStart must be between 0-23.\nEnd must be between 1-24.\nStart must be less than End.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = start; i < end; i++)
                {
                    if ((i >= 0 && i < 7) || (i >= 21 && i < 24))
                    {
                        total += 500;
                    }
                    else if ((i >= 7 && i < 14) || (i >= 19 && i < 21))
                    {
                        total += 1000;
                    }
                    else if (i >= 14 && i < 19)
                    {
                        total += 1500;
                    }
                }

                lblTotal.Text = total.ToString() + " RWF";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid whole numbers (no decimals or letters).",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm choose = new ChooseForm();
            choose.Show();
            this.Hide(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide(); 
        }
    }
}
