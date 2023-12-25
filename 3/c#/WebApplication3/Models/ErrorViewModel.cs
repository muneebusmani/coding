namespace WebApplication3.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
}