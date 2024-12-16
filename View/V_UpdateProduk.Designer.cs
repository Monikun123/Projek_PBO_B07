namespace Projek_PBO_B07.View
{
    partial class V_UpdateProduk
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
            panel1 = new Panel();
            label10 = new Label();
            TanggalTransaksiDate = new DateTimePicker();
            AddRiwayatbutton = new Button();
            BusuktextBox = new TextBox();
            TerjualTexbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BackButton = new Button();
            AddPromosiButton = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            PromosiCombobox = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(TanggalTransaksiDate);
            panel1.Controls.Add(AddRiwayatbutton);
            panel1.Controls.Add(BusuktextBox);
            panel1.Controls.Add(TerjualTexbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(AddPromosiButton);
            panel1.Controls.Add(PromosiCombobox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(432, 220);
            label10.Name = "label10";
            label10.Size = new Size(114, 27);
            label10.TabIndex = 29;
            label10.Text = "Tgl Keluar";
            // 
            // TanggalTransaksiDate
            // 
            TanggalTransaksiDate.CustomFormat = "yyyy-MM-dd";
            TanggalTransaksiDate.Format = DateTimePickerFormat.Custom;
            TanggalTransaksiDate.Location = new Point(432, 247);
            TanggalTransaksiDate.Name = "TanggalTransaksiDate";
            TanggalTransaksiDate.Size = new Size(300, 31);
            TanggalTransaksiDate.TabIndex = 20;
            // 
            // AddRiwayatbutton
            // 
            AddRiwayatbutton.BackColor = Color.FromArgb(244, 204, 92);
            AddRiwayatbutton.Location = new Point(508, 352);
            AddRiwayatbutton.Name = "AddRiwayatbutton";
            AddRiwayatbutton.Size = new Size(171, 34);
            AddRiwayatbutton.TabIndex = 19;
            AddRiwayatbutton.Text = "Mengeluarkan";
            AddRiwayatbutton.UseVisualStyleBackColor = false;
            AddRiwayatbutton.Click += AddRiwayatbutton_Click_1;
            // 
            // BusuktextBox
            // 
            BusuktextBox.Location = new Point(616, 306);
            BusuktextBox.Name = "BusuktextBox";
            BusuktextBox.Size = new Size(150, 31);
            BusuktextBox.TabIndex = 18;
            // 
            // TerjualTexbox
            // 
            TerjualTexbox.Location = new Point(432, 306);
            TerjualTexbox.Name = "TerjualTexbox";
            TerjualTexbox.Size = new Size(150, 31);
            TerjualTexbox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(616, 281);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 16;
            label5.Text = "Busuk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(432, 281);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 15;
            label4.Text = "Terjual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(413, 184);
            label3.Name = "label3";
            label3.Size = new Size(207, 27);
            label3.TabIndex = 14;
            label3.Text = "Mengeluarkan Buah";
            label3.Click += label3_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(655, 404);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AddPromosiButton
            // 
            AddPromosiButton.BackColor = Color.FromArgb(244, 204, 92);
            AddPromosiButton.Location = new Point(24, 286);
            AddPromosiButton.Name = "AddPromosiButton";
            AddPromosiButton.Size = new Size(214, 34);
            AddPromosiButton.TabIndex = 12;
            AddPromosiButton.Text = "Edit Promosi";
            AddPromosiButton.UseVisualStyleBackColor = false;
            AddPromosiButton.Click += AddPromosiButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 215);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 1;
            label2.Text = "Promosi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 204, 92);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 72);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(233, 78, 1);
            label1.Location = new Point(344, 23);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 1;
            label1.Text = "Fruities";
            label1.Click += label1_Click;
            // 
            // PromosiCombobox
            // 
            PromosiCombobox.FormattingEnabled = true;
            PromosiCombobox.Location = new Point(24, 245);
            PromosiCombobox.Name = "PromosiCombobox";
            PromosiCombobox.Size = new Size(182, 33);
            PromosiCombobox.TabIndex = 2;
            // 
            // V_UpdateProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "V_UpdateProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_UpdateProduk";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BackButton;
        private Button AddPromosiButton;
        private DateTimePicker TanggalExpiredDate;
        private Label label5;
        private Label label4;
        private DateTimePicker TanggalMasukDate;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button AddRiwayatbutton;
        private TextBox BusuktextBox;
        private TextBox TerjualTexbox;
        private DateTimePicker TanggalTransaksiDate;
        private Label label10;
        private ComboBox PromosiCombobox;
    }
}