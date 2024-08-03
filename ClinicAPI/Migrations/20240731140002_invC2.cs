using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class invC2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Patients_PatientId",
                table: "Investigations");

            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Patients_PatientModelId",
                table: "Investigations");

            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Visits_VisitId",
                table: "Investigations");

            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Visits_VisitModelId",
                table: "Investigations");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_PatientId",
                table: "Investigations");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_PatientModelId",
                table: "Investigations");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_VisitId",
                table: "Investigations");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_VisitModelId",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "PatientModelId",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "VisitModelId",
                table: "Investigations");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 7, 31, 17, 0, 2, 252, DateTimeKind.Local).AddTicks(4087));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Investigations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientModelId",
                table: "Investigations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Investigations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VisitModelId",
                table: "Investigations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 7, 31, 16, 57, 1, 786, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_PatientId",
                table: "Investigations",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_PatientModelId",
                table: "Investigations",
                column: "PatientModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_VisitId",
                table: "Investigations",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_VisitModelId",
                table: "Investigations",
                column: "VisitModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Patients_PatientId",
                table: "Investigations",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Patients_PatientModelId",
                table: "Investigations",
                column: "PatientModelId",
                principalTable: "Patients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Visits_VisitId",
                table: "Investigations",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Visits_VisitModelId",
                table: "Investigations",
                column: "VisitModelId",
                principalTable: "Visits",
                principalColumn: "Id");
        }
    }
}
