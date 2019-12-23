using Microsoft.EntityFrameworkCore.Migrations;

namespace PinnacleClasses.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-3,5_disc",
                table: "Prices",
                newName: "AWAY_HDP -3,5_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-3,5_computed_",
                table: "Prices",
                newName: "AWAY_HDP -3,5_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-3,5",
                table: "Prices",
                newName: "AWAY_HDP -3,5");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-3,0_disc",
                table: "Prices",
                newName: "AWAY_HDP -3,0_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-3,0_computed_",
                table: "Prices",
                newName: "AWAY_HDP -3,0_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-3,0",
                table: "Prices",
                newName: "AWAY_HDP -3,0");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,75_disc",
                table: "Prices",
                newName: "AWAY_HDP -2,75_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,75_computed_",
                table: "Prices",
                newName: "AWAY_HDP -2,75_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,75",
                table: "Prices",
                newName: "AWAY_HDP -2,75");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,5_disc",
                table: "Prices",
                newName: "AWAY_HDP -2,5_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,5_computed_",
                table: "Prices",
                newName: "AWAY_HDP -2,5_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,5",
                table: "Prices",
                newName: "AWAY_HDP -2,5");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,0_disc",
                table: "Prices",
                newName: "AWAY_HDP -2,0_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,0_computed_",
                table: "Prices",
                newName: "AWAY_HDP -2,0_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-2,0",
                table: "Prices",
                newName: "AWAY_HDP -2,0");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,75_disc",
                table: "Prices",
                newName: "AWAY_HDP -1,75_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,75_computed_",
                table: "Prices",
                newName: "AWAY_HDP -1,75_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,75",
                table: "Prices",
                newName: "AWAY_HDP -1,75");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,5_disc",
                table: "Prices",
                newName: "AWAY_HDP -1,5_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,5_computed_",
                table: "Prices",
                newName: "AWAY_HDP -1,5_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,5",
                table: "Prices",
                newName: "AWAY_HDP -1,5");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,0_disc",
                table: "Prices",
                newName: "AWAY_HDP -1,0_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,0_computed_",
                table: "Prices",
                newName: "AWAY_HDP -1,0_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-1,0",
                table: "Prices",
                newName: "AWAY_HDP -1,0");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-0,75_disc",
                table: "Prices",
                newName: "AWAY_HDP -0,75_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-0,75_computed_",
                table: "Prices",
                newName: "AWAY_HDP -0,75_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-0,75",
                table: "Prices",
                newName: "AWAY_HDP -0,75");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-0,5_disc",
                table: "Prices",
                newName: "AWAY_HDP -0,5_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-0,5_computed_",
                table: "Prices",
                newName: "AWAY_HDP -0,5_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-0,5",
                table: "Prices",
                newName: "AWAY_HDP -0,5");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-0,25_disc",
                table: "Prices",
                newName: "AWAY_HDP -0,25_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP-0,25",
                table: "Prices",
                newName: "AWAY_HDP -0,25");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -3,5_disc",
                table: "Prices",
                newName: "AWAY_HDP-3,5_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -3,5_computed_",
                table: "Prices",
                newName: "AWAY_HDP-3,5_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -3,5",
                table: "Prices",
                newName: "AWAY_HDP-3,5");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -3,0_disc",
                table: "Prices",
                newName: "AWAY_HDP-3,0_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -3,0_computed_",
                table: "Prices",
                newName: "AWAY_HDP-3,0_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -3,0",
                table: "Prices",
                newName: "AWAY_HDP-3,0");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,75_disc",
                table: "Prices",
                newName: "AWAY_HDP-2,75_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,75_computed_",
                table: "Prices",
                newName: "AWAY_HDP-2,75_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,75",
                table: "Prices",
                newName: "AWAY_HDP-2,75");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,5_disc",
                table: "Prices",
                newName: "AWAY_HDP-2,5_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,5_computed_",
                table: "Prices",
                newName: "AWAY_HDP-2,5_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,5",
                table: "Prices",
                newName: "AWAY_HDP-2,5");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,0_disc",
                table: "Prices",
                newName: "AWAY_HDP-2,0_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,0_computed_",
                table: "Prices",
                newName: "AWAY_HDP-2,0_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -2,0",
                table: "Prices",
                newName: "AWAY_HDP-2,0");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,75_disc",
                table: "Prices",
                newName: "AWAY_HDP-1,75_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,75_computed_",
                table: "Prices",
                newName: "AWAY_HDP-1,75_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,75",
                table: "Prices",
                newName: "AWAY_HDP-1,75");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,5_disc",
                table: "Prices",
                newName: "AWAY_HDP-1,5_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,5_computed_",
                table: "Prices",
                newName: "AWAY_HDP-1,5_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,5",
                table: "Prices",
                newName: "AWAY_HDP-1,5");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,0_disc",
                table: "Prices",
                newName: "AWAY_HDP-1,0_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,0_computed_",
                table: "Prices",
                newName: "AWAY_HDP-1,0_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -1,0",
                table: "Prices",
                newName: "AWAY_HDP-1,0");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -0,75_disc",
                table: "Prices",
                newName: "AWAY_HDP-0,75_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -0,75_computed_",
                table: "Prices",
                newName: "AWAY_HDP-0,75_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -0,75",
                table: "Prices",
                newName: "AWAY_HDP-0,75");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -0,5_disc",
                table: "Prices",
                newName: "AWAY_HDP-0,5_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -0,5_computed_",
                table: "Prices",
                newName: "AWAY_HDP-0,5_computed_");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -0,5",
                table: "Prices",
                newName: "AWAY_HDP-0,5");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -0,25_disc",
                table: "Prices",
                newName: "AWAY_HDP-0,25_disc");

            migrationBuilder.RenameColumn(
                name: "AWAY_HDP -0,25",
                table: "Prices",
                newName: "AWAY_HDP-0,25");
        }
    }
}
