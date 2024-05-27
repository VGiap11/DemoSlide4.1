using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoSlide4.Migrations
{
    /// <inheritdoc />
    public partial class demoslide41 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Employesses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employesses",
                table: "Employesses",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employesses",
                table: "Employesses");

            migrationBuilder.RenameTable(
                name: "Employesses",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }
    }
}
