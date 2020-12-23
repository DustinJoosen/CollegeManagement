using Microsoft.EntityFrameworkCore.Migrations;

namespace CollegeManagement.Api.Migrations
{
    public partial class FixTeacherConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Employees_MentorId1",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeachers_Employees_TeacherId1",
                table: "StudentTeachers");

            migrationBuilder.DropIndex(
                name: "IX_StudentTeachers_TeacherId1",
                table: "StudentTeachers");

            migrationBuilder.DropIndex(
                name: "IX_Classes_MentorId1",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeacherId1",
                table: "StudentTeachers");

            migrationBuilder.DropColumn(
                name: "MentorId1",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId1",
                table: "StudentTeachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MentorId1",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeachers_TeacherId1",
                table: "StudentTeachers",
                column: "TeacherId1");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_MentorId1",
                table: "Classes",
                column: "MentorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Employees_MentorId1",
                table: "Classes",
                column: "MentorId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeachers_Employees_TeacherId1",
                table: "StudentTeachers",
                column: "TeacherId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
