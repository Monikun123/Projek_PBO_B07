using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Projek_PBO_B07.Core;

namespace Projek_PBO_B07.Context
{
    internal class PromosiContext : DataWrapper
    {
        private static string table = "promosi";
        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataPromosi = queryExecutor(query);
            return dataPromosi;
        }

    }
}
