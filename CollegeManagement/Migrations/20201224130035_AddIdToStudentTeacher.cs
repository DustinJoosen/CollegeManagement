using Microsoft.EntityFrameworkCore.Migrations;

namespace CollegeManagement.Api.Migrations
{
    public partial class AddIdToStudentTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentTeachers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTeachers",
                table: "StudentTeachers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTeachers",
                table: "StudentTeachers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentTeachers");
        }
    }
}
