using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdate_SC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1e0290c7-60fc-4b0b-927c-dc0e764e04b0"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("7552dee1-1836-46a7-aaa5-07d7216a4a89"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreateBy",
                table: "StudentConsultation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9018e2f1-0bad-42f7-820a-cafef89adcf1", "AQAAAAEAACcQAAAAEJsDMFCfbHJfMIc+wbTAB2Q/AbprBM3VvufI3HWukloM/gh2hqckDksv2eyjkuE+FA==", "f9a5b12c-3c9a-44cd-bcf2-b03fbe2b509a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ac82548-38cf-4c2a-8423-563c296345c4", "AQAAAAEAACcQAAAAEE4zTJjShVQT6s9Lu3gYyIkZoUOXsaAwzb0LSjBdPSIGMhibVJI3TnihHTYjdfe/sA==", "c90a64de-9644-41e1-867b-56de39323a27" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e5e22b1-ef67-4052-b08c-7648037a8fe8", "AQAAAAEAACcQAAAAEC37PcvCyRGZAdgpy7Bx7+a49nYPBXVS9v16X4uNdZOUMeX54l77so7w3g0UnrOiBw==", "ed7b29c1-a71f-4ccc-bfbf-eb27dce1d9a9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f70dd79-7a87-470b-8e22-ffe7a1989a16", "AQAAAAEAACcQAAAAEFNg1nlhXfKbXBgQ5LxVmlXpcHLPwUcxFJ22mCIXKpn8Ca9L4V7QfmhvAXzC5kWi+A==", "44597367-5465-47c4-9ac6-20b013875134" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f399bf55-b48d-42d4-9303-4beaf5a504b6", "AQAAAAEAACcQAAAAEMs46Czfd4qXtHsx6Yo+/JG/NFuhTovkRtP/kfzYr/U8SfYeIqkHn0ShSYCVBh/mhA==", "f064206f-3522-42cc-a481-62ea6a1553ce" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 24, 0, 35, 16, 885, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "bcf04eec-7565-4c50-b09b-0691271689ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "2d0c1772-b76d-4c2a-8317-cbc3b9e2e8ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "95ef099e-47b4-4d26-bcc1-19019de11b33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "67a69b35-90bb-48e8-8c38-2cd721e79fdd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "1d5b2a9d-e6a1-465e-98b0-ffab2ec3390a");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("816e696d-72c0-4e62-a970-6809e2cd2e45"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("cda500bd-64bc-4b73-88c6-2c916f1ca449"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentConsultation_CreateBy",
                table: "StudentConsultation",
                column: "CreateBy");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentConsultation_Account_CreateBy",
                table: "StudentConsultation",
                column: "CreateBy",
                principalTable: "Account",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentConsultation_Account_CreateBy",
                table: "StudentConsultation");

            migrationBuilder.DropIndex(
                name: "IX_StudentConsultation_CreateBy",
                table: "StudentConsultation");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("816e696d-72c0-4e62-a970-6809e2cd2e45"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("cda500bd-64bc-4b73-88c6-2c916f1ca449"));

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "StudentConsultation");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a60c6e1-b402-40d0-876d-b34c6791f281", "AQAAAAEAACcQAAAAEDETo4oSraJddHNUG78SoR0jdNTa7BwKT933twFOaVmKgHYqQ7Icq3PM/nOxrZMNrQ==", "a11538e9-6dbd-40e5-988c-7369b0846176" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4f74d6d-e46c-405e-96a5-7248b979131d", "AQAAAAEAACcQAAAAECTv8/s6apinCw82nGTGM7JuFxZe88xUiS4KvLuUlXLQaxEKPsSlVF0yih+xlQuvJw==", "8343cfda-64ff-4f31-96ac-ebaf5d2332c7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57bd8696-dcf2-4099-b118-accbffa0f4e6", "AQAAAAEAACcQAAAAEJmpP6wL0aQZBCUv8B4RmQu6J6/cLJ7P9HEt2NstDqL0nG8CUrHTNkPG9bZ0ZInkvQ==", "98d87ed2-4616-4954-9882-f674a908d8a9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35afdd20-a64e-41f3-b4c4-6d853fdcfbe3", "AQAAAAEAACcQAAAAEIDJ6iIBKAEzBMIWKK9QdbDD8jynFFPmmCVv8OnEsdrm6QQD6gCTF2w7KBaRuBRZiQ==", "d64519fb-cd09-42c0-bab7-2b5e72851096" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706f23ad-a069-46a7-90a5-8489d55c7b80", "AQAAAAEAACcQAAAAEI74RHNY73/hc5bLf/2KG9FZ44jnjKHpWG2dpYudwHpVU9KqybVO8pBWJX46DEjjpA==", "0fbbbdd1-4f9d-4c9c-bc8e-dbfc590b80bd" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 23, 18, 54, 21, 519, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "c6509c87-ec03-48d2-986f-6fe3021aeaae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "53fcf724-f310-444e-b124-617ba6552662");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "770c563c-a0cf-476e-af96-e34170ea9309");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "3ebf5b07-52ed-418a-a7be-b6aed15e538b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "59cea2d1-490b-4c39-ba8a-0d804fcd8895");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("1e0290c7-60fc-4b0b-927c-dc0e764e04b0"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("7552dee1-1836-46a7-aaa5-07d7216a4a89"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
