using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdate_AT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_AdmissionTime_AIId",
                table: "StudentProfile");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("816e696d-72c0-4e62-a970-6809e2cd2e45"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("cda500bd-64bc-4b73-88c6-2c916f1ca449"));

            migrationBuilder.RenameColumn(
                name: "AIId",
                table: "StudentProfile",
                newName: "AdmissionTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentProfile_AIId",
                table: "StudentProfile",
                newName: "IX_StudentProfile_AdmissionTimeId");

            migrationBuilder.RenameColumn(
                name: "AdmissionInformationName",
                table: "AdmissionTime",
                newName: "AdmissionTimeName");

            migrationBuilder.RenameColumn(
                name: "AIId",
                table: "AdmissionTime",
                newName: "AdmissionTimeId");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1a8a33c-3186-4fb2-ab2f-aba5f5913d11", "AQAAAAEAACcQAAAAENpWzChFZroCYlc7wyxSmHdA/yDvDQuITsqYCRiTiV3leH2pG5ZYHH94bjmrzln7TA==", "6591caa1-843a-41c4-bf17-a7c571d039df" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf459f09-6ba5-4373-9bb8-6d4e8be973a5", "AQAAAAEAACcQAAAAELw7VW7zgFbKeH99pAEarRMFJRhFyoRr1Z/sMbkwmTqwugjHdu9lsGnV146wMY5yzg==", "96ad1f87-b5b7-4242-95f1-4b1b99ca0313" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "512f8de3-29ea-4fb5-a2c3-9061d945f418", "AQAAAAEAACcQAAAAEEzBXIP1tkDj5Hdm7Ja6HT0CAP0gVel0v7rVPNBgRgGk8FR86JUv0FTGW7IK1AGKLA==", "537ef188-a64b-49a5-a681-3baa4cf729c9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85fc0acc-89a4-4340-807e-0a4fe28787b1", "AQAAAAEAACcQAAAAEPCbMGP7g+vTWpXlk/FykB7IOPkcxOuwBl0St5rkN2lj7/qwGMyYUWXQc5Ij1rkJEQ==", "e0cb879e-07f1-46c2-a434-b86012d77eeb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5778f880-ffa9-42b0-a336-49802f73dba2", "AQAAAAEAACcQAAAAEHTaboGjFrFABgyLsu6GdBdMQmfgUAEwmAIJmkMtc9uU6+UPxAWEFnPkB+UwnGrDYQ==", "42ac391b-b738-447d-bedb-7a65fe11f3b6" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 1, 20, 51, 232, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "a90aef91-f424-46ca-a235-3aa0ae5fc3bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "304fad32-a373-443b-ac08-bd9dbaabdd33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "6d59b682-bfd7-4271-95bd-f2b3c48b749b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "23c61ecf-bd98-47c6-8068-0a7433df8a85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "31e61c05-e1ea-40e6-bfcc-5c11f18167a5");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("545136e0-91f7-4a79-9a92-07f8d8c4a8ce"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("92d08d22-37f6-4a1b-81df-ad747abdb0d6"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_AdmissionTime_AdmissionTimeId",
                table: "StudentProfile",
                column: "AdmissionTimeId",
                principalTable: "AdmissionTime",
                principalColumn: "AdmissionTimeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_AdmissionTime_AdmissionTimeId",
                table: "StudentProfile");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("545136e0-91f7-4a79-9a92-07f8d8c4a8ce"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("92d08d22-37f6-4a1b-81df-ad747abdb0d6"));

            migrationBuilder.RenameColumn(
                name: "AdmissionTimeId",
                table: "StudentProfile",
                newName: "AIId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentProfile_AdmissionTimeId",
                table: "StudentProfile",
                newName: "IX_StudentProfile_AIId");

            migrationBuilder.RenameColumn(
                name: "AdmissionTimeName",
                table: "AdmissionTime",
                newName: "AdmissionInformationName");

            migrationBuilder.RenameColumn(
                name: "AdmissionTimeId",
                table: "AdmissionTime",
                newName: "AIId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_AdmissionTime_AIId",
                table: "StudentProfile",
                column: "AIId",
                principalTable: "AdmissionTime",
                principalColumn: "AIId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
