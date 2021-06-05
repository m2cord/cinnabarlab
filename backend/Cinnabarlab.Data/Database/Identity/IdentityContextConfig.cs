
namespace Cinnabarlab.Data.Database.Identity
{
    public static class IdentityContextConfig
    {
        private static readonly string EnvConnectionString =
            System.Environment.GetEnvironmentVariable(Environment.EnvironmentVariableNames.IdDatabaseUrl);

        public static string ConnectionString => EnvConnectionString ?? "host=database_id;port=5432;database=cinnabarlab_id;username=cinnabarlab_id;password=cinnabarlab_id;";
    }
}
