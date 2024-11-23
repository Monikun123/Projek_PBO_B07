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
            getDataBuahBusuk();
            getDataTotalTransaksi();
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
        private void getDataBuahBusuk()
        {
            try
            {
                // Panggil metode untuk mendapatkan total buah busuk
                int totalBusuk = C_DashboardAdmin.getTotalBuahBusuk();

                // Perbarui teks pada label
                lblTotalBuahBusuk.Text = $"{totalBusuk}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getDataTotalTransaksi()
        {
            try
            {
                // Panggil metode untuk mendapatkan total buah busuk
                int totalTransaksi = C_DashboardAdmin.getTotalTransaksi();

                // Perbarui teks pada label
                lblTotalTransaksi.Text = $"{totalTransaksi}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


