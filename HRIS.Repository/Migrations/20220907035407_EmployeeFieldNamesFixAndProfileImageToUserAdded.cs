using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class EmployeeFieldNamesFixAndProfileImageToUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_schedules_ScheduleId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_work_position_WorkPositionId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "profile_image",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "WorkPositionId",
                table: "employees",
                newName: "work_position_id");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "employees",
                newName: "schedule_id");

            migrationBuilder.RenameColumn(
                name: "EmployeeNo",
                table: "employees",
                newName: "employee_no");

            migrationBuilder.RenameIndex(
                name: "IX_employees_WorkPositionId",
                table: "employees",
                newName: "IX_employees_work_position_id");

            migrationBuilder.RenameIndex(
                name: "IX_employees_ScheduleId",
                table: "employees",
                newName: "IX_employees_schedule_id");

            migrationBuilder.AddColumn<string>(
                name: "profile_image",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_schedules_schedule_id",
                table: "employees",
                column: "schedule_id",
                principalTable: "schedules",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_work_position_work_position_id",
                table: "employees",
                column: "work_position_id",
                principalTable: "work_position",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_schedules_schedule_id",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_work_position_work_position_id",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "profile_image",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "work_position_id",
                table: "employees",
                newName: "WorkPositionId");

            migrationBuilder.RenameColumn(
                name: "schedule_id",
                table: "employees",
                newName: "ScheduleId");

            migrationBuilder.RenameColumn(
                name: "employee_no",
                table: "employees",
                newName: "EmployeeNo");

            migrationBuilder.RenameIndex(
                name: "IX_employees_work_position_id",
                table: "employees",
                newName: "IX_employees_WorkPositionId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_schedule_id",
                table: "employees",
                newName: "IX_employees_ScheduleId");

            migrationBuilder.AddColumn<string>(
                name: "profile_image",
                table: "employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_schedules_ScheduleId",
                table: "employees",
                column: "ScheduleId",
                principalTable: "schedules",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_work_position_WorkPositionId",
                table: "employees",
                column: "WorkPositionId",
                principalTable: "work_position",
                principalColumn: "id");
        }
    }
}
