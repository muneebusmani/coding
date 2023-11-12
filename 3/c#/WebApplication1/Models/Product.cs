using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {
        [DisplayName("Id:")]
        [Key]
        public int ProductId{ get; set; }
        [MaxLength(25)]
        [Required]
        public required string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public required string Description { get; set; }

        [MaxLength(15)]
        [Required]
        public required string Type { get; set; }

        [MaxLength(200)]
        [DisplayName("Comments(optional)")]
        public string? Comments { get; set; }
    }
}
