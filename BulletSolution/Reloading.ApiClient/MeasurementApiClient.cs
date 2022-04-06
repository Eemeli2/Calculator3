using BulletLibrary;
using BulletLibrary.Interfaces;
using Reloading.ApiClient.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reloading.ApiClient
{
    public class MeasurementApiClient : IMeasurementService
    {
        private readonly string _host;

        public MeasurementApiClient(string host)
        {
            _host = host;
        }
        public async Task<IEnumerable<Diameter>> GetAllDiameters()
        {
            return await $"{_host}api/diameter/GetAllDiameters".Get<IEnumerable<Diameter>>();
        }

        public async Task<IEnumerable<Mass>> GetAllMasses()
        {
            return await $"{_host}api/diameter/GetAllMasses".Get<IEnumerable<Mass>>();
        }

        public async Task<Guid> InsertDiameter(Diameter diameter)
        {
            var response = await $"{_host}api/diameter/InsertDiameter".Post(diameter);

            return await response.ReadResponse<Guid>();
        }

        public async Task<Guid> InsertMass(Mass mass)
        {
            var response = await $"{_host}/api/diameter/InsertMass".Post(mass);

            return await response.ReadResponse<Guid>();
        }
    }
}
