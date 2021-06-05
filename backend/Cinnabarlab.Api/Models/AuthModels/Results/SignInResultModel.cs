using System.Collections.Generic;

namespace Cinnabarlab.Api.Models.AuthModels
{
    public class SignInResultModel
    {
        public string Token { get; set; }
        public bool Result { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
