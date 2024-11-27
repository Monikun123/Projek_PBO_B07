﻿using System;
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
            this.Load += V_Produk_Load;
        }

        private void V_Produk_Load(object sender, EventArgs e)
        {
            LoadDataProduk();
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
                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Detail",
                    HeaderText = "Detail",
                    Text = "Update",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void AddProdukButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_FormTambahProduk formtambahproduk = new V_FormTambahProduk();
            
            if (formtambahproduk.ShowDialog() == DialogResult.OK)
            {
                getDataBuahAll();
                LoadDataProduk();
            }
            this.Show();
        }
    }
}