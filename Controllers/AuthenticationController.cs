using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cinnabarlab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger;
        }
        [HttpPost("Login")]
        public LoginResultModel Login()
        {
            _logger.LogInformation($"User TestUser logged in.");
            return new LoginResultModel{
                Success = true,
                Username = "TestUser"
            };
        }
    }
}
