using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _09_ListViewExample
{
   public class S_Info
    {


            [Key]
            public int ContactID { get; set; }
        
            public string?   FirstName { get; set; }
            public string?   LastName { get; set; }
            public string?   EmailAddress { get; set; }


        
    }
}
