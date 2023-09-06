using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataView
{
   public class S_Info
    {
        [Key]
        public int ContactID { get; set; }
        public int ProvinceID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
