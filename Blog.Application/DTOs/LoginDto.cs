using System.ComponentModel.DataAnnotations;

namespace Blog.Application.DTOs
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}
