using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdateAlldb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Link",
                table: "Notification");

            migrationBuilder.AddColumn<Guid>(
                name: "SPId",
                table: "Notification",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6decbbbd-f35b-4589-ba8b-6721ddd6ef69", "AQAAAAEAACcQAAAAEDwlE4qPDwa86K2ZsY/Zs46f+h9IxT6Z5rt6sAXldotD5Qqx0a47UDzAqWz4b/NHrg==", "a3335dd6-a2d9-4488-95a0-aae5eae19241" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58aa2d1e-2bae-4d04-940c-0aae889f9eab", "AQAAAAEAACcQAAAAED1hWODpU9IrelbSU5nZFi5K7/CIDhcox6mefTl8EH7E56E8s8iPz3AsRYfkmbKS6w==", "80321569-f4ac-4cd4-98e4-4f6ae2c3da64" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92810bc2-3273-402f-bd81-c11edc5aeea4", "AQAAAAEAACcQAAAAEJaOwPE7mtXWZaRA5GtEvMCpkRWKDK4SmpUM5OiQSrjlXvJ7XYrY3P3u21V1cwgPmg==", "d1c0a571-dd25-4511-b359-5834d2f1634c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcdcb696-6f23-4ff4-a9a0-1cb1181e10bc", "AQAAAAEAACcQAAAAEDkXTdN7fyJdsH4Pq6lEsioKmFu+jTffDb5GAEBgP9IogVIlp3qdfkHtLrECeg11QA==", "a4491ea7-03d5-4499-88fc-6e971ce96156" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2443a86a-adf4-4e20-a9bb-7fe5243547da", "AQAAAAEAACcQAAAAEDbk8XU6eWTioUVs/oVsx2QaYdbD1/m5DjvVzO4ptf64QcisLx66MPB1OQYMH06U8g==", "bc644ff9-4206-481a-a14f-c616ff56de5b" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 17, 16, 58, 48, 7, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "4ebcc52e-884c-4e15-9133-954de9e16965");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "603c8b6c-7b09-4e82-bdd6-83190e019af3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "c2435f68-176a-4918-95c8-ce42d93249f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "cbc2c990-88e8-4c28-9ae8-4d72d4ee618f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "7f7f3257-3147-4ab0-8247-c7cae6062b6b");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("05a78aa8-35da-4a33-8da9-0f49a56b0668"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("f56f9371-cab8-4791-8380-055dcaebbeef"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("05a78aa8-35da-4a33-8da9-0f49a56b0668"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f56f9371-cab8-4791-8380-055dcaebbeef"));

            migrationBuilder.DropColumn(
                name: "SPId",
                table: "Notification");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Notification",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
