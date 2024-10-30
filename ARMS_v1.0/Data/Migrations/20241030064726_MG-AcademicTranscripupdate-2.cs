using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAcademicTranscripupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4ac103bf-9637-4672-994d-a131798140be", "AQAAAAEAACcQAAAAENf1+KHqwBwU5cM+otKFAAqgAz9yzG6kEg5kDR/yL86aHw4X4uCwuyAPJ5iNtfbD8A==", "12609aa3-0521-41ac-a515-452d996d25c7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ecacffb-9456-4093-8070-3fa839a4e650", "AQAAAAEAACcQAAAAEOvDRGfg8lu56gx7oJo1xKdahDrUi8727Q1//vTGt2lzF23KIWVirPoU+dK/D/C7iA==", "981b2ee1-e3df-425a-af4c-23bd4ce649e8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "734e7cef-00e8-4474-85f4-d00cd07d73c9", "AQAAAAEAACcQAAAAEBBmPYQ7Hvs7E4uDurZaaXCZi7y460CtUJhM/Uft52qsYekxgDgzxhIsBkRHb5VUlg==", "a62dc56a-0b5b-40ba-9976-807d71bfc87d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48df2849-e542-4e14-9e16-182a2de7cb80", "AQAAAAEAACcQAAAAEF12gPexzXlm6UHnNBmjrEfCaJkRxF/6fuuL+6WnD6MiO1bwhk7r6mX2ffTiHBiIPg==", "3eb58566-d400-499d-8e81-ae1e3644de6b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07505553-5dd9-4c80-82c8-7691a56df450", "AQAAAAEAACcQAAAAELe7JgXWpVMdaikS+9GC6989CM5zSTL8gNpDb/yXRVOEw4xs1I+Ec5hqVn13GmkTNg==", "7e1e3bba-ee58-43c0-a787-d978fd5b5a4d" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "ff2454de-452e-4b06-b841-7083553e8564");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "da4c006f-e7b6-48dd-aa69-64189988cdf3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "78c7af45-e293-49c4-83ce-2844956be059");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "8975b641-b280-42d9-a534-daa48ba55c98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "69332b5e-d94c-422f-a1f0-45e37050bf76");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("08f7cb29-eced-42ac-9f13-3ee20cf74ca2"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("c613cfd7-62b4-417e-8d3f-7c339f579970"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailsPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "TypeofStatus", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4738), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 13, 47, 25, 440, DateTimeKind.Local).AddTicks(4744), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, 0, null, null, null, null, null, null, null, 0, null, null });

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[] { new Guid("33618168-816d-4398-b0d0-4feac59d961e"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1 });

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[] { new Guid("d48b2841-c8cc-4f9e-b703-6c7efda13a10"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0 });

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[] { new Guid("ee629dfe-c4c4-4a96-8fe4-55d4ab1ad970"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("33618168-816d-4398-b0d0-4feac59d961e"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("d48b2841-c8cc-4f9e-b703-6c7efda13a10"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("ee629dfe-c4c4-4a96-8fe4-55d4ab1ad970"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("08f7cb29-eced-42ac-9f13-3ee20cf74ca2"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c613cfd7-62b4-417e-8d3f-7c339f579970"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"));

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
    }
}
