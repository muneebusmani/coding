using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class TemplateTb
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string? Username { get; set; } = "";

        [Required]
        public required string? Email { get; set; } = "";

        [Required]
        [DisplayName("Phone Number")]
        public required string? PhoneNumber { get; set; } = "";

        [Required]
        public required string? Password { get; set; } = "";
    }
}
