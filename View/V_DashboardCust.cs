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
        public int id_user { get; set; }
        public V_DashboardCust(int id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
            LoadData();
        }

        private void LoadDataProduk()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable mahasiswaData = ProdukContext.GetAllProduk();
                if (mahasiswaData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data mahasiswa");
                    return;
                }

                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = mahasiswaData;

                if (dataGridView1.Columns["produk.ID_produk"] != null)
                    dataGridView1.Columns["produk.ID_produk"].Visible = false;
                if (dataGridView1.Columns["nama_buah.nama_buah"] != null)
                    dataGridView1.Columns["nama_buah.nama_buah"].HeaderText = "Nama Buah";
                if (dataGridView1.Columns["harga_awal"] != null)
                    dataGridView1.Columns["harga_awal"].HeaderText = "harga_awal";
                if (dataGridView1.Columns["produk.stok"] != null)
                    dataGridView1.Columns["produk.stok"].HeaderText = "Stok";
                if (dataGridView1.Columns["produk.tanggal_masuk"] != null)
                    dataGridView1.Columns["produk.tanggal_masuk"].HeaderText = "Tanggal_Masuk";
                if (dataGridView1.Columns["produk.tanggal_expired"] != null)
                    dataGridView1.Columns["produk.tanggal_expired"].HeaderText = "Tanggal Expired";
                if (dataGridView1.Columns["diskon"] != null)
                    dataGridView1.Columns["diskon"].HeaderText = "Diskon";
                if (dataGridView1.Columns["harga_setelah_diskon"] != null)
                    dataGridView1.Columns["harga_setelah_diskon"].HeaderText = "Harga setelah Diskon";


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void LoadDataProduk()
        {

        }
        private void LoadData()
        {
            try
            {
                // Ambil data riwayat transaksi dari controller
                DataTable data = ProdukContext.GetAllProdukdanGambar();

                // Bersihkan panel7 sebelum menambahkan data baru

                // Pastikan ada data sebelum menambahkannya ke panel
                if (data != null && data.Rows.Count > 0)
                {
                    int topPosition = 10;  // Menentukan posisi vertikal pertama untuk panel

                    foreach (DataRow row in data.Rows)
                    {
                        // Membuat panel baru untuk setiap baris data
                        Panel itemPanel = new Panel();
                        itemPanel.Width = panel8.Width - 20;  // Menyesuaikan lebar itemPanel dengan panel9
                        itemPanel.Height = 80;  // Menentukan tinggi panel per item
                        itemPanel.Location = new Point(10, topPosition);  // Menentukan posisi panel vertikal

                        // Menambahkan label untuk ID
                        Label labelID = new Label();
                        labelID.Text = row["id_produk"].ToString();
                        labelID.Width = 50;
                        labelID.Location = new Point(10, 10);
                        itemPanel.Controls.Add(labelID);

                        //Menambahkan picturebox buat gambar
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 90;
                        pictureBox.Height = 90;
                        pictureBox.Location = new Point(70, 100);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                        // Ambil nama gambar dari DataTable
                        string imageName = row["gambar"].ToString(); // Kolom "image_name" harus ada di DataTable
                        object resourceObject = Properties.Resources.ResourceManager.GetObject(imageName);

                        if (resourceObject is byte[] imageBytes)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBox.Image = Image.FromStream(ms);
                            }
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }


                        // Jika gambar tidak ditemukan, gunakan gambar default
                        if (pictureBox.Image == null)
                        {
                            string imagedefault = "strawbery.jpg";
                            object resourceObject2 = Properties.Resources.ResourceManager.GetObject(imagedefault);
                            // Ganti dengan nama gambar default Anda

                            if (resourceObject2 is byte[] defaultImageBytes)
                            {
                                using (MemoryStream ms = new MemoryStream(defaultImageBytes))
                                {
                                    pictureBox.Image = Image.FromStream(ms);
                                }
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }

                        itemPanel.Controls.Add(pictureBox);


                        // Menambahkan label untuk Nama buah
                        Label labelnama_buah = new Label();
                        labelnama_buah.Text = row["nama_buah"].ToString();
                        labelnama_buah.Width = 150;
                        labelnama_buah.Location = new Point(100, 10);
                        itemPanel.Controls.Add(labelnama_buah);

                        // Menambahkan label untuk Harga awal
                        Label labelharga_awal = new Label();
                        labelharga_awal.Text = row["harga_awal"].ToString();
                        labelharga_awal.Width = 120;
                        labelharga_awal.Location = new Point(150, 10);  // Ubah lokasi agar tidak bertumpuk
                        itemPanel.Controls.Add(labelharga_awal);

                        // Menambahkan label untuk stok
                        Label labelstok = new Label();
                        labelstok.Text = row["stok"].ToString();
                        labelstok.Width = 100;
                        labelstok.Location = new Point(200, 10);
                        itemPanel.Controls.Add(labelstok);

                        Label labeltanggal_masuk = new Label();
                        labeltanggal_masuk.Text = row["tanggal_masuk"].ToString();
                        labeltanggal_masuk.Width = 150;
                        labeltanggal_masuk.Location = new Point(250, 10);
                        itemPanel.Controls.Add(labeltanggal_masuk);

                        Label labeltanggal_expired = new Label();
                        labeltanggal_expired.Text = row["tanggal_expired"].ToString();
                        labeltanggal_expired.Width = 150;
                        labeltanggal_expired.Location = new Point(300, 10);
                        itemPanel.Controls.Add(labeltanggal_expired);

                        Label labeldiskon = new Label();
                        labeldiskon.Text = row["diskon"].ToString();
                        labeldiskon.Width = 100;
                        labeldiskon.Location = new Point(350, 10);
                        itemPanel.Controls.Add(labeldiskon);

                        Label labelharga_setelah_diskon = new Label();
                        labelharga_setelah_diskon.Text = row["harga_setelah_diskon"].ToString();
                        labelharga_setelah_diskon.Width = 150;
                        labelharga_setelah_diskon.Location = new Point(400, 10);
                        itemPanel.Controls.Add(labelharga_setelah_diskon);


                        // Menambahkan itemPanel ke panel9
                        panel8.Controls.Add(itemPanel);

                        // Update posisi vertikal untuk panel berikutnya
                        topPosition += itemPanel.Height + 10;  // Tambah tinggi panel dan margin vertikal
                    }
                }
                else
                {
                    MessageBox.Show("Tidak ada data riwayat transaksi.");
                }
            }
            catch (Exception ex)
            {
                // Menangani error dan menampilkan pesan kesalahan
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
            this.Hide();
            V_Logout v_logout = new V_Logout(id_user);
            v_logout.Show();
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Logout v_logout = new V_Logout();
            v_logout.Show();
        }
    }
}
