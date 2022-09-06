using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedScheduleEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "employees",
                newName: "EmployeeNo");

            migrationBuilder.AddColumn<Guid>(
                name: "ScheduleId",
                table: "employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    start_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    create_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_ScheduleId",
                table: "employees",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_schedules_ScheduleId",
                table: "employees",
                column: "ScheduleId",
                principalTable: "schedules",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_schedules_ScheduleId",
                table: "employees");

            migrationBuilder.DropTable(
                name: "schedules");

            migrationBuilder.DropIndex(
                name: "IX_employees_ScheduleId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeNo",
                table: "employees",
                newName: "EmployeeId");
        }
    }
}
