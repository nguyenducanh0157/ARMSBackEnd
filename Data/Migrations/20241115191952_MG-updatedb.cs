using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c7fd155f-799e-485c-8c11-f632a5b376f5", "AQAAAAEAACcQAAAAEOqMw/YPUb29ueojvlmn+IzzBk5R/QeAQGftOdxC0l32vJpZYG336U+jgiQXSiqdeg==", "7886a31e-b1a8-4a7e-b4d4-260fc477bf0c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edc9d9b5-7aee-4831-a92a-a7f095436ae8", "AQAAAAEAACcQAAAAEP2YScSCuOJjxPaqE5dmduP9ts/BBb2rwama93Ct/x5pCW15VwhHUjRMlSG6B1Z5tg==", "b40e5eea-9453-41d2-9686-2d29b4a40b81" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2b5d4fe-6da8-4cb5-9cc9-2c4de3bc2f86", "AQAAAAEAACcQAAAAEPBUcwBL+LQFMn6VMgiNY1C20V1ym1bPdUXcD390sudBOU9Gxq+QAD2/nHxC+uoSgw==", "2bf33830-2611-497f-86d8-70147d4e3faa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3943acd5-e0a0-440a-b4a0-c86f67cbb4bf", "AQAAAAEAACcQAAAAEBOw30ZC9iDi3qN3qf7raczOb/MoMsUpJtBAeGbasolF105XaO6M9uVP4/Rxqu1JmA==", "5bfbc9f2-2bc9-4cc2-b7a1-a40f5b8f97b1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df85ac1a-640e-4eb8-88f8-fa4e20286ff8", "AQAAAAEAACcQAAAAEIGXgLRz91orAaWqQ3gfHn0pBmn2MA2vlUZz6nfaE2HHJHTGWJtgTbpFZDg/YosllQ==", "f722841f-e710-4506-91c2-4eef214a3be1" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("087f7ef3-4deb-48cf-9233-4a11d306c43c"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("08a8009a-84b6-4d61-b160-cefcfb56232f"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("144c5aac-3ede-4260-b753-c918ccbc9aeb"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2919f233-0b09-4de7-b930-8bd1d1f965f7"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2ac85d39-5596-4053-be71-5c83d6a466c9"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("33145f32-13cb-4bb5-8a8d-43731b9de27b"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("394a22e6-a0cd-420d-a5b5-66e5db01d277"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3a1a3d2d-66fa-4069-85af-e4ee5a0e215b"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("483e8967-d7d7-40d2-a63a-eac7aed100ba"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("559bccd0-bb3f-4e43-abbb-5b2b60bfab1d"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("56df6fc8-0c35-42fe-aac5-239220ecf39b"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("73ed225a-e88f-4f6a-a30a-1423bd549a6e"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7db112f9-a883-4c69-b03f-55adef002a45"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7f15b6a5-b2ad-46c4-97d9-3c776d46fe19"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("88634196-a658-4210-992a-a65b98e5d189"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9766d19a-5323-4d26-8d5f-8eec9d4a5018"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a849383a-116a-47e2-bde5-4a0036aa5891"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ab3377a3-7e0d-4d74-9d80-368976316d0c"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b03b2c59-fb2e-4771-bac0-734d13726c34"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("b6971f16-3099-41c5-a0e4-c06a17ce8496"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c4c99e87-c4d4-4122-8e15-d37533d24f6e"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cd0d7f7f-fd21-46d8-9b8f-e2564204ff65"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e96399c6-906e-4a9f-817c-c1719dda4977"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ed5d4014-b45e-4cc4-9499-36e30cbdc0f2"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "18b33a2e-6575-41e4-af0f-87953119ab7d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "17868375-f166-439b-8ba1-3a8bb9686c8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "bdf984ff-3683-4a60-b470-503154e94c01");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "d2d1e77a-da02-4dcf-9953-4d4c52907753");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "23817a9b-1f54-43ed-b735-594121698a81");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("89a06b96-edb8-4887-a2c8-a42f0af08306"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("bf9a8037-e857-4374-bb00-3652d0fe4877"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgAcademicTranscript6", "ImgAcademicTranscript7", "ImgAcademicTranscript8", "ImgAcademicTranscript9", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiplomaMajor1", "ImgDiplomaMajor2", "Imgpriority", "Major1", "Major2", "Nation", "Note", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailPriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TimeRegister", "TypeOfDiplomaMajor1", "TypeOfDiplomaMajor2", "TypeOfTranscriptMajor1", "TypeOfTranscriptMajor2", "TypeofStatusMajor1", "TypeofStatusMajor2", "TypeofStatusProfile", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8893), "Hanoi", "038301012121", null, new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8895), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, null, "0971341555", 1, null, null, null, null, null, new DateTime(2024, 11, 16, 2, 19, 51, 133, DateTimeKind.Local).AddTicks(8897), 5, 5, null, null, 2, 2, 1, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("087f7ef3-4deb-48cf-9233-4a11d306c43c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("08a8009a-84b6-4d61-b160-cefcfb56232f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("144c5aac-3ede-4260-b753-c918ccbc9aeb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2919f233-0b09-4de7-b930-8bd1d1f965f7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2ac85d39-5596-4053-be71-5c83d6a466c9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("33145f32-13cb-4bb5-8a8d-43731b9de27b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("394a22e6-a0cd-420d-a5b5-66e5db01d277"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3a1a3d2d-66fa-4069-85af-e4ee5a0e215b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("483e8967-d7d7-40d2-a63a-eac7aed100ba"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("559bccd0-bb3f-4e43-abbb-5b2b60bfab1d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("56df6fc8-0c35-42fe-aac5-239220ecf39b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("73ed225a-e88f-4f6a-a30a-1423bd549a6e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7db112f9-a883-4c69-b03f-55adef002a45"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7f15b6a5-b2ad-46c4-97d9-3c776d46fe19"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("88634196-a658-4210-992a-a65b98e5d189"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9766d19a-5323-4d26-8d5f-8eec9d4a5018"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a849383a-116a-47e2-bde5-4a0036aa5891"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ab3377a3-7e0d-4d74-9d80-368976316d0c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b03b2c59-fb2e-4771-bac0-734d13726c34"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b6971f16-3099-41c5-a0e4-c06a17ce8496"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c4c99e87-c4d4-4122-8e15-d37533d24f6e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cd0d7f7f-fd21-46d8-9b8f-e2564204ff65"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e96399c6-906e-4a9f-817c-c1719dda4977"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ed5d4014-b45e-4cc4-9499-36e30cbdc0f2"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("89a06b96-edb8-4887-a2c8-a42f0af08306"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("bf9a8037-e857-4374-bb00-3652d0fe4877"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"));

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
    }
}
