using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MG1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("61e32021-c7f5-44c2-9d25-d9c683660abc"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f801caa7-e342-4e66-9d59-c7066112702c"));

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

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "Status", "SubjectGroupsJson", "Target", "TotalScore", "TotalScoreAcademic" },
                values: new object[,]
                {
                    { 2, "DAO", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DBS", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DBT", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DEA", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DFO", false, "[0,1]", 200, 24m, 24m },
                    { 2, "DGE", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DHM", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DJA", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DKA", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DME", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DRM", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DSM", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DSO", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DTE", true, "[0,1]", 200, 24m, 24m },
                    { 2, "DWE", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CAO", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CBS", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CBT", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CEA", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CFO", false, "[0,1]", 200, 24m, 24m },
                    { 3, "CGE", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CHM", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CJA", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CKA", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CME", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CRM", true, "[0,1]", 200, 24m, 24m }
                });

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "Status", "SubjectGroupsJson", "Target", "TotalScore", "TotalScoreAcademic" },
                values: new object[,]
                {
                    { 3, "CSM", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CSO", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CTE", true, "[0,1]", 200, 24m, 24m },
                    { 3, "CWE", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SAO", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SBS", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SBT", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SEA", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SFO", false, "[0,1]", 200, 24m, 24m },
                    { 4, "SGE", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SHM", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SJA", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SKA", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SME", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SRM", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SSM", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SSO", true, "[0,1]", 200, 24m, 24m },
                    { 4, "STE", true, "[0,1]", 200, 24m, 24m },
                    { 4, "SWE", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TAO", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TBS", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TBT", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TEA", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TFO", false, "[0,1]", 200, 24m, 24m },
                    { 5, "TGE", true, "[0,1]", 200, 24m, 24m },
                    { 5, "THM", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TJA", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TKA", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TME", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TRM", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TSM", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TSO", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TTE", true, "[0,1]", 200, 24m, 24m },
                    { 5, "TWE", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HAO", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HBS", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HBT", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HEA", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HFO", false, "[0,1]", 200, 24m, 24m },
                    { 6, "HGE", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HHM", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HJA", true, "[0,1]", 200, 24m, 24m }
                });

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "Status", "SubjectGroupsJson", "Target", "TotalScore", "TotalScoreAcademic" },
                values: new object[,]
                {
                    { 6, "HKA", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HME", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HRM", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HSM", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HSO", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HTE", true, "[0,1]", 200, 24m, 24m },
                    { 6, "HWE", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DAO", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DBS", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DBT", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DEA", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DFO", false, "[0,1]", 200, 24m, 24m },
                    { 7, "DGE", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DHM", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DJA", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DKA", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DME", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DRM", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DSM", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DSO", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DTE", true, "[0,1]", 200, 24m, 24m },
                    { 7, "DWE", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CAO", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CBS", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CBT", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CEA", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CFO", false, "[0,1]", 200, 24m, 24m },
                    { 8, "CGE", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CHM", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CJA", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CKA", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CME", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CRM", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CSM", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CSO", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CTE", true, "[0,1]", 200, 24m, 24m },
                    { 8, "CWE", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SAO", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SBS", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SBT", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SEA", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SFO", false, "[0,1]", 200, 24m, 24m }
                });

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "Status", "SubjectGroupsJson", "Target", "TotalScore", "TotalScoreAcademic" },
                values: new object[,]
                {
                    { 9, "SGE", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SHM", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SJA", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SKA", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SME", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SRM", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SSM", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SSO", true, "[0,1]", 200, 24m, 24m },
                    { 9, "STE", true, "[0,1]", 200, 24m, 24m },
                    { 9, "SWE", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TAO", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TBS", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TBT", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TEA", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TFO", false, "[0,1]", 200, 24m, 24m },
                    { 10, "TGE", true, "[0,1]", 200, 24m, 24m },
                    { 10, "THM", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TJA", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TKA", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TME", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TRM", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TSM", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TSO", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TTE", true, "[0,1]", 200, 24m, 24m },
                    { 10, "TWE", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HAO", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HBS", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HBT", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HEA", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HFO", false, "[0,1]", 200, 24m, 24m },
                    { 11, "HGE", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HHM", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HJA", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HKA", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HME", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HRM", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HSM", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HSO", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HTE", true, "[0,1]", 200, 24m, 24m },
                    { 11, "HWE", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DAO", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DBS", true, "[0,1]", 200, 24m, 24m }
                });

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "Status", "SubjectGroupsJson", "Target", "TotalScore", "TotalScoreAcademic" },
                values: new object[,]
                {
                    { 12, "DBT", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DEA", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DFO", false, "[0,1]", 200, 24m, 24m },
                    { 12, "DGE", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DHM", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DJA", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DKA", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DME", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DRM", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DSM", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DSO", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DTE", true, "[0,1]", 200, 24m, 24m },
                    { 12, "DWE", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CAO", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CBS", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CBT", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CEA", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CFO", false, "[0,1]", 200, 24m, 24m },
                    { 13, "CGE", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CHM", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CJA", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CKA", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CME", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CRM", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CSM", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CSO", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CTE", true, "[0,1]", 200, 24m, 24m },
                    { 13, "CWE", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SAO", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SBS", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SBT", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SEA", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SFO", false, "[0,1]", 200, 24m, 24m },
                    { 14, "SGE", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SHM", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SJA", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SKA", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SME", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SRM", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SSM", true, "[0,1]", 200, 24m, 24m },
                    { 14, "SSO", true, "[0,1]", 200, 24m, 24m },
                    { 14, "STE", true, "[0,1]", 200, 24m, 24m }
                });

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "Status", "SubjectGroupsJson", "Target", "TotalScore", "TotalScoreAcademic" },
                values: new object[,]
                {
                    { 14, "SWE", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TAO", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TBS", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TBT", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TEA", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TFO", false, "[0,1]", 200, 24m, 24m },
                    { 15, "TGE", true, "[0,1]", 200, 24m, 24m },
                    { 15, "THM", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TJA", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TKA", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TME", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TRM", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TSM", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TSO", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TTE", true, "[0,1]", 200, 24m, 24m },
                    { 15, "TWE", true, "[0,1]", 200, 24m, 24m }
                });

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

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AIId", "AccountId", "AddressRecipientResults", "AdmissionForm", "BirthCertificate", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgAcademicTranscript6", "ImgAcademicTranscript7", "ImgAcademicTranscript8", "ImgAcademicTranscript9", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiplomaMajor1", "ImgDiplomaMajor2", "Imgpriority", "Major1", "Major2", "Nation", "Note", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailPriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TimeRegister", "TypeOfDiplomaMajor1", "TypeOfDiplomaMajor2", "TypeOfTranscriptMajor1", "TypeOfTranscriptMajor2", "TypeofStatusMajor1", "TypeofStatusMajor2", "TypeofStatusProfile", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"), 1, null, null, null, null, "Thanh Hóa", new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9333), "Hanoi", "038301012222", null, new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9334), "nguyenducanh01.57@gmail.com", "Trương Thị Thu", null, true, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "SME", "HCM", null, null, null, null, "0971341555", 1, null, null, null, null, null, new DateTime(2024, 11, 18, 2, 29, 26, 844, DateTimeKind.Local).AddTicks(9336), 5, 5, null, null, 1, 3, 6, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 2, "DWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 3, "CWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "STE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 4, "SWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "THM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 5, "TWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 6, "HWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 7, "DWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 8, "CWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "STE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 9, "SWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "THM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 10, "TWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 11, "HWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 12, "DWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 13, "CWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "STE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 14, "SWE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "THM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 15, "TWE" });

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a702bba7-20e1-4080-9d0e-99ae67d5eb65"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("ac2cd4d1-a6b3-4411-b05e-c20db8c48ade"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfee7277-0597-46a4-90cb-9f7f97fde82d", "AQAAAAEAACcQAAAAEGPRgEsCVVppCFfdShXv92smHBrKGZTQXEWZUGDu23WJU0wS5GyjLRjtAbAq6jKghQ==", "8fe270f7-9cb7-4f20-b6b5-ded6b649f567" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea060d4a-df6f-4e62-b363-6458e0433d29", "AQAAAAEAACcQAAAAEIfuynfZnru5ZiIk3WIZ2meO+j0mC8ozF0wZy8D/EGMqx5eISTkCKqaTc9o9ge2UFw==", "79452d52-c9da-48e9-a781-77d89370ea97" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48a4b62f-b472-4653-b291-5886d3e0cabb", "AQAAAAEAACcQAAAAEAQFvYC5Kx8O1W86FdKANEDXD5qqTn4+vSqZ1H7hIZjT9qcwgoCkOjPJvm0cH8gdig==", "caf2c378-91c5-4857-a2e1-8a36c96434a0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1c90dd3-fb43-4211-b341-85f0a49e9579", "AQAAAAEAACcQAAAAEJt7/OlbaKVs7alZWmhERMsNEWKMo+jYE7roj0ceyX1vhyZDPXuQinnVMAjVS7lIYQ==", "37c296ab-0c86-4209-ac78-269e88f1c44e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef711d37-df87-470a-9866-09aceb7475e1", "AQAAAAEAACcQAAAAEAQ3b6KbcdTHtnMLasrv3XaRoXYYvRGHycMoxN8e2dN8t3RGGaz0amOeTNsNMczLjQ==", "4f376664-9b94-4c2f-927c-b5a66974221a" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "c73dcf90-6bf0-429a-bb80-2977d64bcf65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "401947de-77ce-45be-8c98-700e3aadebe7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "dc2de1ff-5df7-47a2-9d39-5e83651a82b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "fbbbe5ed-4d3f-49ba-9e5b-c46a176841ce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "274d71a9-c31c-4acf-8ee7-f0466d5bbd16");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("61e32021-c7f5-44c2-9d25-d9c683660abc"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("f801caa7-e342-4e66-9d59-c7066112702c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5291), new DateTime(2024, 11, 18, 0, 46, 57, 68, DateTimeKind.Local).AddTicks(5293) });
        }
    }
}
