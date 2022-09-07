using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedDailyRecordTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "daily_recor",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    employee_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    time_in = table.Column<DateTime>(type: "datetime", nullable: true),
                    time_out = table.Column<DateTime>(type: "datetime", nullable: true),
                    lunch_in = table.Column<DateTime>(type: "datetime", nullable: true),
                    lunch_out = table.Column<DateTime>(type: "datetime", nullable: true),
                    ot_in = table.Column<DateTime>(type: "datetime", nullable: true),
                    ot_out = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    update_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    created_by = table.Column<string>(type: "varchar", nullable: true),
                    updated_by = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_daily_recor", x => x.id);
                    table.ForeignKey(
                        name: "FK_daily_recor_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_daily_recor_employee_id",
                table: "daily_recor",
                column: "employee_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "daily_recor");
        }
    }
}
