using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedWorkPositionEntityAndConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "employees",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "employees",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "DateHired",
                table: "employees",
                newName: "date_hired");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "employees",
                newName: "birth_date");

            migrationBuilder.AddColumn<Guid>(
                name: "WorkPositionId",
                table: "employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contact_name",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contact_no",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "profile_image",
                table: "employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "work_position",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    end_time = table.Column<TimeSpan>(type: "time", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_work_position", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_WorkPositionId",
                table: "employees",
                column: "WorkPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_work_position_WorkPositionId",
                table: "employees",
                column: "WorkPositionId",
                principalTable: "work_position",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_work_position_WorkPositionId",
                table: "employees");

            migrationBuilder.DropTable(
                name: "work_position");

            migrationBuilder.DropIndex(
                name: "IX_employees_WorkPositionId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "WorkPositionId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "address",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "contact_name",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "contact_no",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "profile_image",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "employees",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "date_hired",
                table: "employees",
                newName: "DateHired");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "employees",
                newName: "BirthDate");
        }
    }
}
