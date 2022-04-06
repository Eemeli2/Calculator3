using BulletLibrary;
using BulletLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloading.Services
{
    public class MockBulletService : IBulletService
    {
        readonly List<Bullet> _bullets = new List<Bullet>();

        public async Task<IEnumerable<Bullet>> GetAll()
        {
            return await Task.FromResult(_bullets);
        }

        public async Task<IEnumerable<Bullet>> GetAllByDiameter(Diameter diameter)
        {
            var matches = _bullets.Where(b => diameter.Equals(b.Diameter));
            return await Task.FromResult(matches);
        }

        public async Task<Guid> Insert(Bullet bullet)
        {
            _bullets.Add(bullet);
            bullet.Id = bullet.Id ?? Guid.NewGuid();

            return await Task.FromResult(bullet.Id.Value);
        }
    }
}
