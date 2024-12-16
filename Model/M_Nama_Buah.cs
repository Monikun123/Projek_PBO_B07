using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_PBO_B07.Model
{
    public class M_Nama_Buah
    {
        [Key]
        public int id_nama_buah { get; set; }
       [Required] 
       public int id_jenis_buah { get; set; }
        [Required]
        public string gambar {  get; set; }
        [Required]
        public string nama_buah { get; set; }
        [Required]
        public int harga {  get; set; }
    }
}
