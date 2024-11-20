using Npgsql;
using Projek_PBO_B07.Core;
using Projek_PBO_B07.Context;
using Projek_PBO_B07.Model;
namespace Projek_PBO_B07
{
    public partial class V_Login : Form
    {
        public V_Login()
        {
            InitializeComponent();
        }

        private void MainFormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {


            C_LoginAkun loginakunContext = new C_LoginAkun();
            M_User login = loginakunContext.Validate(usernameText.Text, passwordText.Text);

            if (login != null)
            {
                MessageBox.Show("Login berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();


            }
            else if (string.IsNullOrEmpty(usernameText.Text) || string.IsNullOrEmpty(passwordText.Text))
            {
                MessageBox.Show("Username & Password tidak boleh kosong!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username atau Password salah. Masukkan dengan benar!", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ClearTextBox()
        {
            usernameText.Text = "";
            passwordText.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
