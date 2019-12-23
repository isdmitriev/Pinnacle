using Microsoft.EntityFrameworkCore.Migrations;

namespace Olimp.Migrations
{
    public partial class Full_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Prices",
                table: "Prices");

            migrationBuilder.RenameTable(
                name: "Prices",
                newName: "OlimpPrices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OlimpPrices",
                table: "OlimpPrices",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OlimpPrices",
                table: "OlimpPrices");

            migrationBuilder.RenameTable(
                name: "OlimpPrices",
                newName: "Prices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prices",
                table: "Prices",
                column: "Id");
        }
    }
}
