using System.ComponentModel.DataAnnotations;

namespace Blazor1.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(20)]
        public string Pseudo { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
