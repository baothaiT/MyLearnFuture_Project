using Microsoft.AspNetCore.Mvc;

namespace MyLearnFuture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeathController : Controller
    {
        private readonly ILogger<HeathController> _logger;
        public HeathController(ILogger<HeathController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GelAll()
        {
            return Ok("Heathy!");
        }
    }
}
