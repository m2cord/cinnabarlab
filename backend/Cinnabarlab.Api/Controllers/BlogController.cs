using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cinnabarlab.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogDebug("Get() called.");
            return Ok();
        }
    }
}
