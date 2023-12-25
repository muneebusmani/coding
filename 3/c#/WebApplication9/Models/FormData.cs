using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication9.Models
{
    public class FormData:Model
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Gender { get; set; } = null!;
    }
}
