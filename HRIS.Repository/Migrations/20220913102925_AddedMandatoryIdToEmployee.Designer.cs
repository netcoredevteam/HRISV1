﻿// <auto-generated />
using System;
using HRIS.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRIS.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220913102925_AddedMandatoryIdToEmployee")]
    partial class AddedMandatoryIdToEmployee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HRIS.Domain.Entities.Announcement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar")
                        .HasColumnName("created_by");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("message");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("update_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("varchar")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("announcements", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.CalendarTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("DateTask")
                        .HasColumnType("datetime")
                        .HasColumnName("date_task");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("calendar_tasks", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.DailyRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("LunchIn")
                        .HasColumnType("datetime")
                        .HasColumnName("lunch_in");

                    b.Property<DateTime>("LunchOut")
                        .HasColumnType("datetime")
                        .HasColumnName("lunch_out");

                    b.Property<DateTime>("OTIn")
                        .HasColumnType("datetime")
                        .HasColumnName("ot_in");

                    b.Property<DateTime>("OTOut")
                        .HasColumnType("datetime")
                        .HasColumnName("ot_out");

                    b.Property<DateTime>("TimeIn")
                        .HasColumnType("datetime")
                        .HasColumnName("time_in");

                    b.Property<DateTime>("TimeOut")
                        .HasColumnType("datetime")
                        .HasColumnName("time_out");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("daily_records", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birth_date");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("contact_name");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("contact_no");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("DateHired")
                        .HasColumnType("date")
                        .HasColumnName("date_hired");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("employee_no");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<Guid>("MandatoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("mandatory_id");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone");

                    b.Property<Guid>("ScheduleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("schedule_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.Property<Guid>("WorkPositionId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("work_position_id");

                    b.HasKey("Id");

                    b.HasIndex("MandatoryId")
                        .IsUnique();

                    b.HasIndex("ScheduleId");

                    b.HasIndex("WorkPositionId");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.LeaveRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("FiledDate")
                        .HasColumnType("datetime")
                        .HasColumnName("filed_date");

                    b.Property<DateTime>("LeaveEndDate")
                        .HasColumnType("datetime")
                        .HasColumnName("leave_end_date");

                    b.Property<DateTime>("LeaveStartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("leave_start_date");

                    b.Property<int>("Leavetype")
                        .HasColumnType("int")
                        .HasColumnName("leave_type")
                        .HasComment("1 with pay, 0 w/o pay");

                    b.Property<string>("ReasonOfLeave")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reason_of_leave");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("remarks");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("leave_records", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Mandatory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<Guid>("EmployeeId")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("employee_id");

                    b.Property<string>("HMO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("hmo");

                    b.Property<string>("PagIbig")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("pag_ibig");

                    b.Property<string>("PhilHealth")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phil_health");

                    b.Property<string>("SSS")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sss");

                    b.Property<string>("TIN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tin");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("mandatory", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("icon");

                    b.Property<int?>("IsShown")
                        .HasColumnType("int")
                        .HasColumnName("is_shown");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Page")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("page");

                    b.Property<int?>("Sort")
                        .HasColumnType("int")
                        .HasColumnName("sort");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("menus", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Schedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_time");

                    b.Property<int?>("Status")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("schedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a110003b-25ad-4d99-bb9a-0092e4005e99"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1499),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Morning Shift",
                            StartTime = new DateTime(1, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1501),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = new Guid("0bea6297-ce57-4cad-b0b6-b4acc67378b1"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1509),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 5, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Night Shift",
                            StartTime = new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1510),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = new Guid("2ee62d6e-91af-4f05-828f-bcfcb2423b8c"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1512),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Marketing Shift",
                            StartTime = new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1512),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = new Guid("89f0361f-366a-47f8-b037-ef7eda822576"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1514),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "IT Shift",
                            StartTime = new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1515),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = new Guid("67245a0a-3aae-495d-8cd9-3a168aa9171f"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1519),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "HR Shift",
                            StartTime = new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(1519),
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("HRIS.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<Guid>("EmployeeId")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_login_time");

                    b.Property<string>("Nickname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nickname");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("profile_image");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("User")
                        .HasColumnName("role");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Whitelist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("create_time");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ip");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("remark");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("update_time");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("whitelists", (string)null);
                });

            modelBuilder.Entity("HRIS.Domain.Entities.WorkPosition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.Property<string>("WorkCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("work_code");

                    b.HasKey("Id");

                    b.ToTable("work_position", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9745d908-4eb8-4dbb-9c69-15154f1c3b5d"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(426),
                            CreatedBy = "System",
                            Name = "NetCore Developer",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(435),
                            UpdatedBy = "System",
                            WorkCode = "NCD"
                        },
                        new
                        {
                            Id = new Guid("7608ff2d-c005-446e-8fc1-f2841d4d6d61"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(437),
                            CreatedBy = "System",
                            Name = "Frontend Developer",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(438),
                            UpdatedBy = "System",
                            WorkCode = "FED"
                        },
                        new
                        {
                            Id = new Guid("2dca13b6-49c4-4542-af8d-746637efd04e"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(439),
                            CreatedBy = "System",
                            Name = "Chat Support",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(440),
                            UpdatedBy = "System",
                            WorkCode = "CS"
                        },
                        new
                        {
                            Id = new Guid("e3a06b22-9f71-4245-9e86-72b325aca230"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(441),
                            CreatedBy = "System",
                            Name = "Marketing",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(442),
                            UpdatedBy = "System",
                            WorkCode = "MKT"
                        },
                        new
                        {
                            Id = new Guid("c7dbcd7f-1613-4d92-b444-043dfc134bc4"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(443),
                            CreatedBy = "System",
                            Name = "Affiliate",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(443),
                            UpdatedBy = "System",
                            WorkCode = "AFF"
                        },
                        new
                        {
                            Id = new Guid("4d507c37-c76d-4822-91a4-3b1695f8fffa"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(444),
                            CreatedBy = "System",
                            Name = "Data Analyst",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(445),
                            UpdatedBy = "System",
                            WorkCode = "DA"
                        },
                        new
                        {
                            Id = new Guid("c5f6c73a-fbc2-4307-80cb-dd64714189ae"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(446),
                            CreatedBy = "System",
                            Name = "Human Resource",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 29, 24, 979, DateTimeKind.Local).AddTicks(446),
                            UpdatedBy = "System",
                            WorkCode = "HR"
                        });
                });

            modelBuilder.Entity("HRIS.Domain.Entities.DailyRecord", b =>
                {
                    b.HasOne("HRIS.Domain.Entities.Employee", "Employee")
                        .WithMany("DailyRecords")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Employee", b =>
                {
                    b.HasOne("HRIS.Domain.Entities.Mandatory", "Mandatory")
                        .WithOne("Employee")
                        .HasForeignKey("HRIS.Domain.Entities.Employee", "MandatoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRIS.Domain.Entities.Schedule", "Schedule")
                        .WithMany("Employees")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HRIS.Domain.Entities.WorkPosition", "WorkPosition")
                        .WithMany("Employees")
                        .HasForeignKey("WorkPositionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Mandatory");

                    b.Navigation("Schedule");

                    b.Navigation("WorkPosition");
                });

            modelBuilder.Entity("HRIS.Domain.Entities.LeaveRecord", b =>
                {
                    b.HasOne("HRIS.Domain.Entities.User", "User")
                        .WithMany("LeaveRecords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRIS.Domain.Entities.User", b =>
                {
                    b.HasOne("HRIS.Domain.Entities.Employee", "Employee")
                        .WithMany("Users")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Employee", b =>
                {
                    b.Navigation("DailyRecords");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Mandatory", b =>
                {
                    b.Navigation("Employee")
                        .IsRequired();
                });

            modelBuilder.Entity("HRIS.Domain.Entities.Schedule", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("HRIS.Domain.Entities.User", b =>
                {
                    b.Navigation("LeaveRecords");
                });

            modelBuilder.Entity("HRIS.Domain.Entities.WorkPosition", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
