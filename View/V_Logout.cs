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
        public int id_user { get; set; }
        public V_Logout(int id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
  

        }

        private void btnya_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login v_login = new V_Login();
            v_login.Show();
        }

        private void btntidak_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DashboardAdmin v_dashboardadmin = new V_DashboardAdmin(id_user);
            v_dashboardadmin.Show();
        }

        private void V_Logout_Load(object sender, EventArgs e)
        {

        }
    }
}
