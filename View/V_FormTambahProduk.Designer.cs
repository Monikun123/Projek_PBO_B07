namespace Projek_PBO_B07.View
{
    partial class V_FormTambahProduk
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
            AddProdukButton = new Button();
            TanggalExpiredDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            TanggalMasukDate = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            NamaBuahcomboBox = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(AddProdukButton);
            panel1.Controls.Add(TanggalExpiredDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TanggalMasukDate);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NamaBuahcomboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // AddProdukButton
            // 
            AddProdukButton.BackColor = Color.FromArgb(244, 204, 92);
            AddProdukButton.Location = new Point(36, 357);
            AddProdukButton.Name = "AddProdukButton";
            AddProdukButton.Size = new Size(214, 34);
            AddProdukButton.TabIndex = 12;
            AddProdukButton.Text = "Menambahkan Produk";
            AddProdukButton.UseVisualStyleBackColor = false;
            // 
            // TanggalExpiredDate
            // 
            TanggalExpiredDate.Location = new Point(392, 292);
            TanggalExpiredDate.Name = "TanggalExpiredDate";
            TanggalExpiredDate.Size = new Size(300, 31);
            TanggalExpiredDate.TabIndex = 8;
            TanggalExpiredDate.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(392, 262);
            label5.Name = "label5";
            label5.Size = new Size(168, 27);
            label5.TabIndex = 7;
            label5.Text = "Tanggal Expired";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 262);
            label4.Name = "label4";
            label4.Size = new Size(157, 27);
            label4.TabIndex = 6;
            label4.Text = "Tanggal Masuk";
            // 
            // TanggalMasukDate
            // 
            TanggalMasukDate.Location = new Point(36, 292);
            TanggalMasukDate.Name = "TanggalMasukDate";
            TanggalMasukDate.Size = new Size(300, 31);
            TanggalMasukDate.TabIndex = 5;
            TanggalMasukDate.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 177);
            label3.Name = "label3";
            label3.Size = new Size(55, 27);
            label3.TabIndex = 3;
            label3.Text = "Stok";
            // 
            // NamaBuahcomboBox
            // 
            NamaBuahcomboBox.FormattingEnabled = true;
            NamaBuahcomboBox.Location = new Point(36, 126);
            NamaBuahcomboBox.Name = "NamaBuahcomboBox";
            NamaBuahcomboBox.Size = new Size(182, 33);
            NamaBuahcomboBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 96);
            label2.Name = "label2";
            label2.Size = new Size(126, 27);
            label2.TabIndex = 1;
            label2.Text = "Nama Buah";
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
            label1.Location = new Point(346, 20);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 1;
            label1.Text = "Fruities";
            // 
            // V_FormTambahProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "V_FormTambahProduk";
            Text = "V_FormTambahProduk";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DateTimePicker TanggalMasukDate;
        private TextBox textBox1;
        private Label label3;
        private ComboBox NamaBuahcomboBox;
        private Label label2;
        private Label label4;
        private DateTimePicker TanggalExpiredDate;
        private Label label5;
        private Button AddProdukButton;
    }
}