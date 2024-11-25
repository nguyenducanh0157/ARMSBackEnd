using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdate_AT1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("545136e0-91f7-4a79-9a92-07f8d8c4a8ce"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("92d08d22-37f6-4a1b-81df-ad747abdb0d6"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38c9a5c3-b5aa-4566-a203-5c68d4efc133", "AQAAAAEAACcQAAAAEDesTQLZeSN851iZApPQVDkPilsxzNDySqRyZUENh4zHp0InyG03+/RyqaXDVVw10Q==", "cd970654-c802-44a1-8c79-c148489b92c8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e01396a-0871-4586-b4ba-adc0f6fddf4c", "AQAAAAEAACcQAAAAEL+K2IDreNodLA5Gt1ob1Dm9Jd5tFWhKDW7QU3nvia8OQoRC+HG5ptuYkIFasiLfeA==", "0ce44571-f1e1-4a3f-a0fe-50cf56e9cdc3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c182303-7d6c-486a-83d6-a0436e77f84b", "AQAAAAEAACcQAAAAEFE3Ek394FOGPQ9Sj/1o5dXl38HQInGhgcCiVzv6z1o0Enquj6qMpmUlA6l62/2g7w==", "2eabb1a5-27b3-4cf1-9209-b0b5b360b298" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fadfd2df-acc6-4545-a2b6-4222cd85911a", "AQAAAAEAACcQAAAAEMdbBt9a8TGffcdykCM93v4Q4bshhWpGbU1ex5txZfUStZdFZgNyiHYpqk5GtSpATQ==", "1bba8f16-040d-48c8-8c20-b4f46b5a57c5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f57cc6e-06a0-49f2-8a86-b790e605acfd", "AQAAAAEAACcQAAAAELzsm9jCug+umXTAn57vGVdFi9mzFqjwK78evPgyBxHvorxmMJeN/LX7+vdkvnl14g==", "f907e8f8-0713-44d1-8baf-852727d4a3f3" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "30480fc5-09fc-4234-865b-667d84efc54a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "666ba211-9a05-44b4-83a4-a2dc3cc57665");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7b05101d-bd7e-44d1-8999-8f397f60f6bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "056d3ad3-0fc6-481e-a6e1-7580e07a9cca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "b9e3e7cc-afb4-4c44-9bd1-c4b8bc725933");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0764f7b0-0147-42ce-9047-bdd53c3cde39"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("c6b1243f-e357-4583-b0e5-2ae77fe214e1"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0764f7b0-0147-42ce-9047-bdd53c3cde39"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c6b1243f-e357-4583-b0e5-2ae77fe214e1"));

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
        }
    }
}
