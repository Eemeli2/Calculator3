using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloading.Services.EF
{
    public class EntityMeasurementService : IMeasurementService
    {
        public async Task<IEnumerable<Diameter>> GetAllDiameters()
        {
            using (var db = new ReloadingContext())
            {
                return await db.Diameters.ToListAsync();
            }
        }

        public async Task<IEnumerable<Mass>> GetAllMasses()
        {
            using (var db = new ReloadingContext())
            {
                return await db.Masses.ToListAsync();
            }
        }

        public async Task<Guid> InsertDiameter(Diameter diameter)
        {
            using (var db = new ReloadingContext())
            {
                var b = await db.Diameters.AddAsync(diameter);
                await db.SaveChangesAsync();
                return diameter.Id.Value;
            }
        }

        public async Task<Guid> InsertMass(Mass mass)
        {
            using (var db = new ReloadingContext())
            {
                var b = await db.Masses.AddAsync(mass);
                await db.SaveChangesAsync();
                return mass.Id.Value;
            }
        }
    }
}
