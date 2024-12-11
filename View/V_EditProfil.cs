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
using Projek_PBO_B07.Core;
using Projek_PBO_B07.Context;
using Projek_PBO_B07.Model;
using Microsoft.VisualBasic.ApplicationServices;

namespace Projek_PBO_B07.View
{
    public partial class V_EditProfil : Form
    {
       public int id_profil { get; set; }

        public V_EditProfil(int userId)
        {
            InitializeComponent();
            id_profil = userId;
            populateform(userId);

          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Profil v_Profil = new V_Profil(id_profil);
            v_Profil.Show();
        }
        private void populateform(int userId)
        {
            C_Profil profilContext = new C_Profil();
            M_Profile profil = profilContext.GetProfil(userId);
            namaupdate.Text = profil.Nama;
            emailupdate.Text = profil.Email;
            passwordupdate.Text = profil.Password;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string Nama = namaupdate.Text;
                string Email = emailupdate.Text;
                string Password = passwordupdate.Text;

                C_Profil c_Profil = new C_Profil();
                C_Profil.Updateprofil(Nama, Email, Password, id_profil);
                MessageBox.Show("Profil berhasil diupdate");
                this.Hide();
                V_Profil v_Profil = new V_Profil(id_profil);
                v_Profil.Show();
            }

        }
        private bool ValidateInput()
        {
            // Validasi Nama: tidak boleh kosong
            if (string.IsNullOrWhiteSpace(namaupdate.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong.");
                return false;
            }

            // Validasi Email: format email sederhana
            if (string.IsNullOrWhiteSpace(emailupdate.Text))
            {
                MessageBox.Show("Email tidak valid. Harap masukkan email yang benar.");
                return false;
            }

            // Validasi Password: tidak boleh kosong dan minimal 6 karakter
            if (string.IsNullOrWhiteSpace(passwordupdate.Text))
            {
                MessageBox.Show("Password harus memiliki setidaknya 6 karakter.");
                return false;
            }

            return true;
        }
        //public V_EditProfil (int userId)
        //{
        //    this.userId = userId;   
        //}
    }
}
