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

        private void picturebox()
        {
            string imageName = "download.jpg";  // Nama gambar yang ingin diambil
            string resourcesFolderPath = @"C:\Users\Naufal Kemal A\source\repos\Projek_PBO_B07\Resources";

            // Tentukan path lengkap gambar
            string imagePath = Path.Combine(resourcesFolderPath, imageName);

            // Tampilkan path untuk memverifikasi
            MessageBox.Show("Path Gambar: " + imagePath);

            // Periksa apakah gambar ada di folder Resources
            if (File.Exists(imagePath))
            {
                try
                {
                    // Memuat gambar dari file
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    MessageBox.Show("Gambar berhasil dimuat dari: " + imagePath);
                }
                catch (Exception ex)
                {
                    // Menangani kesalahan jika format gambar tidak valid
                    MessageBox.Show("Terjadi kesalahan saat memuat gambar: " + ex.Message);
                }
            }
            else
            {
                // Jika gambar tidak ditemukan, berikan informasi path dan cek ekstensi file
                MessageBox.Show("Gambar tidak ditemukan di path: " + imagePath);

                // Cek apakah file dengan ekstensi lain ada di folder Resources
                string[] validExtensions = { ".jpg", ".jpeg", ".png" };
                bool imageFound = false;

                foreach (var ext in validExtensions)
                {
                    string tempPath = Path.ChangeExtension(imagePath, ext);
                    if (File.Exists(tempPath))
                    {
                        MessageBox.Show("Gambar dengan ekstensi " + ext + " ditemukan: " + tempPath);
                        pictureBox1.Image = Image.FromFile(tempPath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        imageFound = true;
                        break;
                    }
                }

                if (!imageFound)
                {
                    MessageBox.Show("Tidak ada gambar dengan ekstensi yang valid ditemukan.");
                }
            }
        }

    }
}




