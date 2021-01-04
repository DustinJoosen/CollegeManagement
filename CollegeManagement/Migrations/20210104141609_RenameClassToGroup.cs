using Microsoft.EntityFrameworkCore.Migrations;

namespace CollegeManagement.Api.Migrations
{
    public partial class RenameClassToGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Buildings_BuildingId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Colleges_CollegeId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Employees_MentorId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.RenameTable(
                name: "Classes",
                newName: "Groups");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_MentorId",
                table: "Groups",
                newName: "IX_Groups_MentorId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_CollegeId",
                table: "Groups",
                newName: "IX_Groups_CollegeId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_BuildingId",
                table: "Groups",
                newName: "IX_Groups_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Buildings_BuildingId",
                table: "Groups",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Colleges_CollegeId",
                table: "Groups",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Employees_MentorId",
                table: "Groups",
                column: "MentorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Buildings_BuildingId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Colleges_CollegeId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Employees_MentorId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Classes");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "IX_Students_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_MentorId",
                table: "Classes",
                newName: "IX_Classes_MentorId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_CollegeId",
                table: "Classes",
                newName: "IX_Classes_CollegeId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_BuildingId",
                table: "Classes",
                newName: "IX_Classes_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Buildings_BuildingId",
                table: "Classes",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Colleges_CollegeId",
                table: "Classes",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Employees_MentorId",
                table: "Classes",
                column: "MentorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
