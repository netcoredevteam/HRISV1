using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedUsersAndConfiguredProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "employees",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "employees",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "employees",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "employees",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "employees",
                newName: "created_at");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    last_login_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_EmployeeId",
                table: "users",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "employees",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "employees",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "employees",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "employees",
                newName: "DateCreated");
        }
    }
}
