using Microsoft.EntityFrameworkCore.Migrations;

namespace Olimp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AWAY_HDP 0,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 0,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 0,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 0,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 0,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 0,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 0,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 0,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 1,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 1,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 1,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 1,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 1,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 1,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 2,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 2,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 2,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 2,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 2,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 2,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 2,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 2,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 3,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 3,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 3,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 3,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 3,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP 3,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP-0,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -0,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -0,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -0,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -0,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -0,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -1,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -1,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -1,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -1,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -2,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -2,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -2,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -2,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -2,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -2,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -3,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -3,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -3,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_HDP -3,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "AWAY_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "DRAWAWAY_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "DRAWAWAY_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "DRAW_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "DRAW_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOMEAWAY_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOMEAWAY_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOMEDRAW_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOMEDRAW_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 0,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 0,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 0,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 0,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 0,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 0,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 0,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 0,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 1,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 1,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 1,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 1,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 2,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 2,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 2,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 2,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 2,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 2,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 3,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 3,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 3,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP 3,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -0,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -0,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -0,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -0,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -0,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -0,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -1,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -1,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -1,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -1,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -1,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -1,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -2,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -2,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -2,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -2,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -2,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -2,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -2,75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -2,75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -3,0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -3,0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -3,25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -3,25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -3,5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_HDP -3,5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HOME_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_0_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_0_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_0_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_0_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_1_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_1_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_1_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_1_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_1_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_1_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_1_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_1_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_2_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_2_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_2_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_2_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_2_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_2_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_2_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_2_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_3_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_3_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_3_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_3_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_3_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_3_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_3_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_3_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_4_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_4_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_4_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_4_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_4_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1O_4_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_0_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_0_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_0_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_0_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_1_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_1_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_1_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_1_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_1_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_1_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_1_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_1_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_2_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_2_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_2_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_2_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_2_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_2_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_2_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_2_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_3_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_3_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_3_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_3_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_3_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_3_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_3_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_3_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_4_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_4_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_4_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_4_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_4_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T1U_4_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_0_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_0_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_0_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_0_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_1_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_1_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_1_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_1_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_1_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_1_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_1_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_1_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_2_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_2_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_2_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_2_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_2_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_2_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_2_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_2_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_3_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_3_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_3_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_3_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_3_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_3_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_3_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_3_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_4_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_4_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_4_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_4_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_4_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2O_4_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_0_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_0_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_0_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_0_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_1_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_1_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_1_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_1_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_1_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_1_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_1_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_1_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_2_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_2_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_2_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_2_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_2_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_2_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_2_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_2_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_3_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_3_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_3_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_3_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_3_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_3_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_3_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_3_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_4_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_4_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_4_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_4_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_4_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "T2U_4_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_0_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_0_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_0_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_0_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_1_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_1_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_1_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_1_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_1_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_1_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_1_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_1_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_2_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_2_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_2_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_2_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_2_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_2_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_2_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_2_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_3_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_3_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_3_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_3_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_3_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_3_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_3_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_3_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_4_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_4_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_4_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_4_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_4_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_4_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_4_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_4_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_5_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_5_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_5_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_5_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_5_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_5_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_5_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_5_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_6_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_6_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_6_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_6_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_6_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TO_6_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_0_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_0_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_0_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_0_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_1_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_1_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_1_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_1_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_1_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_1_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_1_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_1_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_2_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_2_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_2_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_2_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_2_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_2_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_2_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_2_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_3_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_3_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_3_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_3_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_3_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_3_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_3_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_3_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_4_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_4_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_4_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_4_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_4_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_4_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_4_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_4_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_5_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_5_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_5_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_5_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_5_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_5_5_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_5_75_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_5_75_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_6_0_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_6_0_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_6_25_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_6_25_disc",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_6_5_computed_",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "TU_6_5_disc",
                table: "Prices");

            migrationBuilder.RenameColumn(
                name: "HOME_HDP 2,5",
                table: "Prices",
                newName: "HOME_HDP_2_5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HOME_HDP_2_5",
                table: "Prices",
                newName: "HOME_HDP 2,5");

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 0,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 0,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 0,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 0,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 0,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 0,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 0,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 0,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 1,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 1,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 1,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 1,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 1,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 1,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 2,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 2,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 2,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 2,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 2,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 2,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 2,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 2,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 3,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 3,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 3,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 3,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 3,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP 3,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP-0,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -0,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -0,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -0,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -0,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -0,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -1,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -1,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -1,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -1,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -2,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -2,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -2,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -2,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -2,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -2,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -3,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -3,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -3,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_HDP -3,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AWAY_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DRAWAWAY_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DRAWAWAY_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DRAW_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DRAW_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOMEAWAY_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOMEAWAY_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOMEDRAW_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOMEDRAW_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 0,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 0,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 0,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 0,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 0,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 0,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 0,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 0,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 1,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 1,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 1,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 1,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 2,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 2,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 2,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 2,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 2,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 2,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 3,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 3,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 3,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP 3,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -0,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -0,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -0,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -0,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -0,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -0,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -1,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -1,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -1,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -1,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -1,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -1,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -2,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -2,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -2,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -2,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -2,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -2,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -2,75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -2,75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -3,0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -3,0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -3,25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -3,25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -3,5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_HDP -3,5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "HOME_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_0_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_0_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_0_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_0_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_1_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_1_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_1_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_1_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_1_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_1_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_1_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_1_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_2_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_2_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_2_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_2_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_2_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_2_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_2_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_2_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_3_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_3_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_3_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_3_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_3_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_3_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_3_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_3_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_4_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_4_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_4_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_4_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_4_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1O_4_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_0_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_0_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_0_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_0_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_1_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_1_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_1_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_1_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_1_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_1_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_1_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_1_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_2_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_2_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_2_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_2_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_2_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_2_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_2_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_2_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_3_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_3_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_3_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_3_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_3_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_3_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_3_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_3_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_4_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_4_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_4_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_4_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_4_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T1U_4_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_0_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_0_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_0_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_0_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_1_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_1_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_1_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_1_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_1_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_1_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_1_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_1_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_2_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_2_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_2_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_2_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_2_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_2_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_2_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_2_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_3_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_3_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_3_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_3_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_3_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_3_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_3_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_3_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_4_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_4_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_4_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_4_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_4_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2O_4_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_0_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_0_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_0_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_0_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_1_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_1_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_1_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_1_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_1_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_1_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_1_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_1_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_2_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_2_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_2_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_2_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_2_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_2_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_2_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_2_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_3_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_3_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_3_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_3_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_3_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_3_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_3_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_3_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_4_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_4_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_4_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_4_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_4_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "T2U_4_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_0_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_0_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_0_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_0_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_1_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_1_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_1_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_1_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_1_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_1_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_1_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_1_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_2_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_2_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_2_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_2_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_2_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_2_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_2_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_2_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_3_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_3_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_3_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_3_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_3_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_3_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_3_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_3_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_4_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_4_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_4_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_4_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_4_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_4_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_4_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_4_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_5_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_5_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_5_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_5_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_5_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_5_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_5_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_5_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_6_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_6_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_6_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_6_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_6_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TO_6_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_0_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_0_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_0_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_0_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_1_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_1_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_1_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_1_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_1_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_1_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_1_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_1_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_2_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_2_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_2_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_2_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_2_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_2_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_2_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_2_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_3_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_3_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_3_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_3_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_3_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_3_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_3_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_3_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_4_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_4_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_4_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_4_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_4_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_4_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_4_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_4_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_5_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_5_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_5_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_5_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_5_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_5_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_5_75_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_5_75_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_6_0_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_6_0_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_6_25_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_6_25_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_6_5_computed_",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TU_6_5_disc",
                table: "Prices",
                type: "decimal(18,7)",
                nullable: true);
        }
    }
}
