using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200406142.Data.Migrations
{
    public partial class Vasya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "Food",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Food",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
