using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200406142.Data.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                column: "TypeOfAnimal",
                value: "Cat");

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                column: "TypeOfAnimal",
                value: "Dog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                column: "TypeOfAnimal",
                value: null);

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                column: "TypeOfAnimal",
                value: null);
        }
    }
}
