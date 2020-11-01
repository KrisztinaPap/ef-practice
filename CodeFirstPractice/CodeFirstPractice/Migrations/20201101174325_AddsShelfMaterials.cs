using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class AddsShelfMaterials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "FK_Shelf_Material_Shelf",
                table: "shelf",
                column: "ShelfMaterialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelf_Material_Shelf",
                table: "shelf",
                column: "ShelfMaterialID",
                principalTable: "shelf_material",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelf_Material_Shelf",
                table: "shelf");

            migrationBuilder.DropIndex(
                name: "FK_Shelf_Material_Shelf",
                table: "shelf");
        }
    }
}
