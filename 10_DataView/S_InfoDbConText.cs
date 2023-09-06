using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataView
{
   public class S_InfoDbConText:DbContext
    {
        public DbSet<S_Info> S_Info { set; get; }
        public DbSet<ProvinceInfo> ProvinceInfo { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString ="Server=localhost;Database=mydbs;Uid=root;Pwd=''";
            optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));

            }
    }
}
