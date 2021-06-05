using Cinnabarlab.Data.Database.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cinnabarlab.Data.Migrations.Helpers
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<IdentityContext>
    {
        public IdentityContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<IdentityContext>();
            builder.UseNpgsql(IdentityContextConfig.ConnectionString);
            return new IdentityContext(builder.Options);
        }
    }
}
