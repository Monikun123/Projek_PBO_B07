using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projek_PBO_B07.Properties;
using System.IO;

namespace Projek_PBO_B07.View
{
    public partial class Percobaan : Form
    {
        public Percobaan()
        {
            InitializeComponent();
            picturebox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
            private void picturebox()
            {
                string imageName = "strawbery.jpg";
            // Ambil resource sebagai byte array
            object resourceObject = Properties.Resources.ResourceManager.GetObject(imageName);

            if (resourceObject is byte[] imageBytes)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Gambar tidak ditemukan atau format tidak valid.");
            }

        }

    }
}

   
