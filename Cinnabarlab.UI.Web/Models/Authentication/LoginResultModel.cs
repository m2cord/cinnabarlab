using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace Cinnabarlab.UI.Web.Models.Authentication
{
    public class LoginResultModel {
        private string _username;
        public bool Success { get; set; }
        public IList<string> FaultyFields { get; set; }
        public string Username {
            get
            {
                return HtmlEncoder.Default.Encode(_username);
            }
            set
            {
                _username = value;
            }
        }
    }
}