using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentPlanner.Migrations
{
    public partial class Speaker1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Speaker1",
                table: "Planner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speaker1",
                table: "Planner");
        }
    }
}
