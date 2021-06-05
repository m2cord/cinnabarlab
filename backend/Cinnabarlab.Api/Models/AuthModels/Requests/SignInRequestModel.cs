
using System.ComponentModel.DataAnnotations;

namespace Cinnabarlab.Api.Models.AuthModels.Requests
{
    public class SignInRequestModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
