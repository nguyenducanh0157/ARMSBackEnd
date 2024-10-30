using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAcademicTranscript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("26ab7b98-c27b-4802-bf19-101a307c1b36"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("bb031d07-12f2-41a9-b565-c544ab587826"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("08d6820d-f66c-4483-a84e-e8c2e08e0d40"));

            migrationBuilder.CreateTable(
                name: "AcademicTranscript",
                columns: table => new
                {
                    ATId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TypeOfAcademicTranscript = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicTranscript", x => x.ATId);
                    table.ForeignKey(
                        name: "FK_AcademicTranscript_StudentProfile_SpId",
                        column: x => x.SpId,
                        principalTable: "StudentProfile",
                        principalColumn: "SpId");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dae5080f-85dd-46ca-ad0e-7892bd7d959d", "AQAAAAEAACcQAAAAELEPVhzd5US2sgWb64EFM5aR52xrGLzgi2cEEdMysZ8Y5Kzo+n2OlAhpAk0UAI3wSA==", "8e111fb1-add2-4c2e-903a-d67dec88b4d1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cc6fee6-8106-4983-85b4-ea2d4a688556", "AQAAAAEAACcQAAAAEBN6eCeTrs6Wa0XTMkwuGQqhT1TMlkJvAHB3jp8vII4pfodEzua/KavwY6dbbux1DQ==", "300a955b-290d-4a0f-ac7f-beac1ba17a21" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13795bf9-eacb-4e5e-aedb-7109ff93b90e", "AQAAAAEAACcQAAAAEEs952McYoUYyt+hDc3k+YWmyr3W/fhldpJxFZXmOkYoioxi1kw+2HzK8kj7loWDqw==", "e64a5056-6b1f-4cf9-a837-0fdcf2057952" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a6ffa82-f640-405c-973a-57e47369c77c", "AQAAAAEAACcQAAAAEFt1g/LXw7lSPCojn917AV5Np7uBCmaefBSW9x9gfGzc2oab3LB6/BhYYFnxFSIyzQ==", "07e15d47-6f31-45ae-8e01-adf18346ed9c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7191168-54ee-495d-ad3f-6dd426cac5b8", "AQAAAAEAACcQAAAAEDYPCOv9ZR8HD15osBdaMo+uw3PEfj65EcBnOfBfKOnwt94Wd/1SgfzcH4WHk7tr3A==", "40a48388-6edf-4699-8ea2-94aa18500086" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "7b3a6641-e13d-4553-b481-4d9fd014e086");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "f43e3de1-a6e8-4b7d-ba7d-18fafb91947a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "1c0f9af7-875d-4b95-bed9-7ce0bac1b724");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "1d4dea3a-80e9-4865-8d9b-a4c891b4fddd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "a0298652-890c-4482-ad4a-730513750f1f");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("a0ee8dbc-1813-4829-948b-c4dfe8df84fe"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("d29072fe-3400-489c-9063-426ecda718b5"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailsPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "TypeofStatus", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("9a69bf24-4a86-4c22-b9f1-384661075b6e"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(3057), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 13, 30, 19, 42, DateTimeKind.Local).AddTicks(3060), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, 0, null, null, null, null, null, null, null, 0, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicTranscript_SpId",
                table: "AcademicTranscript",
                column: "SpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicTranscript");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a0ee8dbc-1813-4829-948b-c4dfe8df84fe"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d29072fe-3400-489c-9063-426ecda718b5"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("9a69bf24-4a86-4c22-b9f1-384661075b6e"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9401a0dc-46bf-438b-8b6c-e0a702b4714e", "AQAAAAEAACcQAAAAEKnEZxXxqTv3aP+OTPqDFsQSR4Zww/QYTQ087e3/nC7u5r6U48iQKWslcdz0nVn/3Q==", "8e9e4f49-24c6-419d-b455-42a3a7766fc1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42a3787b-2d58-460c-8320-9505ad6f8d0a", "AQAAAAEAACcQAAAAEL39sCr8K+1+FjTSkxsQGM+cWceqaTl7cnulPZCq75flWw9l2R6SWuKHSO+xvc4gew==", "4d30dfbf-ac3f-4604-a45a-45227b5ae03e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e94af06-b90f-410a-9a64-101ea3b82970", "AQAAAAEAACcQAAAAEDcQnfiIu6SgCLH7PCgW7a+cVqsklpPETDhmVDES9rHJEX2UL2uWptAKzP3UYDSVLQ==", "363301d2-6f79-41cf-b95f-2626d6d9ffea" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af305abf-3949-48cd-b561-0cfdaac24c1b", "AQAAAAEAACcQAAAAELfrYg5VlxspWMEzSPESPtJMjlmB3+XhVbh7S+H6jXDxGu2asl8gip2jjrQ785OgWw==", "a3a57e29-aca0-452b-b90d-57b65efd3add" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2db63efd-a3e4-46a3-8827-0d77e3a7050e", "AQAAAAEAACcQAAAAELmoKWOVPocPUR+Ii4XDyGC5hx84eGUtaeSNws0wFAZJf2LOQ7gjxGzkSJTx1RU0hg==", "c5791371-c90d-476a-a2d3-e66c57058ce3" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "acc6f57f-eaec-4f0f-aed7-8e6942160fa5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "25d9f4df-19bb-4589-a260-505f60ed983a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "40e4a6b1-4468-42d7-9d82-f0bbd2ddc308");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "42e66bb1-a1fc-48b3-820b-241ae680abd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "60bd60b3-b84a-448e-9035-4f595f88ffa6");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("26ab7b98-c27b-4802-bf19-101a307c1b36"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("bb031d07-12f2-41a9-b565-c544ab587826"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailsPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "TypeofStatus", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("08d6820d-f66c-4483-a84e-e8c2e08e0d40"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9923), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9926), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, 0, null, null, null, null, null, null, null, 0, null, null });
        }
    }
}
