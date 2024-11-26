using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdateall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "SendToId",
                table: "RequestNotification",
                newName: "SendTo");

            migrationBuilder.AddColumn<bool>(
                name: "isRead",
                table: "RequestNotification",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "877158a8-aec8-47e1-a4c9-8e584239a774", "AQAAAAEAACcQAAAAEBkMSLwPjhNtEvGnIJxVmZU0i8R3YitTEGbs3iRPHTJsockmgErnUU33bvNZWGJ55Q==", "ec2476e6-14c4-4844-8921-c6876218fe85" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc4aa38b-98d4-4c09-a31e-7b44aa0fb1f6", "AQAAAAEAACcQAAAAEN3VwtEla/cOHjXvldb4vOZy7AByBWHp/y1bniEJ8wFhXjM38xlh7RIbfOuxdfNMGQ==", "1bea899c-5079-4d97-bc19-516e9249b704" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd0d5be6-3d22-49fd-811c-35a69a241974", "anhtran120786@gmail.com", "AQAAAAEAACcQAAAAEPlheNLUHmCxe5PRFk9zciuMO0TYbw8BovtyJmzi0OSOcOHyZSJEyQBpyxcVFxjEZQ==", "15dff7c2-ab17-4e20-882c-eca0a1012dc5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e2f83dc-888f-4689-a288-af4c093e097b", "hoaithu1707.25@gmail.com", "AQAAAAEAACcQAAAAEBJ+WckqrRRtC53BJMFzwg8ifSjW1LBt/s/T0A//WCDCnYib4T/cp7ki49KVl+H+Nw==", "fee307ac-4b9d-4fa5-bd64-816cdeb3618c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b5eb7a4-0e65-455c-aee0-ee2fb0f01e71", "AQAAAAEAACcQAAAAEAiKtTwRxqK2PzeS+nEG2ovJN9PGooWFpf5S9WUAYYg6Ulhb+7Ox1huomYlHjSubTg==", "4dd78687-ba2b-4538-9979-cdaa5bb6ca56" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 27, 3, 23, 31, 154, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "5d592c1b-82d3-4c79-be45-24b2a78bd9be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "73e3edf7-3d65-4e70-bc1e-6dfe58832263");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d7abc3bf-7513-478a-b4e2-5119dc903f90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "591c5e81-7154-410c-9aff-93bdc7583175");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "494d71be-1f52-4c61-a04e-d3279aeb500c");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("3dee6319-1fcc-4e93-b7df-dab686679877"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("3f17e6bb-ad1b-407e-bc7a-f9dd231d253f"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("3dee6319-1fcc-4e93-b7df-dab686679877"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("3f17e6bb-ad1b-407e-bc7a-f9dd231d253f"));

            migrationBuilder.DropColumn(
                name: "isRead",
                table: "RequestNotification");

            migrationBuilder.RenameColumn(
                name: "SendTo",
                table: "RequestNotification",
                newName: "SendToId");

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
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f04c9019-8047-4b14-a7f7-974ae4d09eea", "AdmissionOfficer@gmail.com", "AQAAAAEAACcQAAAAEH/D9hqs3lpP7yZb+1qox7L7KZGqnfCwEyWOUb+l74zQils2RZeDjhwEOfGGm56wAw==", "69045a2f-1542-4cb1-b25c-c7faf46bf240" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5642e8d4-7b2a-40a6-9618-723730faea0e", "AdmissionCouncil@gmail.com", "AQAAAAEAACcQAAAAEErqjbHYooFWWzaMKD0uuVLSkCi+Sfs5hdQSHREIiHJxnxulqbmFWDYR7WDLoeFeVw==", "629a84c2-6a13-444c-92b8-1c0d9984b086" });

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
    }
}
