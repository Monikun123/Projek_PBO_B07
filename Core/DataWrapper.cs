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
            string fileName = Path.GetFileName(filePath);
            string resourceName = Path.GetFileNameWithoutExtension(fileName); // Nama file tanpa ekstensi

            string resourcesPath = Path.Combine(Application.StartupPath, @"C:\Users\Naufal Kemal A\source\repos\Projek_PBO_B071\Properties\Resources.resx");

            if (!File.Exists(resourcesPath))
            {
                MessageBox.Show("Resources.resx tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Menyalin gambar ke dalam folder Resources jika perlu
            string targetFolder = Path.Combine(Application.StartupPath, "Resources");
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            string targetPath = Path.Combine(targetFolder, fileName);
            File.Copy(filePath, targetPath, true);

            // Menggunakan ResXResourceWriter untuk menambah gambar ke Resources
            using (ResXResourceWriter resxWriter = new ResXResourceWriter(resourcesPath))
            {
                resxWriter.AddResource(resourceName, new ResXFileRef(targetPath, "System.Drawing.Bitmap"));
            }

            MessageBox.Show($"Gambar '{fileName}' berhasil disimpan ke Resources.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
