using Cinnabarlab.Infrastructure.DependencyInjection;

namespace Cinnabarlab.Infrastructure.Authentication
{
    public interface IPasswordHasher : ICinnabarlabService
    {
        byte[] Hash(string password);
        
        (bool Verified, bool NeedsUpgrade) Check(byte[] hash, string password);
    }
}