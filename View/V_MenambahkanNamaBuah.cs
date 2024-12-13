using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projek_PBO_B07.Context;
using Projek_PBO_B07.Core;

namespace Projek_PBO_B07.View
{
    public partial class V_MenambahkanNamaBuah : Form
    {
        public V_MenambahkanNamaBuah()
        {
            InitializeComponent();
            LoadJenisBuah();
        }

        private void LoadJenisBuah()
        {
            DataTable datajenisbuah = JenisBuahcontext.All();
            JbcomboBox1.DisplayMember = "jenis_buah";
            JbcomboBox1.ValueMember = "id_jenis_buah";
            JbcomboBox1.DataSource = datajenisbuah;
            JbcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Pilih Gambar",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Mengecek apakah file yang dipilih adalah gambar
                    if (openFileDialog.FileName.EndsWith(".jpg") ||
                        openFileDialog.FileName.EndsWith(".png") ||
                        openFileDialog.FileName.EndsWith(".bmp"))
                    {
                        // Mengurangi ukuran gambar sebelum memuatnya
                        Image originalImage = Image.FromFile(openFileDialog.FileName);
                        int newWidth = 800; // Ganti ukuran lebar gambar yang diinginkan
                        int newHeight = (int)(originalImage.Height * ((float)newWidth / originalImage.Width));
                        Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                        // Memuat gambar yang telah diubah ukurannya ke PictureBox
                        pictureBox1.Image = resizedImage;

                        // Tentukan path folder Resources
                        string resourcesPath = @"C:\Users\Naufal Kemal A\source\repos\Projek_PBO_B071\Resources";

                        // Pastikan folder Resources ada, jika tidak ada buat folder baru
                        if (!Directory.Exists(resourcesPath))
                        {
                            Directory.CreateDirectory(resourcesPath);
                        }

                        // Simpan gambar dengan nama file asli
                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        string destinationPath = Path.Combine(resourcesPath, fileName);

                        // Salin file ke folder Resources
                        File.Copy(openFileDialog.FileName, destinationPath, overwrite: true);

                        // Menampilkan nama file di TextBox (NamaGambar)
                        NamaGambar.Text = fileName;

                        MessageBox.Show($"Gambar '{fileName}' berhasil disalin ke folder Resources.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File yang dipilih bukan gambar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Menangani kesalahan
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
