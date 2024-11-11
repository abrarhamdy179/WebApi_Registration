using System.ComponentModel.DataAnnotations;

namespace registration.Dto
{
    public class loginDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserNameDto { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string UserPasswordDto { get; set; }
    }
}
