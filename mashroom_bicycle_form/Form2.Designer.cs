namespace mashroom_bicycle_form
{
    partial class ChooseForm
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
            btnBicyle = new Button();
            button2 = new Button();
            lblBelow = new Label();
            SuspendLayout();
            // 
            // btnBicyle
            // 
            btnBicyle.Location = new Point(268, 352);
            btnBicyle.Margin = new Padding(4);
            btnBicyle.Name = "btnBicyle";
            btnBicyle.Size = new Size(157, 44);
            btnBicyle.TabIndex = 0;
            btnBicyle.Text = "Bicycle";
            btnBicyle.UseVisualStyleBackColor = true;
            btnBicyle.Click += btnBicyle_Click;
            // 
            // button2
            // 
            button2.Location = new Point(697, 352);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(157, 44);
            button2.TabIndex = 1;
            button2.Text = "Mashroom";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblBelow
            // 
            lblBelow.AutoSize = true;
            lblBelow.Location = new Point(365, 169);
            lblBelow.Margin = new Padding(4, 0, 4, 0);
            lblBelow.Name = "lblBelow";
            lblBelow.Size = new Size(403, 32);
            lblBelow.TabIndex = 2;
            lblBelow.Text = "Bicycle or Mashroom? Click below";
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 576);
            Controls.Add(lblBelow);
            Controls.Add(button2);
            Controls.Add(btnBicyle);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ChooseForm";
            Text = "Choose Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBicyle;
        private Button button2;
        private Label lblBelow;
    }
}