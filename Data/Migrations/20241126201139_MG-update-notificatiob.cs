using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdatenotificatiob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("2fa69596-67d6-4aee-9c24-98a8a8b0314c"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("676c3fa8-30b0-453c-a125-1f1baa3c7445"));

            migrationBuilder.AddColumn<Guid>(
                name: "SendToId",
                table: "RequestNotification",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eaedc9b-b896-4567-9563-acffffe56563", "AQAAAAEAACcQAAAAEIhQY2oiHCQkC1McyPO/WYDaFzZzWi1LMfB8603GRigFnE3dUurvZWocFHQvOns4Zg==", "a5ed06e1-b7a2-479e-a21f-9c677a6242d4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e808e4e5-7248-451f-8d5a-aa9d0ef5cf33", "AQAAAAEAACcQAAAAEEm9jZCQYJqEgAVtjbX5FXpL6O13hO3b/zVuZAUq8rp3aHUeffGJ9Cv+iyDPvza6hA==", "aab35c0b-854e-41b8-8253-a2286ef76281" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f04c9019-8047-4b14-a7f7-974ae4d09eea", "AQAAAAEAACcQAAAAEH/D9hqs3lpP7yZb+1qox7L7KZGqnfCwEyWOUb+l74zQils2RZeDjhwEOfGGm56wAw==", "69045a2f-1542-4cb1-b25c-c7faf46bf240" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5642e8d4-7b2a-40a6-9618-723730faea0e", "AQAAAAEAACcQAAAAEErqjbHYooFWWzaMKD0uuVLSkCi+Sfs5hdQSHREIiHJxnxulqbmFWDYR7WDLoeFeVw==", "629a84c2-6a13-444c-92b8-1c0d9984b086" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b3dab46-4a16-4e94-b2be-d48569ae7937", "AQAAAAEAACcQAAAAEBspjf9ojeln7gcZE+Jj5HwReJ2f09iuO8P4HIEhXUXtD2rsYav4ns2IDkCp2n8sFw==", "807fd64d-1e2d-477f-9a1f-db3ba772ca68" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 27, 3, 11, 36, 884, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "4b05762a-1894-4f65-b305-d04e6ff8f19f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "d5b24a18-7b0a-41a1-8816-b49ac1182b21");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "bf71c790-a430-451a-be38-2521a039419a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "5c4a9a39-f024-4118-b53d-8c5a75addc2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "24ca22b6-ca54-452d-9352-75d8810a4fe6");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("a81d9fa3-6b25-4d43-9351-80518080a1e2"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("f81a31d4-9040-40f0-bb9c-2a8ebd82f287"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestNotification_SendToId",
                table: "RequestNotification",
                column: "SendToId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestNotification_Account_SendToId",
                table: "RequestNotification",
                column: "SendToId",
                principalTable: "Account",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestNotification_Account_SendToId",
                table: "RequestNotification");

            migrationBuilder.DropIndex(
                name: "IX_RequestNotification_SendToId",
                table: "RequestNotification");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a81d9fa3-6b25-4d43-9351-80518080a1e2"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f81a31d4-9040-40f0-bb9c-2a8ebd82f287"));

            migrationBuilder.DropColumn(
                name: "SendToId",
                table: "RequestNotification");

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
    }
}
