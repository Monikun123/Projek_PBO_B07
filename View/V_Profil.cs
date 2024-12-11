using Microsoft.VisualBasic.ApplicationServices;
using Projek_PBO_B07.Context;
using Projek_PBO_B07.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Projek_PBO_B07.View
{
    public partial class V_Profil : Form
    {
        private int id_user { get; set; }
        private M_User currentUser;
        public V_Profil(int user_id)
        {
            id_user = user_id;

            InitializeComponent();
            C_Profil profilContext = new C_Profil();
            M_Profile profil = profilContext.GetProfil(user_id);

            if (profil != null)
            {
                currentUser = profil;
                DisplayProfile();
            }
            else
            {
                MessageBox.Show("Data profil tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayProfile()
        {
            if (currentUser != null)
            {
                Nama.Text = currentUser.nama;
                Email.Text = currentUser.Email;
                Password.Text = currentUser.Password;
            }
            else
            {
                MessageBox.Show("Data pengguna tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin(id_user);
            v_DashboardAdmin.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_EditProfil v_EditProfil = new V_EditProfil(id_user);

            v_EditProfil.Show();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalBuahBusuk_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Logout v_logout = new V_Logout(id_user);
            v_logout.Show();
        }

        private void ProfilButton_Click(object sender, EventArgs e)
        {

        }

        private void RiwayatButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Riwayat v_Riwayat = new V_Riwayat(id_user);
            v_Riwayat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Produk v_Produk = new V_Produk(id_user);
            v_Produk.Show();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin(id_user);
            v_DashboardAdmin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            V_Logout v_logout = new V_Logout(id_user);
            v_logout.Show();
        }

        private void RiwayatButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            V_Riwayat addriwayat = new V_Riwayat(id_user);
            addriwayat.Show();


        }

        private void HalProdukButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Produk addproduk = new V_Produk(id_user);
            addproduk.Show();
        }
    }
}

