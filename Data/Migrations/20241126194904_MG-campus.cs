using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGcampus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("77550752-bddc-4a10-88ca-4b2028b421f5"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d4668c5d-0801-42a6-9694-a135ee78ecc0"));

            migrationBuilder.AddColumn<string>(
                name: "CampusCode",
                table: "Campus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13ab75a3-dce6-41f0-a215-26cec8b7c85b", "AQAAAAEAACcQAAAAEHJmplAo/AQtgu9o5MUFKgnK4eBHvMt+EERAaqid/fsutTzEYeX63RzD0iSOCKtyNA==", "0eb9a51f-147c-446b-92c7-255a4a09f0a0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "081dcbf8-6a9e-4ecc-9b24-861fb80f9e91", "AQAAAAEAACcQAAAAEF3F6Veuub+0Cp1ca05TBdBfgozI5c8HQwlECybLGhupp9pnDraynVLvj7dRJxBrVw==", "0ef48b43-c371-4899-8807-b29ff132436d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400269e9-9af1-4baa-b642-27284e3b2fa9", "AQAAAAEAACcQAAAAEElZLO5PXj3962ssuu8tWevuZKpieJKQ9Dg6RS0NH6UTKjLSCnP0gdjLy/D/DsiRFw==", "96942201-0f6b-4421-8eca-ced22788c1bd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "254d17c5-25f5-4fb2-97d4-3101719926c8", "AQAAAAEAACcQAAAAEF91LOaiss00DVo7k9Tf7tyh1v/JwWx3hsg23FdbzxmRefl5u3IrTOoppsVuDjFSww==", "fbf6fc2a-205b-4c16-8f48-b72d00d0e9bc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1919851d-09cf-432c-95a7-608549e8cb35", "AQAAAAEAACcQAAAAEH1NObOxB6fh+M3Uz50G8hxCWdsnipnyY++7wMehpJlER+zjexDzbpba8MmfVTXAFQ==", "5ffdec8c-f0f0-44f6-9f7c-be5b6256185c" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Cantho",
                column: "CampusCode",
                value: "C");

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Danang",
                column: "CampusCode",
                value: "D");

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Hanoi",
                column: "CampusCode",
                value: "H");

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "HCM",
                column: "CampusCode",
                value: "S");

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "CampusId",
                keyValue: "Thanhhoa",
                column: "CampusCode",
                value: "T");

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 27, 2, 49, 2, 83, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "46c2e8ac-03c5-469d-ba88-162d0b337e92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "466b3f58-a372-417a-a3d2-950b2b0a0a1c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "f99f859d-b35e-4837-90ad-0c008b08f29d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "9e6f2ffa-0e82-42fa-a3b9-524b8e2f8b4b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "0d993a68-13a1-49d0-a3c5-ab771a0c02a9");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("2fa69596-67d6-4aee-9c24-98a8a8b0314c"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("676c3fa8-30b0-453c-a125-1f1baa3c7445"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("2fa69596-67d6-4aee-9c24-98a8a8b0314c"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("676c3fa8-30b0-453c-a125-1f1baa3c7445"));

            migrationBuilder.DropColumn(
                name: "CampusCode",
                table: "Campus");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e452016-e8fc-40d1-bcf0-3c1f1bd1fd18", "AQAAAAEAACcQAAAAEGC8h/hQEquN+P529UC4c1EdvdH+yjBpigOo6leuDhW+X7fHVHDxy0UX6VmWtLNNdA==", "fa183d47-b697-4d78-a361-3880efe7c4af" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ae367e1-9a9a-45fe-8acf-a54e151d228b", "AQAAAAEAACcQAAAAENsGExXiRnqpy65YNoDyOrjnDx7Z0m18whIfg6efnhjHs0Gb4m1618Eq4dQeKdwKdg==", "48ba6b8d-e24f-4dde-9ccb-88ceed7b511b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f802a4b-58fd-4ba5-acb1-ff6445979c0d", "AQAAAAEAACcQAAAAEGExf7BCocbfsLfI9R7vIGFEiuiFLTT6wQ5iYZztyxWc+ts8pZiTIiLAbOfbbpk2YA==", "4813adff-f933-4417-835b-4c0e1a8bc9f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0020b670-3e2c-4dda-a679-f2073b0ade04", "AQAAAAEAACcQAAAAEERM4nNxNccp/a0SLmuQ0IxGqyOA7IDcjuzMiPiM09Xp1oXD874mes3TkFFsWBOkiw==", "13a16a85-48ca-47d0-8fa0-7ac0146c99f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0159b95-921f-404a-9b10-3b5f595ed438", "AQAAAAEAACcQAAAAEOJxyK9gimvgWy8R4t0bbAK6rDx9ucv9BoiJVbpdPYEUeaQHH+IPhuYV1JNGbY+TfQ==", "56ef9ae4-3c34-45bf-82ea-15f376c32922" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "57bf4ca0-ef27-43a9-96e8-ce8b3baee87b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ee2f11ec-08ee-48c9-96ee-39167d2803b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "5fe5f0b0-1dd8-4849-b045-38b84e33d580");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "d461392d-2684-4091-aac4-e5bef562c1b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "3aa3da03-19c7-44cf-9be2-5d3f2f9d7a05");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("77550752-bddc-4a10-88ca-4b2028b421f5"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("d4668c5d-0801-42a6-9694-a135ee78ecc0"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
