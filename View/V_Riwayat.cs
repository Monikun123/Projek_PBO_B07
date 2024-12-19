using Projek_PBO_B07.Context;
using Projek_PBO_B07.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Projek_PBO_B07.View
{
    public partial class V_Riwayat : Form
    {
        public int id_profil { get; set; }
        private C_Riwayat controller;

        public V_Riwayat(int id_user)
        {

            InitializeComponent();
            id_profil = id_user;
            getDataBuahAll();
            controller = new C_Riwayat();
            LoadData();
        }


        private void LoadData()
        {
            try
            {

                DataTable data = controller.GetRiwayatTransaksi();


                if (data != null && data.Rows.Count > 0)
                {
                    int topPosition = 10;  

                    foreach (DataRow row in data.Rows)
                    {
                        // Membuat panel baru untuk setiap baris data
                        Panel itemPanel = new Panel();
                        itemPanel.Width = panel8.Width - 20;
                        itemPanel.Height = 80;
                        itemPanel.Location = new Point(10, topPosition);

                        // Menambahkan label untuk ID
                        Label labelID = new Label();
                        labelID.Text = row["id_riwayat"].ToString();
                        labelID.Width = 50;
                        labelID.Location = new Point(10, 10);
                        itemPanel.Controls.Add(labelID);

                        // Menambahkan label untuk Jumlah Keluar
                        Label labelNamaBuah = new Label();
                        labelNamaBuah.Text = row["nama"].ToString();
                        labelNamaBuah.Width = 150;
                        labelNamaBuah.Location = new Point(110, 10);
                        itemPanel.Controls.Add(labelNamaBuah);

                        // Menambahkan label untuk Tanggal Transaksi
                        Label labelTglTransaksi = new Label();
                        labelTglTransaksi.Text = row["tanggal_transaksi"].ToString();
                        labelTglTransaksi.Width = 120;
                        labelTglTransaksi.Location = new Point(420, 10);
                        itemPanel.Controls.Add(labelTglTransaksi);

                        // Menambahkan label untuk Buah Busuk
                        Label labelBobot = new Label();
                        labelBobot.Text = row["bobot"].ToString();
                        labelBobot.Width = 100;
                        labelBobot.Location = new Point(290, 10);
                        itemPanel.Controls.Add(labelBobot);

                        Label labelStatus = new Label();
                        labelStatus.Text = row["status"].ToString();
                        labelStatus.Width = 150;
                        labelStatus.Location = new Point(600, 10);
                        itemPanel.Controls.Add(labelStatus);


                        // Menambahkan itemPanel ke panel7
                        panel7.Controls.Add(itemPanel);

                        // Update posisi vertikal untuk panel berikutnya
                        topPosition += itemPanel.Height + 10;
                    }
                }
                else
                {
                    MessageBox.Show("Tidak ada data riwayat transaksi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin(id_profil);
            v_DashboardAdmin.Show();

        }
        //sddsadasd 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Produk v_Produk = new V_Produk(id_profil);
            v_Produk.Show();

        }

        private void ProfilButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Profil v_profil = new V_Profil(id_profil);
            v_profil.Show();

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Logout v_logout = new V_Logout();

            if (v_logout.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
