using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedMandatoryTableAndConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MandatoryId",
                table: "employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Mandatory",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagIbig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhilHealth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HMO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mandatory", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_MandatoryId",
                table: "employees",
                column: "MandatoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_Mandatory_MandatoryId",
                table: "employees",
                column: "MandatoryId",
                principalTable: "Mandatory",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_Mandatory_MandatoryId",
                table: "employees");

            migrationBuilder.DropTable(
                name: "Mandatory");

            migrationBuilder.DropIndex(
                name: "IX_employees_MandatoryId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "MandatoryId",
                table: "employees");
        }
    }
}
