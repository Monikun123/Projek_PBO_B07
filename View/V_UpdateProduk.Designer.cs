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
            BackButton = new Button();
            this.AddPromosiButton = new Button();
            PromosiCombobox = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(this.AddPromosiButton);
            panel1.Controls.Add(PromosiCombobox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
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
            // AddPromosiButton
            // 
            this.AddPromosiButton.BackColor = Color.FromArgb(244, 204, 92);
            this.AddPromosiButton.Location = new Point(36, 312);
            this.AddPromosiButton.Name = "AddPromosiButton";
            this.AddPromosiButton.Size = new Size(214, 34);
            this.AddPromosiButton.TabIndex = 12;
            this.AddPromosiButton.Text = "Add Promosi";
            this.AddPromosiButton.UseVisualStyleBackColor = false;
            // 
            // PromosiCombobox
            // 
            PromosiCombobox.FormattingEnabled = true;
            PromosiCombobox.Location = new Point(36, 273);
            PromosiCombobox.Name = "PromosiCombobox";
            PromosiCombobox.Size = new Size(182, 33);
            PromosiCombobox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 232);
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
        private Button AddProdukButton;
        private DateTimePicker TanggalExpiredDate;
        private Label label5;
        private Label label4;
        private DateTimePicker TanggalMasukDate;
        private TextBox StoktextBox;
        private Label label3;
        private ComboBox PromosiCombobox;
        private Label label2;
        private Panel panel2;
        private Label label1;
    }
}