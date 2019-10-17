using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200406142.Data.Migrations
{
    public partial class SeedDataAndcreatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Food",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "AnimalId", "Description", "Name" },
                values: new object[] { 1, "Cats - incredibly cute creatures that successfully live both in houses and in the wild (instilling fear in any forest animals). And those cats who live in houses have their own slaves - people.", "Cats" });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "AnimalId", "Description", "Name" },
                values: new object[] { 2, "Dogs (doge) - animals devoted to man, ready to give their lives in order to protect the owner. But be sure, if you leave the dog at house alone, it will gobble up your Sweet Roll.", "Dogs" });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "AnimalId", "Brand", "Description", "Name", "NutritionalInformation", "Price", "TypeOfAnimal", "Weight" },
                values: new object[] { 1, 1, "TigerFood", "Gives your cat the power of Tiger!", "Real Hunter's Dinner", "Protein: 15. Fat: 5. Tiger Meat: 101%.", 12m, null, 400m });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "AnimalId", "Brand", "Description", "Name", "NutritionalInformation", "Price", "TypeOfAnimal", "Weight" },
                values: new object[] { 2, 2, "Wolfenstein", "The food, the secret of the recipe of which is kept in Germany, contains all the necessary elements for a healthy dog nutrition.", "Wolf Mittagessen", "Protein: 20, Fat: 10, Secret Ingridient B418/2918, Secret Ingridient 'Wolfenstein'", 30m, null, 1300m });

            migrationBuilder.CreateIndex(
                name: "IX_Food_AnimalId",
                table: "Food",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Animal_AnimalId",
                table: "Food",
                column: "AnimalId",
                principalTable: "Animal",
                principalColumn: "AnimalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Animal_AnimalId",
                table: "Food");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Food_AnimalId",
                table: "Food");

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Food");
        }
    }
}
