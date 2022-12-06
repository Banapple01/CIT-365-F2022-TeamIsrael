using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlannerDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Conducting = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Presiding = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    OpeningHymn = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SacramentHymn = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ClosingHymn = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IntermediateHymn = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SpeakerSubject = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PlannerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speaker_Planner_PlannerId",
                        column: x => x.PlannerId,
                        principalTable: "Planner",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_PlannerId",
                table: "Speaker",
                column: "PlannerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "Planner");
        }
    }
}
