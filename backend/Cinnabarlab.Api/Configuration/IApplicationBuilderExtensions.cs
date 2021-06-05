using Cinnabarlab.Data.Database.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cinnabarlab.Api.Configuration
{
    internal static class IApplicationBuilderExtensions
    {
        internal static void MigrateDatabases(this IApplicationBuilder app)
        {
            using (var context = app.ApplicationServices.GetRequiredService<IdentityContext>())
            {
                context.Database.Migrate(); //TODO: Find a cleaner solution for this -> Takes a ton of time upon application start
            }
        }
    }
}
