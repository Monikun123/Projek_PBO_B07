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

        private void DashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
