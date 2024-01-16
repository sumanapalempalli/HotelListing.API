using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.ApiUser
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        
        [Required]
        [StringLength(15, ErrorMessage = "It requires minimum {1} to maximum {2} length password", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
