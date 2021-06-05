using Cinnabarlab.Data.Environment;
using System;

namespace Cinnabarlab.Infrastructure.Services.Authentication
{
    public class JwtConfig
    {
        public static string Secret => Environment.GetEnvironmentVariable(EnvironmentVariableNames.JwtSecret);
        public static bool RequireExpirationTime => bool.Parse(Environment.GetEnvironmentVariable(EnvironmentVariableNames.JwtRequireExpirationTime) ?? "false");
        public static bool ValidateAudience => bool.Parse(Environment.GetEnvironmentVariable(EnvironmentVariableNames.JwtValidateAudience) ?? "false");
        public static bool ValidateLifetime => bool.Parse(Environment.GetEnvironmentVariable(EnvironmentVariableNames.JwtValidateLifetime) ?? "true");
        public static bool ValidateIssuer => bool.Parse(Environment.GetEnvironmentVariable(EnvironmentVariableNames.JwtValidateIssuer) ?? "false");
        public static bool ValidateIssuerSigningKey => bool.Parse(Environment.GetEnvironmentVariable(EnvironmentVariableNames.JwtValidateIssuerSigningKey) ?? "true");
    }
}
