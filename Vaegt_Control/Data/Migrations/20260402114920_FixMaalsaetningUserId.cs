using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaegt_Control.Migrations
{
    /// <inheritdoc />
    public partial class FixMaalsaetningUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Maalsaetninger",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Maalsaetninger",
                newName: "UserName");
        }
    }
}
