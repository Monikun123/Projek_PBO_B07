using Projek_PBO_B07.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_PBO_B07.View
{
    public partial class V_DashboardCust : Form
    {
        
        public V_DashboardCust()
        {
            InitializeComponent();
            
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                // Ambil data dari sumber (database)
                DataTable data = ProdukContext.GetAllProdukdanGambar();

                if (data != null && data.Rows.Count > 0)
                {
                    panel8.Controls.Clear(); // Bersihkan panel sebelum memuat data baru
                    panel8.AutoScroll = true; // Mengaktifkan AutoScroll
                    panel8.HorizontalScroll.Enabled = true;
                    panel8.HorizontalScroll.Visible = true;

                    int topPosition = 10; // Posisi vertikal awal
                    int panelItemWidth = 850; // Total lebar item panel yang lebih besar dari panel8

                    // Membuat header kolom
                    Panel headerPanel = new Panel
                    {
                        Width = panelItemWidth,
                        Height = 30,
                        Location = new Point(10, topPosition),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Fungsi untuk membuat dan menambahkan header label dengan lebar dinamis
                    void TambahkanHeaderLabel(string text, int width, int xPosition)
                    {
                        Label label = new Label
                        {
                            Text = text,
                            Width = width,
                            Height = 30,
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.LightGray,
                            BorderStyle = BorderStyle.FixedSingle,
                            Location = new Point(xPosition, 0)
                        };
                        headerPanel.Controls.Add(label);
                    }

                    // Menambahkan header kolom dengan lebar yang sesuai
                    int[] columnWidths = {110, 50, 120, 100, 50, 120, 120, 70, 120 };
                    string[] headers = { "Gambar","ID", "Nama", "Harga", "Stok", "Tanggal Masuk", "Tanggal Expired", "Diskon", "Harga Diskon" };

                    int headerXPosition = 0; // Posisi awal untuk header
                    for (int i = 0; i < headers.Length; i++)
                    {
                        TambahkanHeaderLabel(headers[i], columnWidths[i], headerXPosition);
                        headerXPosition += columnWidths[i];
                    }

                    // Menambahkan headerPanel ke panel utama
                    panel8.Controls.Add(headerPanel);

                    // Update posisi setelah header
                    topPosition += headerPanel.Height + 10;

                    foreach (DataRow row in data.Rows)
                    {
                        // Panel untuk setiap item
                        Panel itemPanel = new Panel
                        {
                            Width = panelItemWidth, // Set lebar lebih besar dari panel8 untuk memungkinkan scroll horizontal
                            Height = 120,
                            Location = new Point(10, topPosition),
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        int currentX = 10; // Posisi horizontal awal
                        int paddingX = 0; // Padding antar elemen data

                        // PictureBox untuk gambar
                        String resourcesFolderPath = @"C:\Users\Naufal Kemal A\Source\Repos\Projek_PBO_B071\Resources\";

                        // Membuat PictureBox
                        PictureBox pictureBox = new PictureBox
                        {
                            Width = 100,
                            Height = 100,
                            Location = new Point(currentX, 10),
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };

                        // Mengambil nama gambar dari data (misalnya, DataTable atau database)
                        string imageName = row["gambar"].ToString();

                        // Tentukan path lengkap gambar yang ada di folder Resources
                        string imagePath = Path.Combine(resourcesFolderPath, imageName);

                        // Daftar ekstensi gambar yang valid
                        string[] validExtensions = { ".jpg", ".jpeg", ".png" };

                        // Memeriksa apakah file gambar ada dengan ekstensi yang valid
                        bool imageFound = false;
                        foreach (string ext in validExtensions)
                        {
                            string filePath = Path.Combine(resourcesFolderPath, Path.ChangeExtension(imageName, ext));

                            if (File.Exists(filePath))
                            {
                                pictureBox.Image = Image.FromFile(filePath);
                                imageFound = true;
                                break;
                            }
                        }

                        // Jika gambar tidak ditemukan, gunakan gambar default
                        if (!imageFound)
                        {
                            string defaultImage = "strawbery.jpg.jpg"; // Nama gambar default (tanpa ekstensi)
                            string defaultImagePath = Path.Combine(resourcesFolderPath, defaultImage);

                            if (File.Exists(defaultImagePath))
                            {
                                pictureBox.Image = Image.FromFile(defaultImagePath);
                            }
                            else
                            {
                                MessageBox.Show("Gambar default tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        itemPanel.Controls.Add(pictureBox);
                        currentX += pictureBox.Width + paddingX;
                        // Fungsi untuk menambah label
                        void TambahkanLabel(string text, int width)
                        {
                            Label label = new Label
                            {
                                Text = text,
                                Width = width,
                                Height = 30,
                                Location = new Point(currentX, 45), // Posisikan data di tengah secara vertikal
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            itemPanel.Controls.Add(label);
                            currentX += width + paddingX;
                        }

                        // Menambahkan kolom-kolom dengan lebar yang sesuai
                        TambahkanLabel(row["id_produk"].ToString(), columnWidths[1]); // ID Produk
                        TambahkanLabel(row["nama_buah"].ToString(), columnWidths[2]); // Nama Produk
                        TambahkanLabel(row["harga_awal"].ToString(), columnWidths[3]); // Harga Awal
                        TambahkanLabel(row["stok"].ToString(), columnWidths[4]); // Stok
                        TambahkanLabel(row["tanggal_masuk"].ToString(), columnWidths[5]); // Tanggal Masuk
                        TambahkanLabel(row["tanggal_expired"].ToString(), columnWidths[6]); // Tanggal Expired
                        TambahkanLabel($"{row["diskon"]}%", columnWidths[7]); // Diskon
                        TambahkanLabel(row["harga_setelah_diskon"].ToString(), columnWidths[8]); // Harga Setelah Diskon

                        // Tambahkan panel item ke panel utama
                        panel8.Controls.Add(itemPanel);

                        // Perbarui posisi vertikal untuk item berikutnya
                        topPosition += itemPanel.Height + 10;
                    }

                    // Pastikan lebar total konten lebih besar dari panel8
                    panel8.HorizontalScroll.Maximum = panelItemWidth;
                }
                else
                {
                    MessageBox.Show("Tidak ada data untuk ditampilkan.");
                }
            }
            catch (Exception ex)
            {
                // Menangani error
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }






        private void DashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}

