namespace mashroom_bicycle_form
{
    partial class MushroomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnYes = new Button();
            lblQuestion = new Label();
            btnNo = new Button();
            btnLogout = new Button();
            btnBack = new Button();
            lblMashroom = new Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.Location = new Point(374, 299);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(112, 34);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(374, 182);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(365, 38);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Questions will appear here";
            // 
            // btnNo
            // 
            btnNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.Location = new Point(627, 299);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(112, 34);
            btnNo.TabIndex = 2;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(949, 35);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(26, 35);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblMashroom
            // 
            lblMashroom.AutoSize = true;
            lblMashroom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMashroom.Location = new Point(456, 71);
            lblMashroom.Name = "lblMashroom";
            lblMashroom.Size = new Size(137, 32);
            lblMashroom.TabIndex = 5;
            lblMashroom.Text = "Mashroom";
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 547);
            Controls.Add(lblMashroom);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Controls.Add(btnNo);
            Controls.Add(lblQuestion);
            Controls.Add(btnYes);
            Name = "MushroomForm";
            Text = "MashroomForm";
            Load += MashroomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Label lblQuestion;
        private Button btnNo;
        private Button btnLogout;
        private Button btnBack;
        private Label lblMashroom;
    }
}