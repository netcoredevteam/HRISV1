using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedSeedDataInScheduleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "schedules",
                columns: new[] { "id", "created_at", "created_by", "end_time", "name", "start_time", "status", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("276177f5-e727-41f6-a4b6-f991120230f1"), new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(501), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(501), "System" },
                    { new Guid("6755ebe2-8c66-4367-813f-604033c7ec46"), new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(543), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "HR Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(543), "System" },
                    { new Guid("969d1fa6-c159-40c8-b70a-1bebe7d86a2f"), new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(540), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "IT Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(541), "System" },
                    { new Guid("c3753078-4422-42b2-8fa8-efc6b983af67"), new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(493), "System", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift", new DateTime(1, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(495), "System" },
                    { new Guid("cf09e2a8-8e00-4d3f-a44c-874a974eaaab"), new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(498), "System", new DateTime(1, 1, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), "Night Shift", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 11, 37, 20, 284, DateTimeKind.Local).AddTicks(498), "System" }
                });

            migrationBuilder.InsertData(
                table: "work_position",
                columns: new[] { "id", "created_at", "created_by", "name", "updated_at", "updated_by", "work_code" },
                values: new object[,]
                {
                    { new Guid("00e08fc3-911a-494a-9a7a-84fabace0d11"), new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9449), "System", "Data Analyst", new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9450), "System", "DA" },
                    { new Guid("07ab7ac2-4ca5-43dd-8593-38c6b1054739"), new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9439), "System", "Frontend Developer", new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9440), "System", "FED" },
                    { new Guid("19a4331c-7b7d-4c9c-aea9-52d3dc01941c"), new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9447), "System", "Affiliate", new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9447), "System", "AFF" },
                    { new Guid("29f79839-ef3e-4b04-b836-f8b057315834"), new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9426), "System", "NetCore Developer", new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9436), "System", "NCD" },
                    { new Guid("3bf7600b-a0d2-4d70-a2f4-02e0f6b26018"), new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9444), "System", "Marketing", new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9445), "System", "MKT" },
                    { new Guid("641eab66-a692-4ba3-868a-9b80fc58d64d"), new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9456), "System", "Human Resource", new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9457), "System", "HR" },
                    { new Guid("94850d99-7fa7-4cdb-a76f-49c3cebc673e"), new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9442), "System", "Chat Support", new DateTime(2022, 9, 13, 11, 37, 20, 283, DateTimeKind.Local).AddTicks(9442), "System", "CS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("276177f5-e727-41f6-a4b6-f991120230f1"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("6755ebe2-8c66-4367-813f-604033c7ec46"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("969d1fa6-c159-40c8-b70a-1bebe7d86a2f"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("c3753078-4422-42b2-8fa8-efc6b983af67"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("cf09e2a8-8e00-4d3f-a44c-874a974eaaab"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("00e08fc3-911a-494a-9a7a-84fabace0d11"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("07ab7ac2-4ca5-43dd-8593-38c6b1054739"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("19a4331c-7b7d-4c9c-aea9-52d3dc01941c"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("29f79839-ef3e-4b04-b836-f8b057315834"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("3bf7600b-a0d2-4d70-a2f4-02e0f6b26018"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("641eab66-a692-4ba3-868a-9b80fc58d64d"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("94850d99-7fa7-4cdb-a76f-49c3cebc673e"));

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
    }
}
