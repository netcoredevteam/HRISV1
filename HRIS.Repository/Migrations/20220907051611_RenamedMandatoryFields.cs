using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class RenamedMandatoryFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_Mandatory_MandatoryId",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mandatory",
                table: "Mandatory");

            migrationBuilder.RenameTable(
                name: "Mandatory",
                newName: "mandatory");

            migrationBuilder.RenameColumn(
                name: "TIN",
                table: "mandatory",
                newName: "tin");

            migrationBuilder.RenameColumn(
                name: "SSS",
                table: "mandatory",
                newName: "sss");

            migrationBuilder.RenameColumn(
                name: "HMO",
                table: "mandatory",
                newName: "hmo");

            migrationBuilder.RenameColumn(
                name: "PhilHealth",
                table: "mandatory",
                newName: "phil_health");

            migrationBuilder.RenameColumn(
                name: "PagIbig",
                table: "mandatory",
                newName: "pag_ibig");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "mandatory",
                newName: "employee_id");

            migrationBuilder.AlterColumn<string>(
                name: "tin",
                table: "mandatory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sss",
                table: "mandatory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "hmo",
                table: "mandatory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "phil_health",
                table: "mandatory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pag_ibig",
                table: "mandatory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_mandatory",
                table: "mandatory",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_mandatory_MandatoryId",
                table: "employees",
                column: "MandatoryId",
                principalTable: "mandatory",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_mandatory_MandatoryId",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mandatory",
                table: "mandatory");

            migrationBuilder.RenameTable(
                name: "mandatory",
                newName: "Mandatory");

            migrationBuilder.RenameColumn(
                name: "tin",
                table: "Mandatory",
                newName: "TIN");

            migrationBuilder.RenameColumn(
                name: "sss",
                table: "Mandatory",
                newName: "SSS");

            migrationBuilder.RenameColumn(
                name: "hmo",
                table: "Mandatory",
                newName: "HMO");

            migrationBuilder.RenameColumn(
                name: "phil_health",
                table: "Mandatory",
                newName: "PhilHealth");

            migrationBuilder.RenameColumn(
                name: "pag_ibig",
                table: "Mandatory",
                newName: "PagIbig");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Mandatory",
                newName: "EmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "TIN",
                table: "Mandatory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SSS",
                table: "Mandatory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HMO",
                table: "Mandatory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhilHealth",
                table: "Mandatory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PagIbig",
                table: "Mandatory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mandatory",
                table: "Mandatory",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_Mandatory_MandatoryId",
                table: "employees",
                column: "MandatoryId",
                principalTable: "Mandatory",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
