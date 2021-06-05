using System.Collections.Generic;

namespace Cinnabarlab.Api.Models.AuthModels.Results
{
    public class SignUpResultModel
    {
        public bool Result { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
