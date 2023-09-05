using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ListViewExample
{

    // Note refer to using Microsoft.EntityFrameworkCore;
    public class TestDbConText : DbContext
    {
        public DbSet<S_Info> S_info { get; set; }
        public string DbPath { get; }
        public TestDbConText()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "mydbs.db");

        }

        
    } 
}
