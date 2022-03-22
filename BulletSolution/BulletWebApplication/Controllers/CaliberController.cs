using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BulletWebApplication.Controllers
{
    [Route("api/caliber")]
    [ApiController]
    public class CaliberController : ControllerBase, ICaliberService
    { 
      private readonly ILogger<ReloadController> _logger;
      private readonly ICaliberService _caliberService;
        
        public CaliberController(ILogger<ReloadController> logger, ICaliberService caliberService)
        {
        _logger = logger;
        _caliberService = caliberService;
        }
        
        [HttpGet]
        [Route("GetAll")]
        public Task<IEnumerable<Caliber>> GetAll()
        {
           return _caliberService.GetAll();
        }

        [HttpPost]
        [Route("GetAllByDiameter")]
        public Task<IEnumerable<Caliber>> GetAllByDiameter(Diameter diameter)
        {
            return _caliberService.GetAllByDiameter(diameter);
        }

        [HttpPost]
        [Route("Insert")]
        public Task<Guid> Insert([FromBody]Caliber caliber)
        {
            return _caliberService.Insert(caliber);
        }
    }
}
