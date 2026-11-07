namespace mashroom_bicycle_form
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signinbtn = new Button();
            closebtn = new Button();
            usernamelbl = new Label();
            passlbl = new Label();
            login_pagelbl = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // signinbtn
            // 
            signinbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signinbtn.Location = new Point(429, 324);
            signinbtn.Name = "signinbtn";
            signinbtn.Size = new Size(112, 34);
            signinbtn.TabIndex = 0;
            signinbtn.Text = "SIGN IN";
            signinbtn.UseVisualStyleBackColor = true;
            signinbtn.Click += signinbtn_Click;
            // 
            // closebtn
            // 
            closebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.Location = new Point(805, 32);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(112, 34);
            closebtn.TabIndex = 1;
            closebtn.Text = "CLOSE";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamelbl.Location = new Point(128, 150);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(128, 32);
            usernamelbl.TabIndex = 2;
            usernamelbl.Text = "Username";
            usernamelbl.UseMnemonic = false;
            usernamelbl.Click += label1_Click;
            // 
            // passlbl
            // 
            passlbl.AutoSize = true;
            passlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passlbl.Location = new Point(128, 211);
            passlbl.Name = "passlbl";
            passlbl.Size = new Size(122, 32);
            passlbl.TabIndex = 3;
            passlbl.Text = "Password";
            // 
            // login_pagelbl
            // 
            login_pagelbl.AutoSize = true;
            login_pagelbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_pagelbl.Location = new Point(429, 41);
            login_pagelbl.Name = "login_pagelbl";
            login_pagelbl.Size = new Size(180, 38);
            login_pagelbl.TabIndex = 4;
            login_pagelbl.Text = "LOGIN PAGE";
            login_pagelbl.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(322, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(348, 31);
            txtUsername.TabIndex = 5;
            txtUsername.TextChanged += usertxt_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(322, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(348, 31);
            txtPassword.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 562);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(login_pagelbl);
            Controls.Add(passlbl);
            Controls.Add(usernamelbl);
            Controls.Add(closebtn);
            Controls.Add(signinbtn);
            Name = "LoginForm";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signinbtn;
        private Button closebtn;
        private Label usernamelbl;
        private Label passlbl;
        private Label login_pagelbl;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}
