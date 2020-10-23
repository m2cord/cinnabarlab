using System.Collections.Generic;

namespace Cinnabarlab.UI.Web.Models.Authentication
{
    public class SignUpResultModel
    {
        public bool Success { get; set; }
        public IList<string> FaultyFields { get; set; }
    }
}