using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_PBO_B07.Model
{
    public class M_Profile : M_User
    {
        public string nama {  get; set; }
        public M_Profile(string email, string password, string nama) : base(email, password)
        {
            this.Password = password;
            this.Email = email;
            this.nama = nama;
        }
    }
}
