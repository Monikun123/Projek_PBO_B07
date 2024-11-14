using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_PBO_B07.Model
{
    internal class M_LoginAkun
    {
        public string username { get; set; }
        public string password { get; set; }
        public int id { get; set; }
        [Required]

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public M_LoginAkun(string username, string password) //Constructor
        {
            this.username = username;
            this.password = password;
        }
    }
}
