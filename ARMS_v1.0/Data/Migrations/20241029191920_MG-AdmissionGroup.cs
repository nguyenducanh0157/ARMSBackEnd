using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissionGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("b735881f-8a18-4cf5-8831-b2b9b72dfce8"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e4608a42-d507-4020-882f-58ef5cebe3b1"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("4055539e-e722-4338-8a9b-352ec234200d"));

            migrationBuilder.AddColumn<int>(
                name: "PriorityDetailsPriorityID",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriorityID",
                table: "StudentProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdmissionGroup",
                columns: table => new
                {
                    AdmissionGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalScoreAcademic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusScore = table.Column<bool>(type: "bit", nullable: false),
                    StatusScoreAcademic = table.Column<bool>(type: "bit", nullable: false),
                    SubjectGroup = table.Column<int>(type: "int", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionGroup", x => x.AdmissionGroupId);
                    table.ForeignKey(
                        name: "FK_AdmissionGroup_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3f8014e-5c43-4b6a-9767-936f6ce19093", "AQAAAAEAACcQAAAAEDfqrt/6ISRUG+F57xiNqTT8Uc5hV0iwwPYnu38U+tG/MemjSrnzB2CLlhxZbzIJbw==", "c9943eca-0389-4d36-8c06-6605b7fb2688" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a97404bb-8489-45ec-b403-975747f324f5", "AQAAAAEAACcQAAAAEPSRrZ8DiexAhVIRvd9C0mbaxNzRO3YDSXVdanGIwa/5s3RUwpKeVlxYlLlNkF6uuA==", "66aa3a9c-e623-48e7-8915-d2fc5cf506f7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18a3bb5-256f-4bb5-a850-3e88c8add2bc", "AQAAAAEAACcQAAAAEFpKJbJHhFjUMLt3o5WTUf3uEBV1zValmny9BGdOhU1AcVZJNGQWtLXuIhptNRfU4w==", "b287772e-7f1b-49fa-be23-4df13e0e20df" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47cf2b55-4374-4734-b2ab-8ed325ed2168", "AQAAAAEAACcQAAAAELzr8uXePuDLf4OG8WgdAAlqtF1+zsNBk7FoZInpalid/oQo+tToH/ZzdeG2VPCXng==", "f521ddc5-2cb9-43d9-9fc0-309528791086" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "255237b9-570b-4e5d-9aab-c5ed89b14ba4", "AQAAAAEAACcQAAAAEGJr3McO3Klerr+1N4EdREEjQZ/1bSb1dZFDfeWQKFJRMlUdJXs60Ml3l63I7n0NSA==", "0a38481f-6218-4e9f-b05b-e4c32d3c1878" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "033c0790-1b83-4d21-ae6c-2733493c69a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "abec109b-6cb7-4244-96be-e934c64a690b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "8ce9c430-3228-4e30-b6a9-a772c8d3578a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "75899988-2bf9-4288-b613-e1bed359b38a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "e22cddbc-a1b3-484e-89ae-b401a5deddf2");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("7b07fc37-045c-45cc-8e54-3bfb704ad0e3"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("deb1f3af-3e04-48d9-a2f5-b5c64216100a"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailsPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("46ff9646-35ae-4286-b156-b89dcf7f8a4f"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(391), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 2, 19, 19, 148, DateTimeKind.Local).AddTicks(394), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, 0, null, null, null, null, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_PriorityDetailsPriorityID",
                table: "StudentProfile",
                column: "PriorityDetailsPriorityID");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionGroup_CampusId",
                table: "AdmissionGroup",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_PriorityDetail_PriorityDetailsPriorityID",
                table: "StudentProfile",
                column: "PriorityDetailsPriorityID",
                principalTable: "PriorityDetail",
                principalColumn: "PriorityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_PriorityDetail_PriorityDetailsPriorityID",
                table: "StudentProfile");

            migrationBuilder.DropTable(
                name: "AdmissionGroup");

            migrationBuilder.DropIndex(
                name: "IX_StudentProfile_PriorityDetailsPriorityID",
                table: "StudentProfile");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("7b07fc37-045c-45cc-8e54-3bfb704ad0e3"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("deb1f3af-3e04-48d9-a2f5-b5c64216100a"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("46ff9646-35ae-4286-b156-b89dcf7f8a4f"));

            migrationBuilder.DropColumn(
                name: "PriorityDetailsPriorityID",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "PriorityID",
                table: "StudentProfile");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24dc9a02-f774-4e32-a8f5-22c5dcb57502", "AQAAAAEAACcQAAAAECtllLo0sqqLjykc6/yK8/+ZSng7CrkEJvM0LBV/tbM9BUk9EZn0GaCclD5XQFcioQ==", "766f6c76-7c42-40f7-b3d6-bb54dcaad648" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daaf6e71-2da7-4f2f-bceb-2831db701cd7", "AQAAAAEAACcQAAAAEF+Rz6Ki/fUFeQSadaUFpIuKHH6VpsY49PsByoiMuxfm4tg4CY5ulD9IA2mIl0ZBbQ==", "0112270f-9a46-4b73-85c0-045e4b3fae0d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b279c5e-65d4-4dae-87b4-5b388210e956", "AQAAAAEAACcQAAAAEO3+94WarZuCvwWeoamJ3nNCxuwrYpcrhk6XSUgEP57z4LvoVWtTtghtfX70uJ6j7Q==", "60d00837-9729-45cb-b6b2-60673670a98c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "563b2d33-d467-4004-bdfc-438d0c478cde", "AQAAAAEAACcQAAAAEAmyVONwc47lNGH9GeDVPGqlSx0VIcJUsB88xiYxeebhajDSXGXVkIUt3049qDkrkA==", "1e325f84-4b0d-4d3e-ad42-14b24aef3b54" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cae34a7c-b802-4d53-bd41-9e09f742abc2", "AQAAAAEAACcQAAAAEGjzwEyG3m7ybdwC7semuDCIc83jg/wAcGVtMRnd+itNbP81Qao8RR7LZAgErfm9hg==", "f223e458-bf6b-45d0-998e-64f83935d51e" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "b10873b0-a9cb-4a76-bd2f-040f4da4af18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "c067c005-f557-46d5-95d7-0732d5b8a4c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "8c1272d7-8e21-489e-96f3-8bc8c21ac5a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "edf252fa-02d5-47c5-b546-23fdd50dee44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "c1c30030-7277-4614-af7f-c73986963fd5");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("b735881f-8a18-4cf5-8831-b2b9b72dfce8"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("e4608a42-d507-4020-882f-58ef5cebe3b1"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("4055539e-e722-4338-8a9b-352ec234200d"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2519), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2523), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });
        }
    }
}
