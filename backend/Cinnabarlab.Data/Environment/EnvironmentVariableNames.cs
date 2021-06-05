namespace Cinnabarlab.Data.Environment
{
    public static class EnvironmentVariableNames
    {
        //DATABASE
        public const string DatabaseUrl = "DATABASE_URL";
        public const string IdDatabaseUrl = "ID_DATABASE_URL";

        //JWT
        public const string JwtSecret = "JWT_SECRET";
        public const string JwtRequireExpirationTime = "JWT_REQUIRE_EXPIRATION_TIME";
        public const string JwtValidateAudience = "JWT_VALIDATE_AUDIENCE";
        public const string JwtValidateLifetime = "JWT_VALIDATE_LIFETIME";
        public const string JwtValidateIssuer = "JWT_VALIDATE_ISSUER";
        public const string JwtValidateIssuerSigningKey = "JWT_VALIDATE_ISSUER_SIGNING_KEY";
    }
}
