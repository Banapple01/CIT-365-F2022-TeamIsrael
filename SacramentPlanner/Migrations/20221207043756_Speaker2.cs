using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentPlanner.Migrations
{
    public partial class Speaker2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.AlterColumn<string>(
                name: "Speaker1",
                table: "Planner",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Speaker2",
                table: "Planner",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Speaker3",
                table: "Planner",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Topic1",
                table: "Planner",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Topic2",
                table: "Planner",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Topic3",
                table: "Planner",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speaker2",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Speaker3",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Topic1",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Topic2",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Topic3",
                table: "Planner");

            migrationBuilder.AlterColumn<string>(
                name: "Speaker1",
                table: "Planner",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlannerId = table.Column<int>(type: "int", nullable: true),
                    SpeakerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SpeakerSubject = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
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
    }
}
