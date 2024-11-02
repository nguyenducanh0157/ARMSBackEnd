using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGStudentProfleupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("0d98d5ec-f41e-4814-93be-1a6f1a0316ca"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("22ed6b96-407f-473b-bd49-b8a7df46720d"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("555f58d7-5cc8-4b35-b246-c27bca57bbf6"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("840f7c5e-ebe6-46d1-bb90-627c259661df"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("95ec87af-22c0-454c-b870-22f297951684"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("d2351212-a095-4b56-a4f3-0c74d1b8821d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("02f27cde-d5ff-4786-ad96-b0ba3eaf3a35"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("09b34ec9-c47c-4c4b-9920-17a4bb6fd939"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2614dc09-3416-4e90-a20b-441511edc2a7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("40ee808a-1d44-4c44-9e94-f358ced761af"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("43813578-35bc-4c87-bb64-1390ad931a64"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5c02ebfd-1a37-456b-b9a0-cd09d2bb0adb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5d335941-75ba-4bd4-af30-e4232f443d5f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("62d014a3-1a4f-4825-8eff-9e588a38fe60"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6347c155-a35e-41b9-b8d4-fedc455c6e48"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6e267320-b17a-4d90-863f-9ab6a1e1d4a4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("85e58ffe-1606-418b-bbf5-57d6d95ad72d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8b3be06a-105a-4fd9-9e42-d38a7cf8714a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a04aa0a5-a94f-4079-bc9f-b947bcb669f3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a4a74c03-ab73-4004-b578-87338d3a9a2c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c8ae6a15-e528-43d7-8347-a6751d849120"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d74190ad-85a9-43ba-be81-693b6ba0651a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("da48b495-837a-4c15-a552-b964ebf90a52"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dbe58bca-40b9-4e50-ae44-08f2d21e6098"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dd8b9ab7-2785-4b87-8542-e7e458c0a543"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("deba63d3-12f8-4ab5-a550-3ad937ed4285"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ea8a63ba-c372-4b27-992a-e1a2c13aead2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ee952e45-241c-411d-b6b5-42a0219a89e4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f2051a00-fdc0-44f0-b4ed-c06b469410c3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f983aead-b29e-42e5-9c70-a5627780f593"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e4a43c5a-46fc-4b06-b0fb-df53b7b9b528"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f9696c97-812b-4283-91f0-8bb574d921c2"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"));

            migrationBuilder.RenameColumn(
                name: "TypeOfTranscript",
                table: "StudentProfile",
                newName: "TypeOfTranscriptMajor2");

            migrationBuilder.RenameColumn(
                name: "TypeOfDiploma",
                table: "StudentProfile",
                newName: "TypeOfTranscriptMajor1");

            migrationBuilder.RenameColumn(
                name: "ImgDiploma",
                table: "StudentProfile",
                newName: "ImgDiplomaMajor2");

            migrationBuilder.AddColumn<string>(
                name: "ImgAcademicTranscript6",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgAcademicTranscript7",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgAcademicTranscript8",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgAcademicTranscript9",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgDiplomaMajor1",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfDiplomaMajor1",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfDiplomaMajor2",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74d7c79c-c9ae-4da3-9a79-9f9fbf3164ea", "AQAAAAEAACcQAAAAEKffpRfTa6bY+qOPZCuawTMcJLbC9aV4DKKKwxoItToYcS+jw7U5tLebHfsNcoJLOA==", "7aad4299-8c66-4068-b4e3-4271167d73e7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58e8a2dc-46c5-495b-a48e-e034b48f31b0", "AQAAAAEAACcQAAAAEE7DGPDT9n/7XXHXTjZkXfGark0E9kXj7z70Y/hpPeJyQR/Pf5o8qVPsA3kDY4fjGg==", "2108f57f-5e7d-4079-a632-40c12afa186f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7040c1b4-ea2a-47a5-9d16-4a02d3b4c079", "AQAAAAEAACcQAAAAELKU7Qc3OcM1198sHmXTc1qfQL8754xxYB29Fhu8nKJWbWuCJSMEvo1d6Jv+/Ji17g==", "2c95b4c3-0ad9-497c-ab0e-20560986982c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae00a295-d003-4c49-9ab3-f6ef66cec968", "AQAAAAEAACcQAAAAEORTg/g1M0uKfRA6rNAMIKF7QEQPpKi91SgrZ/55WXjqiNa2l3UhtSisOWxbvSdKpA==", "92269fd2-f946-4452-82d2-2a3ca18a3529" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59acfd39-78db-4e38-9fed-3b6d97a657e1", "AQAAAAEAACcQAAAAENpgrJK7hjVZ9YI+sPAFmfrf9FBqTMY/TqhQW4wZ0oS62B/VUvgdrGzKy3Xb4kkVRQ==", "5eaadae8-fc1d-4c0c-8d30-39a2d52c81ef" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("0091da11-2d1d-4885-9b49-520e7f74b18e"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("026591ea-9807-4c8d-aeee-57b31b7378d9"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("05fffa29-4c98-47c6-8c5e-5b6c466d54b6"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1c23bb33-ec14-4180-b7ca-a5254d37677e"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("466fe9e7-2a57-40bc-9b7c-82f110dc0333"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("50914362-9954-4d77-b686-f8dcc648f26b"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6ba386a3-ccf1-4abd-8222-b5a941416be2"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7167d8a0-3031-49f0-ac49-ead3014c8f1a"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("96245195-79e3-4507-807c-3a7fd0abc27f"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("afc343ca-5a93-4ff1-8dbb-2ced5283fc79"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b1ad7d1e-95c9-4dd7-bdea-1d8175f89620"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b243eaa8-e960-4c84-b7d1-77f827a56f89"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bfde72b8-c329-4fbb-b48c-7ee888dbea3d"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c3fe3178-4bc0-43a5-8ce6-ec79c1ea11c6"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c65d671a-f2d9-49d8-959f-139951c65047"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cbac8be4-a744-4147-bc12-4d0d516daa35"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d0f1d929-d7e8-41f7-9b12-5a7f2eaa1758"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dab7ea55-3178-4bb2-9778-6725e50bbfe8"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("dff74e45-edd4-4bab-bc49-e0e55caa92f7"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e536f1fb-196b-4929-9d19-f7738fe3dec6"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ea0ab068-64e4-4b48-a331-0da33d03482f"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f5dade59-9ec3-41a7-9b6c-f5d292eadcf2"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("fbddf7fa-067a-4419-a3b3-ee7740f06a51"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("fc27ba27-09c9-4800-b2ea-9071fc346124"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 2, 22, 52, 50, 194, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "8a08d41f-7cdf-4011-a483-12d0de8bd0c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "38476e2e-9d9c-4498-b373-e76eeabb2658");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "8bf34b64-2b68-4874-8fc1-55fe226c8b69");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "48a813d5-270f-4ecd-9a97-c127b0f36505");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "ff93a4ef-82f1-4af2-a1a4-fa1b3f1d9a0b");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("259dc01c-8ef4-48eb-a20f-211a7503473c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("94b792e4-153a-4d10-b941-711748138cf9"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0091da11-2d1d-4885-9b49-520e7f74b18e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("026591ea-9807-4c8d-aeee-57b31b7378d9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("05fffa29-4c98-47c6-8c5e-5b6c466d54b6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1c23bb33-ec14-4180-b7ca-a5254d37677e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("466fe9e7-2a57-40bc-9b7c-82f110dc0333"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("50914362-9954-4d77-b686-f8dcc648f26b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6ba386a3-ccf1-4abd-8222-b5a941416be2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7167d8a0-3031-49f0-ac49-ead3014c8f1a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("96245195-79e3-4507-807c-3a7fd0abc27f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("afc343ca-5a93-4ff1-8dbb-2ced5283fc79"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b1ad7d1e-95c9-4dd7-bdea-1d8175f89620"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b243eaa8-e960-4c84-b7d1-77f827a56f89"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bfde72b8-c329-4fbb-b48c-7ee888dbea3d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c3fe3178-4bc0-43a5-8ce6-ec79c1ea11c6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c65d671a-f2d9-49d8-959f-139951c65047"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cbac8be4-a744-4147-bc12-4d0d516daa35"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d0f1d929-d7e8-41f7-9b12-5a7f2eaa1758"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dab7ea55-3178-4bb2-9778-6725e50bbfe8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dff74e45-edd4-4bab-bc49-e0e55caa92f7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e536f1fb-196b-4929-9d19-f7738fe3dec6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ea0ab068-64e4-4b48-a331-0da33d03482f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f5dade59-9ec3-41a7-9b6c-f5d292eadcf2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("fbddf7fa-067a-4419-a3b3-ee7740f06a51"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("fc27ba27-09c9-4800-b2ea-9071fc346124"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("259dc01c-8ef4-48eb-a20f-211a7503473c"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("94b792e4-153a-4d10-b941-711748138cf9"));

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript6",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript7",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript8",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgAcademicTranscript9",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgDiplomaMajor1",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "TypeOfDiplomaMajor1",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "TypeOfDiplomaMajor2",
                table: "StudentProfile");

            migrationBuilder.RenameColumn(
                name: "TypeOfTranscriptMajor2",
                table: "StudentProfile",
                newName: "TypeOfTranscript");

            migrationBuilder.RenameColumn(
                name: "TypeOfTranscriptMajor1",
                table: "StudentProfile",
                newName: "TypeOfDiploma");

            migrationBuilder.RenameColumn(
                name: "ImgDiplomaMajor2",
                table: "StudentProfile",
                newName: "ImgDiploma");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9362354c-069c-4701-ba43-b2f4c2300472", "AQAAAAEAACcQAAAAEKTGl0KC1pqHTxttKj4CtwtxOonibpDDPdJsFYlID3KG3kA053zoMv6mY8eAy77uMQ==", "eeb7378f-20fe-4e1c-8a55-cd0be14e5879" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa3504a4-6d8e-404b-a3ee-eb4b08274dd9", "AQAAAAEAACcQAAAAED8VibAOc8SELG1Sd8pspIdCgfeoYLwfcRqHNX4eSykGrkwEMU1wAuFWqE68ByqxAg==", "e5c5f4c3-a797-47a8-9dd2-77b9e812e8d6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc4795f1-ecc8-4400-ba6b-0c06c7a35f63", "AQAAAAEAACcQAAAAEHoLNmN4iX1E7+h2uaxd9mvNiFhpiAc+tyA03jRrqDX1cqhrsUPWP/Ob7I54k4JqTA==", "454a3c7f-205d-4b71-ae6c-6778d1ec0562" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56f099ab-a6ca-4d0a-8d1b-d62966da9508", "AQAAAAEAACcQAAAAEHSBrCusJvUTeQiReybm6MppkwBNftnmK9LKXftmMhAlL1CG+nZT9lDx0as5kXgxpQ==", "bbfe5336-27be-4189-9d7f-6874a8ea60cf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcd4af30-b81f-47fb-9128-ee74d4e97eef", "AQAAAAEAACcQAAAAEGDk2GcfcQAPGbjfTVEWQQQmWORc4VrEqIJz2FaLjJYzxmMgWFiWYKu3TVZFMrW36w==", "29c9a94b-22b0-4a9d-abcf-0f2889519bd3" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("02f27cde-d5ff-4786-ad96-b0ba3eaf3a35"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("09b34ec9-c47c-4c4b-9920-17a4bb6fd939"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2614dc09-3416-4e90-a20b-441511edc2a7"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("40ee808a-1d44-4c44-9e94-f358ced761af"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("43813578-35bc-4c87-bb64-1390ad931a64"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("5c02ebfd-1a37-456b-b9a0-cd09d2bb0adb"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5d335941-75ba-4bd4-af30-e4232f443d5f"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("62d014a3-1a4f-4825-8eff-9e588a38fe60"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6347c155-a35e-41b9-b8d4-fedc455c6e48"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6e267320-b17a-4d90-863f-9ab6a1e1d4a4"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("85e58ffe-1606-418b-bbf5-57d6d95ad72d"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8b3be06a-105a-4fd9-9e42-d38a7cf8714a"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a04aa0a5-a94f-4079-bc9f-b947bcb669f3"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a4a74c03-ab73-4004-b578-87338d3a9a2c"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c8ae6a15-e528-43d7-8347-a6751d849120"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d74190ad-85a9-43ba-be81-693b6ba0651a"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("da48b495-837a-4c15-a552-b964ebf90a52"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dbe58bca-40b9-4e50-ae44-08f2d21e6098"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dd8b9ab7-2785-4b87-8542-e7e458c0a543"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("deba63d3-12f8-4ab5-a550-3ad937ed4285"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ea8a63ba-c372-4b27-992a-e1a2c13aead2"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ee952e45-241c-411d-b6b5-42a0219a89e4"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f2051a00-fdc0-44f0-b4ed-c06b469410c3"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f983aead-b29e-42e5-9c70-a5627780f593"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "85d4a094-5008-43e0-ae4a-49e1f3453102");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "22fb4e7f-9a08-4989-a0c9-561c488bc155");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "592b1dc6-91af-4de0-a2d6-f7620cbc0f0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "52f56ed0-6337-4ee6-bdbc-9ba02bed1182");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "d90fa812-0ff1-456d-8cce-56dba9475434");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("e4a43c5a-46fc-4b06-b0fb-df53b7b9b528"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("f9696c97-812b-4283-91f0-8bb574d921c2"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "Note", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailPriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TimeRegister", "TypeOfDiploma", "TypeOfTranscript", "TypeofStatus", "Ward", "YearOfGraduation" },
                values: new object[,]
                {
                    { new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2703), "Hanoi", "038301012121", null, new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2706), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, null, "0971341555", 1, null, null, null, null, null, new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2708), 5, null, 0, null, null },
                    { new Guid("795b3e70-1312-4889-8352-a696757d1730"), null, null, "HCM", new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2711), "Hanoi", "038301010101", null, new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2713), "hoaithu1707.25@gmail.com", "Truong Thi Thu", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, null, "0971341554", 1, null, null, null, null, null, new DateTime(2024, 11, 1, 23, 40, 37, 848, DateTimeKind.Local).AddTicks(2714), 5, null, 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript", "isMajor1" },
                values: new object[,]
                {
                    { new Guid("0d98d5ec-f41e-4814-93be-1a6f1a0316ca"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0, false },
                    { new Guid("22ed6b96-407f-473b-bd49-b8a7df46720d"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2, false },
                    { new Guid("555f58d7-5cc8-4b35-b246-c27bca57bbf6"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0, false },
                    { new Guid("840f7c5e-ebe6-46d1-bb90-627c259661df"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2, false },
                    { new Guid("95ec87af-22c0-454c-b870-22f297951684"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1, false },
                    { new Guid("d2351212-a095-4b56-a4f3-0c74d1b8821d"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1, false }
                });
        }
    }
}
