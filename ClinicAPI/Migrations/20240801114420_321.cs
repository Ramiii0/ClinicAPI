using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class _321 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientModelId",
                table: "Investigations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 8, 1, 14, 44, 20, 90, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_PatientModelId",
                table: "Investigations",
                column: "PatientModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Patients_PatientModelId",
                table: "Investigations",
                column: "PatientModelId",
                principalTable: "Patients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Patients_PatientModelId",
                table: "Investigations");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_PatientModelId",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "PatientModelId",
                table: "Investigations");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 7, 31, 21, 23, 35, 763, DateTimeKind.Local).AddTicks(5524));
        }
    }
}
