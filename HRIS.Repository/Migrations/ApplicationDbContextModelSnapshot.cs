﻿// <auto-generated />
using System;
using HRIS.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRIS.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasIndex("EmployeeId")
                        .IsUnique();

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
                            Id = new Guid("ac7e9fa2-47c9-4f37-a972-04e9320a2297"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2833),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Morning Shift",
                            StartTime = new DateTime(1, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2840),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = new Guid("d085e7cc-056b-4505-8c9a-a16c7ef8b0ff"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2843),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 5, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Night Shift",
                            StartTime = new DateTime(1, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2843),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = new Guid("be994082-c38e-4d57-857a-f8708a6b80b3"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2845),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Marketing Shift",
                            StartTime = new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2845),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = new Guid("1db75cc2-7f64-469a-acc7-2510f12bfbb1"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2847),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "IT Shift",
                            StartTime = new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2847),
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = new Guid("f8918399-55a8-414c-b29e-05c552083135"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2849),
                            CreatedBy = "System",
                            EndTime = new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "HR Shift",
                            StartTime = new DateTime(1, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(2849),
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
                            Id = new Guid("c34b1a2e-c3b7-4dbe-90f0-3315f2b6a3ce"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1773),
                            CreatedBy = "System",
                            Name = "NetCore Developer",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1781),
                            UpdatedBy = "System",
                            WorkCode = "NCD"
                        },
                        new
                        {
                            Id = new Guid("435eade4-116a-43f4-b53b-02dc4424cdfb"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1784),
                            CreatedBy = "System",
                            Name = "Frontend Developer",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1784),
                            UpdatedBy = "System",
                            WorkCode = "FED"
                        },
                        new
                        {
                            Id = new Guid("a91299c0-c008-4787-a173-737f20a0dd70"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1786),
                            CreatedBy = "System",
                            Name = "Chat Support",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1786),
                            UpdatedBy = "System",
                            WorkCode = "CS"
                        },
                        new
                        {
                            Id = new Guid("6ca57d29-9f04-4a37-bcbf-98d1c7ffc5d2"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1788),
                            CreatedBy = "System",
                            Name = "Marketing",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1788),
                            UpdatedBy = "System",
                            WorkCode = "MKT"
                        },
                        new
                        {
                            Id = new Guid("f36129c4-77c8-4379-9839-503408c92db1"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1790),
                            CreatedBy = "System",
                            Name = "Affiliate",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1790),
                            UpdatedBy = "System",
                            WorkCode = "AFF"
                        },
                        new
                        {
                            Id = new Guid("f50f5a74-dcd4-4bbf-9ab7-ae9d05e45643"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1792),
                            CreatedBy = "System",
                            Name = "Data Analyst",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1792),
                            UpdatedBy = "System",
                            WorkCode = "DA"
                        },
                        new
                        {
                            Id = new Guid("d711a0bf-a921-47b7-9a55-41ad0e1270b6"),
                            CreatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1801),
                            CreatedBy = "System",
                            Name = "Human Resource",
                            UpdatedAt = new DateTime(2022, 9, 13, 18, 8, 53, 368, DateTimeKind.Local).AddTicks(1802),
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

            modelBuilder.Entity("HRIS.Domain.Entities.Mandatory", b =>
                {
                    b.HasOne("HRIS.Domain.Entities.Employee", "Employee")
                        .WithOne("Mandatory")
                        .HasForeignKey("HRIS.Domain.Entities.Mandatory", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
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

                    b.Navigation("Mandatory")
                        .IsRequired();

                    b.Navigation("Users");
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
