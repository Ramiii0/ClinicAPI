using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class invC21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Investigation", "VisitDate" },
                values: new object[] { "[1,231,32,32,34,65,30,450,10,20,120,46,90,70,860,80]", new DateTime(2024, 7, 31, 17, 32, 49, 905, DateTimeKind.Local).AddTicks(2628) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Investigation", "VisitDate" },
                values: new object[] { "[null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null]", new DateTime(2024, 7, 31, 17, 0, 2, 252, DateTimeKind.Local).AddTicks(4087) });
        }
    }
}
