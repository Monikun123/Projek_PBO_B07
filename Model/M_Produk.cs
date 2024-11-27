using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_PBO_B07.Model
{
    public class M_Produk
    {
        [Key]
        public int id_produk { get; set; }
        [ForeignKey("M_Promosi")]
        public int id_promosi { get; set; }
        [ForeignKey("M_User")]
        public int id_pengguna { get; set; }
        [ForeignKey("M_Nama_Buah")]
        public int id_nama_buah {  get; set; }
        [Required]
        public DateOnly tanggal_masuk {  get; set; }
        [Required]
        public DateOnly tanggal_expired {  get; set; }
        [Required]
        public int stok {  get; set; }
    }
}
