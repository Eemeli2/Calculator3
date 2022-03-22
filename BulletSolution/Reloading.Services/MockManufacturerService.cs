//using BulletLibrary;
//using BulletLibrary.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace Reloading.Services
//{
//    public class MockManufacturerService : IManufacturerService
//    {
//        readonly List<Manufacturer> _manufacturer = new List<Manufacturer>();

//        public async Task<IEnumerable<Manufacturer>> GetAll()
//        {
//            return await Task.FromResult(_manufacturer);
//        }

//        public async Task<Manufacturer> GetById(Guid manufacturerId)
//        {
//            var matches = _manufacturer.FirstOrDefault(m => manufacturerId.Equals(m.Id));
//            return await Task.FromResult(matches);
//        }

//        public async Task<Guid> Insert(Manufacturer manufacturer)
//        {
//            _manufacturer.Add(manufacturer);
//            manufacturer.Id = manufacturer.Id ?? Guid.NewGuid();

//            return await Task.FromResult(manufacturer.Id.Value);
//        }
//    }
//}

