using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGPriorityDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("5e977d09-9c66-4f83-b01e-2a2948f5a49b"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("da2b90f9-9c84-4c75-8bbc-4887ef252bfc"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("bae00227-cb4b-403d-9ec0-193adb3bbfda"));

            migrationBuilder.RenameColumn(
                name: "Major",
                table: "StudentProfile",
                newName: "Major2");

            migrationBuilder.AddColumn<string>(
                name: "Imgpriority",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Major1",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PriorityDetail",
                columns: table => new
                {
                    PriorityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriorityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfPriority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriorityDetail", x => x.PriorityID);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e317723-ebeb-4a11-91ce-b64197175986", "AQAAAAEAACcQAAAAEGufOBdnn4PBc5mbuNAhznZkW+M0Bf+e/eru8LQyDZq8D0081ekyxU4YHgl3lx+j2g==", "5df19b9b-8c36-4b3e-bd86-b7e6456c6215" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df3ffd6d-171c-4aa6-b84e-4cb9e5748e0f", "AQAAAAEAACcQAAAAEDR6YqVRznpley1CQe4K2QJIyX993NPhuGoNKmm/hLUeXvGiOm1ZJRX8YF5UHjBTyw==", "d32ff22d-d591-4118-b84f-2f53d6edb57e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bb6fee3-b1b3-4709-859a-4945fa233b05", "AQAAAAEAACcQAAAAEJscBCqB+anjO9sTb5IBCljJgRIp63KbTFDR0SMcZRdEblmlJztGOluVvRgcOfrvPw==", "6db6bd33-d01f-4299-a790-4aa5e58181c1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a549258-7163-4ca6-ad16-5923cb33b9db", "AQAAAAEAACcQAAAAEKlhbAvFbgG7OvD21ICSDRB1fcqYFd/GxQJwmeJH8QIBnfUz6F84g1NzS+K0zUnhTw==", "1a3c8eb9-9407-4a12-8d40-975744682a50" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1225e677-8a55-41d2-a230-ed189a12356b", "AQAAAAEAACcQAAAAENxExQZPKgQsUIW+0rZhYxZdJ41UC7wQkUUZbZUn+l1Q3wMAYSlcWrd3YRuSAInMJw==", "3b2d6e27-d958-4ec6-b188-0a66b5ee4383" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "c708d143-2582-47fd-961e-8389c853cf47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "05dd8c12-b6b0-468b-86b0-6965b646b66a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "c1bce356-c7a0-4cf7-8559-b5bd55759287");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "8651952f-76a9-4f0e-894e-f66da6fb95e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "79bfe744-dc08-470c-a59b-bdb3b10bded8");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("dff8236f-8a4d-4cc7-9d6f-aab8149d1883"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("f78668c8-42f8-4edc-affa-e8e1a72b2dab"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("7f8fce9b-7ee9-44e6-8ca5-50f751dea36a"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4700), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4707), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriorityDetail");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("dff8236f-8a4d-4cc7-9d6f-aab8149d1883"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f78668c8-42f8-4edc-affa-e8e1a72b2dab"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("7f8fce9b-7ee9-44e6-8ca5-50f751dea36a"));

            migrationBuilder.DropColumn(
                name: "Imgpriority",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "Major1",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "Blog");

            migrationBuilder.RenameColumn(
                name: "Major2",
                table: "StudentProfile",
                newName: "Major");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a355932-1f5c-4041-9e1c-4f1173c4e2c7", "AQAAAAEAACcQAAAAECRQ5eKVuaH3sxhTI8l833t3prlHYZsyTK4HYDw0RE7kPWdPbbSqsRg3f/vljooLUg==", "e9f98848-b257-4d88-9043-a42bf51c311a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e364ea9b-35ee-4f99-a9e1-16c2b67cd289", "AQAAAAEAACcQAAAAEBfBonIVe7ig3k61FewrQtMp7Rr45yC89nHXr9almy6ConIvcvTmeKBBsHbjkXMklA==", "83c24534-089c-4d35-9dcd-d11e487eac33" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47907a5a-6d62-4623-9180-2ec1d9903562", "AQAAAAEAACcQAAAAEEA1pe70CJIUvLjLAllHczOpeJvtUvepnPPbi76pYT49hm4kpswweDZ0bgEOJ7GvxA==", "ec301443-1acb-4a00-a9af-c6dc9b3ed352" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4dc4c19-c6ad-4109-99b0-d094e2fec762", "AQAAAAEAACcQAAAAEJYuxthsSpRJ2afO4lrmShvlcMsOk1IWaDZpGirxWuToxKtFKXKaGlPxhabPcK/6yg==", "9a3e8f08-dc39-4978-9805-841b9a99afdd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9aed1a8-a2dd-4c5e-b575-2c5ffce75b01", "AQAAAAEAACcQAAAAEIeYYvuEVX90ytFhLSKGjP0nQSsks0geHpqR5msg+SzZH78xKBzzjcsjDuxxDP6BXQ==", "938673b4-8e27-4148-a8d1-a49651e188f5" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "652602d3-4a1c-4146-94e9-5e70fb030bc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "9d9b1d2a-4d8a-4e09-80ba-ffe33d8aa5a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "32e52fb4-815f-40f7-a546-8de3f66296e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "4fc90ad5-1dfb-4f33-a89b-72ddca373b33");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "f4ca2544-a5ba-4a14-b385-eade089442d1");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("5e977d09-9c66-4f83-b01e-2a2948f5a49b"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("da2b90f9-9c84-4c75-8bbc-4887ef252bfc"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Major", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("bae00227-cb4b-403d-9ec0-193adb3bbfda"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3132), "Hanoi", "038301012121", null, new DateTime(2024, 10, 17, 1, 40, 49, 204, DateTimeKind.Local).AddTicks(3135), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, "HAO", null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });
        }
    }
}
