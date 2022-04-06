using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Reloading.Services.EF
{
    public class EntityBulletService : IBulletService
    {
        public async Task<IEnumerable<Bullet>> GetAll()
        {
            using (var db = new ReloadingContext())
            {
                return await db.Bullets.IncludeAll();
            }
        }

        public async Task<IEnumerable<Bullet>> GetAllByDiameter(Diameter diameter)
        {
            using var db = new ReloadingContext();
            
            return await db.Bullets.Where(b => diameter.Equals(b.Diameter)).IncludeAll();
        }

        public async Task<Guid> Insert(Bullet bullet)
        {
            using (var db = new ReloadingContext())
            {
                //if (bullet.Diameter!.Id.HasValue) bullet.Diameter = await db.Diameters.FirstAsync(d => d.Id!.Equals(bullet.Diameter.Id!));
                //if (bullet.Mass!.Id.HasValue) bullet.Mass = await db.Masses.FirstAsync(d => d.Id!.Equals(bullet.Mass.Id!));
                //if (bullet.Manufacturer!.Id.HasValue) bullet.Manufacturer = await db.Manufacturers.FirstAsync(d => d.Id!.Equals(bullet.Manufacturer.Id!));

                if (bullet.Diameter!.Id.HasValue) db.Diameters.Attach(bullet.Diameter!);
                if (bullet.Mass!.Id.HasValue) db.Masses.Attach(bullet.Mass!);
                if (bullet.Manufacturer!.Id.HasValue) db.Manufacturers.Attach(bullet.Manufacturer!);
              


                //db.Manufacturers.Attach(bullet.Manufacturer!);
                //db.Diameters.Attach(bullet.Diameter!);
                //db.Masses.Attach(bullet.Mass!);

                _ = await db.Bullets.AddAsync(bullet);
                await db.SaveChangesAsync();
                return bullet.Id.Value;
            }
        }
    }

    public static class EntityBulletServiceExtensions
    {
        public static Task<List<Bullet>> IncludeAll(this IQueryable<Bullet> bullets)
        {
            return bullets.Include(b => b.Manufacturer).Include(d => d.Diameter).Include(m => m.Mass).ToListAsync();
        }
    }
}
