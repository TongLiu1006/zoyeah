using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataView
{
    public class ProvinceInfo
    {
        [Key]
        public int ProvinceID { get; set; }

        [Column(TypeName ="varchar(255)")]
        public string? ProvinceName { get; set; } 
    }
}
