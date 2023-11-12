using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class seedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Comments", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Sample Comment 1", "Sample Description 1", "Sample Product 1", "Sample type 1" },
                    { 2, "Sample Comment 2", "Sample Description 2", "Sample Product 2", "Sample type 2" },
                    { 3, "Sample Comment 3", "Sample Description 3", "Sample Product 3", "Sample type 3" },
                    { 4, "Sample Comment 4", "Sample Description 4", "Sample Product 4", "Sample type 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
