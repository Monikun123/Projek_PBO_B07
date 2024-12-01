namespace Projek_PBO_B07.View
{
    partial class V_Logout
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
            btntidak = new Button();
            btnya = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 77);
            label1.Name = "label1";
            label1.Size = new Size(425, 32);
            label1.TabIndex = 0;
            label1.Text = "Apakah anda yakin untuk logout?";
            // 
            // btntidak
            // 
            btntidak.BackColor = Color.Red;
            btntidak.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntidak.Location = new Point(505, 257);
            btntidak.Name = "btntidak";
            btntidak.Size = new Size(94, 40);
            btntidak.TabIndex = 1;
            btntidak.Text = "Tidak";
            btntidak.UseVisualStyleBackColor = false;
            btntidak.Click += btntidak_Click;
            // 
            // btnya
            // 
            btnya.BackColor = Color.Lime;
            btnya.Font = new Font("Microsoft Sans Serif", 12F);
            btnya.Location = new Point(174, 257);
            btnya.Name = "btnya";
            btnya.Size = new Size(96, 40);
            btnya.TabIndex = 2;
            btnya.Text = "Ya";
            btnya.UseVisualStyleBackColor = false;
            btnya.Click += btnya_Click;
            // 
            // V_Logout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnya);
            Controls.Add(btntidak);
            Controls.Add(label1);
            Name = "V_Logout";
            Text = "V_Logout";
            Load += V_Logout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btntidak;
        private Button btnya;
    }
}