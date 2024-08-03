using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class invC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Investigations",
                table: "Visits");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 7, 31, 16, 57, 1, 786, DateTimeKind.Local).AddTicks(8981));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Investigations",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Investigations", "VisitDate" },
                values: new object[] { "Investigations Details", new DateTime(2024, 7, 31, 16, 45, 13, 762, DateTimeKind.Local).AddTicks(8468) });
        }
    }
}
