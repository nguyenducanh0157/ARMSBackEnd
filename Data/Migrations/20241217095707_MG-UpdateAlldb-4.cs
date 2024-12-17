using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdateAlldb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("6aa71370-af52-4493-8278-646b41ac0306"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c418b65f-88b6-4fa7-a582-d1d5520ec2fa"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Notification",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34aeba8b-14e6-4f50-9767-605b876f8a69", "AQAAAAEAACcQAAAAEP5GkNUs90UBTCKQ8WxIwV9xAVLKx8e/ZRvuwtgJ27/7TzFAM7YGQU1tm5nhb+qttw==", "76709e67-f55f-4a27-8d89-50857d242d60" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "371aa4dd-1339-482a-b3c8-b94ac22e1fa6", "AQAAAAEAACcQAAAAEJRRLvD/O+HWdW5SBWtj993APf9Z64fN2YY9vYlu9c738XGLZh2yhYB2orHZqeVfAg==", "2ff20368-a119-4678-accb-85a8810d840e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d2d0920-3bee-4f30-ac2d-d49cf66c1bd9", "AQAAAAEAACcQAAAAEAHZLhiNZov9UC99/inMgSDrej7D+p70sccZFZGF6jJaPgqVw73hqUJ7UnYCKzRvnQ==", "522cadae-cb6f-4abd-b54d-b433f4dccc8e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01654df8-b53f-47de-a786-51618bbb482b", "AQAAAAEAACcQAAAAEEpk4Atvl9PUpsdjT4pW0wVpDHXEK0ubkqFk9d9XAChW7ycU6aL0/2g4gLWv0WcH7A==", "6fdbc477-3703-4863-8e31-b6f91f4ca472" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac2aa68-3630-43e6-ab57-4bc447adfa70", "AQAAAAEAACcQAAAAEKKdZn1Oaj005M8/k1Guc+v3AaAQWCP7moa5O50Xzu6H1V8kZNOKwbLXHRRNh7Db8Q==", "f2ade401-4db1-4925-858e-f73c7ac36ba9" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 17, 16, 57, 6, 68, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "faf22a46-10cc-4a6e-af54-b8126bd5c69d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "c5cf07ec-6fde-45b5-baa7-1e899f6a00b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "cb98c860-6ba1-4979-90ff-e79cba6ea504");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "e3d51f5e-8aa3-4503-bb25-5d8017e0142f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "d8ffd54d-7038-4cae-9ae5-c7d55640615e");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("993a8477-bc22-4567-8e7a-85d3f11fdd4b"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("d196d132-d103-4efc-98cb-c41067f73870"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("993a8477-bc22-4567-8e7a-85d3f11fdd4b"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d196d132-d103-4efc-98cb-c41067f73870"));

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07284d0-0dc0-430c-8cc2-e5b1a64a0230", "AQAAAAEAACcQAAAAELq9aC+qh8rLgfbNQBov2RRFisOiFyTkk0grUuUZpNGzrIJahCeiAkjbKn7uWj2GKA==", "1e5708bc-d7db-4d10-add7-77ce38aabc2d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11556b18-62dd-4957-aaad-c524f34e3bdf", "AQAAAAEAACcQAAAAEKdibB9LtwURggXqn49ylRS3BHiJmB4Pd+5uDGUQ/MEpXO/qxbOg1biAIDaNrAFuEA==", "9c531378-29b8-430d-821a-4909e08eba0d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1ea36f2-71f5-48d7-982e-62a80f746b7f", "AQAAAAEAACcQAAAAEPAb8SHNlMbNs3OZbK1Tkdi8xB725SyjOpJroFU4ubdxzXtp5sfdf0jAff8EkRwy2A==", "45823980-79c1-41a3-8811-54db842e6708" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa1e266e-5d13-4835-bf6f-c9f3463ac24e", "AQAAAAEAACcQAAAAEGxGHYjFVqRdkzqpZr2hK6uLzdgi1YVPXx8ztK7g8kebwNjdEwuadhtRYRpFEO8giQ==", "e31ccb05-9209-4ab5-845c-1c00267728ac" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1779e28a-82c0-4d03-ab00-d1a883cd3ecf", "AQAAAAEAACcQAAAAEL+066UQ4A5VGJN99SCjG5Y2Krq31pO9koxIINlQSQcQSSt5FI4sBWZfWSjZmOSKaQ==", "302aab4a-1f26-4d2e-97d8-67f48eecceaa" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 17, 16, 47, 51, 839, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "3a93359f-8aec-4ca9-b1f4-2add460133d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "d7fc9c4e-e9ca-4d55-97be-4736bfa90148");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "f41827d0-ba06-4700-ae7f-fda10b8ba451");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "5fb39e01-00c8-45b1-85ee-6f9ff4c98570");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "a8676d44-4e62-4576-8418-a7d775981d50");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("6aa71370-af52-4493-8278-646b41ac0306"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("c418b65f-88b6-4fa7-a582-d1d5520ec2fa"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
