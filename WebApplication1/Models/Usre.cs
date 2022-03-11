using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Usre
    {
    }
    public class User
    {
        [Required]
        public string Username { get; set; }
        [MinLength(6,ErrorMessage = "Minimum 6 characters!")]
        public string Password { get; set; }
    }
}
