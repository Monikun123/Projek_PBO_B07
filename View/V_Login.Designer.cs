namespace Projek_PBO_B07
{
    partial class V_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login));
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            emailText = new TextBox();
            label6 = new Label();
            label7 = new Label();
            passwordText = new TextBox();
            loginbutton = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(233, 78, 1);
            label3.Location = new Point(510, 84);
            label3.Name = "label3";
            label3.Size = new Size(211, 45);
            label3.TabIndex = 1;
            label3.Text = "FRUITIES";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(510, 129);
            label4.Name = "label4";
            label4.Size = new Size(366, 52);
            label4.TabIndex = 2;
            label4.Text = "Kelola Buah Anda dengan Mudah,\r\nEfisien, dan Terorganisir.";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(687, 237);
            label5.Name = "label5";
            label5.Size = new Size(118, 45);
            label5.TabIndex = 3;
            label5.Text = "Login";
            // 
            // emailText
            // 
            emailText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            emailText.Location = new Point(551, 328);
            emailText.Name = "emailText";
            emailText.Size = new Size(349, 31);
            emailText.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(551, 299);
            label6.Name = "label6";
            label6.Size = new Size(73, 26);
            label6.TabIndex = 5;
            label6.Text = "Email";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(551, 362);
            label7.Name = "label7";
            label7.Size = new Size(110, 26);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // passwordText
            // 
            passwordText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordText.Location = new Point(551, 400);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(349, 31);
            passwordText.TabIndex = 7;
            // 
            // loginbutton
            // 
            loginbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginbutton.BackColor = Color.FromArgb(235, 90, 19);
            loginbutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.ForeColor = Color.Black;
            loginbutton.Location = new Point(551, 459);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(349, 50);
            loginbutton.TabIndex = 8;
            loginbutton.Text = "LOGIN";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(20);
            pictureBox1.Size = new Size(445, 646);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(247, 204, 92);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -19);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 646);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 624);
            panel2.TabIndex = 9;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 624);
            Controls.Add(loginbutton);
            Controls.Add(passwordText);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(emailText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "V_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox emailText;
        private Label label6;
        private Label label7;
        private TextBox passwordText;
        private Button loginbutton;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}
