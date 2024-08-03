using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class removeenum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Treatments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 8, 2, 17, 10, 52, 821, DateTimeKind.Local).AddTicks(4767));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Treatments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Category", "Dose", "Drug", "Duration", "Frequency", "PatientId", "Root", "SubCategory", "Time", "VisitId" },
                values: new object[] { 1, 0, "500mg", null, "7 days", "3", 1, "oral", "amoxicillin", "08:00", 1 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 8, 2, 16, 7, 53, 64, DateTimeKind.Local).AddTicks(5475));
        }
    }
}
