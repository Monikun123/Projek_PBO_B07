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
using Projek_PBO_B07.Model;

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
                    
                    if (
                        openFileDialog.FileName.EndsWith(".jpg") ||
                        openFileDialog.FileName.EndsWith(".png") ||
                        openFileDialog.FileName.EndsWith(".bmp"))
                    {
                       
                        Image originalImage = Image.FromFile(openFileDialog.FileName);
                        int newWidth = 80; 
                        int newHeight = (int)(originalImage.Height * ((float)newWidth / originalImage.Width));
                        Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                        
                        pictureBox1.Image = resizedImage;

                       
                        string resourcesPath = @"C:\Users\Naufal Kemal A\source\repos\Projek_PBO_B071\Resources\";

                        
                        if (!Directory.Exists(resourcesPath))
                        {
                            Directory.CreateDirectory(resourcesPath);
                        }

                        
                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        string destinationPath = Path.Combine(resourcesPath, fileName);


                     
                        File.Copy(openFileDialog.FileName, destinationPath, overwrite: true);

                        
                        NamaGambar.Text = fileName;

                        MessageBox.Show($"Gambar '{fileName}' berhasil disalin ke folder Resources.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File yang dipilih gambar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Menangani kesalahan
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void AddProdukButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NamatextBox.Text))
            {
                MessageBox.Show("Nama buah tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(HargaTextBox.Text) || !int.TryParse(HargaTextBox.Text, out int harga))
            {
                MessageBox.Show("Harga harus berupa angka yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NamaGambar.Text == "Gambar" || string.IsNullOrWhiteSpace(NamaGambar.Text))
            {
                MessageBox.Show("Gambar tidak boleh kosong atau hanya berisi teks 'Gambar'.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (JbcomboBox1.SelectedValue == null)
            {
                MessageBox.Show("Jenis buah harus dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            M_Nama_Buah buah = new M_Nama_Buah()
            {
                nama_buah = NamatextBox.Text,
                harga = int.Parse(HargaTextBox.Text),
                gambar = NamaGambar.Text,
                id_jenis_buah = (int)JbcomboBox1.SelectedValue
            };
            ProdukContext.AddNamaBuah(buah);
            MessageBox.Show("Buah baru berhasil ditambahkan");
            this.DialogResult = DialogResult.OK;
            this.Hide();


        }
    }


}
