﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Repository.Migrations
{
    public partial class addedDateHiredInEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateHired",
                table: "employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateHired",
                table: "employees");
        }
    }
}
