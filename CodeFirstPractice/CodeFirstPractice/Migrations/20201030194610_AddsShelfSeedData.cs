using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class AddsShelfSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shelf",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { -1, "Dairy" },
                    { -2, "Vegetables" },
                    { -3, "Candy" },
                    { -4, "Medicine" },
                    { -5, "Baked goods" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
