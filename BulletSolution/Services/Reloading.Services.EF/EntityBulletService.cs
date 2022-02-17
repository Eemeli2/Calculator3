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
    public class EntityBulletService : IBulletService
    {
        public async Task<IEnumerable<Bullet>> GetAll()
        {
            using (var db = new ReloadingContext())
            {
                return await db.Bullets.ToListAsync();
            }
                
        }

        public async Task<IEnumerable<Bullet>> GetAllByDiameter(Diameter diameter)
        {
            using (var db = new ReloadingContext())
            {
                return db.Bullets.Where(b => diameter.Equals(b.Diameter));
            }

        }

        public async Task<Guid> Insert(Bullet bullet)
        {
            using (var db = new ReloadingContext())
            {
                var b = await db.Bullets.AddAsync(bullet);
                await db.SaveChangesAsync();
                return bullet.Id.Value;

            }

        }
    }
}
