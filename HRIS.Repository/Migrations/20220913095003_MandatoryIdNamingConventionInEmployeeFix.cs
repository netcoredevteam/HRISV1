using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class MandatoryIdNamingConventionInEmployeeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_mandatory_MandatoryId",
                table: "employees");

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

            migrationBuilder.RenameColumn(
                name: "MandatoryId",
                table: "employees",
                newName: "mandatory_id");

            migrationBuilder.RenameIndex(
                name: "IX_employees_MandatoryId",
                table: "employees",
                newName: "IX_employees_mandatory_id");

            migrationBuilder.InsertData(
                table: "schedules",
                columns: new[] { "id", "created_at", "created_by", "end_time", "name", "start_time", "status", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("02706dae-b293-4bfa-a087-dbf431789578"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5878), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5878), "System" },
                    { new Guid("1948ee74-c197-4985-a0a1-2826e1ed6316"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5871), "System", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift", new DateTime(1, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5873), "System" },
                    { new Guid("3c1cd169-ec4b-4a81-83d3-8e73819fd24f"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5879), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "IT Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5880), "System" },
                    { new Guid("c72583e1-3dd7-4516-859d-ec3c93b78f26"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5882), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "HR Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5882), "System" },
                    { new Guid("ecb1f0f2-a87f-4dff-bf65-2ebd7567d181"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5875), "System", new DateTime(1, 1, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), "Night Shift", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(5876), "System" }
                });

            migrationBuilder.InsertData(
                table: "work_position",
                columns: new[] { "id", "created_at", "created_by", "name", "updated_at", "updated_by", "work_code" },
                values: new object[,]
                {
                    { new Guid("2e90b8e8-3533-47ec-9850-b7c926a5df1b"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4800), "System", "Marketing", new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4800), "System", "MKT" },
                    { new Guid("449069a6-987c-4ee2-a45f-039e68a6459e"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4801), "System", "Affiliate", new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4802), "System", "AFF" },
                    { new Guid("4d4a275d-2483-4e55-b74a-bf42aad37855"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4813), "System", "Data Analyst", new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4813), "System", "DA" },
                    { new Guid("94449f9d-5530-466e-b185-d8484ac6db91"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4796), "System", "Chat Support", new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4798), "System", "CS" },
                    { new Guid("97e3c644-7038-4c7e-bba9-e3721a1b6190"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4794), "System", "Frontend Developer", new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4795), "System", "FED" },
                    { new Guid("a83015a9-165f-41dc-996f-f35397ebc719"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4785), "System", "NetCore Developer", new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4792), "System", "NCD" },
                    { new Guid("d6ec6335-756e-40fb-b6e2-c3240d6c8d75"), new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4815), "System", "Human Resource", new DateTime(2022, 9, 13, 17, 50, 3, 596, DateTimeKind.Local).AddTicks(4815), "System", "HR" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_employees_mandatory_mandatory_id",
                table: "employees",
                column: "mandatory_id",
                principalTable: "mandatory",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_mandatory_mandatory_id",
                table: "employees");

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("02706dae-b293-4bfa-a087-dbf431789578"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("1948ee74-c197-4985-a0a1-2826e1ed6316"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("3c1cd169-ec4b-4a81-83d3-8e73819fd24f"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("c72583e1-3dd7-4516-859d-ec3c93b78f26"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("ecb1f0f2-a87f-4dff-bf65-2ebd7567d181"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("2e90b8e8-3533-47ec-9850-b7c926a5df1b"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("449069a6-987c-4ee2-a45f-039e68a6459e"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("4d4a275d-2483-4e55-b74a-bf42aad37855"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("94449f9d-5530-466e-b185-d8484ac6db91"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("97e3c644-7038-4c7e-bba9-e3721a1b6190"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("a83015a9-165f-41dc-996f-f35397ebc719"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("d6ec6335-756e-40fb-b6e2-c3240d6c8d75"));

            migrationBuilder.RenameColumn(
                name: "mandatory_id",
                table: "employees",
                newName: "MandatoryId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_mandatory_id",
                table: "employees",
                newName: "IX_employees_MandatoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_employees_mandatory_MandatoryId",
                table: "employees",
                column: "MandatoryId",
                principalTable: "mandatory",
                principalColumn: "id");
        }
    }
}
