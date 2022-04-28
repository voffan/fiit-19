using Microsoft.EntityFrameworkCore.Migrations;

namespace SiliconValley.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patronymic",
                table: "Employees",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Employees",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Patronymic",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Employees");
        }
    }
}
