using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Projek_PBO_B07.Core;

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

            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }

    }
}
