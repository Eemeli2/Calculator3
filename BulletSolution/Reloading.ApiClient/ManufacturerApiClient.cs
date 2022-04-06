using BulletLibrary;
using BulletLibrary.Interfaces;
using Reloading.ApiClient.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reloading.ApiClient
{
    public class ManufacturerApiClient : IManufacturerService
    {
        private readonly string _host;

        public ManufacturerApiClient (string host)
        {
            _host = host;
        }

        public async Task<IEnumerable<Manufacturer>> GetAll()
        {
            return await $"{_host}/api/manufacturer/GetAll".Get<IEnumerable<Manufacturer>>();
        }

        public async Task<Manufacturer> GetById(Guid manufacturerId)
        {
            return await $"{_host}/api/manufacturer/GetById".Get<Manufacturer>();
        }

        public async Task<Guid> Insert(Manufacturer manufacturer)
        {
           var response = await $"{_host}api/manufacturer".Post(manufacturer);

           return await response.ReadResponse<Guid>();
        }
    }
 }
