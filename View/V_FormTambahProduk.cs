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
using Projek_PBO_B07.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_PBO_B07.View
{
    public partial class V_FormTambahProduk : Form
    {
        public V_FormTambahProduk()
        {
            InitializeComponent();
            LoadNamaBuahData();


        }
        private void LoadNamaBuahData()
        {
            DataTable dataNamabuah = NamaBuahContext.All();
            NamaBuahcomboBox.DisplayMember = "nama_buah";
            NamaBuahcomboBox.ValueMember = "id_nama_buah";
            NamaBuahcomboBox.DataSource = dataNamabuah;
            NamaBuahcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddProdukButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            M_Produk produk = new M_Produk()
            {
                id_promosi = 1,
                id_pengguna = 1,
                id_nama_buah = (int)NamaBuahcomboBox.SelectedValue,
                tanggal_masuk = TanggalMasukDate.Value,
                tanggal_expired = TanggalExpiredDate.Value,
                stok = int.Parse(StoktextBox.Text),



            };
            ProdukContext.AddProduk(produk);
            MessageBox.Show("Produk berhasil ditambah");
            ClearFields();
            this.DialogResult = DialogResult.OK;
            this.Hide();


        }
        private bool ValidateInput()
        {

            if (NamaBuahcomboBox.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih nama buah.");
                return false;
            }


            if (TanggalMasukDate.Value > TanggalExpiredDate.Value)
            {
                MessageBox.Show("Tanggal masuk tidak boleh lebih besar dari tanggal expired.");
                return false;
            }


            if (string.IsNullOrWhiteSpace(StoktextBox.Text) ||
                !int.TryParse(StoktextBox.Text, out int stok) || stok < 0)
            {
                MessageBox.Show("Stok harus berupa bilangan bulat dan tidak boleh negatif.");
                return false;
            }


            return true;
        }
        private void ClearFields()
        {

            StoktextBox.Clear();


            NamaBuahcomboBox.SelectedIndex = -1;


            TanggalMasukDate.Value = DateTime.Now;
            TanggalExpiredDate.Value = DateTime.Now;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
