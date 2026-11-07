using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mashroom_bicycle_form
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicyle_Click(object sender, EventArgs e)
        {
            BicycleForm bikeForm = new BicycleForm();
            bikeForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MushroomForm mushForm = new MushroomForm();
            mushForm.Show();
            this.Hide();
        }
    }
}
