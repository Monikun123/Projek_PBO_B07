namespace Projek_PBO_B07.View
{
    partial class EditProfil
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
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            Password = new Label();
            panel3 = new Panel();
            Email = new Label();
            panel5 = new Panel();
            Nama = new Label();
            label1 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 121);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 15;
            label7.Text = "Nama : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 240);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 10;
            label6.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 178);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "Email : ";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(247, 204, 92);
            panel4.Controls.Add(Password);
            panel4.Location = new Point(125, 229);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 36);
            panel4.TabIndex = 14;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(8, 11);
            Password.Margin = new Padding(2, 0, 2, 0);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.BackColor = Color.FromArgb(247, 204, 92);
            panel3.Controls.Add(Email);
            panel3.Location = new Point(125, 167);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 36);
            panel3.TabIndex = 13;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(8, 11);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 2;
            Email.Text = "Email";
            Email.Click += Email_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoSize = true;
            panel5.BackColor = Color.FromArgb(247, 204, 92);
            panel5.Controls.Add(Nama);
            panel5.Location = new Point(125, 110);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(254, 36);
            panel5.TabIndex = 12;
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Location = new Point(8, 11);
            Nama.Margin = new Padding(2, 0, 2, 0);
            Nama.Name = "Nama";
            Nama.Size = new Size(39, 15);
            Nama.TabIndex = 2;
            Nama.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(233, 78, 1);
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 16;
            label1.Text = "EDIT PROFIL";
            label1.Click += label1_Click;
            // 
            // EditProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Name = "EditProfil";
            Text = "EditProfil";
            Load += EditProfil_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label4;
        private Panel panel4;
        private Label Password;
        private Panel panel3;
        private Label Email;
        private Panel panel5;
        private Label Nama;
        private Label label1;
    }
}