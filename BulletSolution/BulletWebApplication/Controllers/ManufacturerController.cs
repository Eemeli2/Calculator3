using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BulletWebApplication.Controllers
{
    [Route("api/manufacturer")]
    [ApiController]
    public class ManufacturerController : ControllerBase, IManufacturerService
    {
        private readonly ILogger<ReloadController> _logger;
        private readonly IManufacturerService _manufacturerService;
        public ManufacturerController(ILogger<ReloadController> logger, IManufacturerService manufacturerService)
        {
            _logger = logger;
            _manufacturerService = manufacturerService;
        }

        [HttpGet]
        [Route("getall")]
        public Task<IEnumerable<Manufacturer>> GetAll()
        {
            return _manufacturerService.GetAll();
        }

        [HttpGet]
        [Route("GetById")]

        public Task<Manufacturer> GetById(Guid manufacturerId)
        {
            return _manufacturerService.GetById(manufacturerId);
        }

        [HttpPost]
        [Route("Insert")]
        public Task<Guid> Insert([FromBody] Manufacturer manufacturer)
        {
            return _manufacturerService.Insert(manufacturer);
        }
    }
}
