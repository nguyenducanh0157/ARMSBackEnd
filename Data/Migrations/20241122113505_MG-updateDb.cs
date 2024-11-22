using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("06da53a7-71e2-4b90-a65b-c45788769406"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("3e4a3377-c498-4e7e-8a7a-05496a83036c"));

            migrationBuilder.AddColumn<string>(
                name: "OrderType",
                table: "PayFeeAdmission",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1029df6-f937-40b0-b012-c49d96a3857b", "AQAAAAEAACcQAAAAEDNDI0Iru/c3jQLOH5r91uwB+cV2xRQGah75x7nHrCdlRI77DXDoy23FHZRF1EzgYQ==", "39dfcd3b-225e-4615-a25b-d2bd0f161566" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efc3c478-8626-4db3-8a43-15c5ab1c7923", "AQAAAAEAACcQAAAAEAROwsZ1h5h3Y5YYaFkHZHXs5uJg+GzcSiUez3oJpuoBf70u0g4oT8//QCBMZ9V2MA==", "ab6f4423-a148-4e40-a539-bb2fc1d571af" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce4a2828-77c8-4b86-bbfd-28cd9a64ad9d", "AQAAAAEAACcQAAAAEDUVs4wSDnHWKkHjn6h6cMF86klOdGiOnpA33K1mWbMr7oNzMXWKSxPr/LgNtzi8kg==", "dfc8df40-e261-4d69-83e7-be1bd58481ba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f4a681b-12fe-4739-81aa-5eafb7dc4fd5", "AQAAAAEAACcQAAAAEMzdVdNnIZoJbFHgYJmfEXAmI9122WVS9pdkC+xXqAuY/RRW8DXuELpSg9Ipr+LmPQ==", "4e539117-9c46-4343-86d2-04fb583b150b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5853a80-4f5a-4967-8236-8ba2eca4b869", "AQAAAAEAACcQAAAAECeFBK9snQk1HkM63iSqfcuk4WR8N9WhipJhANqKVbNQenqwNOy5IbKZLB34w4NXbA==", "fb6715a8-aece-403d-badb-325fcb9ef342" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "1da91266-43dd-479b-88d8-ab59bb245c57");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "dcd349eb-32ec-4c40-8c34-357c56c09a84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "10dfd37b-8ce0-47f7-96bf-d9f032465d85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "531b6a81-1638-4f6b-b001-917bf6cf3bd1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "fd8736ba-b69a-43bb-ae58-62a6042f8019");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("1916fe0a-4b70-4451-9400-e23b85037909"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("f2d5c9aa-1d08-402c-b461-0e98e93d5e8e"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6301), new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"),
                column: "TimeRegister",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6319));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1916fe0a-4b70-4451-9400-e23b85037909"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f2d5c9aa-1d08-402c-b461-0e98e93d5e8e"));

            migrationBuilder.DropColumn(
                name: "OrderType",
                table: "PayFeeAdmission");

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
                column: "TimeRegister",
                value: new DateTime(2024, 11, 20, 0, 29, 48, 424, DateTimeKind.Local).AddTicks(642));
        }
    }
}
