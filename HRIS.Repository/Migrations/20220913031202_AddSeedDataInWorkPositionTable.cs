using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddSeedDataInWorkPositionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "work_position",
                columns: new[] { "id", "created_at", "created_by", "name", "updated_at", "updated_by", "work_code" },
                values: new object[,]
                {
                    { new Guid("110d8f7b-8ba5-4e09-85c4-c440bcf88ef6"), new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1546), "System", "NetCore Developer", new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1554), "System", "NCD" },
                    { new Guid("156f6242-796d-4dfb-93dd-baf9c08fb239"), new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1566), "System", "Data Analyst", new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1566), "System", "DA" },
                    { new Guid("3180bf5d-0275-4cdd-a5eb-98b7e95f4477"), new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1586), "System", "Human Resource", new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1586), "System", "HR" },
                    { new Guid("3a8e1211-e1f6-4a0b-9dc3-b60f20210e96"), new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1561), "System", "Marketing", new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1562), "System", "MKT" },
                    { new Guid("5bf18a26-cb7a-448e-9275-cf41c0f908f3"), new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1556), "System", "Frontend Developer", new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1557), "System", "FED" },
                    { new Guid("73b87ee7-a298-4ba3-8adb-4765edc48786"), new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1564), "System", "Affiliate", new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1564), "System", "AFF" },
                    { new Guid("cf8b326f-df2b-444c-9e46-99c01739105c"), new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1559), "System", "Chat Support", new DateTime(2022, 9, 13, 11, 12, 2, 420, DateTimeKind.Local).AddTicks(1560), "System", "CS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("110d8f7b-8ba5-4e09-85c4-c440bcf88ef6"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("156f6242-796d-4dfb-93dd-baf9c08fb239"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("3180bf5d-0275-4cdd-a5eb-98b7e95f4477"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("3a8e1211-e1f6-4a0b-9dc3-b60f20210e96"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("5bf18a26-cb7a-448e-9275-cf41c0f908f3"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("73b87ee7-a298-4ba3-8adb-4765edc48786"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("cf8b326f-df2b-444c-9e46-99c01739105c"));
        }
    }
}
