using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedStatusToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "employees");
        }
    }
}
