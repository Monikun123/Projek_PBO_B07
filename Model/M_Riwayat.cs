 using System;
using System.Data;
using Projek_PBO_B07.Core;

namespace Projek_PBO_B07.Model
{
    public class M_Riwayat
    {
        // Properti untuk menyimpan data riwayat transaksi
        public int Id { get; set; }
        public string Nama { get; set; }
        public DateTime Tanggal { get; set; }
        public string Status { get; set; }
        public double Bobot { get; set; }

        // Konstruktor
        public M_Riwayat(int id, string nama, DateTime tanggal, string status, double bobot)
        {
            Id = id;
            Nama = nama;
            Tanggal = tanggal;
            Status = status;
            Bobot = bobot;
        }

        // Metode untuk mengambil riwayat transaksi dari database menggunakan DataWrapper
        public static DataTable GetRiwayatTransaksi()
        {
            // Query untuk mengambil data riwayat transaksi dengan logika status dan bobot
            string query = @"
                SELECT 
                    ri.id_riwayat, 
                    nb.nama_buah AS nama, 
                    ri.tanggal_transaksi, 
                    CASE 
                        WHEN ri.buah_terjual > 0 AND ri.buah_busuk = 0 THEN 'Terjual' 
                        WHEN ri.buah_busuk > 0 AND ri.buah_terjual = 0 THEN 'Busuk' 
                        ELSE 'Unknown' 
                    END AS status,
                    CASE 
                        WHEN ri.buah_terjual > 0 AND ri.buah_busuk = 0 THEN ri.buah_terjual 
                        WHEN ri.buah_busuk > 0 AND ri.buah_terjual = 0 THEN ri.buah_busuk 
                        ELSE 0 
                    END AS bobot
                FROM 
                    riwayat ri
                JOIN 
                    transaksi t ON ri.id_riwayat = t.id_riwayat
                JOIN 
                    produk p ON t.id_produk = p.id_produk
                JOIN 
                    nama_buah nb ON p.id_nama_buah = nb.id_nama_buah
                ";

            try
            {
                DataTable dataTable = DataWrapper.queryExecutor(query);
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        /*public static DataTable GetTransaksi()
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

            DataTable dataProduk = DataWrapper.queryExecutor(query);
            return dataProduk;
        }
*/
    }
}
