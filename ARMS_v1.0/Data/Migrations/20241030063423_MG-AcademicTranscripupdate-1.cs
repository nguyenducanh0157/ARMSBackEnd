using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAcademicTranscripupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "8110ad60-da75-40f7-b3ea-30b5b43f704d", "AQAAAAEAACcQAAAAEPFNkYx+FiY2UAG4vcaWXGvwh0hhnvhI8Qmqka+IJvAZmuZoHj109r6ETZxBKoIW9w==", "bd9ca368-f31a-4066-a6b8-0856f878ace0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f7189d-b429-4057-a96f-9f38cae8c852", "AQAAAAEAACcQAAAAEDzPkf+KFkfx5NeLTTEPBMnGezNfk0VzlshDhQDNsYM2sdZTb3nHllaK1iDbTNtdbg==", "b3cd3b2d-050c-49b5-b1e5-381e6fc7bc8b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8056f110-2e7a-4462-a132-ba1640d7c13a", "AQAAAAEAACcQAAAAEANUhMhcYHGgimPUXUvNBFeEtwjAAsUkXJUcO92tBvVR7y/Yxgxt2PF+/y90CBnE1A==", "2e2b47c0-fbb3-4bba-a157-792c2869f30f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41e5f3b1-e7f6-4be1-bbcc-d75858bd4585", "AQAAAAEAACcQAAAAENX1YnVN3W5A1LRku80dnCHS2T5UXIP13vc4eq74a71HHDJkmmVJ84ztpm3X+m5o3w==", "a658e0cc-1948-4b9c-a1cd-02e8b4810004" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75cc4dba-dadc-4b9a-8708-108e19816b72", "AQAAAAEAACcQAAAAEETg4efHQgsxfmMyw0d5ziKnmR6cp1/Nwio/bIoDU3TJ7ZDi4akEy+LmUtSdSvFt5g==", "0716fd27-2af6-41b7-bba7-ce1fec36d715" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "2f7586b5-a1b7-4382-9b6b-9f80cf95b61d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ac0c4a6d-73a8-4747-a686-4ccb4d9588a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "2c72e421-6f45-441f-b01b-548825949517");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "e9303005-6ac7-4823-aa2b-3f657b7073c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "6487e199-ec29-41a3-90f7-fb418a5fe9c8");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("6e718614-acc3-4457-9580-84e3649a58e2"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("d8469ee6-dca1-4ea6-8c4d-b18905104284"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailsPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "TypeofStatus", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("a1eb6d3e-c5db-44ec-beb0-c02c2776e089"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(5088), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 13, 34, 22, 109, DateTimeKind.Local).AddTicks(5091), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, 0, null, null, null, null, null, null, null, 0, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("6e718614-acc3-4457-9580-84e3649a58e2"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d8469ee6-dca1-4ea6-8c4d-b18905104284"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("a1eb6d3e-c5db-44ec-beb0-c02c2776e089"));

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
        }
    }
}
