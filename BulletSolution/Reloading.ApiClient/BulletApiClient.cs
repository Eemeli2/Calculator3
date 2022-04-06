using BulletLibrary;
using BulletLibrary.Interfaces;
using Reloading.ApiClient.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reloading.ApiClient
{
    public class BulletApiClient : IBulletService
    {
        private readonly string _host;


        public BulletApiClient(string host)
        {
            _host = host;
        }

        public async Task<IEnumerable<Bullet>> GetAll()
        {
            return await $"{_host}/api/bullet/getall".Get<IEnumerable<Bullet>>();
        }

        public async Task<IEnumerable<Bullet>> GetAllByDiameter(Diameter diameter)
        {
            var response = await $"{_host}/api/bullet/GetAllByDiameter".Post(diameter);

            return await response.ReadResponse<IEnumerable<Bullet>>();
        }

        public async Task<Guid> Insert(Bullet bullet)
        {
            var response = await $"{_host}/api/bullet/Insert".Post(bullet);

            return await response.ReadResponse<Guid>();
        }
    }
}