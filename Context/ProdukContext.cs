using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Projek_PBO_B07.Core;
using Projek_PBO_B07.Model;
using Npgsql;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Projek_PBO_B07.View;

namespace Projek_PBO_B07.Context
{
    internal class ProdukContext : DataWrapper
    {
        private static string table = "produk";
        public static DataTable GetAllProduk()
        {
            string query = @"SELECT 
    produk.ID_produk,
    nama_buah.nama_buah,
    nama_buah.harga AS harga_awal,
    produk.stok,
    produk.tanggal_masuk,
    produk.tanggal_expired,
    COALESCE(promosi.diskon, 0) AS diskon,
    (nama_buah.harga - (nama_buah.harga * COALESCE(promosi.diskon, 0) / 100)) AS harga_setelah_diskon
FROM 
    produk
JOIN 
    nama_buah ON produk.ID_nama_buah = nama_buah.ID_nama_buah
LEFT JOIN 
    promosi ON produk.ID_promosi = promosi.ID_promosi
ORDER BY 
    produk.ID_produk;";

            DataTable dataProduk = queryExecutor(query);
            return dataProduk;
        }
        public static DataTable GetAllProdukdanGambar()
        {
            string query = @"SELECT 
    produk.ID_produk,
    nama_buah.gambar,
    nama_buah.nama_buah,
    nama_buah.harga AS harga_awal,
    produk.stok,
    produk.tanggal_masuk,
    produk.tanggal_expired,
    COALESCE(promosi.diskon, 0) AS diskon,
    (nama_buah.harga - (nama_buah.harga * COALESCE(promosi.diskon, 0) / 100)) AS harga_setelah_diskon
FROM 
    produk
JOIN 
    nama_buah ON produk.ID_nama_buah = nama_buah.ID_nama_buah
LEFT JOIN 
    promosi ON produk.ID_promosi = promosi.ID_promosi
ORDER BY 
    produk.ID_produk;";

            DataTable dataProduk = queryExecutor(query);
            return dataProduk;
        }

        public static void AddProduk(M_Produk Produk)
        {
            string query = $"INSERT INTO {table} (id_promosi, id_pengguna, id_nama_buah, tanggal_masuk, tanggal_expired, stok) " +
                $"VALUES(@id_promosi, @id_pengguna, @id_nama_buah, @tanggal_masuk, @tanggal_expired, @stok)";


            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_promosi", Produk.id_promosi),
                new NpgsqlParameter("@id_pengguna",Produk.id_pengguna),
                new NpgsqlParameter("@id_nama_buah", Produk.id_nama_buah),
                new NpgsqlParameter("@tanggal_masuk", Produk.tanggal_masuk),
                new NpgsqlParameter("@tanggal_expired", Produk.tanggal_expired),
                new NpgsqlParameter("@stok", Produk.stok),
            };

            commandExecutor(query, parameters);

        }

        public static void AddNamaBuah (M_Nama_Buah Buah)
        {
            string query = $"INSERT INTO nama_buah (id_jenis_buah, gambar, nama_buah, harga) " +
                $"VALUES(@id_jenis_buah, @gambar, @nama_buah, @harga)";
            NpgsqlParameter[] parameters =
{
                new NpgsqlParameter("@id_jenis_buah", Buah.id_jenis_buah),
                new NpgsqlParameter("@gambar", Buah.gambar),
                new NpgsqlParameter("@nama_buah", Buah.nama_buah),
                new NpgsqlParameter("@harga", Buah.harga),
    
            };

            commandExecutor(query, parameters);

        }

        public static void UpdateDiskon(int id_promosi, int id_produk)
        {
            string query = $"UPDATE produk SET id_promosi = @id_promosi WHERE id_produk = @id_produk;";

            NpgsqlParameter[] parameters =
           {
                new NpgsqlParameter("@id_promosi", id_promosi),
                new NpgsqlParameter("@id_produk", id_produk),
                
            };
            commandExecutor(query, parameters);

        }

        public static DataTable GetDataStock(int id_produk)
        {
            string query = $"SELECT stok FROM produk  Where id_produk = @id_produk";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_produk", id_produk),
            };
            DataTable getId = queryExecutor(query, parameters);
            return getId;
        }
        public static void UpdateStok(int total, int id_produk)
        {
            string query = $"UPDATE produk SET stok = @stok WHERE id_produk = @id_produk";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("stok", total),
                new NpgsqlParameter("@id_produk", id_produk),
            };
            commandExecutor(query, parameters);
        }

    }
 }

