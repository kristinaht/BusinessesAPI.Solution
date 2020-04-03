using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessesApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Italian Restaurant", "Piazza Italia" },
                    { 2, "Department store", "Nordstrom" },
                    { 3, "Grocery store", "New Seasons" },
                    { 4, "Caffee", "Umbria" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);
        }
    }
}
