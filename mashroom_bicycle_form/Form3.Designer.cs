namespace mashroom_bicycle_form
{
    partial class BicycleForm
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
            btnCalculate = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            txtStart = new TextBox();
            lblBicycle = new Label();
            lblEnd = new Label();
            lblStart = new Label();
            txtEnd = new TextBox();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(506, 248);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(147, 36);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate ";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(26, 41);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(959, 41);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(421, 113);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(358, 31);
            txtStart.TabIndex = 3;
            // 
            // lblBicycle
            // 
            lblBicycle.AutoSize = true;
            lblBicycle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBicycle.Location = new Point(506, 26);
            lblBicycle.Name = "lblBicycle";
            lblBicycle.Size = new Size(107, 38);
            lblBicycle.TabIndex = 4;
            lblBicycle.Text = "Bicycle";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnd.Location = new Point(245, 178);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(158, 28);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "End Hour(1-24)";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStart.Location = new Point(245, 113);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(170, 28);
            lblStart.TabIndex = 6;
            lblStart.Text = "Start Hour(1-23)";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(421, 175);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(358, 31);
            txtEnd.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(536, 368);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 28);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total";
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 541);
            Controls.Add(lblTotal);
            Controls.Add(txtEnd);
            Controls.Add(lblStart);
            Controls.Add(lblEnd);
            Controls.Add(lblBicycle);
            Controls.Add(txtStart);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(btnCalculate);
            Name = "BicycleForm";
            Text = "bicycleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnBack;
        private Button btnLogout;
        private TextBox txtStart;
        private Label lblBicycle;
        private Label lblEnd;
        private Label lblStart;
        private TextBox txtEnd;
        private Label lblTotal;
    }
}