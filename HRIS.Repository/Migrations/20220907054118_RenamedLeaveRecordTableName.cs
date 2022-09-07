using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class RenamedLeaveRecordTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_leave_record_users_user_id",
                table: "leave_record");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leave_record",
                table: "leave_record");

            migrationBuilder.RenameTable(
                name: "leave_record",
                newName: "leave_records");

            migrationBuilder.RenameIndex(
                name: "IX_leave_record_user_id",
                table: "leave_records",
                newName: "IX_leave_records_user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_leave_records",
                table: "leave_records",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_leave_records_users_user_id",
                table: "leave_records",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_leave_records_users_user_id",
                table: "leave_records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leave_records",
                table: "leave_records");

            migrationBuilder.RenameTable(
                name: "leave_records",
                newName: "leave_record");

            migrationBuilder.RenameIndex(
                name: "IX_leave_records_user_id",
                table: "leave_record",
                newName: "IX_leave_record_user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_leave_record",
                table: "leave_record",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_leave_record_users_user_id",
                table: "leave_record",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
