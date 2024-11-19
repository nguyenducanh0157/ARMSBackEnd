using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MG2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a702bba7-20e1-4080-9d0e-99ae67d5eb65"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("ac2cd4d1-a6b3-4411-b05e-c20db8c48ade"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d34049ba-7476-4781-a962-28e9aaee8f7c", "AQAAAAEAACcQAAAAEHtDYgLws25h9tN/xaMLlmFk+8CN3wpZUx+HXhknGXKwpSY8RH5FZSPmdvosDBrd6w==", "eb292e97-dce0-4a83-9d01-497ace9367f6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84714313-d177-471c-9b34-481265fedbcd", "AQAAAAEAACcQAAAAEFFvZ/+mCsSW8l8CDidP4T8vHwZEBtoJnxv6udkrc/r8mTgyPrtl50I2Cxh63LaM1w==", "9d4e42c3-4226-482b-8f74-28744ebad838" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c021a6d-f1c1-4eaf-9db0-5a93c5ae1def", "AQAAAAEAACcQAAAAEACUhgV5/L+A3RpK5cut82OCpybN87nliE/XDeynlGo+2gDgmtwoL5L5klsXjBWjNw==", "4e7a7d26-d730-430f-b619-4eabdc81b474" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62b683ae-76c7-49ae-89e1-138a394dfef6", "AQAAAAEAACcQAAAAEFI6jffDP+yAHDX3U2iTPm3RE/5UWuPQMRBDJpv9kdyVgwc6+QOXjE/mXJ1aWJV7hA==", "a7a43f54-5565-47d4-9a70-8c28706ff910" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3c64be1-1fd5-43d6-ba5d-c78169327ff4", "AQAAAAEAACcQAAAAEA1LnMKwjGVUHEB0y1zRhsgE7z/I0Hd7rApvxueFwVgGJaG3KO2/5lljBaZrU24HTg==", "901761f1-c013-41cf-a969-23371a2a412d" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "ac4ada70-c391-46ab-8b3f-a59c33b880e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "5327d2c8-fda2-407a-a949-bf97e47ee81b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "2e14afba-ea78-465c-adcc-1b8284406482");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "c8ae383f-0e14-42e5-93ef-546ff051cde2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "c43597c7-0811-430d-9e8d-8becb1acb30e");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("06da53a7-71e2-4b90-a65b-c45788769406"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("3e4a3377-c498-4e7e-8a7a-05496a83036c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"),
                columns: new[] { "CIDate", "District", "Dob", "EmailStudent", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgAcademicTranscript6", "ImgAcademicTranscript7", "ImgAcademicTranscript8", "ImgAcademicTranscript9", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiplomaMajor1", "ImgDiplomaMajor2", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "TimeRegister", "Ward", "YearOfGraduation" },
                values: new object[] { new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quảng Xương", new DateTime(2001, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoaithu1707.25@gmail.com", "Nguyễn Văn A", false, "", "", "", "", "", "", "", "", "", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fcccd1.jpg?alt=media&token=a72b40d8-50e9-439a-9ded-977a7cf6eed9", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fcccd2.jpg?alt=media&token=36141516-93fa-440d-adaa-55f707818621", "", "", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fgiay-to-xac-nhan-doi-tuong-uu-tien-tuyen-sinh.jpg?alt=media&token=704b6826-0b67-4242-ad66-c515deec95fb", "HME", "HGE", "Kinh", true, "0971341555", "Thanh Hóa", true, "Trường THPT A", "Số nhà 129", new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(642), "Quảng Ninh", 2024 });

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 11, "HAO", 1, null },
                    { 11, "HAO", 2, null },
                    { 11, "HAO", 3, 1 },
                    { 11, "HBS", 1, null },
                    { 11, "HBS", 2, null },
                    { 11, "HBS", 3, 1 },
                    { 11, "HBT", 1, null },
                    { 11, "HBT", 2, null },
                    { 11, "HBT", 3, 1 },
                    { 11, "HEA", 1, null },
                    { 11, "HEA", 2, null },
                    { 11, "HEA", 3, 1 },
                    { 11, "HFO", 1, null },
                    { 11, "HFO", 2, null },
                    { 11, "HFO", 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 11, "HGE", 1, null },
                    { 11, "HGE", 2, null },
                    { 11, "HHM", 1, null },
                    { 11, "HHM", 2, null },
                    { 11, "HHM", 3, 1 },
                    { 11, "HJA", 1, null },
                    { 11, "HJA", 2, null },
                    { 11, "HJA", 3, 1 },
                    { 11, "HKA", 1, null },
                    { 11, "HKA", 2, null },
                    { 11, "HKA", 3, 1 },
                    { 11, "HME", 1, null },
                    { 11, "HME", 2, null },
                    { 11, "HRM", 1, null },
                    { 11, "HRM", 2, null },
                    { 11, "HRM", 3, 1 },
                    { 11, "HSM", 1, null },
                    { 11, "HSM", 2, null },
                    { 11, "HSM", 3, 1 },
                    { 11, "HSO", 1, null },
                    { 11, "HSO", 2, null },
                    { 11, "HSO", 3, 1 },
                    { 11, "HTE", 1, null },
                    { 11, "HTE", 2, null },
                    { 11, "HTE", 3, 1 },
                    { 11, "HWE", 1, null },
                    { 11, "HWE", 2, null },
                    { 11, "HWE", 3, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("06da53a7-71e2-4b90-a65b-c45788769406"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("3e4a3377-c498-4e7e-8a7a-05496a83036c"));

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HAO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HAO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HAO", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HBS", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HBS", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HBS", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HBT", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HBT", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HBT", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HEA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HEA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HEA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HFO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HFO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HFO", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HGE", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HGE", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HHM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HHM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HHM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HJA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HJA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HJA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HKA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HKA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HKA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HME", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HME", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HRM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HRM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HRM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HSM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HSM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HSM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HSO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HSO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HSO", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HTE", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HTE", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HTE", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HWE", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HWE", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HWE", 3 });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed8e0c20-e846-4933-8c54-3750cc95473c", "AQAAAAEAACcQAAAAEEQGYEaKeVT5x4OA9R//E+8kZEDTHRzRhfjHoWYibSM7FfBU11Akc8bPAGlTNpxf9g==", "aba189fb-e3af-437e-92d8-048924371d03" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3d23a4f-c290-4725-bcb2-d1d56f93a62b", "AQAAAAEAACcQAAAAEHoaSDp7UdE11B4v6iZ7iDyslscSDVPlW7qBftEStwY2TjAucIq4rjHrmMN/z5nyLQ==", "5afa0ccc-5a4f-49c5-b489-779376eb3501" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74d3b194-f5b8-4486-9a55-c88d5d2a0ec4", "AQAAAAEAACcQAAAAEEwLlMldKZYh24NtK5RzKkHOLbjd8MRyfOnw2BlP8D3Hh4J6njWL3DNoa/e+GwOTJw==", "1f8edcc9-8e07-4852-bb71-2a8e40294322" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78648924-9edd-4cb8-acb9-dc367f071653", "AQAAAAEAACcQAAAAEF217kFSacBmM3vhAg6M61Dx8Z0ugagF4XzRqgDmZQ3e+JCin1P6C4hsE6d/NGLyBw==", "0be79d73-b34c-4475-9cd3-3329a67bc10f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce1ed401-50a8-4292-bc82-0277ee0befb5", "AQAAAAEAACcQAAAAEDunWVJ3NSC/SbQlwhcyFIU/n6eB0ljv3i5HN3QrswE4tR2ntS0f5U3VEsPzcqbGhA==", "94c98eea-f52a-4e79-a57f-a22b5b1daf6e" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "4c87eb8d-727e-4524-a16f-c8127cb73362");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "9315c73b-3fe9-47a8-b1ef-dc72e6374e3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "6cc858bd-e951-4c2d-9425-c6277b7f10cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "560b1310-d279-4d3c-9fd4-8d82dfc699f2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "f558e52b-2a6f-4b35-89a8-886e1944b8e3");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("a702bba7-20e1-4080-9d0e-99ae67d5eb65"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("ac2cd4d1-a6b3-4411-b05e-c20db8c48ade"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"),
                columns: new[] { "CIDate", "District", "Dob", "EmailStudent", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgAcademicTranscript6", "ImgAcademicTranscript7", "ImgAcademicTranscript8", "ImgAcademicTranscript9", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiplomaMajor1", "ImgDiplomaMajor2", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "TimeRegister", "Ward", "YearOfGraduation" },
                values: new object[] { new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9333), null, new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9334), "nguyenducanh01.57@gmail.com", null, true, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "SME", "HCM", null, null, null, null, null, null, null, new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9336), null, null });
        }
    }
}
