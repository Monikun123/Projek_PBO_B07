using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_PBO_B07.Model
{
    internal class M_RiwayatTabel
    {
        [Key]
        public int id_riwayat { get; set; }
        [Required]
        public int jumlah_keluar { get; set; }
        [Required]
        public int buah_busuk { get; set; }
        [Required]
        public int buah_terjual { get; set; }
        [Required]
        public DateTime tanggal_transaksi { get; set; }

    }
}
