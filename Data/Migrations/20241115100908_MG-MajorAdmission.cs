using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGMajorAdmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0ab2351f-0ca6-4403-9016-50c327abb57b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0af73741-4a03-4b83-92e0-6979ec99e2b1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1143c408-074c-4dec-abc7-75df9e2e30eb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2a99daf5-59bf-4f18-a313-3db130de0978"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("303d38bc-27ba-4a42-b888-e3585f3f0ac2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("46acc71b-9aa6-4996-96ea-a08a98c95fbd"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5a55fd66-ead6-4e28-b767-637e4d3656b5"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6258745d-e751-4550-aff4-3b783861cccc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6aae2f69-cd16-4290-8eac-b03d03c16835"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("79612d45-3bf5-44d9-b235-0a41b95ecf3a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7a895569-b382-4040-b7f2-c1cece4120e2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7cf476fa-47d2-427a-9621-70695e42c879"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7d894ea8-6fb5-458a-b517-662b3711cc5a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9052109a-a8c5-4730-a543-b66d4a736e9e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("937633c0-2266-44a2-bc60-f9fd8dfe131c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("94813c38-d1e9-47ff-9e43-e674e3b66143"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a6bf07c8-c54a-4433-9387-c0df073bff58"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c0b50822-83b9-47b6-a0a2-642cf30c0e92"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c0ddeb3e-d353-4b5c-82b7-32c1899ea9dc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c1c38421-4c8f-4cb8-9d03-d3c99d6b9bd1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c32fcdb7-cab8-4527-be00-4fb9b048228a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c811ce07-8d53-4f1c-9825-ebb6c863604f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d79d4365-aad0-4098-a9e4-e2d5f1e576c0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f7bb1048-c92d-41bf-8c4d-d13ab969c1ee"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a02ac614-a9d8-4592-9d8d-9ec3c69e2c82"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d891ec48-36eb-4742-a28b-55cef9a5c5dd"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Major");

            migrationBuilder.DropColumn(
                name: "Target",
                table: "Major");

            migrationBuilder.CreateTable(
                name: "MajorAdmission",
                columns: table => new
                {
                    AdmissionInformationID = table.Column<int>(type: "int", nullable: false),
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Target = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorAdmission", x => new { x.AdmissionInformationID, x.MajorID });
                    table.ForeignKey(
                        name: "FK_MajorAdmission_AdmissionInformation_AdmissionInformationID",
                        column: x => x.AdmissionInformationID,
                        principalTable: "AdmissionInformation",
                        principalColumn: "AdmissionInformationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MajorAdmission_Major_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "MajorID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_MajorAdmission_MajorID",
                table: "MajorAdmission",
                column: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MajorAdmission");

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

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Major",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Target",
                table: "Major",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1e61497-190e-4b29-a07f-1f70ca3f4161", "AQAAAAEAACcQAAAAEEr1NsaUkpIWVlvOVPgNQ1I+O46rXQATIC4IXR5svyaQY/KPwHDv7vSjU6MRv/m/Bg==", "f7dc0019-3936-419c-8d1e-d08a24596eea" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d39470b9-2537-4fb9-9c9f-be787975a7e7", "AQAAAAEAACcQAAAAEKNz3N4xEjTjbyWUWddtL/RuhIK9qxgb74NGi1ugMrLNKnKQI618ygiM7Pdeb4uT+g==", "fd651367-7aee-4c92-9638-143996e4d400" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04908347-1786-4da8-911c-9d38766b9def", "AQAAAAEAACcQAAAAECO2qI8mlho68JWEjGTJaf+BpN4SvmqfVqWnQz7tQZN/v4mzjnqh+Gl7qxv4NDKaAA==", "1a853a6f-637f-4b57-b264-5394691a03fb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f381f2ac-4159-4123-9e9f-435247b8c7e0", "AQAAAAEAACcQAAAAELfFjLk2/yhcYXXmVaR5Lv2128kI6uv2hmPnv3RQT21FDchlOBd9dBfTmltfK9Wsxg==", "3aba857b-0340-4417-ab34-7792d873402d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d48d7196-9986-4850-8bfc-8ba13d73d07c", "AQAAAAEAACcQAAAAEHCQwJ4FRpQn37QJ0EUjU1AZ/mZBvLmw+SCprwdPoTSzhfiNaKooY9vo5doRk/bOpg==", "cba781c6-e914-4f00-9123-c74a607e4f91" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("0ab2351f-0ca6-4403-9016-50c327abb57b"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0af73741-4a03-4b83-92e0-6979ec99e2b1"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1143c408-074c-4dec-abc7-75df9e2e30eb"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2a99daf5-59bf-4f18-a313-3db130de0978"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("303d38bc-27ba-4a42-b888-e3585f3f0ac2"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("46acc71b-9aa6-4996-96ea-a08a98c95fbd"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5a55fd66-ead6-4e28-b767-637e4d3656b5"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6258745d-e751-4550-aff4-3b783861cccc"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6aae2f69-cd16-4290-8eac-b03d03c16835"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("79612d45-3bf5-44d9-b235-0a41b95ecf3a"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7a895569-b382-4040-b7f2-c1cece4120e2"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("7cf476fa-47d2-427a-9621-70695e42c879"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7d894ea8-6fb5-458a-b517-662b3711cc5a"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9052109a-a8c5-4730-a543-b66d4a736e9e"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("937633c0-2266-44a2-bc60-f9fd8dfe131c"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("94813c38-d1e9-47ff-9e43-e674e3b66143"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a6bf07c8-c54a-4433-9387-c0df073bff58"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c0b50822-83b9-47b6-a0a2-642cf30c0e92"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c0ddeb3e-d353-4b5c-82b7-32c1899ea9dc"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c1c38421-4c8f-4cb8-9d03-d3c99d6b9bd1"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c32fcdb7-cab8-4527-be00-4fb9b048228a"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c811ce07-8d53-4f1c-9825-ebb6c863604f"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d79d4365-aad0-4098-a9e4-e2d5f1e576c0"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f7bb1048-c92d-41bf-8c4d-d13ab969c1ee"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HAO",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HBS",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HBT",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HEA",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HFO",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HGE",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HHM",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HJA",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HKA",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HME",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HRM",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HSM",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HSO",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HTE",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "HWE",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SAO",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SBS",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SBT",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SEA",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SFO",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SGE",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SHM",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SJA",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SKA",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SME",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SRM",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SSM",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SSO",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "STE",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Major",
                keyColumn: "MajorID",
                keyValue: "SWE",
                columns: new[] { "Status", "Target" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "9f90366b-471b-4cf8-8819-4f790305611e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "dc46c642-fe92-418c-96c0-b1dca62f21c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "25bf293f-872c-4328-8957-866d7a0581b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "00ee626f-bea1-41b3-8852-69ae9dd8d9bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "0651c779-029e-47ac-a307-de6d2f890120");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("a02ac614-a9d8-4592-9d8d-9ec3c69e2c82"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("d891ec48-36eb-4742-a28b-55cef9a5c5dd"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
