using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_PBO_B07.Model
{
    public class M_User
    {
        public string nama { get; set; }
        public string email { get; set; }

        public string password { get; set; }

        public string role { get; set; }
        public int Id_User { get; set; }
        [Required]

        public string Nama { 
        
            get { return nama; }
            set { nama = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public M_User(string email, string password) //Constructor
        {
            this.email = email;
            this.password = password;
        }
    }
}
