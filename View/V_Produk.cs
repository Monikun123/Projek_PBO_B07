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
    public partial class V_Produk : Form
    {
        public V_Produk()
        {
            InitializeComponent();
            getDataBuahAll(); 
        }

        private void label5_Click(object sender, EventArgs e)
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
    }
}
