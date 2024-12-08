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

namespace Projek_PBO_B07.View
{
    public partial class V_DashboardAdmin : Form
    {
        public V_DashboardAdmin()
        {
            InitializeComponent();
            getDataBuahAll();
            this.Load += DashboardAdmin_Load;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalStok_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalBuahBusuk_Click(object sender, EventArgs e)
        {

        }
        private void getDataBuahAll()
        {
            try
            {

                int totalBusuk = C_DashboardAdmin.getTotalBuahBusuk();

                int totalTransaksi = C_DashboardAdmin.getTotalTransaksi();

                int totalStok = C_DashboardAdmin.getDataStok();


                lblTotalStok.Text = $"{totalStok}";

                lblTotalTransaksi.Text = $"{totalTransaksi}";

                lblTotalBuahBusuk.Text = $"{totalBusuk}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            LoadDataProduk();
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

        private void HalProdukButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Produk addHalProduk = new V_Produk();
            if (addHalProduk.ShowDialog() == DialogResult.OK)
            {
                LoadDataProduk();
            }
            this.Show();

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {

        }
    }

}



