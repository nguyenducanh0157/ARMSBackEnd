using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGMajorAdmissionupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("00b31791-925a-4abe-8d23-e9a429938e24"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("00ec3d57-6ea7-4581-8b73-38c536ac47bb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("136743b9-a2fd-4d02-a95b-6eca25d248ff"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("14b32b5c-be28-46a2-b3b0-5081742ab22b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1cb4ec9f-8395-4925-a67b-0267e95555a6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2065e612-6931-4e0e-a90b-70491824ab95"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2e011af4-7de1-47f3-84c9-94f9d4acf3b9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2e3920f3-0aa2-4cd6-ae4c-838234b9899d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("339f96fe-7c8f-49f4-95c1-514eaadc6067"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3d90d5c7-d754-4ebb-9de3-07830bc546fa"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3fb279b3-42b9-4a95-9ddf-354bc99a872b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("4fd3a575-050f-4b7c-9cc0-106e9ae12d95"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5b5ea3f1-c123-4542-8f9f-f0c0e0272c3d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("678a86e1-fb6b-4cc8-8e9e-4ab1eb222767"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6c253222-64fe-4903-968b-c6fdabb0fda6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6c86e2ce-f473-4fd0-a55d-e82a6aff2c28"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("77dc90a5-e795-4062-8d8e-df11680f7b2e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("797869c7-1dde-4067-9a27-117a662b1273"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7bb49853-aad4-4dc3-b283-7ef47c299c1e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a1b8812b-737e-4d58-aae7-91849d759201"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a3afdadb-ebe5-4e4b-a6ca-b1c7868f1bfa"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bdb5973c-cd46-40e6-adbc-14187cab5a2e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c99cf337-2067-45e7-aa83-fa06090e4ca8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f787284a-9b34-4637-91e8-ddd24beb1e03"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0ff8c776-b919-4043-a5b4-6a87f59d3111"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a17d867d-6929-4dcc-a6e0-19c23661072f"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a404911-c456-4633-80f4-8ebe5c5a7903", "AQAAAAEAACcQAAAAEPkJn8EIReLLalJxNpTWDbUHo6eg26vEs0kx5+lLFNZ6ZqMn8dtgMZCrf8uF9rez5A==", "1d1e50ee-7eed-44eb-8584-939d15e9b130" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e152f34c-9be5-4ee3-b1fb-c4050718e520", "AQAAAAEAACcQAAAAENECfQGddfu0SHI17r034lFT+Jeu7QKZIyC+E+TAfVhTWxUJkWjVJhIYpwaWQvdTXw==", "7f021241-2403-4478-87ab-994594bc43cb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcdc9437-5dab-4fad-b220-d3d7300b9aae", "AQAAAAEAACcQAAAAEHUx6uwBJfljORfOL+fOozquYY+ummL75iTZaeieV3bFBphTHf8eS0zx7MGqARtVWw==", "666fd604-b7f9-4dc4-a6e2-222e36028964" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fb3c0f6-664d-4e6f-ba19-4d1a2258e210", "AQAAAAEAACcQAAAAEPbjGYLtcBs4LYOTtClwadZI4lL5rOIrV/raPklbpSDcdybANNYJU3xqot6y3Sa7eQ==", "8ef466f4-1a32-426c-b403-8da342ba6a4e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23ea4c8a-b2c9-4d30-9dec-db4de457a978", "AQAAAAEAACcQAAAAEBtEPFkD6w3VjlfDRiAZO7+tsF7U8eIwvKVarJqAmZ1InJ/Kbl9dX2aPJnnC0nHUaw==", "7f12a18a-b2fe-4c86-9a44-851b988c4bf7" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("05272e7b-d7e7-4c7e-83d0-49cc78cbfc0c"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("06bcdb27-f443-4939-b104-6ea086810d01"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("09b301e6-d366-4b33-9c6b-15183e099457"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0a29d95b-3f56-416d-b48c-7bcef00bd804"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0e361d3f-84fc-4266-b270-f144a77b95a8"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0fe3b6b6-5b69-416f-a810-3d8b1b134666"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("211aaeeb-2337-4e4f-8ee7-117e1167ff88"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2620d18f-2fb8-474d-8906-d39d30e5409f"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("29c9f486-550d-4b04-b0f7-1116bbcdb410"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("32436cf5-764a-4e0b-895a-b6a6451ce75a"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3d27ca0b-d8cc-41c4-865b-7187c24768ef"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("44df4966-30e5-49fd-ad47-4ccb8c0ce2bf"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("45c595d2-f872-44c7-9f31-887e856efc2c"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6ac95a8c-a184-4f00-8774-f2ffc74f6912"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("6b30f9d5-7ecb-4cd0-8613-ebe220fd9209"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("74eed70d-ada3-4743-8ffc-3d21a50dbeb0"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("79dcde99-f9bd-41a4-96f4-9cc7eb432cd1"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7db2acbc-22b2-425e-9e5f-167f939b5c4d"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7f391302-0f63-4ba7-ad91-07a5251e19ea"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("861d05b0-c364-4836-bf5b-52af09d78c6a"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9556c53c-40a3-4678-9453-9b12a4aeb189"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dd5812a2-960b-4eee-b79d-18142623c5f8"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e8aef338-7f93-456a-99f3-a4c9286a5a39"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("fa744de4-72e5-4d84-8965-07a48c2a6133"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "Status", "Target" },
                values: new object[,]
                {
                    { 1, "HAO", true, 200 },
                    { 1, "HBS", true, 200 },
                    { 1, "HBT", true, 200 },
                    { 1, "HEA", true, 200 }
                });

            migrationBuilder.InsertData(
                table: "MajorAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "Status", "Target" },
                values: new object[,]
                {
                    { 1, "HFO", false, 200 },
                    { 1, "HGE", true, 200 },
                    { 1, "HHM", true, 200 },
                    { 1, "HJA", true, 200 },
                    { 1, "HKA", true, 200 },
                    { 1, "HME", true, 200 },
                    { 1, "HRM", true, 200 },
                    { 1, "HSM", true, 200 },
                    { 1, "HSO", true, 200 },
                    { 1, "HTE", true, 200 },
                    { 1, "HWE", true, 200 }
                });

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 17, 46, 38, 500, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "b824b4dc-1136-4ec8-bf3b-98b146f7f035");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "f9018243-2f29-475d-ba8f-512bffe27c40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "ffbbc06a-ab27-4f25-952e-7ff599f530f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "7bcf0e45-e570-46b3-bcde-66301129b266");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "e702673d-63c2-4b0d-b056-8c1b861dc878");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("93280a53-8ce5-4ff6-98ad-0f3ca9a2d277"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("a4464935-6abe-4959-909d-c2005b5c2a52"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("05272e7b-d7e7-4c7e-83d0-49cc78cbfc0c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("06bcdb27-f443-4939-b104-6ea086810d01"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("09b301e6-d366-4b33-9c6b-15183e099457"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0a29d95b-3f56-416d-b48c-7bcef00bd804"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0e361d3f-84fc-4266-b270-f144a77b95a8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0fe3b6b6-5b69-416f-a810-3d8b1b134666"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("211aaeeb-2337-4e4f-8ee7-117e1167ff88"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2620d18f-2fb8-474d-8906-d39d30e5409f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("29c9f486-550d-4b04-b0f7-1116bbcdb410"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("32436cf5-764a-4e0b-895a-b6a6451ce75a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3d27ca0b-d8cc-41c4-865b-7187c24768ef"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("44df4966-30e5-49fd-ad47-4ccb8c0ce2bf"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("45c595d2-f872-44c7-9f31-887e856efc2c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6ac95a8c-a184-4f00-8774-f2ffc74f6912"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6b30f9d5-7ecb-4cd0-8613-ebe220fd9209"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("74eed70d-ada3-4743-8ffc-3d21a50dbeb0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("79dcde99-f9bd-41a4-96f4-9cc7eb432cd1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7db2acbc-22b2-425e-9e5f-167f939b5c4d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7f391302-0f63-4ba7-ad91-07a5251e19ea"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("861d05b0-c364-4836-bf5b-52af09d78c6a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9556c53c-40a3-4678-9453-9b12a4aeb189"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dd5812a2-960b-4eee-b79d-18142623c5f8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e8aef338-7f93-456a-99f3-a4c9286a5a39"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("fa744de4-72e5-4d84-8965-07a48c2a6133"));

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HAO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HBS" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HBT" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HEA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HFO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HGE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HHM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HJA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HKA" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HME" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HRM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HSM" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HSO" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HTE" });

            migrationBuilder.DeleteData(
                table: "MajorAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID" },
                keyValues: new object[] { 1, "HWE" });

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("93280a53-8ce5-4ff6-98ad-0f3ca9a2d277"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a4464935-6abe-4959-909d-c2005b5c2a52"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7660eab6-fa92-4e57-81e8-0b6f7ce87a2a", "AQAAAAEAACcQAAAAECktk5zwxkkzZV0VG4YwxuiQCRdJgsHLO1DMef93qUHPkGbPHmJsaKp6kvKAA6r2nw==", "5a32b87c-1093-4d59-b7e8-69760df6b030" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eae7b7d-75f5-4823-b1c3-1aec3482025e", "AQAAAAEAACcQAAAAEFQQQMU8kqC8LMxckXq5djMpe6fhhDs0zVWTbIbXPClqktwqBz1NgRHxNhXRAkB79Q==", "6d549323-7215-43be-af58-f1be82658124" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a27b97ac-ccee-4b8f-b757-71f28032724e", "AQAAAAEAACcQAAAAEDqW7hlxzlA476c/Y7D3MRiUdFzWt8xuT8Xuv3eZ2JCr4HfmrI4YsRD0N5q6NAEYqw==", "e6f346c5-e026-4905-b257-390b3339b310" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a1e2946-3c2b-472a-8b7b-98a22491546e", "AQAAAAEAACcQAAAAEPNhbzIaAXpPNtddUUNJCGNxKeJ/pUf9APsIxfbJE3XjuNjUtATHhfzCdvbVYBqufA==", "b75938dd-84c6-4587-a1f0-9b76f3634a3e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f96a368-6455-4250-9b40-845317feed50", "AQAAAAEAACcQAAAAEH38bsErsn1KX4UJQV5bj7Q7TTTjWO0Ub7jhf16fSt15+0TmoOHJx4dEfVZhw7XklA==", "81b682fc-561c-4926-a3b8-ebb1d2825f56" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("00b31791-925a-4abe-8d23-e9a429938e24"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("00ec3d57-6ea7-4581-8b73-38c536ac47bb"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("136743b9-a2fd-4d02-a95b-6eca25d248ff"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("14b32b5c-be28-46a2-b3b0-5081742ab22b"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1cb4ec9f-8395-4925-a67b-0267e95555a6"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2065e612-6931-4e0e-a90b-70491824ab95"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2e011af4-7de1-47f3-84c9-94f9d4acf3b9"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2e3920f3-0aa2-4cd6-ae4c-838234b9899d"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("339f96fe-7c8f-49f4-95c1-514eaadc6067"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3d90d5c7-d754-4ebb-9de3-07830bc546fa"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3fb279b3-42b9-4a95-9ddf-354bc99a872b"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("4fd3a575-050f-4b7c-9cc0-106e9ae12d95"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("5b5ea3f1-c123-4542-8f9f-f0c0e0272c3d"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("678a86e1-fb6b-4cc8-8e9e-4ab1eb222767"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6c253222-64fe-4903-968b-c6fdabb0fda6"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6c86e2ce-f473-4fd0-a55d-e82a6aff2c28"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("77dc90a5-e795-4062-8d8e-df11680f7b2e"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("797869c7-1dde-4067-9a27-117a662b1273"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7bb49853-aad4-4dc3-b283-7ef47c299c1e"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a1b8812b-737e-4d58-aae7-91849d759201"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a3afdadb-ebe5-4e4b-a6ca-b1c7868f1bfa"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bdb5973c-cd46-40e6-adbc-14187cab5a2e"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c99cf337-2067-45e7-aa83-fa06090e4ca8"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f787284a-9b34-4637-91e8-ddd24beb1e03"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 17, 18, 48, 76, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "d9ba23c1-310e-4aed-95e2-97927bea4149");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "785f78fc-e015-4c16-baa3-3df935ca022b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "749df0cb-ec79-4b4f-8142-750334a833f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "a229dc35-7535-456a-8b13-558391a1f35d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "a1e1543f-d4c0-4b1c-b903-e75acdb96212");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0ff8c776-b919-4043-a5b4-6a87f59d3111"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("a17d867d-6929-4dcc-a6e0-19c23661072f"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
