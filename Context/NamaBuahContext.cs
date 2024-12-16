using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projek_PBO_B07.Core;

namespace Projek_PBO_B07.Context
{
    internal class NamaBuahContext : DataWrapper
    {
        private static string table = "nama_buah";
        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataNamabuah = queryExecutor(query);
            return dataNamabuah;
        }
    }
}
