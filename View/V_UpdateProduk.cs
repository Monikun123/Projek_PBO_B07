using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Projek_PBO_B07.Context;
using Projek_PBO_B07.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_PBO_B07.View
{

    public partial class V_UpdateProduk : Form
    {
        public int id_produk { get; set; }
        public V_UpdateProduk(int produk_id)
        {
 
            id_produk = produk_id;
            InitializeComponent();
 

            LoadPromosi();
            loadnilai0();
            populateForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        private void LoadPromosi()
        {
            DataTable dataNamabuah = PromosiContext.All();
            PromosiCombobox.DisplayMember = "diskon";
            PromosiCombobox.ValueMember = "id_promosi";
            PromosiCombobox.DataSource = dataNamabuah;
            PromosiCombobox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void populateForm()
        {

           ProdukContext produkContext = new ProdukContext();
            M_Produk produk = produkContext.GetProdukbtId(id_produk);
            PromosiCombobox.SelectedValue = produk.id_promosi;
            

        }

        private void loadnilai0()
        {
            TerjualTexbox.Text = "0";
            BusuktextBox.Text = "0";

        }

        private void AddPromosiButton_Click(object sender, EventArgs e)
        {
            int id_promosi = (int)PromosiCombobox.SelectedValue;

            ProdukContext.UpdateDiskon(id_promosi, id_produk);
            MessageBox.Show("Diskon Produk berhasil diupdate");
            ClearFields();
            this.DialogResult = DialogResult.OK;
            this.Hide();


        }
        private void ClearFields()
        {
            TerjualTexbox.Text = "0";
            TerjualTexbox.Text = "0";

            PromosiCombobox.SelectedIndex = -1;
        }

        private void AddRiwayatbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(TerjualTexbox.Text) || string.IsNullOrWhiteSpace(BusuktextBox.Text))
                {
                    MessageBox.Show("Harap isi kedua field 'Terjual' dan 'Busuk'.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (!int.TryParse(TerjualTexbox.Text, out int terjual) || !int.TryParse(BusuktextBox.Text, out int busuk))
                {
                    MessageBox.Show("Input harus berupa angka!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (terjual < 0 || busuk < 0)
                {
                    MessageBox.Show("Nilai tidak boleh negatif.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (terjual == 0 && busuk == 0)
                {
                    MessageBox.Show("jumlah Buah harus diisi.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataTable stokSaatIni = ProdukContext.GetDataStock(id_produk); // Ganti dengan fungsi yang benar untuk mendapatkan stok
                int stock = Convert.ToInt32(stokSaatIni.Rows[0]["stok"]);
                // Validasi total (terjual + busuk) tidak boleh melebihi stok
                int total = terjual + busuk;
                if (total > stock)
                {
                    MessageBox.Show($"Total pengeluaran tidak boleh melebihi stok ({stokSaatIni}).", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (terjual > 0)
                {
                    M_RiwayatTabel riwayatterjual = new M_RiwayatTabel()
                    {
                        jumlah_keluar = int.Parse(TerjualTexbox.Text),
                        buah_terjual = int.Parse(TerjualTexbox.Text),
                        buah_busuk = 0,
                        tanggal_transaksi = TanggalTransaksiDate.Value
                    };

                    RiwayatContext.InsertDataBaru(riwayatterjual);
                    int id_riwayat = RiwayatContext.GetId(riwayatterjual);

                    RiwayatContext.InsertTransaksi(id_produk, id_riwayat);

                }
                if (busuk > 0)
                {
                    M_RiwayatTabel riwayatbusuk = new M_RiwayatTabel()
                    {
                        jumlah_keluar = int.Parse(BusuktextBox.Text),
                        buah_terjual = 0,
                        buah_busuk = int.Parse(BusuktextBox.Text),
                        tanggal_transaksi = TanggalTransaksiDate.Value
                    };

                    RiwayatContext.InsertDataBaru(riwayatbusuk);
                    int id_riwayat = RiwayatContext.GetId(riwayatbusuk);
                    RiwayatContext.InsertTransaksi(id_produk, id_riwayat);

                }
                int stokbaru = stock - total;
                ProdukContext.UpdateStok(stokbaru, id_produk);
                MessageBox.Show(" Produk berhasil dikeluarkan");
                ClearFields();
                this.DialogResult = DialogResult.OK;
                this.Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
