using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class AddsNewShelfSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -3,
                column: "ShelfMaterialID",
                value: -3);

            migrationBuilder.UpdateData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -2,
                column: "ShelfMaterialID",
                value: -2);

            migrationBuilder.InsertData(
                table: "shelf",
                columns: new[] { "ID", "Name", "ShelfMaterialID" },
                values: new object[,]
                {
                    { -6, "Pet food", -1 },
                    { -7, "Ornaments", -3 },
                    { -8, "Tools", -1 },
                    { -9, "Cleaning supplies", -3 },
                    { -10, "Clothing", -2 },
                    { -11, "Baked goods", -1 }
                });

            migrationBuilder.UpdateData(
                table: "shelf_material",
                keyColumn: "ID",
                keyValue: -3,
                column: "MaterialName",
                value: "birch");

            migrationBuilder.UpdateData(
                table: "shelf_material",
                keyColumn: "ID",
                keyValue: -2,
                column: "MaterialName",
                value: "spruce");

            migrationBuilder.UpdateData(
                table: "shelf_material",
                keyColumn: "ID",
                keyValue: -1,
                column: "MaterialName",
                value: "oak");

            migrationBuilder.InsertData(
                table: "shelf_material",
                columns: new[] { "ID", "MaterialName" },
                values: new object[] { -4, "acacia" });

            migrationBuilder.UpdateData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -5,
                columns: new[] { "Name", "ShelfMaterialID" },
                values: new object[] { "Toys", -4 });

            migrationBuilder.UpdateData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -4,
                column: "ShelfMaterialID",
                value: -4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "shelf_material",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.UpdateData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -3,
                column: "ShelfMaterialID",
                value: -1);

            migrationBuilder.UpdateData(
                table: "shelf",
                keyColumn: "ID",
                keyValue: -2,
                column: "ShelfMaterialID",
                value: -1);

            migrationBuilder.InsertData(
                table: "shelf",
                columns: new[] { "ID", "Name", "ShelfMaterialID" },
                values: new object[,]
                {
                    { -5, "Baked goods", -1 },
                    { -4, "Medicine", -1 }
                });

            migrationBuilder.UpdateData(
                table: "shelf_material",
                keyColumn: "ID",
                keyValue: -3,
                column: "MaterialName",
                value: "yogurt");

            migrationBuilder.UpdateData(
                table: "shelf_material",
                keyColumn: "ID",
                keyValue: -2,
                column: "MaterialName",
                value: "Chocolate");

            migrationBuilder.UpdateData(
                table: "shelf_material",
                keyColumn: "ID",
                keyValue: -1,
                column: "MaterialName",
                value: "Milk");
        }
    }
}
