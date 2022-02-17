using BulletLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloading.Services.EF
{
    internal class ReloadingContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=winterfell;Database=reload;Username=reloader;Password=reload");
        }
    }
}
