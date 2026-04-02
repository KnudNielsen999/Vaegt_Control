using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaegt_Control.Migrations
{
    /// <inheritdoc />
    public partial class AddMaalDatoToMaalsaetning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MaalDato",
                table: "Maalsaetninger",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaalDato",
                table: "Maalsaetninger");
        }
    }
}
