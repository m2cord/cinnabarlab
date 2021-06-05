using System.Collections.Generic;

namespace Cinnabarlab.Infrastructure.Models.Authentication
{
    public class CinnabarlabSignUpResult
    {
        public bool Result { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
