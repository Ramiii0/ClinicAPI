using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class @in : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Investigation",
                table: "Visits");

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
                value: new DateTime(2024, 7, 31, 19, 15, 30, 693, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_VisitModelId",
                table: "Investigations",
                column: "VisitModelId");

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Visits_VisitModelId",
                table: "Investigations");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_VisitModelId",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "VisitModelId",
                table: "Investigations");

            migrationBuilder.AddColumn<string>(
                name: "Investigation",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Investigation", "VisitDate" },
                values: new object[] { "[0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]", new DateTime(2024, 7, 31, 17, 32, 49, 905, DateTimeKind.Local).AddTicks(2628) });
        }
    }
}
