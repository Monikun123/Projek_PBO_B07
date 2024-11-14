using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_PBO_B07.Core;
using Projek_PBO_B07.Model;

namespace Projek_PBO_B07.Context
{
    internal class LoginAkunContext : DataWrapper
    {

        public LoginAkunModel Validate(string username, string password)
        {
            LoginAkunModel loginAkun = null;
            string query = "SELECT * FROM akun WHERE username = @username AND psword = @password";

            // Parameter untuk query
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@username", username),
            new NpgsqlParameter("@password", password)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    loginAkun = new LoginAkunModel(username, password);
                    loginAkun.Username = (string)reader["username"];
                    loginAkun.Password = (string)reader["psword"];

                };
            return loginAkun;

        }
    }
}
