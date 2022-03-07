using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Reloading.Services.EF
{
    public class EntityCaliberService : ICaliberService
    {
        public async Task<IEnumerable<Caliber>> GetAll()
        {
            using (var db = new ReloadingContext())
            {
                return await db.Calibers.ToListAsync();
            }
        }

        public async Task<IEnumerable<Caliber>> GetAllByDiameter(Diameter diameter)
        {
            using (var db = new ReloadingContext())
            {
                return db.Calibers.Where(b => diameter.Equals(b.Diameter));
            }

        }

        public async Task<Guid> Insert(Caliber caliber)
        {
            using (var db = new ReloadingContext())
            {

                if (caliber.Diameter!.Id.HasValue) db.Diameters.Attach(caliber.Diameter!);
               



                var c = await db.Calibers.AddAsync(caliber);
               await db.SaveChangesAsync();
               return caliber.Id.Value;
            }
        }
    }
}
