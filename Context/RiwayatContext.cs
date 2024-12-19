
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Projek_PBO_B07.Core;
using Projek_PBO_B07.Model;

using Npgsql;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projek_PBO_B07.View;

namespace Projek_PBO_B07.Context
{
    internal class RiwayatContext :DataWrapper
    {
        private static string table = "riwayat";
        public static void InsertDataBaru(M_RiwayatTabel riwayarTabel)
        {

            string query = $"INSERT INTO {table} ( jumlah_keluar, buah_busuk, buah_terjual, tanggal_transaksi) VALUES (@jumlah_keluar, @buah_busuk, @buah_terjual, @tanggal_transaksi);";

            NpgsqlParameter[] parameters =
{
                new NpgsqlParameter("@jumlah_keluar", riwayarTabel.jumlah_keluar),
                new NpgsqlParameter("@buah_busuk",riwayarTabel.buah_busuk),
                new NpgsqlParameter("@buah_terjual", riwayarTabel.buah_terjual),
                new NpgsqlParameter("@tanggal_transaksi", riwayarTabel.tanggal_transaksi)

            };
            commandExecutor(query, parameters);
        }

        public static int GetId(M_RiwayatTabel riwayarTabel)
        {
            DateTime tanggalTransaksi = riwayarTabel.tanggal_transaksi.Date;

            string query = $"SELECT id_riwayat FROM {table} WHERE jumlah_keluar = @jumlah_keluar AND buah_busuk = @buah_busuk AND buah_terjual = @buah_terjual AND tanggal_transaksi = @tanggal_transaksi";

            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@jumlah_keluar", riwayarTabel.jumlah_keluar),
        new NpgsqlParameter("@buah_busuk", riwayarTabel.buah_busuk),
        new NpgsqlParameter("@buah_terjual", riwayarTabel.buah_terjual),
        new NpgsqlParameter("@tanggal_transaksi", tanggalTransaksi) 
    };

            try
            {
                // Eksekusi query dan ambil data
                DataTable datariwayat = queryExecutor(query, parameters); // Pastikan queryExecutor menerima parameters
                if (datariwayat.Rows.Count > 0)
                {
                    // Mengambil id_riwayat dari hasil query
                    return Convert.ToInt32(datariwayat.Rows[0]["id_riwayat"]);
                }
                else
                {
                    // Jika tidak ada data ditemukan
                    throw new Exception("Data tidak ditemukan untuk parameter yang diberikan.");
                }
            }
            catch (Exception ex)
            {
                // Menangani kesalahan
                throw new Exception($"Terjadi kesalahan saat mengambil ID: {ex.Message}");
            }
        }
        public static void InsertTransaksi(int id_produk, int id_riwayat)
        {
            string query = "INSERT INTO transaksi (id_produk, id_riwayat) VALUES (@id_produk, @id_riwayat)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_produk", id_produk),
                new NpgsqlParameter("@id_riwayat", id_riwayat),
            };
            commandExecutor(query, parameters);
        }

    }
}

