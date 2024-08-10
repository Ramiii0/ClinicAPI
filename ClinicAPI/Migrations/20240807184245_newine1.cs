using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class newine1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "DrugCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugCategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drugs_DrugCategories_DrugCategoryId",
                        column: x => x.DrugCategoryId,
                        principalTable: "DrugCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_DrugCategoryId",
                table: "Drugs",
                column: "DrugCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "DrugCategories");

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "DateCreated", "FirstName", "Gender", "Height", "LastName", "Medical", "Phone", "Photo", "Residence", "Social", "Surgical", "Weight" },
                values: new object[] { 1, 22, new DateTime(2024, 8, 6, 21, 58, 33, 215, DateTimeKind.Local).AddTicks(6827), "Mohammed", "Male", 180, "Raid", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer in elementum massa. Aliquam  r", 123, null, "Baghdad", "wfvbeuibwjebdjiwvbwjklvf", "Lorem ipsum   , consectetur adipiscing elit. Integer in elementum massa. Aliquam elementum risus vitae   . Sed eu  tellus, eget lacinia", 70 });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "CC", "Examination", "HPI", "PR", "PatientId", "ServiceFollow", "Title", "VisitDate" },
                values: new object[] { 1, "C.C details...", "exam details", "HPI details", "PR details", 1, null, "Visit 1", new DateTime(2024, 8, 6, 21, 58, 33, 215, DateTimeKind.Local).AddTicks(6935) });
        }
    }
}
