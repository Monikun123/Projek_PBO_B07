using Npgsql;
using Projek_PBO_B07.Core;
using Projek_PBO_B07.Context;
using Projek_PBO_B07.Model;
using Projek_PBO_B07.View;
namespace Projek_PBO_B07
{
    public partial class V_Login : Form
    {
        private int id_produk { get; set; }
        public V_Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailText.Text) || string.IsNullOrEmpty(passwordText.Text))
            {
                MessageBox.Show("Email dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (emailText.Text.EndsWith("@gmail.com") == false)
            {
                MessageBox.Show("Maaf, Anda kurang menambahkan @gmail.com", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            C_LoginAkun loginakunContext = new C_LoginAkun();
            M_User login = loginakunContext.Validate(emailText.Text, passwordText.Text);

                if (login == null)
                {
                    MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string role = login.Role;

                if (role == "Admin")
                {
                    MessageBox.Show("Login berhasil! Anda masuk sebagai Admin.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    V_Profil addprofil = new V_Profil(login.Id_User);
                    V_DashboardAdmin adminDashboard = new V_DashboardAdmin(login.Id_User);
                    this.Hide();
                    adminDashboard.Show();
                }
                else if (role == "User")
                {
                    MessageBox.Show("Login berhasil! Anda masuk sebagai User.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    V_DashboardCust userDashboard = new V_DashboardCust();

                    this.Hide();
                    userDashboard.Show();
                }
                else
                {
                    // Handle unexpected roles (optional)
                }
            }
        }

        public void ClearTextBox()
        {
            emailText.Text = "";
            passwordText.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void emailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_DashboardCust v_dashboardcust = new V_DashboardCust();
            v_dashboardcust.Show();
        }
    }
}
