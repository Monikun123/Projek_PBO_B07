using Npgsql;
using Projek_PBO_B07.Core;
using Projek_PBO_B07.Context;
using Projek_PBO_B07.Model;
using Projek_PBO_B07.View;
namespace Projek_PBO_B07
{
    public partial class V_Login : Form
    {
        public V_Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {


            C_LoginAkun loginakunContext = new C_LoginAkun();
            M_User login = loginakunContext.Validate(emailText.Text, passwordText.Text);
            {
                if (string.IsNullOrEmpty(emailText.Text) || string.IsNullOrEmpty(passwordText.Text))
            {
                MessageBox.Show("Email dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // C_LoginAkun loginakunContext = new C_LoginAkun();
            // M_User login = loginakunContext.Validate(emailText.Text, passwordText.Text);

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
                    V_DashboardAdmin adminDashboard = new V_DashboardAdmin();
                    this.Hide();
                    adminDashboard.Show();
                }
                else if (role == "User")
                {
                    MessageBox.Show("Login berhasil! Anda masuk sebagai User.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    V_DashboardUser userDashboard = new V_DashboardUser();
                    this.Hide();
                    userDashboard.Show();
                }
                else
                {
                    // Handle unexpected roles (optional)
                }
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
    }
}
