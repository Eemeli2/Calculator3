using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Reloading.Services.EF
{
    public class EntityManufacturerService : IManufacturerService
    {
        async Task<Manufacturer> IManufacturerService.GetById(Guid manufacturerId)
        {
            using (var db = new ReloadingContext())
            {
                return await db.Manufacturers.FirstOrDefaultAsync(m => manufacturerId.Equals(m.Id));
            }
        }

        async Task<IEnumerable<Manufacturer>> IManufacturerService.GetAll()
        {
            using (var db = new ReloadingContext())
            {
                return await db.Manufacturers.ToListAsync();
            }
        }

        public async Task<Guid> Insert(Manufacturer manufacturer)
        {
            using (var db = new ReloadingContext())
            {
                var m = await db.Manufacturers.AddAsync(manufacturer);
                await db.SaveChangesAsync();
                return manufacturer.Id.Value;
            }
        }
    }
}
