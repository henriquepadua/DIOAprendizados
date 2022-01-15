using API.DIO.Infra.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.DIO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var singleton = Singleton.Instance;

            return Ok(singleton);
        }
    }
}
