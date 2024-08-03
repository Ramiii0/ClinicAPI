using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class category124 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Treatments");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 8, 2, 16, 6, 45, 418, DateTimeKind.Local).AddTicks(6223));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Treatments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 8, 2, 16, 3, 44, 46, DateTimeKind.Local).AddTicks(11));
        }
    }
}
