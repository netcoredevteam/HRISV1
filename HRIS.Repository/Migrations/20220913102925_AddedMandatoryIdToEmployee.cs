using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class AddedMandatoryIdToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0bea6297-ce57-4cad-b0b6-b4acc67378b1"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1509), "System", new DateTime(1, 1, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), "Night Shift", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1510), "System" },
                    { new Guid("2ee62d6e-91af-4f05-828f-bcfcb2423b8c"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1512), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1512), "System" },
                    { new Guid("67245a0a-3aae-495d-8cd9-3a168aa9171f"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1519), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "HR Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1519), "System" },
                    { new Guid("89f0361f-366a-47f8-b037-ef7eda822576"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1514), "System", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "IT Shift", new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1515), "System" },
                    { new Guid("a110003b-25ad-4d99-bb9a-0092e4005e99"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1499), "System", new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift", new DateTime(1, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1501), "System" }
                });

            migrationBuilder.InsertData(
                table: "work_position",
                columns: new[] { "id", "created_at", "created_by", "name", "updated_at", "updated_by", "work_code" },
                values: new object[,]
                {
                    { new Guid("2dca13b6-49c4-4542-af8d-746637efd04e"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(439), "System", "Chat Support", new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(440), "System", "CS" },
                    { new Guid("4d507c37-c76d-4822-91a4-3b1695f8fffa"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(444), "System", "Data Analyst", new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(445), "System", "DA" },
                    { new Guid("7608ff2d-c005-446e-8fc1-f2841d4d6d61"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(437), "System", "Frontend Developer", new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(438), "System", "FED" },
                    { new Guid("9745d908-4eb8-4dbb-9c69-15154f1c3b5d"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(426), "System", "NetCore Developer", new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(435), "System", "NCD" },
                    { new Guid("c5f6c73a-fbc2-4307-80cb-dd64714189ae"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(446), "System", "Human Resource", new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(446), "System", "HR" },
                    { new Guid("c7dbcd7f-1613-4d92-b444-043dfc134bc4"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(443), "System", "Affiliate", new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(443), "System", "AFF" },
                    { new Guid("e3a06b22-9f71-4245-9e86-72b325aca230"), new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(441), "System", "Marketing", new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(442), "System", "MKT" }
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
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("0bea6297-ce57-4cad-b0b6-b4acc67378b1"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("2ee62d6e-91af-4f05-828f-bcfcb2423b8c"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("67245a0a-3aae-495d-8cd9-3a168aa9171f"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("89f0361f-366a-47f8-b037-ef7eda822576"));

            migrationBuilder.DeleteData(
                table: "schedules",
                keyColumn: "id",
                keyValue: new Guid("a110003b-25ad-4d99-bb9a-0092e4005e99"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("2dca13b6-49c4-4542-af8d-746637efd04e"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("4d507c37-c76d-4822-91a4-3b1695f8fffa"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("7608ff2d-c005-446e-8fc1-f2841d4d6d61"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("9745d908-4eb8-4dbb-9c69-15154f1c3b5d"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("c5f6c73a-fbc2-4307-80cb-dd64714189ae"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("c7dbcd7f-1613-4d92-b444-043dfc134bc4"));

            migrationBuilder.DeleteData(
                table: "work_position",
                keyColumn: "id",
                keyValue: new Guid("e3a06b22-9f71-4245-9e86-72b325aca230"));

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
    }
}
