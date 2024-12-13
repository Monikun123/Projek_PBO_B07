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
                    // Memuat gambar ke PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Menyimpan gambar ke dalam Resources.resx
                    DataWrapper dataWrapper = new DataWrapper();
                    dataWrapper.SaveImageToResources(openFileDialog.FileName);

                    NamaGambar.Text = Path.GetFileName(openFileDialog.FileName); // Menampilkan nama file di TextBox
                }
                catch (Exception ex)
                {
                    // Menangani kesalahan
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File yang dipilih bukan gambar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
