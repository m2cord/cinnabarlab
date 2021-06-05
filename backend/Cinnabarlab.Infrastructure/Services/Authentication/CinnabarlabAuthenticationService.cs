using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Cinnabarlab.Infrastructure.Models.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace Cinnabarlab.Infrastructure.Services.Authentication
{
    public class CinnabarlabAuthenticationService : ICinnabarlabAuthenticationService
    {
        private UserManager<IdentityUser> _userManager;

        public CinnabarlabAuthenticationService(IServiceProvider services)
        {
            _userManager = services.GetRequiredService<UserManager<IdentityUser>>();
        }

        public async Task<CinnabarlabSignInResult> SignIn(string userName, string password)
        {
            var existingUser = await _userManager.FindByNameAsync(userName);

            if (existingUser == null)
            {
                return new CinnabarlabSignInResult
                {
                    Result = false,
                    Token = string.Empty,
                    Errors = new List<string>
                    {
                        "Invalid Credentials provided"
                    }
                };
            }

            var pwCorrect = await _userManager.CheckPasswordAsync(existingUser, password);

            if (!pwCorrect)
            {
                return new CinnabarlabSignInResult
                {
                    Result = false,
                    Token = string.Empty,
                    Errors = new List<string>
                    {
                        "Invalid Credentials provided"
                    }
                };
            }

            var token = GenerateJwtToken(existingUser);
            return new CinnabarlabSignInResult
            {
                Result = true,
                Token = token,
                Errors = new List<string>()
            };
        }

        public async Task<CinnabarlabSignUpResult> SignUp(string username, string email, string password)
        {
            var existingUser = await _userManager.FindByEmailAsync(email);
            existingUser = await _userManager.FindByNameAsync(username);
            if (existingUser != null)
            {
                return new CinnabarlabSignUpResult
                {
                    Result = false,
                    Errors = new List<string>()
                    {
                        "Either your email or your username is already in use" //TODO: Translatable
                    }
                };
            }

            var newUser = new IdentityUser
            {
                Email = email,
                UserName = username,

            };
            var isCreated = await _userManager.CreateAsync(newUser, password);
            if (!isCreated.Succeeded)
            {
                return new CinnabarlabSignUpResult
                {
                    Result = false,
                    Errors = isCreated.Errors.Select(errors => errors.Description).ToList()
                };
            }

            return new CinnabarlabSignUpResult
            {
                Result = true,
                Errors = new List<string>()
            };
        }

        private string GenerateJwtToken(IdentityUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(JwtConfig.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(12),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
