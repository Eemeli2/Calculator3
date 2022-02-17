using BulletLibrary;
using Microsoft.AspNetCore.Mvc;

namespace BulletWebApplication.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ReloadController : ControllerBase
    {

        private readonly ILogger<ReloadController> _logger;
        public ReloadController(ILogger<ReloadController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetBulletCaliber")]
        //public IEnumerable<Ammunition> Get()
        //{
        //    return Enumerable.Range(1, 8).Select(index => new Ammunition
        //    {
        //        Caliber = Calibers[Random.Shared.Next(Calibers.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
