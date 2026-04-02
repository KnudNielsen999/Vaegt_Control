using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaegt_Control.Migrations
{
    /// <inheritdoc />
    public partial class ChangeMaaltidsTidspunktToTimeOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maalsaetninger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaalVaegtKg = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaaltidsTidspunkt = table.Column<TimeOnly>(type: "time", nullable: true),
                    VisceralFatMaal = table.Column<int>(type: "int", nullable: true),
                    BmiMaal = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maalsaetninger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeightEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeightKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VisceralFatRating = table.Column<int>(type: "int", nullable: true),
                    BMI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightEntries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maalsaetninger");

            migrationBuilder.DropTable(
                name: "WeightEntries");
        }
    }
}
