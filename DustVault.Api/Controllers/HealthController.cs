using Microsoft.AspNetCore.Mvc;

namespace DustVault.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("API is healthy");
        }
    }
}
