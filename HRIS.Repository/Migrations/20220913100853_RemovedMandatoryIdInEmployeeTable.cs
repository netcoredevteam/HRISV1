using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class RemovedMandatoryIdInEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_mandatory_mandatory_id",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_mandatory_id",
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

            migrationBuilder.DropColumn(
                name: "mandatory_id",
                table: "employees");

            migrationBuilder.InsertData(
                table: "schedules",
                columns: new[] { "id", "created_at", "created_by", "end_time", "name", "start_time", "status", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("1db75cc2-7f64-469a-acc7-2510f12bfbb1"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2847), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "IT Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2847), "System" },
                    { new Guid("ac7e9fa2-47c9-4f37-a972-04e9320a2297"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2833), "System", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift", new DateTime(1, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2840), "System" },
                    { new Guid("be994082-c38e-4d57-857a-f8708a6b80b3"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2845), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2845), "System" },
                    { new Guid("d085e7cc-056b-4505-8c9a-a16c7ef8b0ff"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2843), "System", new DateTime(1, 1, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), "Night Shift", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2843), "System" },
                    { new Guid("f8918399-55a8-414c-b29e-05c552083135"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2849), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "HR Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2849), "System" }
                });

            migrationBuilder.InsertData(
                table: "work_position",
                columns: new[] { "id", "created_at", "created_by", "name", "updated_at", "updated_by", "work_code" },
                values: new object[,]
                {
                    { new Guid("435eade4-116a-43f4-b53b-02dc4424cdfb"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1784), "System", "Frontend Developer", new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1784), "System", "FED" },
                    { new Guid("6ca57d29-9f04-4a37-bcbf-98d1c7ffc5d2"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1788), "System", "Marketing", new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1788), "System", "MKT" },
                    { new Guid("a91299c0-c008-4787-a173-737f20a0dd70"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1786), "System", "Chat Support", new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1786), "System", "CS" },
                    { new Guid("c34b1a2e-c3b7-4dbe-90f0-3315f2b6a3ce"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1773), "System", "NetCore Developer", new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1781), "System", "NCD" },
                    { new Guid("d711a0bf-a921-47b7-9a55-41ad0e1270b6"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1801), "System", "Human Resource", new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1802), "System", "HR" },
                    { new Guid("f36129c4-77c8-4379-9839-503408c92db1"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1790), "System", "Affiliate", new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1790), "System", "AFF" },
                    { new Guid("f50f5a74-dcd4-4bbf-9ab7-ae9d05e45643"), new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1792), "System", "Data Analyst", new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1792), "System", "DA" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_mandatory_employee_id",
                table: "mandatory",
                column: "employee_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_mandatory_employees_employee_id",
                table: "mandatory",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mandatory_employees_employee_id",
                table: "mandatory");

            migrationBuilder.DropIndex(
                name: "IX_mandatory_employee_id",
                table: "mandatory");

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("1db75cc2-7f64-469a-acc7-2510f12bfbb1"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("ac7e9fa2-47c9-4f37-a972-04e9320a2297"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("be994082-c38e-4d57-857a-f8708a6b80b3"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("d085e7cc-056b-4505-8c9a-a16c7ef8b0ff"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("f8918399-55a8-414c-b29e-05c552083135"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("435eade4-116a-43f4-b53b-02dc4424cdfb"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("6ca57d29-9f04-4a37-bcbf-98d1c7ffc5d2"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("a91299c0-c008-4787-a173-737f20a0dd70"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("c34b1a2e-c3b7-4dbe-90f0-3315f2b6a3ce"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("d711a0bf-a921-47b7-9a55-41ad0e1270b6"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("f36129c4-77c8-4379-9839-503408c92db1"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("f50f5a74-dcd4-4bbf-9ab7-ae9d05e45643"));

            migrationBuilder.AddColumn<Guid>(
                name: "mandatory_id",
                table: "employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_employees_mandatory_id",
                table: "employees",
                column: "mandatory_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_mandatory_mandatory_id",
                table: "employees",
                column: "mandatory_id",
                principalTable: "mandatory",
                principalColumn: "id");
        }
    }
}
