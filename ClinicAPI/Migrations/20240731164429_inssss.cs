using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class inssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 7, 31, 19, 44, 29, 519, DateTimeKind.Local).AddTicks(6819));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 7, 31, 19, 23, 53, 860, DateTimeKind.Local).AddTicks(9712));
        }
    }
}
