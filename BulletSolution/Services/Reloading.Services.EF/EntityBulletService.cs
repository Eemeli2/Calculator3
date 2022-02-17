using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reloading.Services.EF
{
    public class EntityBulletService : DbContext, IBulletService
    {
        public DbSet<Bullet> Bullets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=winterfell;Database=reload;Username=reloader;Password=reload");
        }

        public Task<IEnumerable<Bullet>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bullet>> GetAllByDiameter(Diameter diameter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Bullet bullet)
        {
            throw new NotImplementedException();
        }
    }
}
