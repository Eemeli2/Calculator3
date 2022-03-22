using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BulletWebApplication.Controllers
{
    [Route("api/bullet")]
    [ApiController]
    public class BulletController : ControllerBase, IBulletService
    {
        private readonly ILogger<ReloadController> _logger;
        private readonly IBulletService _bulletService;
        public BulletController(ILogger<ReloadController> logger, IBulletService bulletService)
        {
            _logger = logger;
            _bulletService = bulletService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<Bullet>> GetAll()
        {
            var bullets = await _bulletService.GetAll();
            

            return bullets;
        }

        [HttpPost]
        [Route("GetAllByDiameter")]
        public Task<IEnumerable<Bullet>> GetAllByDiameter(Diameter diameter)
        {
            return _bulletService.GetAllByDiameter(diameter);
        }

        [HttpPost]
        [Route("Insert")]
        public Task<Guid> Insert([FromBody] Bullet bullet)
        {
            return _bulletService.Insert(bullet);
        }
    }
}
