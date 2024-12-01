using Projek_PBO_B07.Model;
using System.Data;
using Npgsql;
using Projek_PBO_B07.Core;
using Projek_PBO_B07.View;

namespace Projek_PBO_B07.Context
{
    public class C_Profil : DataWrapper
    {
        public M_Profile GetProfil(int userId)
        {
            string query = "SELECT * FROM pengguna WHERE id_pengguna = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", userId)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))
            {
                if (reader.Read())
                {
                    M_Profile profil = new M_Profile(
                        (string)reader["email"],
                        (string)reader["nama"],
                        (string)reader["password"]
                    )
                    {
                        Nama = (string)reader["nama"],
                        Role = (string)reader["role"],
                        Email = (string)reader["email"],
                        Password = (string)reader["password"],
                        Id_User = userId
                    };

                    return profil;
                }
            }
            return null;
        }

    }
}
