using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinnabarlab.Api.Models.AuthModels;
using Cinnabarlab.Api.Models.AuthModels.Requests;
using Cinnabarlab.Api.Models.AuthModels.Results;
using Cinnabarlab.Infrastructure.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Cinnabarlab.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AuthController : Controller
    {
        private ILogger _logger;
        private ICinnabarlabAuthenticationService _authService;

        public AuthController(ILogger<AuthController> logger, IServiceProvider services)
        {
            _logger = logger;
            _authService = services.GetRequiredService<ICinnabarlabAuthenticationService>();
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public async Task<IActionResult> SignUp([FromBody] SignUpRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _authService.SignUp(model.UserName, model.Email, model.Password);

            return result.Result
                ? Ok(new SignUpResultModel
                {
                    Result = result.Result,
                    Errors = result.Errors
                })
                : BadRequest(new SignUpResultModel
                {
                    Result = result.Result,
                    Errors = result.Errors
                });
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public async Task<IActionResult> SignIn([FromBody] SignInRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _authService.SignIn(model.UserName, model.Password);

            return result.Result
                ? Ok(new SignInResultModel
                {
                    Result = result.Result,
                    Token = result.Token,
                    Errors = result.Errors
                })
                : BadRequest(new SignInResultModel
                {
                    Result = result.Result,
                    Token = result.Token,
                    Errors = result.Errors
                });
        }
    }
}
