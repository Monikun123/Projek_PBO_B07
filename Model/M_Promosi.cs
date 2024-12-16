using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_PBO_B07.Model
{
    public class M_Promosi
    {
        [Key]
        public int id_promosi { get; set; }
        [Required]
        public int diskon { get; set; }
    }
}
