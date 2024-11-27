﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_PBO_B07.Core;

namespace Projek_PBO_B07.Context
{
    internal class C_DashboardAdmin : DataWrapper
    {
        public static int getTotalBuahBusuk()
        {
            string query = @"
        SELECT 
            COALESCE(SUM(buah_busuk), 0) AS total_busuk
        FROM 
            riwayat;";

            NpgsqlParameter[] parameters = { };

            // Menjalankan query untuk mendapatkan DataTable
            DataTable dataTotalBuahBusuk = queryExecutor(query, parameters);

            // Memastikan jika DataTable tidak kosong dan mengambil nilai total_busuk
            if (dataTotalBuahBusuk.Rows.Count > 0)
            {
                // Mengambil nilai dari kolom 'total_busuk' yang pertama dan mengonversinya ke integer
                return Convert.ToInt32(dataTotalBuahBusuk.Rows[0]["total_busuk"]);
            }

            // Jika tidak ada data, kembalikan nilai 0
            return 0;
        }
        public static int getTotalTransaksi()
        {
            string query = @"
        SELECT 
            COALESCE(SUM(buah_terjual), 0) AS buah_terjual
        FROM 
            riwayat;";

            NpgsqlParameter[] parameters = { };

            // Menjalankan query untuk mendapatkan DataTable
            DataTable dataTotalBuahBusuk = queryExecutor(query, parameters);

            // Memastikan jika DataTable tidak kosong dan mengambil nilai total_busuk
            if (dataTotalBuahBusuk.Rows.Count > 0)
            {
                // Mengambil nilai dari kolom 'total_busuk' yang pertama dan mengonversinya ke integer
                return Convert.ToInt32(dataTotalBuahBusuk.Rows[0]["buah_terjual"]);
            }

            // Jika tidak ada data, kembalikan nilai 0
            return 0;
        }
        public static int getDataStok()
        {
            string query = @"
        SELECT 
            COALESCE(SUM(stok), 0) AS total_stok
        FROM 
            produk;";

            NpgsqlParameter[] parameters = { };

            // Menjalankan query untuk mendapatkan DataTable
            DataTable dataStok = queryExecutor(query, parameters);

            // Memastikan jika DataTable tidak kosong dan mengambil nilai total_stok
            if (dataStok.Rows.Count > 0)
            {
                // Mengambil nilai dari kolom 'total_stok' yang pertama dan mengonversinya ke integer
                return Convert.ToInt32(dataStok.Rows[0]["total_stok"]);
            }

            // Jika tidak ada data, kembalikan nilai 0
            return 0;
        }
    }
}