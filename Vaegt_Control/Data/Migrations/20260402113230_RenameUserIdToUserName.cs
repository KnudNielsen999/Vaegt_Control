using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaegt_Control.Migrations
{
    /// <inheritdoc />
    public partial class RenameUserIdToUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Maalsaetninger",
                newName: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Maalsaetninger",
                newName: "UserId");
        }
    }
}
