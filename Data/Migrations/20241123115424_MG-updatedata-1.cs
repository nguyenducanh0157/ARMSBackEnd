using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdatedata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0b240e03-52e5-4ec7-ba0c-4ee7cd7abdf3"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c87e03d9-cb8b-4ae6-b4c3-03b4ac11a52b"));

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HGE", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HJA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HME", 1 });

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

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HEA", 3 },
                column: "TypeOfTranscript",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HTE", 3 },
                column: "TypeOfTranscript",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HWE", 3 },
                column: "TypeOfTranscript",
                value: 4);

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 11, "HGE", 3, 0 },
                    { 11, "HJA", 4, null },
                    { 11, "HME", 3, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1e0290c7-60fc-4b0b-927c-dc0e764e04b0"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("7552dee1-1836-46a7-aaa5-07d7216a4a89"));

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HGE", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HJA", 4 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HME", 3 });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7266290-ee05-4e5b-b089-3cd04c319dc9", "AQAAAAEAACcQAAAAEBlH6Zd0Ana5go9YAusVT/ch/ojFIxhJYuB6MoRIwzYVbxpt1+veu1OOGGhxUbAEvg==", "a4c88cc7-aeb1-4b6b-b190-8b11ea2b30e9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3808deae-5015-4daa-893e-f455a616df75", "AQAAAAEAACcQAAAAEFUDqgJWt0GDn0ya+whLIFh7yihMLfOMZ63piy3y8bGu44HGiAVHDk13yxqEApSdGw==", "d449fab4-afe7-464d-aac6-22fbf8655db9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "058a72ef-2c7e-487a-a332-2854b9869304", "AQAAAAEAACcQAAAAEEar08I5gmv1DrhLUQNbnG7T6cGYOXV1vzv59xTbXauwvyDSpzMNVw64dtOYCzz2lQ==", "927a7211-8e01-4446-854a-040246681712" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87686328-d7f3-4d83-80f1-8237366777c7", "AQAAAAEAACcQAAAAEAC53pnomfsDwvXEKffQ+B1/OKdpppeZ0Avxy1i19djYpIMA4SEr9TNi9Zn1VyqfSA==", "ef090bb4-9f2b-4b6c-96b5-4f6a1b12a84a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e79d2fd-b404-4213-af15-cced82a61b48", "AQAAAAEAACcQAAAAEAI9e3qlWZ3TEToDSdLbN1LTtDrkMCSZPCboOCOadAv6+Rvk8L95t7FSbefWmwaN9Q==", "1a3a09d6-c23f-41b9-847b-50d7cfb332d0" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "d3f87afe-32d5-4fee-bd6e-2d250794ccf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "0e409c04-d7bf-4339-ac92-26df5c621b83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "aeebc4f7-3020-453a-9eaa-3d056ebda7c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "cf4d9a14-34d9-4599-9910-97e2bc58b64e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "ed134558-d3e4-4f1e-861d-47a702d3d12a");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0b240e03-52e5-4ec7-ba0c-4ee7cd7abdf3"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("c87e03d9-cb8b-4ae6-b4c3-03b4ac11a52b"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HEA", 3 },
                column: "TypeOfTranscript",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HTE", 3 },
                column: "TypeOfTranscript",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 11, "HWE", 3 },
                column: "TypeOfTranscript",
                value: 1);

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 11, "HGE", 1, null },
                    { 11, "HJA", 1, null },
                    { 11, "HME", 1, null }
                });
        }
    }
}
