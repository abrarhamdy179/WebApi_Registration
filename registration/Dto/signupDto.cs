using System.ComponentModel.DataAnnotations;

namespace registration.Dto
{
    public class signupDto 
    {
        [MinLength(5)]
        [Required(ErrorMessage = "Username is required")]
        public string UserNameDto { get; set; }
        [EmailAddress]
        public string UserEmailDto { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string UserPasswordDto { get; set; }
        public string UserConfirmPasswodDto { get; set; }
    }
}
