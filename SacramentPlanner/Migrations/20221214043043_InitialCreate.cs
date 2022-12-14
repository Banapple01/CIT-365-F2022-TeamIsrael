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
                    ClosingPrayer = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Speaker1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Speaker2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Speaker3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Topic1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Topic2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Topic3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planner");
        }
    }
}
