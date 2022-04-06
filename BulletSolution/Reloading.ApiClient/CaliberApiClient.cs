using BulletLibrary;
using BulletLibrary.Interfaces;
using Reloading.ApiClient.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reloading.ApiClient
{
    public class CaliberApiClient : ICaliberService
    {
        private readonly string _host;

        public CaliberApiClient (string host)
        {
            _host = host;
        }
        public async Task<IEnumerable<Caliber>> GetAll()
        {
            return await $"{_host}/api/caliber/GetAll".Get<IEnumerable<Caliber>>();
        }

        public async Task<IEnumerable<Caliber>> GetAllByDiameter(Diameter diameter)
        {
            var response = await $"{_host}/api/caliber/GetAllByDiameter".Post(diameter);

            return await response.ReadResponse<IEnumerable<Caliber>>();
        }

        public async Task<Guid> Insert(Caliber caliber)
        {
            var response = await $"{_host}/api/caliber/Insert".Post(caliber);

            return await response.ReadResponse<Guid>();
        }
    }
}
