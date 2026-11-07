using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mashroom_bicycle_form
{
    public partial class MushroomForm : Form
    {
        int currentQuestion = 1;
        bool hasGills;
        bool inForest;
        bool hasRing;
        bool hasConvex;
        public MushroomForm()
        {
            InitializeComponent();
        }

        private void MashroomForm_Load(object sender, EventArgs e)
        {
            ShowQuestion();
        }
        private void ShowQuestion()
        {
            if (currentQuestion == 1) lblQuestion.Text = "Does your mushroom have gills?";
            else if (currentQuestion == 2) lblQuestion.Text = "Does your mushroom grow in a forest?";
            else if (currentQuestion == 3) lblQuestion.Text = "Does your mushroom have a ring?";
            else if (currentQuestion == 4) lblQuestion.Text = "Does your mushroom have a convex cup?";
            else CheckResult();
        }

        private void ProcessAnswer(bool answer)
        {
            if (currentQuestion == 1) hasGills = answer;
            else if (currentQuestion == 2) inForest = answer;
            else if (currentQuestion == 3) hasRing = answer;
            else if (currentQuestion == 4) hasConvex = answer;

            currentQuestion++;
            ShowQuestion();
        }

        private void CheckResult()
        {
            string result = "Unknown Mushroom";

            if (!hasGills)
            {
                result = "Cepe de bordeaux";
            }
            else
            {
                if (!inForest)
                {
                    if (hasRing) result = "Coprin chevelu";
                    else result = "Agaric jaunissant";
                }
                else
                {
                    if (hasConvex)
                    {
                        if (hasRing) result = "Amanite tue-mouche";
                        else result = "Pied bleu";
                    }
                    else
                    {
                        result = "Girolle";
                    }
                }
            }

            MessageBox.Show("Your mushroom is: " + result, "Result");

           
            currentQuestion = 1;
            ShowQuestion();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ProcessAnswer(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ProcessAnswer(false);
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
