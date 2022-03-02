using BulletLibrary;
using Microsoft.EntityFrameworkCore;

namespace Reloading.Services.EF
{
    internal class ReloadingContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Bullet> Bullets { get; set; }

        public DbSet<Diameter> Diameters { get; set; }  

        public DbSet<Mass> Masses { get; set; }

        public DbSet<Caliber> Calibers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=winterfell;Database=reload;Username=reloader;Password=reload");
        }
    }
}
