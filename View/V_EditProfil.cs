using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_PBO_B07.View
{
    public partial class V_EditProfil : Form
    {
        private int userId;

        public V_EditProfil()
        {
            InitializeComponent();
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
            V_Profil v_Profil = new V_Profil(userId);
            v_Profil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
