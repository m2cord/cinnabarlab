
namespace Cinnabarlab.Data.Database.Identity
{
    public class IdentityContextConfig
    {
        public static string ConnectionString => System.Environment.GetEnvironmentVariable(Environment.EnvironmentVariableNames.IdDatabaseUrl);
    }
}
