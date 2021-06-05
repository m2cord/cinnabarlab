using System.Collections.Generic;

namespace Cinnabarlab.Infrastructure.Models.Authentication
{
    public class CinnabarlabSignInResult
    {
        public bool Result { get; set; }
        public string Token { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
