using System.ComponentModel.DataAnnotations;

namespace TestApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(12, MinimumLength=6, ErrorMessage="Password must be between 6 and 12 characters")]
        public string Password { get; set; }
    }
}