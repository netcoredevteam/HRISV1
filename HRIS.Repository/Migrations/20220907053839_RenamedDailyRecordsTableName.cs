using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class RenamedDailyRecordsTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_daily_recor_employees_employee_id",
            //    table: "daily_recor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_daily_recor",
                table: "daily_recor");

            migrationBuilder.RenameTable(
                name: "daily_recor",
                newName: "daily_records");

            migrationBuilder.RenameIndex(
                name: "IX_daily_recor_employee_id",
                table: "daily_records",
                newName: "IX_daily_records_employee_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_daily_records",
                table: "daily_records",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_daily_records_employees_employee_id",
                table: "daily_records",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_daily_records_employees_employee_id",
                table: "daily_records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_daily_records",
                table: "daily_records");

            migrationBuilder.RenameTable(
                name: "daily_records",
                newName: "daily_recor");

            migrationBuilder.RenameIndex(
                name: "IX_daily_records_employee_id",
                table: "daily_recor",
                newName: "IX_daily_recor_employee_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_daily_recor",
                table: "daily_recor",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_daily_recor_employees_employee_id",
                table: "daily_recor",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
