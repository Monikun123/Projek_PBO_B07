using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Projek_PBO_B07.Core
{
    public class DataWrapper
    {
        // Properti credential database dan koneksinya
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "projek3";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "basic324";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        // Method open dan close Koneksi
        public void SaveImageToResources(string filePath)
        {
            try
            {
                // Membaca gambar ke dalam byte array
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (Image image = Image.FromFile(filePath))
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);  // Menyimpan gambar sebagai PNG
                    }
                    imageBytes = ms.ToArray();
                }

                // Tentukan path ke file Resources.resx
                string resourcesPath = @"C:\Users\Naufal Kemal A\Source\Repos\Projek_PBO_B071\Properties\Resources.resx";

                // Membaca file .resx yang sudah ada
                ResXResourceWriter resxWriter = new ResXResourceWriter(resourcesPath);

                // Menambahkan resource baru (gambar) ke dalam .resx
                string resourceName = Path.GetFileName(filePath);  // Gunakan nama file sebagai nama resource
                resxWriter.AddResource(resourceName, imageBytes);  // Menambahkan resource gambar

                // Menyimpan file Resources.resx
                resxWriter.Close();

                MessageBox.Show($"Gambar berhasil disimpan ke Resources.resx dengan nama resource '{resourceName}'", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void openConnection()
        {
            connection = new NpgsqlConnection($"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE};Port={DB_PORT}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }

        public static void closeConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                closeConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.Prepare();
                command.Parameters.Clear();
                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static NpgsqlDataReader ExecuteReaderCommand(string query, NpgsqlParameter[] parameters = null)
        {
            openConnection();
            command.CommandText = query;
            if (parameters != null)
                command.Parameters.AddRange(parameters);
            command.Prepare();

            // Eksekusi dan return reader tanpa menutup koneksi
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
