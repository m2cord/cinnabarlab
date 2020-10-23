using Cinnabarlab.UI.Web.Models.Authentication;
using Cinnabarlab.Infrastructure.Authentication;
using Cinnabarlab.Infrastructure.Authentication.PasswordHasher;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cinnabarlab.UI.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly IPasswordHasher _passwordHasher;

        public AuthenticationController(ILogger<AuthenticationController> logger, IPasswordHasher passwordHasher)
        {
            _logger = logger;
            _passwordHasher = passwordHasher;
            _passwordHasher.Configure(new HashingOptions());
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

        [HttpPost("SignUp")]
        public SignUpResultModel SignUp(SignUpModel model)
        {
            var result = _passwordHasher.Check(_passwordHasher.Hash(model.Password), "password");

            if(!result.Verified){
                return new SignUpResultModel {
                    Success = true
                };
            }

            return new SignUpResultModel {
                Success = false
            };
        }
    }
}
