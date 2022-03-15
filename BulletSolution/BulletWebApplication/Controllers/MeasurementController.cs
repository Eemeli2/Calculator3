using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BulletWebApplication.Controllers
{
    [Route("api/diameter")]
    [ApiController]

    public class MeasurementController : ControllerBase, IMeasurementService
    {
        private readonly ILogger<ReloadController> _logger;
        private readonly IMeasurementService _measurementService;

        public MeasurementController(ILogger<ReloadController> logger, IMeasurementService measurementService)
        {
            _logger = logger;
            _measurementService = measurementService;
        }

        [HttpGet]
        [Route("GetAllDiameters")]
        public Task<IEnumerable<Diameter>> GetAllDiameters()
        {
            return  _measurementService.GetAllDiameters();
        }

        [HttpGet]
        [Route("GetAllMasses")]
        public Task<IEnumerable<Mass>> GetAllMasses()
        {
            return _measurementService.GetAllMasses();
        }

        [HttpGet]
        [Route("InsertDiameter")]
        public Task<Guid> InsertDiameter([FromBody]Diameter diameter)
        {
            return _measurementService.InsertDiameter(diameter);
        }

        [HttpGet]
        [Route("InsertMass")]
        public Task<Guid> InsertMass([FromBody]Mass mass)
        {
            return _measurementService.InsertMass(mass);
        }
    }
}