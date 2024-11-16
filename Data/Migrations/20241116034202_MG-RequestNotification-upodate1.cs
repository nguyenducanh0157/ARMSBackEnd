using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestNotificationupodate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("631a84b2-6de9-4c17-9756-bdaa4273008e"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c3da8247-0ef0-460c-815b-b49d669a7ac8"));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeSend",
                table: "RequestNotification",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3acef0c-74eb-4e34-a898-ebf2306eddfd", "AQAAAAEAACcQAAAAEO2ETvL7f2lL+EiX/KSM3BHMZZWhdaYpmQhnJTqlO4SNckU+96Uv4ExprCXkJ8F5RQ==", "b2804cf3-07f1-4f9d-ba83-66396491492b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bfbd41f-2410-4fad-9b3e-0fa2b5824f75", "AQAAAAEAACcQAAAAEPCkE3yM6sv6Hhq9LscOguGIj6b8V+v92qcwG2z7lcS/aDf1SKJ/2dLwgjKrIlzgUg==", "852b2442-e372-4903-821f-8998f80b42c7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42df628a-134a-453b-ace9-7c0ab4ac0c22", "AQAAAAEAACcQAAAAEPzbygPM6a/nvMnqtP5HSB2geIS7iV014ikrKelzKA0InsvmGJW0wujDUwHDx8YXXg==", "b8424a2e-9c9a-4740-8382-c532359fac52" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f13655d5-1c7b-406d-bd41-1ebdff3f30a3", "AQAAAAEAACcQAAAAEM/FEAHUQGuT3eocfm+OXTgSaPLFA7ZSAbqCpC9YKG8hF4cxRwc0vKxtqZLgf+yX8g==", "360d6d47-d1fb-45de-ac3c-854c1a925066" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a30df940-abbe-4065-a7f7-27d86217d50b", "AQAAAAEAACcQAAAAEBmza1DA8+N0iT+TxapEtMlCtpSm37bfAj1dKlfccsOrkSa/imfv5puWSTxsJ7KWdg==", "a3adf2be-c0fa-4472-9af8-015859f9a05a" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "dad8b1f1-5cc1-4f5b-964a-83b8f9509875");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "0fc0cb28-b843-4aea-acd1-1727c44496d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "719e6704-4bfc-49c7-989f-ade4946ee911");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2afbb223-2937-4825-bf81-e853183c5d10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "68800f98-4fe7-4b88-8ac3-52fd30f9b9d1");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("915109af-3373-4127-90c2-e8d76e18fd35"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("98a9304a-7ff2-499d-a2ba-97a47d4452f9"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5467), new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5469) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("915109af-3373-4127-90c2-e8d76e18fd35"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("98a9304a-7ff2-499d-a2ba-97a47d4452f9"));

            migrationBuilder.DropColumn(
                name: "TimeSend",
                table: "RequestNotification");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2247ff-114a-4d16-913a-43a92516aeb5", "AQAAAAEAACcQAAAAEBBQtXJU/t+5ytJKu7MUp2JUn02DjrrZxmsosFWZndWtSK87g0nZK7FezOQt4A+4Tw==", "29de30c4-cf97-42d3-a1f3-8f5b1af9cfe6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46966d84-fe29-4074-b92f-51e44509079e", "AQAAAAEAACcQAAAAEPX4FNtRfX7AoFMdfdUAC+yCSXubUC2ZrWJH+NvDaONKU7LzrPW/Jb7hAiP/g4Hp0A==", "fe459fa8-4eb7-4d5f-9b6e-05e957a09bca" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f3e3f23-6d48-49d2-861f-a34b46153d81", "AQAAAAEAACcQAAAAEM45qmEBk8dtSl/91I7pISk1P1bCFGtSkaEpq/0xYo1p5vhx0ZUW2ZH1LmXWJniIZg==", "a15d250c-98ca-46e1-bc9b-f166cf736bf7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c69d2a1-a589-48fa-9858-b7d8f6dfae7f", "AQAAAAEAACcQAAAAEGaN2vc/wwNC2E/OB3zgkibqX3Wukxqxk9v2ZfjkdzZG06NYZJkkOA70Gu+2W99BtQ==", "5e38538a-6203-4e87-90cb-d5174adba82a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0bc2964-7d8a-49ef-8489-5471e2460edd", "AQAAAAEAACcQAAAAENMjDNO22L5k4/X0rzmuO7YVpVaYTJ30xkoubhcZSsutxhj8Z9g78htvxBHuJwsnHw==", "85650f72-442b-49e9-b7ba-1639e7f5c92d" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "8b39f430-671c-4afb-841d-19d5431111b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "4f0a0fdb-634a-4337-857b-644146edf0b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "9194e149-dbab-4d48-9671-71113fdaa9d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "ca1deff3-dabe-43ad-a81a-4f80ce73fb77");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "edbd0c35-ecb4-465a-81a4-54553b342b55");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("631a84b2-6de9-4c17-9756-bdaa4273008e"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("c3da8247-0ef0-460c-815b-b49d669a7ac8"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2777), new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2779), new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2782) });
        }
    }
}
