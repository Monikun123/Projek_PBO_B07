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

    }
}
