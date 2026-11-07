namespace mashroom_bicycle_form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and Password cannot be empty!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
