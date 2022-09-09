using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class FixedUsersSchemaName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_employees_EmployeeId",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "Nickname",
                table: "users",
                newName: "nickname");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "users",
                newName: "employee_id");

            migrationBuilder.RenameIndex(
                name: "IX_users_EmployeeId",
                table: "users",
                newName: "IX_users_employee_id");

            migrationBuilder.AlterColumn<string>(
                name: "nickname",
                table: "users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_users_employees_employee_id",
                table: "users",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_employees_employee_id",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "nickname",
                table: "users",
                newName: "Nickname");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "users",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_users_employee_id",
                table: "users",
                newName: "IX_users_EmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "Nickname",
                table: "users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_users_employees_EmployeeId",
                table: "users",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
