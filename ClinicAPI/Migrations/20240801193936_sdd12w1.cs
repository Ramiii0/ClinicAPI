using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class sdd12w1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Investigations",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  CRP = table.Column<int>(type: "int", nullable: false),
                  Creatinine = table.Column<int>(type: "int", nullable: false),
                  D_DIMER = table.Column<int>(type: "int", nullable: false),
                  ESR = table.Column<int>(type: "int", nullable: false),
                  FBS = table.Column<int>(type: "int", nullable: false),
                  FERRITIN = table.Column<int>(type: "int", nullable: false),
                  GUERBC = table.Column<int>(type: "int", nullable: false),
                  GUE_PUS = table.Column<int>(type: "int", nullable: false),
                  HB = table.Column<int>(type: "int", nullable: false),
                  HbA1c = table.Column<int>(type: "int", nullable: false),
                  PLATELETS = table.Column<int>(type: "int", nullable: false),
                  PSA = table.Column<int>(type: "int", nullable: false),
                  PatientId = table.Column<int>(type: "int", nullable: true),
                  RBS = table.Column<int>(type: "int", nullable: false),
                  UREA = table.Column<int>(type: "int", nullable: false),
                  Uric_Acid = table.Column<int>(type: "int", nullable: false),
                  VisitId = table.Column<int>(type: "int", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Investigations", x => x.Id);
                  table.ForeignKey(
                      name: "FK_Investigations_Patients_PatientModelId",
                      column: x => x.PatientId,
                      principalTable: "Patients",
                      principalColumn: "Id");
                  table.ForeignKey(
                      name: "FK_Investigations_Visits_VisitModelId",
                      column: x => x.VisitId,
                      principalTable: "Visits",
                      principalColumn: "Id");
              });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 8, 1, 14, 44, 20, 90, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_PatientModelId",
                table: "Investigations",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_VisitModelId",
                table: "Investigations",
                column: "VisitId");
            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 8, 1, 22, 39, 36, 119, DateTimeKind.Local).AddTicks(2441));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 8, 1, 22, 32, 7, 956, DateTimeKind.Local).AddTicks(911));
        }
    }
}
