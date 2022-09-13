using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedFiledDateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("0924657b-5f23-4723-bf62-340e93c2ee83"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("1f91deee-f79e-418a-b5d7-34aad5038114"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("afc5dac2-735e-4491-8a01-15c764ed9556"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("b9f029ce-ab2b-45b0-8b6e-b20464b865a6"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("c50932d3-6f7d-4c93-a71e-84ee6261288d"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("07575a16-e6a3-4f54-9fb7-de1bd27e63a0"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("8bf74bca-6bac-47a7-af54-0fe12a2911a9"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("a0993064-2401-42e0-9733-b2fd0100f131"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("bd145b00-ce4c-4250-aed8-b31f14c0c254"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("d8867b1e-7a93-45ac-930a-79159db3c711"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("ff0fb465-dd1c-44f3-9bd5-eb03beb291fa"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("ff528473-6b79-43f4-8039-5f011533acdf"));

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "leave_records");

            migrationBuilder.AddColumn<DateTime>(
                name: "filed_date",
                table: "leave_records",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "schedules",
                columns: new[] { "id", "created_at", "created_by", "end_time", "name", "start_time", "status", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("414b1c06-8416-4a32-b6fe-7ad743c36a44"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9032), "System", new DateTime(1, 1, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), "Night Shift", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9033), "System" },
                    { new Guid("6bab620c-3255-435e-bb8a-792efaa35c2e"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9037), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "IT Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9038), "System" },
                    { new Guid("6e6b1232-f968-469e-a4c0-c00e160c4082"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9035), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9035), "System" },
                    { new Guid("946ce33f-92a6-47ce-b26a-d41dd52b2bd9"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9040), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "HR Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9040), "System" },
                    { new Guid("e24fb47a-2d0a-4908-a01f-be00ffc6dd14"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9027), "System", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift", new DateTime(1, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(9029), "System" }
                });

            migrationBuilder.InsertData(
                table: "work_position",
                columns: new[] { "id", "created_at", "created_by", "name", "updated_at", "updated_by", "work_code" },
                values: new object[,]
                {
                    { new Guid("5296209f-ffd7-490e-9457-20409a6f5e9d"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7929), "System", "Chat Support", new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7930), "System", "CS" },
                    { new Guid("5f7050f8-b3a2-4592-84ff-33454962a247"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7934), "System", "Affiliate", new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7934), "System", "AFF" },
                    { new Guid("725ad422-2309-4b47-b9d4-b01887435250"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7932), "System", "Marketing", new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7932), "System", "MKT" },
                    { new Guid("8822a060-6ff1-4d30-b6d2-7f85eaeb12f6"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7915), "System", "NetCore Developer", new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7924), "System", "NCD" },
                    { new Guid("af02bac4-a2da-43e2-be1f-0cbe72697177"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7947), "System", "Human Resource", new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7947), "System", "HR" },
                    { new Guid("bd2dc09c-c7d9-4576-ab1a-89fc46815263"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7927), "System", "Frontend Developer", new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7927), "System", "FED" },
                    { new Guid("ef98b075-2f87-4959-8faa-d788bc1b001e"), new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7936), "System", "Data Analyst", new DateTime(2022, 9, 13, 17, 22, 18, 145, DateTimeKind.Local).AddTicks(7936), "System", "DA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("414b1c06-8416-4a32-b6fe-7ad743c36a44"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("6bab620c-3255-435e-bb8a-792efaa35c2e"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("6e6b1232-f968-469e-a4c0-c00e160c4082"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("946ce33f-92a6-47ce-b26a-d41dd52b2bd9"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("e24fb47a-2d0a-4908-a01f-be00ffc6dd14"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("5296209f-ffd7-490e-9457-20409a6f5e9d"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("5f7050f8-b3a2-4592-84ff-33454962a247"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("725ad422-2309-4b47-b9d4-b01887435250"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("8822a060-6ff1-4d30-b6d2-7f85eaeb12f6"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("af02bac4-a2da-43e2-be1f-0cbe72697177"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("bd2dc09c-c7d9-4576-ab1a-89fc46815263"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("ef98b075-2f87-4959-8faa-d788bc1b001e"));

            migrationBuilder.DropColumn(
                name: "filed_date",
                table: "leave_records");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "leave_records",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "schedules",
                columns: new[] { "id", "created_at", "created_by", "end_time", "name", "start_time", "status", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("0924657b-5f23-4723-bf62-340e93c2ee83"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2960), "System", new DateTime(1, 1, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), "Night Shift", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2960), "System" },
                    { new Guid("1f91deee-f79e-418a-b5d7-34aad5038114"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2954), "System", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift", new DateTime(1, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2956), "System" },
                    { new Guid("afc5dac2-735e-4491-8a01-15c764ed9556"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2965), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "IT Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2966), "System" },
                    { new Guid("b9f029ce-ab2b-45b0-8b6e-b20464b865a6"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2968), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "HR Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2968), "System" },
                    { new Guid("c50932d3-6f7d-4c93-a71e-84ee6261288d"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2963), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(2963), "System" }
                });

            migrationBuilder.InsertData(
                table: "work_position",
                columns: new[] { "id", "created_at", "created_by", "name", "updated_at", "updated_by", "work_code" },
                values: new object[,]
                {
                    { new Guid("07575a16-e6a3-4f54-9fb7-de1bd27e63a0"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1912), "System", "Human Resource", new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1912), "System", "HR" },
                    { new Guid("8bf74bca-6bac-47a7-af54-0fe12a2911a9"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1875), "System", "NetCore Developer", new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1890), "System", "NCD" },
                    { new Guid("a0993064-2401-42e0-9733-b2fd0100f131"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1896), "System", "Chat Support", new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1896), "System", "CS" },
                    { new Guid("bd145b00-ce4c-4250-aed8-b31f14c0c254"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1910), "System", "Data Analyst", new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1910), "System", "DA" },
                    { new Guid("d8867b1e-7a93-45ac-930a-79159db3c711"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1898), "System", "Marketing", new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1898), "System", "MKT" },
                    { new Guid("ff0fb465-dd1c-44f3-9bd5-eb03beb291fa"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1893), "System", "Frontend Developer", new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1894), "System", "FED" },
                    { new Guid("ff528473-6b79-43f4-8039-5f011533acdf"), new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1908), "System", "Affiliate", new DateTime(2022, 9, 13, 15, 4, 52, 891, DateTimeKind.Local).AddTicks(1908), "System", "AFF" }
                });
        }
    }
}
