namespace Projek_PBO_B07.View
{
    partial class Logout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 124);
            label1.Name = "label1";
            label1.Size = new Size(460, 41);
            label1.TabIndex = 0;
            label1.Text = "Apakah anda yakin untuk logout?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 90, 19);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(454, 246);
            button1.Name = "button1";
            button1.Size = new Size(117, 49);
            button1.TabIndex = 1;
            button1.Text = "Tidak";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(175, 246);
            button2.Name = "button2";
            button2.Size = new Size(117, 49);
            button2.TabIndex = 2;
            button2.Text = "Ya";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Logout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Logout";
            Size = new Size(758, 532);
            Load += Logout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}
