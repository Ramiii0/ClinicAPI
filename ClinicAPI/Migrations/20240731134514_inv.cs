using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class inv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Investigation",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Investigation", "VisitDate" },
                values: new object[] { "[null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null]", new DateTime(2024, 7, 31, 16, 45, 13, 762, DateTimeKind.Local).AddTicks(8468) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Investigation",
                table: "Visits");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 7, 31, 16, 13, 44, 245, DateTimeKind.Local).AddTicks(8303));
        }
    }
}
