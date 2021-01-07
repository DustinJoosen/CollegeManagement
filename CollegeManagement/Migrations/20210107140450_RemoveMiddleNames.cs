using Microsoft.EntityFrameworkCore.Migrations;

namespace CollegeManagement.Api.Migrations
{
    public partial class RemoveMiddleNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Middlename",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Middlename",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Middlename",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Middlename",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
