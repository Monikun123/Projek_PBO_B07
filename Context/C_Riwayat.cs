using Projek_PBO_B07.Model;
using Projek_PBO_B07.Core;
using System;
using System.Data;
using Npgsql;

namespace Projek_PBO_B07.Controller
{
    public class C_Riwayat
    {
        private M_Riwayat model;

        public C_Riwayat()
        {
            model = new M_Riwayat(0, "", DateTime.Now, "", 0);
        }

        
        public DataTable GetRiwayatTransaksi()
        {
            return M_Riwayat.GetRiwayatTransaksi(); 
        }
    }
}
