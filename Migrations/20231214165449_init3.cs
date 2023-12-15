using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cqrs.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentDetails",
                table: "StudentDetails");

            migrationBuilder.RenameTable(
                name: "StudentDetails",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "StudentDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentDetails",
                table: "StudentDetails",
                column: "Id");
        }
    }
}
