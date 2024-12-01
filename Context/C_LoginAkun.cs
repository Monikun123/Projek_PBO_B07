using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using Projek_PBO_B07.Core;
using Projek_PBO_B07.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projek_PBO_B07.Context
{
    internal class C_LoginAkun : DataWrapper
    {
        public M_User Validate(string email, string password)
        {
            M_User loginAkun = null;
            string query = "SELECT * FROM pengguna WHERE email = @email AND password = @password";

            // Parameter untuk query
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@email", email),
            new NpgsqlParameter("@password", password)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    loginAkun = new M_User(email, password);
                    loginAkun.Id_User = (int)reader["id_User"];
                    loginAkun.Role = (string)reader["role"];
                    loginAkun.Email = (string)reader["email"];
                    loginAkun.Password = (string)reader["password"];
                    loginAkun.Id_User = (int)reader["id_pengguna"];

                };
            return loginAkun;

        }
    }
}
