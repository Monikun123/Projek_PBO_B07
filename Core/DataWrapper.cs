using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Drawing;
using System.Resources;
using System.Collections;

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


        public void SaveImageToResources(string imagePath)
        {
            // Path ke file Resources.resx
            string resourceFilePath = Path.Combine(Application.StartupPath, @"C:\Users\Naufal Kemal A\Source\Repos\Projek_PBO_B071\Properties\Resources.resx");

            // Pastikan file Resources.resx ada
            if (!File.Exists(resourceFilePath))
            {
                MessageBox.Show("Resources.resx tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imageName = Path.GetFileName(imagePath); // Nama gambar
            string targetFolder = @"C:\Users\Naufal Kemal A\source\repos\Projek_PBO_B07\Resources\";  // Folder target tempat menyimpan gambar

            // Salin gambar ke folder Resources jika perlu
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);  // Membuat folder Resources jika tidak ada
            }

            string targetPath = Path.Combine(targetFolder, imageName); // Path lengkap untuk gambar
            try
            {
                // Salin gambar ke folder Resources
                File.Copy(imagePath, targetPath, true);  // Menyalin gambar ke folder target
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyalin gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Menambahkan gambar ke dalam Resources.resx
            try
            {
                // Membuka file .resx yang ada untuk menambah resource
                using (ResXResourceWriter resxWriter = new ResXResourceWriter(resourceFilePath))
                {
                    // Membaca resource yang sudah ada sebelumnya dan menulis kembali ke file .resx
                    foreach (DictionaryEntry entry in new ResXResourceReader(resourceFilePath))
                    {
                        resxWriter.AddResource(entry.Key.ToString(), entry.Value);
                    }

                    // Menambahkan gambar ke dalam file .resx sebagai referensi file
                    resxWriter.AddResource(imageName, new ResXFileRef(targetPath, "System.Drawing.Bitmap"));
                }

                MessageBox.Show($"Gambar '{imageName}' berhasil disimpan dalam Resources.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menulis ke Resources.resx: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
