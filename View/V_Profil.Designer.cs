﻿namespace Projek_PBO_B07.View
{
    partial class V_Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Profil));
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            button2 = new Button();
            panel4 = new Panel();
            Password = new Label();
            panel3 = new Panel();
            Email = new Label();
            panel5 = new Panel();
            Nama = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            LogOutButton = new Button();
            pictureBox8 = new PictureBox();
            ProfilButton = new Button();
            pictureBox7 = new PictureBox();
            RiwayatButton = new Button();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 40);
            pictureBox4.Margin = new Padding(1, 1, 1, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(233, 78, 1);
            label5.Location = new Point(24, 11);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 4;
            label5.Text = "PROIFL";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(214, 1);
            panel2.Margin = new Padding(1, 1, 1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 549);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 68);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 9;
            label7.Text = "Nama : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 157);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 3;
            label6.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 111);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Email : ";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(24, 218);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 25);
            button2.TabIndex = 8;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(247, 204, 92);
            panel4.Controls.Add(Password);
            panel4.Location = new Point(94, 149);
            panel4.Margin = new Padding(1, 1, 1, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 35);
            panel4.TabIndex = 6;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(7, 8);
            Password.Margin = new Padding(1, 0, 1, 0);
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
            panel3.Location = new Point(94, 103);
            panel3.Margin = new Padding(1, 1, 1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 35);
            panel3.TabIndex = 5;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(7, 8);
            Email.Margin = new Padding(1, 0, 1, 0);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 2;
            Email.Text = "Email";
            Email.Click += label2_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoSize = true;
            panel5.BackColor = Color.FromArgb(247, 204, 92);
            panel5.Controls.Add(Nama);
            panel5.Location = new Point(94, 60);
            panel5.Margin = new Padding(1, 1, 1, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 35);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Location = new Point(7, 8);
            Nama.Margin = new Padding(1, 0, 1, 0);
            Nama.Name = "Nama";
            Nama.Size = new Size(39, 15);
            Nama.TabIndex = 2;
            Nama.Text = "Nama";
            Nama.Click += lblTotalBuahBusuk_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2686558F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.7313461F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(1, 1);
            tableLayoutPanel1.Margin = new Padding(1, 1, 1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1005, 551);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(ProfilButton);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(RiwayatButton);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 549);
            panel1.TabIndex = 0;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.Red;
            LogOutButton.Location = new Point(32, 193);
            LogOutButton.Margin = new Padding(1, 1, 1, 1);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(83, 25);
            LogOutButton.TabIndex = 14;
            LogOutButton.Text = "LogOut";
            LogOutButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Red;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(4, 193);
            pictureBox8.Margin = new Padding(1, 1, 1, 1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 25);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // ProfilButton
            // 
            ProfilButton.BackColor = Color.FromArgb(247, 204, 92);
            ProfilButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfilButton.Location = new Point(32, 123);
            ProfilButton.Margin = new Padding(1, 1, 1, 1);
            ProfilButton.Name = "ProfilButton";
            ProfilButton.Size = new Size(83, 25);
            ProfilButton.TabIndex = 12;
            ProfilButton.Text = "Profil";
            ProfilButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(247, 204, 92);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(4, 123);
            pictureBox7.Margin = new Padding(1, 1, 1, 1);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 25);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // RiwayatButton
            // 
            RiwayatButton.Location = new Point(32, 96);
            RiwayatButton.Margin = new Padding(1, 1, 1, 1);
            RiwayatButton.Name = "RiwayatButton";
            RiwayatButton.Size = new Size(83, 25);
            RiwayatButton.TabIndex = 10;
            RiwayatButton.Text = "Riwayat";
            RiwayatButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(4, 96);
            pictureBox6.Margin = new Padding(1, 1, 1, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(32, 68);
            button1.Margin = new Padding(1, 1, 1, 1);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 8;
            button1.Text = "Produk";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(247, 204, 92);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(1, 1, 1, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(211, 43);
            panel6.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(233, 78, 1);
            label1.Location = new Point(36, 11);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 0;
            label1.Text = "Fruities";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(4, 68);
            pictureBox5.Margin = new Padding(1, 1, 1, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(36, 62);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(72, 17);
            label9.TabIndex = 5;
            label9.Text = "Dashboard";
            label9.Click += label9_Click;
            // 
            // V_Profil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "V_Profil";
            Text = "V_Profil";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button LogOutButton;
        private PictureBox pictureBox8;
        private Button ProfilButton;
        private PictureBox pictureBox7;
        private Button RiwayatButton;
        private PictureBox pictureBox6;
        private Button button1;
        private Panel panel6;
        private Label label1;
        private PictureBox pictureBox5;
        private Label label9;
        private Panel panel5;
        private Label Nama;
        private Panel panel3;
        private Panel panel4;
        private Label Password;
        private Button button2;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label Email;
    }
}