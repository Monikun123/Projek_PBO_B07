namespace Projek_PBO_B07.View
{
    partial class V_EditProfil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            namaupdate = new TextBox();
            emailupdate = new TextBox();
            passwordupdate = new TextBox();
            btnsimpan = new Button();
            btnbatal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(234, 87, 13);
            label1.Location = new Point(62, 56);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 0;
            label1.Text = "EDIT PROFIL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 123);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 179);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 241);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // namaupdate
            // 
            namaupdate.BackColor = Color.FromArgb(247, 204, 92);
            namaupdate.Location = new Point(180, 120);
            namaupdate.Name = "namaupdate";
            namaupdate.Size = new Size(256, 23);
            namaupdate.TabIndex = 4;
            namaupdate.Text = "Nama";
            // 
            // emailupdate
            // 
            emailupdate.BackColor = Color.FromArgb(247, 204, 92);
            emailupdate.Location = new Point(182, 174);
            emailupdate.Name = "emailupdate";
            emailupdate.Size = new Size(254, 23);
            emailupdate.TabIndex = 5;
            emailupdate.Text = "Email";
            // 
            // passwordupdate
            // 
            passwordupdate.BackColor = Color.FromArgb(247, 204, 92);
            passwordupdate.Location = new Point(180, 233);
            passwordupdate.Name = "passwordupdate";
            passwordupdate.Size = new Size(256, 23);
            passwordupdate.TabIndex = 6;
            passwordupdate.Text = "Password";
            passwordupdate.TextChanged += textBox3_TextChanged;
            // 
            // btnsimpan
            // 
            btnsimpan.BackColor = Color.FromArgb(108, 241, 86);
            btnsimpan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsimpan.Location = new Point(68, 307);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(75, 29);
            btnsimpan.TabIndex = 7;
            btnsimpan.Tag = "";
            btnsimpan.Text = "Save";
            btnsimpan.UseVisualStyleBackColor = false;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnbatal
            // 
            btnbatal.BackColor = Color.FromArgb(252, 0, 0);
            btnbatal.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnbatal.Location = new Point(361, 307);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(75, 29);
            btnbatal.TabIndex = 8;
            btnbatal.Text = "Back";
            btnbatal.UseVisualStyleBackColor = false;
            btnbatal.Click += btnbatal_Click;
            // 
            // V_EditProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 452);
            Controls.Add(btnbatal);
            Controls.Add(btnsimpan);
            Controls.Add(passwordupdate);
            Controls.Add(emailupdate);
            Controls.Add(namaupdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "V_EditProfil";
            Text = "EditProfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox namaupdate;
        private TextBox emailupdate;
        private TextBox passwordupdate;
        private Button btnsimpan;
        private Button btnbatal;
    }
}