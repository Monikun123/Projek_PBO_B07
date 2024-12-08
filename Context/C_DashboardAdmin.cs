using System;
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

            
            DataTable dataTotalBuahBusuk = queryExecutor(query, parameters);

            
            if (dataTotalBuahBusuk.Rows.Count > 0)
            {
               
                return Convert.ToInt32(dataTotalBuahBusuk.Rows[0]["total_busuk"]);
            }

           
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

           
            DataTable dataTotalBuahBusuk = queryExecutor(query, parameters);

            
            if (dataTotalBuahBusuk.Rows.Count > 0)
            {
               
                return Convert.ToInt32(dataTotalBuahBusuk.Rows[0]["buah_terjual"]);
            }

           
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

            
            DataTable dataStok = queryExecutor(query, parameters);

           
            if (dataStok.Rows.Count > 0)
            {
                
                return Convert.ToInt32(dataStok.Rows[0]["total_stok"]);
            }

            
            return 0;
        }
    }
}
