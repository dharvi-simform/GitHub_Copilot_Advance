using System.ComponentModel.DataAnnotations;

namespace GitHub_Copilot_Advance.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
