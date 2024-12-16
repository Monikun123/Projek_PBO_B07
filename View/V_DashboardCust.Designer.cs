namespace Projek_PBO_B07.View
{
    partial class V_DashboardCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DashboardCust));
            panel1 = new Panel();
            label9 = new Label();
            LogOutButton = new Button();
            pictureBox8 = new PictureBox();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel8 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 392);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(247, 204, 92);
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(45, 76);
            label9.Name = "label9";
            label9.Size = new Size(99, 25);
            label9.TabIndex = 16;
            label9.Text = "DashBoard";
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.Red;
            LogOutButton.Location = new Point(41, 342);
            LogOutButton.Margin = new Padding(2);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(95, 34);
            LogOutButton.TabIndex = 14;
            LogOutButton.Text = "LogOut";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Red;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(5, 342);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 34);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(247, 204, 92);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(163, 58);
            panel6.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(233, 78, 1);
            label1.Location = new Point(18, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 26);
            label1.TabIndex = 0;
            label1.Text = "Fruities";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(247, 204, 92);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(5, 70);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2686558F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.7313461F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(7, 27);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(786, 396);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(169, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 392);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel8
            // 
            panel8.AutoScroll = true;
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 70);
            panel8.Name = "panel8";
            panel8.Size = new Size(615, 322);
            panel8.TabIndex = 6;
            panel8.Paint += panel8_Paint;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(617, 39);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 6);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 4;
            label5.Text = "DASHBOARD";
            // 
            // V_DashboardCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "V_DashboardCust";
            Text = "V_DashboardCust";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button DashboardButton;
        private Button LogOutButton;
        private PictureBox pictureBox8;
        private Panel panel6;
        private Label label1;
        private PictureBox pictureBox4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private Panel panel2;
        private Panel panel8;
        private Panel panel4;
        private Label label5;
    }
}