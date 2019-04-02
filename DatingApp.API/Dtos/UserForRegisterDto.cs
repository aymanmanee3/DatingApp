

using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [StringLength(6, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 6 characters")]
        public string Password { get; set; }
    }
}