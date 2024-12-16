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
    public partial class V_Logout : Form
    {

        public V_Logout()
        {
            InitializeComponent();
     
  

        }

        private void btnya_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login v_login = new V_Login();
            v_login.Show();
        }

        private void btntidak_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void V_Logout_Load(object sender, EventArgs e)
        {

        }
    }
}
