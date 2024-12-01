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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_PBO_B07.View
{
    public partial class V_UpdateProduk : Form
    {
        public int id_produk { get; set; }
        public V_UpdateProduk()
        {
            InitializeComponent();
            LoadPromosi();
            loadnilai0();
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
    }
}
