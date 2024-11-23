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

        private void loginbutton_Click(object sender, EventArgs e)
        {


            C_LoginAkun loginakunContext = new C_LoginAkun();
            M_User login = loginakunContext.Validate(usernameText.Text, passwordText.Text);

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
