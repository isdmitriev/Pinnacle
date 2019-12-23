using Microsoft.EntityFrameworkCore.Migrations;

namespace Olimp.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AWAY_HDP -1,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -1,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 1,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 1,5_disc",
                table: "Prices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -1,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -1,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 1,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 1,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);
        }
    }
}
