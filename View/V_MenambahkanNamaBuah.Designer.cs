namespace Projek_PBO_B07.View
{
    partial class V_MenambahkanNamaBuah
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
            NamaGambar = new Label();
            AddImageButton = new Button();
            pictureBox1 = new PictureBox();
            JbcomboBox1 = new ComboBox();
            label4 = new Label();
            NamatextBox = new TextBox();
            BackButton = new Button();
            AddProdukButton = new Button();
            HargaTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(NamaGambar);
            panel1.Controls.Add(AddImageButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(JbcomboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(NamatextBox);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(AddProdukButton);
            panel1.Controls.Add(HargaTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // NamaGambar
            // 
            NamaGambar.AutoSize = true;
            NamaGambar.Location = new Point(504, 289);
            NamaGambar.Name = "NamaGambar";
            NamaGambar.Size = new Size(127, 25);
            NamaGambar.TabIndex = 19;
            NamaGambar.Text = "Nama Gambar";
            NamaGambar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddImageButton
            // 
            AddImageButton.BackColor = Color.FromArgb(244, 204, 92);
            AddImageButton.Location = new Point(450, 326);
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(229, 34);
            AddImageButton.TabIndex = 18;
            AddImageButton.Text = "Menambahkan Gambar";
            AddImageButton.UseVisualStyleBackColor = false;
            AddImageButton.Click += AddImageButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(450, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // JbcomboBox1
            // 
            JbcomboBox1.FormattingEnabled = true;
            JbcomboBox1.Location = new Point(36, 281);
            JbcomboBox1.Name = "JbcomboBox1";
            JbcomboBox1.Size = new Size(182, 33);
            JbcomboBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 251);
            label4.Name = "label4";
            label4.Size = new Size(116, 27);
            label4.TabIndex = 15;
            label4.Text = "Jenis Buah";
            // 
            // NamatextBox
            // 
            NamatextBox.Location = new Point(36, 126);
            NamatextBox.Name = "NamatextBox";
            NamatextBox.Size = new Size(182, 31);
            NamatextBox.TabIndex = 14;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(616, 366);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // AddProdukButton
            // 
            AddProdukButton.BackColor = Color.FromArgb(244, 204, 92);
            AddProdukButton.Location = new Point(36, 357);
            AddProdukButton.Name = "AddProdukButton";
            AddProdukButton.Size = new Size(214, 34);
            AddProdukButton.TabIndex = 12;
            AddProdukButton.Text = "Menambahkan Buah";
            AddProdukButton.UseVisualStyleBackColor = false;
            // 
            // HargaTextBox
            // 
            HargaTextBox.Location = new Point(36, 207);
            HargaTextBox.Name = "HargaTextBox";
            HargaTextBox.Size = new Size(182, 31);
            HargaTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 177);
            label3.Name = "label3";
            label3.Size = new Size(192, 27);
            label3.TabIndex = 3;
            label3.Text = "Harga Buah (/box)";
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
            label1.Location = new Point(334, 25);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 1;
            label1.Text = "Fruities";
            // 
            // V_MenambahkanNamaBuah
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "V_MenambahkanNamaBuah";
            Text = "V_MenambahkanNamaBuah";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BackButton;
        private Button AddProdukButton;
        private TextBox HargaTextBox;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private TextBox NamatextBox;
        private PictureBox pictureBox1;
        private ComboBox JbcomboBox1;
        private Label label4;
        private Button AddImageButton;
        private Label NamaGambar;
    }
}