using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdateAlldb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("65ca7474-73f3-4419-823c-0b7fa412bfa1"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("9d128fe4-3dd6-4c20-b111-fbeb35256430"));

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isRead = table.Column<bool>(type: "bit", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeNotification = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notification_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Notification_AccountId",
                table: "Notification",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("6aa71370-af52-4493-8278-646b41ac0306"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c418b65f-88b6-4fa7-a582-d1d5520ec2fa"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33434131-d65b-4893-a286-dc882db32197", "AQAAAAEAACcQAAAAEOw2id35WUWkmxoWCddx1oHN+pOkUPCEUp3axThrS0RmwB+/Ik2VJiXZrn1LuYWicw==", "8a2025cd-b087-49ed-97c6-77fddbfdfb19" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbdfb4ea-5aac-45a2-8a86-fffb2e9f81d9", "AQAAAAEAACcQAAAAEK6WBr1TnqNVufPi0LBwGFNc/wnAelKSpcBGCB5re6AHYbDqDedULEtDMO8ABKjmJw==", "1f2e76c4-375c-4ca7-98bf-23a4482c2100" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23700522-3acd-47c6-878f-134fd059baaa", "AQAAAAEAACcQAAAAEDeIRWjNwacDv8QQc/LEbeJfIHK5tEjbXbTWIFnf+LB6IS+dfhkCw8qFB5PXWUB/pw==", "33301174-fcd8-4fcd-bbe9-af7db60c6d4b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b4b5ad1-f276-44e7-ac44-2b1a30616b05", "AQAAAAEAACcQAAAAEC3jV8uQABKC4tyZkjWDLxGrt10ZmClLqjBYFygCxwbkPiAh3qpn9qk0q/yY+j/wQQ==", "7174e041-eec5-4208-abc2-27666ab9e685" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3252bcfd-bbca-490c-8838-dee46cc7447c", "AQAAAAEAACcQAAAAELTjuO5iUWUwk0UyZNZ8UukwGtPyx6LH3sI20UhyHKR0jfnyPdydfwEfNj7T5qyAHQ==", "a1681643-2089-4970-a730-cac2b60d0616" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 9, 2, 28, 59, 165, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "1b36ec0e-2cad-4223-b17f-374bb53cca9f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "386b0902-cb4b-4c8c-b31f-b77a3ed6afa8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "8952200e-0421-42c2-b0f6-5399384aac94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "d2d8c1eb-0109-4f81-a985-abc89bb7d135");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "d2828e1d-1c73-4746-b683-c734a95e5bd2");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("65ca7474-73f3-4419-823c-0b7fa412bfa1"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("9d128fe4-3dd6-4c20-b111-fbeb35256430"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
