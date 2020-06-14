using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademiaAvalanche.Migrations
{
    public partial class AvalancheGymv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Students",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Students");
        }
    }
}
