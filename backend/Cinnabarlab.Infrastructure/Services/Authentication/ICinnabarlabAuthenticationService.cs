using System.Threading.Tasks;
using Cinnabarlab.Infrastructure.Models.Authentication;

namespace Cinnabarlab.Infrastructure.Services.Authentication
{
    public interface ICinnabarlabAuthenticationService
    {
        Task<CinnabarlabSignInResult> SignIn(string userName, string password);
        Task<CinnabarlabSignUpResult> SignUp(string userName, string email, string password);
    }
}
