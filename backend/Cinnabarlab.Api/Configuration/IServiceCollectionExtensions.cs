using System.Text;
using Cinnabarlab.Data.Database.Identity;
using Cinnabarlab.Infrastructure.Services.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Cinnabarlab.Api.Configuration
{
    internal static class IServiceCollectionExtensions
    {
        internal static void ConfigureDatabaseServices(this IServiceCollection services)
        {
            services.AddDbContext<IdentityContext>(
                options => options.UseNpgsql(IdentityContextConfig.ConnectionString));
        }

        internal static void ConfigureAuthenticationServices(this IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(jwt => {
                    jwt.SaveToken = true;
                    jwt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = JwtConfig.ValidateIssuerSigningKey,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtConfig.Secret)),
                        ValidateIssuer = JwtConfig.ValidateIssuer,
                        ValidateAudience = JwtConfig.ValidateAudience,
                        RequireExpirationTime = JwtConfig.RequireExpirationTime,
                        ValidateLifetime = JwtConfig.ValidateLifetime
                    };
                });

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<IdentityContext>();
        }
    }
}
