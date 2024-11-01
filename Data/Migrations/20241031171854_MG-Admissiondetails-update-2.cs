using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissiondetailsupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("03df4c6d-2741-4a78-b690-443edaab3d80"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("0c3d6393-d0ea-4418-a013-29aba4a4814d"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("2f91f561-6a8d-433b-9b1f-978617356836"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("5f4fc661-a2e8-451d-a271-3cce62924a5c"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("7d0a7c45-f584-460f-b24a-949fbd31595f"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("8504fb6a-9d16-4d9e-bf0f-6c7d31572ebc"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8e5be200-c4a8-40d5-8d46-6b09705151ff"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("dd2cc7db-813e-4eaa-829a-52b04c04c1b8"));

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript", "isMajor1" },
                values: new object[,]
                {
                    { new Guid("5f0910bd-402e-450c-931b-01a1b35bc7bf"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1, false },
                    { new Guid("6fa1148d-ac55-4652-bc09-e57f80679bc4"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1, false },
                    { new Guid("7c88d057-62e0-49ce-b7c0-109234f2ec5a"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0, false },
                    { new Guid("b3b7b60b-94cc-4b89-bff0-de724d409733"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2, false },
                    { new Guid("e3c82444-b430-43a8-b1de-d6c4ea35b9fb"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2, false },
                    { new Guid("fbe1c854-96cd-4dd5-b97f-5d38ee11aff9"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0, false }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98663f88-285e-45d6-b3fe-6289405449b6", "AQAAAAEAACcQAAAAEI2mpvL00R9RX3SgtwQLrcxJSDSxJgKO5Wm17/7Pu0tHvS11CGFTQm+fwK9fGcrqeA==", "05d18455-ca11-4da5-b542-aca01fe99d86" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31845da1-0b33-48ca-8aed-718b48bf4ebf", "AQAAAAEAACcQAAAAEJ0Q6PIL2KXwFw4H8zGQUv+X209nPm45EHfIocq3yn+mmL1mcJ8NQi5N75mCT0Edlw==", "c259d6f0-0f9f-451a-a1ae-441a985e8966" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5fad91c-96f6-47ee-834d-780ea5205322", "AQAAAAEAACcQAAAAEAR5OW/e9Bv26lLJkz7D6P2atYiq4B/aKls0JU5JFKFj55TgO36yDwLig9omuJf8Dw==", "48273c05-77f1-485b-92a9-6e4c85cf71ce" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae4e33c7-2e45-491c-b19f-7fb2aaf0a334", "AQAAAAEAACcQAAAAEG9R396OIcA+BFhFu352recQN/KAJ/WZcd33NL2mQKOYVK/o6vZ+4NGBUskWzWOrsQ==", "518e29c7-00d8-43f2-88a8-b0885f5267e8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b1a6b0a-b75f-4632-b75e-8a93255ad0f8", "AQAAAAEAACcQAAAAEHkCyoNDjZjNAwFtYijBvJmwfIcg7ra+FsmyC5r4b8BrTKIFdpLXv3BmCtoEZA1JgA==", "fb87eaa3-9ae4-441e-96e2-21f91eaaad97" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "85dac92e-cfaf-418b-a1da-62b3c8fab906");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "b8b360d9-b097-4324-8cc8-10afe529605b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "37867c6d-8439-44bc-8663-0447fff11548");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "59c33030-a019-44a2-a14f-730af3ca7725");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "26dd211a-fbba-4f7f-9102-6bce3177cf52");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0eef6cf1-1994-4b1a-a98d-db8fb675b580"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("1b58e24b-3363-484c-8321-9dd5227a0902"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1687), new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1691), new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1692), new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1693) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("5f0910bd-402e-450c-931b-01a1b35bc7bf"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("6fa1148d-ac55-4652-bc09-e57f80679bc4"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("7c88d057-62e0-49ce-b7c0-109234f2ec5a"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("b3b7b60b-94cc-4b89-bff0-de724d409733"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("e3c82444-b430-43a8-b1de-d6c4ea35b9fb"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("fbe1c854-96cd-4dd5-b97f-5d38ee11aff9"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0eef6cf1-1994-4b1a-a98d-db8fb675b580"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1b58e24b-3363-484c-8321-9dd5227a0902"));

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript", "isMajor1" },
                values: new object[,]
                {
                    { new Guid("03df4c6d-2741-4a78-b690-443edaab3d80"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1, false },
                    { new Guid("0c3d6393-d0ea-4418-a013-29aba4a4814d"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1, false },
                    { new Guid("2f91f561-6a8d-433b-9b1f-978617356836"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2, false },
                    { new Guid("5f4fc661-a2e8-451d-a271-3cce62924a5c"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0, false },
                    { new Guid("7d0a7c45-f584-460f-b24a-949fbd31595f"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2, false },
                    { new Guid("8504fb6a-9d16-4d9e-bf0f-6c7d31572ebc"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0, false }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "352ac0c4-e7ac-4536-a69c-fe571ea675e9", "AQAAAAEAACcQAAAAEOE+7uwRCDyY9hV9mvXX5zomvSvVoY9+Zq7E/dvlB1OsCWG+d/531n2NhXBTNXP8Kg==", "ae935c0c-ad13-439d-ac7e-455734a29b4d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c944f4-8e82-4415-a692-aed29c7cda4b", "AQAAAAEAACcQAAAAEA9liP8nWtUjrdxLYV+7fctvUgEwku2QidQV5GAjYywp1nuz8qMYZDJuAYh3D8WkHA==", "0b8242b7-c54a-402b-8d26-9b70c74e377e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63493dbe-2501-4468-8e29-9ba6d89f7502", "AQAAAAEAACcQAAAAEG2sOBDPTzcmL5/Td6Mn2jgxTi+MvrlUlQtfhJR6JnjxRxVBry1dtE/4sX1j+qcACQ==", "ac1a3d7d-744c-4c77-b196-b1bde242e863" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9c135b-0b01-40fa-983e-130a22277af2", "AQAAAAEAACcQAAAAEEJ3XDfnPhk11LvPVlKBeAm3O1BgApRkAfzEPo13Qh4+uG2S5eRHcafkc3mc1K4AlQ==", "57dc370f-b5b0-4433-9a8d-43e7a5378514" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d0bcd18-0c3b-4ee0-a110-95ba03763d39", "AQAAAAEAACcQAAAAEMQ+IPg2DEKFvo0xPviyeTJRPBkz7UENvkeqyk9/Gr01LBhuk7WNnx94+1rfqi3dnw==", "0e82217b-5ada-4e5e-babc-367afc7620c4" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "1240a3fb-f2a8-402c-9b44-f97128a535f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "f592f4b7-ea18-4321-b111-1bdeb413ed0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "2fa6d04e-1719-4761-8fb7-3fa5be2a543c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2ce36450-14e6-40b7-a4fd-910769c991dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "28f42224-1b31-4e30-bce0-9e367596dfb4");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("8e5be200-c4a8-40d5-8d46-6b09705151ff"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("dd2cc7db-813e-4eaa-829a-52b04c04c1b8"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9495), new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9499), new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9504), new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9506) });
        }
    }
}
