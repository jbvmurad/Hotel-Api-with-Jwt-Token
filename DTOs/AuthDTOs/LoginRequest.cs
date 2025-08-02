using System.ComponentModel.DataAnnotations;

namespace PatikaTask.DTOs.AuthDTOs
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
