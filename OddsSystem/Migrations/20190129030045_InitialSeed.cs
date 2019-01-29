using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace OddsSystem.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SportEvents",
                columns: new[] { "EventName", "OddsForFirstTeam", "OddsForDraw", "OddsForSecondTeam", "EventStartDate" },
                values: new object[] { "LiverPool-Juventus", 1.15, 3.5, 4.2, new DateTime(2019, 2, 27, 10, 15, 5) });

            migrationBuilder.InsertData(
                table: "SportEvents",
                columns: new[] { "EventName", "OddsForFirstTeam", "OddsForDraw", "OddsForSecondTeam", "EventStartDate" },
                values: new object[] { "Grigor Dimitrov-Nadal", 1.25, 2.5, 3.2, new DateTime(2019, 2, 26, 10, 15, 5) });

            migrationBuilder.InsertData(
                table: "SportEvents",
                columns: new[] { "EventName", "OddsForFirstTeam", "OddsForDraw", "OddsForSecondTeam", "EventStartDate" },
                values: new object[] { "Barcelona-Juventus", 1.15, 3.5, 4.2, new DateTime(2019, 1, 25, 10, 25, 5) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
