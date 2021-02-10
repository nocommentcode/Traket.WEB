using Spendings.WEB.Controllers;
using System.ComponentModel.DataAnnotations;

namespace Spendings.WEB.Models
{
    public class LoginVm
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Username { get; set; }
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

    public class RegisterLoginVm
    {
        public LoginVm Login { get; set; }
        public string LoginError { get; set; }
        public string RegisterError { get; set; }
        public string ReturnUrl { get; set; }

        public RegisterVm Register { get; set; }
    }
}