using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGMajorAdmissionupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmissionTime_Campus_CampusId",
                table: "AdmissionTime");

            migrationBuilder.DropIndex(
                name: "IX_AdmissionTime_CampusId",
                table: "AdmissionTime");

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0c5c873a-8c53-49b5-a198-e29b8a0b4bba"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0ea21413-8725-4ad2-856b-c9167c784000"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0f5f4277-b824-4dec-80b7-b340cec26291"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("12d6625b-607a-4102-b420-5ec2ba426c0f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1eedb38c-35ed-4034-b42d-cc52d4cad00f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("203fd8c1-8186-4490-aa91-d4c128c9e042"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("312d4dc0-a40c-408a-9efa-6e486ec14c04"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("32ccab55-578a-4c7c-8218-71ab3ce2ab82"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3af05b1b-1d8b-4fe6-a805-f196c1aabf23"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5321b95f-e44a-4c3d-afa6-9e4c6300328f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("64285d6a-c3c9-40c3-93e1-50eaa2688abc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("761879e5-e6b5-4a6d-8e1f-4cfee434bfa7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("78970126-e32d-482d-a382-6ba17f8c5560"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7af18534-ac4e-4739-a3bc-50f4923e58fc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8b095a98-df2f-4992-adf8-7db93db3a15a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("92195142-5929-4f89-b021-ce2145f4e1d8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("92905bbb-38ce-40ea-b821-fe2fdb4b6147"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("950314b6-4ed0-46f1-96fd-1ed61c2b5470"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9f07abd7-23df-4e8a-9ee7-8665a14e42ee"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b51db04f-1c5e-4e23-b9bf-628168479579"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f26c2abf-851a-49ee-8a19-ee332b326b13"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f4c4ca86-e710-4347-9f38-05ea6e057063"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("fa365877-46ca-4cb0-8652-f677f234744f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("fbd5208a-530f-45ed-a646-7c38ec8ef0ff"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8b1cce7e-3b62-496b-92b7-4456494ce529"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a019f8cf-f4f7-4a96-9940-cbac48b0e3dc"));

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "AdmissionTime");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CampusId",
                table: "AdmissionTime",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5052990-6346-430b-bab3-10a17cff68a3", "AQAAAAEAACcQAAAAEP3sNDhbmu3BylDO8b+0MGPlGkbVYAhWoUo3qOvNwntxNGJRzxJlPoymeAcvWJtd5w==", "227558da-cd1b-4536-9803-9f03d64146c5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c40fd325-fa27-498d-8582-394288ae58aa", "AQAAAAEAACcQAAAAEIl8G6sHTrbyi4V/8uYEHGb/KkQOreR8Shbhd4rw58n6AK3OrgCtPuowSQXpcKdAww==", "7bfa55a6-58e8-4224-aaf0-893a9626780c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "360a5071-b8e0-4c51-a834-47ac4af8f75f", "AQAAAAEAACcQAAAAEMTcgyKqR1RpWY9sQB4HaqQvaz5DsrnCM9UejHUi5UX8KF2oymuP3cGbkF/eA2/tQA==", "53ec62c8-fd87-4907-a0a7-ee09e7363285" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35d0e0d0-03a9-4882-8d37-c8950db7694b", "AQAAAAEAACcQAAAAEK751g9Ja7E4R15Ks08Zly7myQbk5mREpWbpOJIzK1PA+B3uxCLw1cojaw8wnOOUqw==", "e5fde6d7-ab69-4d32-aef5-e3cd4f4a0efa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d05a16-3a94-41e5-b861-9634a28b2b47", "AQAAAAEAACcQAAAAEFSc26YR1fWvB5riFdyrUAPJTWTZu8Xiqx8StF0rFZfSjLjEiKQjM3SUCq+rMlRRkw==", "6e5bf081-127f-4645-856a-5c5b4b3fb567" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("0c5c873a-8c53-49b5-a198-e29b8a0b4bba"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0ea21413-8725-4ad2-856b-c9167c784000"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0f5f4277-b824-4dec-80b7-b340cec26291"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("12d6625b-607a-4102-b420-5ec2ba426c0f"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1eedb38c-35ed-4034-b42d-cc52d4cad00f"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("203fd8c1-8186-4490-aa91-d4c128c9e042"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("312d4dc0-a40c-408a-9efa-6e486ec14c04"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("32ccab55-578a-4c7c-8218-71ab3ce2ab82"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3af05b1b-1d8b-4fe6-a805-f196c1aabf23"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5321b95f-e44a-4c3d-afa6-9e4c6300328f"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("64285d6a-c3c9-40c3-93e1-50eaa2688abc"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("761879e5-e6b5-4a6d-8e1f-4cfee434bfa7"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("78970126-e32d-482d-a382-6ba17f8c5560"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7af18534-ac4e-4739-a3bc-50f4923e58fc"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8b095a98-df2f-4992-adf8-7db93db3a15a"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("92195142-5929-4f89-b021-ce2145f4e1d8"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("92905bbb-38ce-40ea-b821-fe2fdb4b6147"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("950314b6-4ed0-46f1-96fd-1ed61c2b5470"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9f07abd7-23df-4e8a-9ee7-8665a14e42ee"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b51db04f-1c5e-4e23-b9bf-628168479579"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f26c2abf-851a-49ee-8a19-ee332b326b13"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f4c4ca86-e710-4347-9f38-05ea6e057063"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("fa365877-46ca-4cb0-8652-f677f234744f"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("fbd5208a-530f-45ed-a646-7c38ec8ef0ff"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AIId",
                keyValue: 1,
                column: "CampusId",
                value: "Hanoi");

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AIId",
                keyValue: 2,
                column: "CampusId",
                value: "Hanoi");

            migrationBuilder.UpdateData(
                table: "AdmissionTime",
                keyColumn: "AIId",
                keyValue: 3,
                column: "CampusId",
                value: "Hanoi");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 17, 9, 6, 770, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "6aa59823-dfd4-4f8b-afd2-09895f1d9fce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "2814ae68-ca3b-4276-b7a9-5528150ed424");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "5c9f8149-7b39-4dfd-b7fc-2cd4ddda8fbc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "0ac0fc01-02a1-4758-aebd-2c625babe3a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "d36a1455-8494-48da-b094-5ba03f7c4c82");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("8b1cce7e-3b62-496b-92b7-4456494ce529"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("a019f8cf-f4f7-4a96-9940-cbac48b0e3dc"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionTime_CampusId",
                table: "AdmissionTime",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmissionTime_Campus_CampusId",
                table: "AdmissionTime",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "CampusId");
        }
    }
}
