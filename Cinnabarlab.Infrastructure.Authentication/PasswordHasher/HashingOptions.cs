using Cinnabarlab.Infrastructure.DependencyInjection;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Cinnabarlab.Infrastructure.Authentication.PasswordHasher
{
    public sealed class HashingOptions : ICinnabarlabServiceConfiguration
    {
        public int Iterations { get; set; } = 10000;
        public KeyDerivationPrf Prf { get; set; } = KeyDerivationPrf.HMACSHA512;
    }
}