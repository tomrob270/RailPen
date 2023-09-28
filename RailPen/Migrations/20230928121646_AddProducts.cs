using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RailPen.Migrations
{
    /// <inheritdoc />
    public partial class AddProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PensionReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    TargetRetirementAge = table.Column<int>(type: "int", nullable: false),
                    DateOfRetirement = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "DateOfBirth", "DateOfRetirement", "FirstName", "Gender", "LastName", "PensionReferenceNumber", "TargetRetirementAge" },
                values: new object[,]
                {
                    { 1, new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", 0, "Mccall", "P0000097", 60 },
                    { 2, new DateTime(1984, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2044, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah", 1, "Kramer", "PO000136", 60 },
                    { 3, new DateTime(1975, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2037, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lianne", 1, "Barrow", "P0004657", 62 },
                    { 4, new DateTime(1980, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2045, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", 0, "Richardson", "P0004701", 65 },
                    { 5, new DateTime(1992, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2057, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kara", 1, "Mccall", "P0004782", 65 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
