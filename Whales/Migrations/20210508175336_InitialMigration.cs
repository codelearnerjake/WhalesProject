using Microsoft.EntityFrameworkCore.Migrations;

namespace Whales.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Whales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageSize = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whales", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Whales",
                columns: new[] { "Id", "AverageSize", "Description", "Diet", "Name" },
                values: new object[] { 1, 79, "Blue whale is largest living mamamal on earth", 0, "Blue Whale" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Whales");
        }
    }
}
