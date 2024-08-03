using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class i2476d5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            

            migrationBuilder.DropColumn(
                name: "VisitModelId",
                table: "Investigations");

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2024, 7, 31, 21, 13, 54, 21, DateTimeKind.Local).AddTicks(2966));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: new DateTime(2024, 7, 31, 21, 9, 28, 156, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_VisitModelId",
                table: "Investigations",
                column: "VisitModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Visits_VisitModelId",
                table: "Investigations",
                column: "VisitModelId",
                principalTable: "Visits",
                principalColumn: "Id");
        }
    }
}
