using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JituCourses.Migrations
{
    /// <inheritdoc />
    public partial class seedCoursesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseDescription", "CourseName" },
                values: new object[] { 1, "C# is a programming language", "C#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);
        }
    }
}
