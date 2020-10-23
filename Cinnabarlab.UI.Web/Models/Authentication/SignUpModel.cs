using System.ComponentModel.DataAnnotations;

namespace Cinnabarlab.UI.Web.Models.Authentication
{
    public class SignUpModel
    {
        [StringLength(50)]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
    }
}