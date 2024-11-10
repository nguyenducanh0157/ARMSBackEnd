using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajorupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("024b4564-2eb5-4db3-b2a5-c691fd009cbe"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("02ac385d-fba4-45ed-a215-fbb38074f88b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1cf46754-bc68-48e9-b8d6-af099f3a2d79"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("286f1f9a-7827-431a-b4db-8781dcf2f8c8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3ae3621c-851f-43f4-a3f5-5064c7211a91"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3e1eeb9e-7c96-4c9f-a634-68f8a5cf91cd"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("46475fc3-c96a-4ec9-9aff-f34060291f4a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("50c66f5c-adb9-45ae-b588-b2cc3a609a72"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("64f26da2-bd25-4378-b85a-507611b97370"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6fb5e1d5-8138-4342-9923-2a704f6fb3b2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("708d75bb-3c3f-45a4-8903-4bde0305b011"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("72222663-1ed9-4025-83fe-71ae4f3ab77a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7cd21a77-4b9e-4b32-aad9-fe2b89c79b54"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("865b01b2-7ae7-48ed-9660-346e7f2ad7c9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8a51a83e-66c7-4113-9b10-c92699952326"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("94a6bc43-6a27-430a-9dd0-64576f4a1cca"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9c014ed4-38b9-4287-9b95-66241ffb1b6b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a65b7105-d7bb-43ca-ac4d-0db1891de4f5"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bd5f8c5d-3315-43ca-b61c-efe11bbce23b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bff32112-fa83-41cf-9440-96d6dfd2f6ce"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c5e0d0d9-4c7f-4f24-b6b5-de46f04afab3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ca40e8a1-b3a6-4cd9-93ee-8d683c0d9bac"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cca2d610-680b-4688-a5ff-ff7793957340"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ed1ce9ff-16ca-4bb0-9434-57bcc5fa0480"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1e7a5547-0e6e-4fbd-b943-747aaf6611d5"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c82405ad-07fe-4a04-b186-0e16eaaa2c2a"));

            migrationBuilder.AlterColumn<string>(
                name: "MajorOld",
                table: "RequestChangeMajor",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MajorNew",
                table: "RequestChangeMajor",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7a7a000-3a9d-488f-81e6-799456e1c189", "AQAAAAEAACcQAAAAEEGjdYWMqyg7eg/PeuNpefh2B8osI6JC9NWPzjPBg9uaAgrUIyN6/slZdYfdAdiklg==", "26a1c4dd-49a5-4366-9046-ff67c5870acf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce538416-28fe-4a8b-9e52-9947a93c3d6c", "AQAAAAEAACcQAAAAEOoW7ziHasbbtS3CtQqN1xRVs9M/gmoIYxI5s7sMdrbBahsATOusLZOquJWSZ4P8JA==", "4e8b1270-bc9b-47bb-a05c-3cd0c38ebee4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "694661c5-c207-41fa-875d-81c7d26c758d", "AQAAAAEAACcQAAAAEMLlxYJxXPX/CeVzrDcvLllTkaaPIp2BZfsfHZ7MmJs2wCCYPLph6jRyj0Y0EGwteQ==", "9b484e12-7ee0-4582-9b66-9250f4724af8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "362c3bff-b593-4190-b25a-94545c6c4045", "AQAAAAEAACcQAAAAEEd/dh1tTYsNP38VQd/aJIQwHeMOd88wcxIW2pL5KyIBCDvsFxboQKudmQoTrn22Gg==", "b95f8c11-a040-482c-b013-d0588d8f201a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9541f20a-e5e6-46bb-bbd9-43afc02bf41b", "AQAAAAEAACcQAAAAEOx3MAZ/jmhG1DfbpxfBxsMwAoQaLXeHv9WXx98sn8CHY1qOpfvcnjvP5ViVMxH/WQ==", "5ea20ea7-3dcf-4901-9471-b880ed960d4a" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("00849b37-cbeb-4c09-a724-a32807cd0cf3"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("01621697-7158-4b22-9481-d26860a316a0"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0f040a2e-2920-41e5-8e46-86b1aaf58235"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("34df1aeb-472f-4570-9307-e2a87e88718b"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("4f22b695-59d0-400e-85b3-ef59af7f4260"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("55aa24ce-a42f-45b4-bdb0-ddbe69ead993"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("580c7014-ae9d-4d30-9554-7b1c7a7ab04a"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("650b31ab-2cc1-4dbd-abad-b2debf0154cf"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("66a2653a-6602-4695-9cc8-c27a9f08154f"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("69cec51d-db45-41fc-a7a4-a4c158378313"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("71675006-24fe-4658-baf9-161c17241a5a"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7855ea4d-e19b-4ca2-b31b-dfde8def4620"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8723a23f-eee8-4131-964d-13355156497c"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8cdbbe1b-a232-43a1-9abf-bc394267f5a0"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("908f37fe-21e3-44d1-b602-88dc58c7ebe4"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9401c2b1-3761-43ef-89a1-e92e2a128e0d"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a498b9ba-8c31-4479-976a-5180a3da2e58"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("aab1e9c1-c339-4d2d-9705-aea79701b7ae"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c81ec6db-aa6b-4d3c-99de-d97188fa4aed"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c8416c32-bf6b-452d-8d25-b18e3716f892"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("df44b8c8-fe8e-49e4-aa92-96a52fa1243f"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("df8909cb-6a86-4b08-aa9f-8cc835ed522b"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e82faf95-618f-4e6b-b445-3d6e8e7b6d58"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("fd38a9df-b626-48e6-a259-1b8c98109e40"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 7, 35, 51, 683, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "7a6f6d88-3c4f-4ad0-bec3-fdb7460c638c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "3b82a74a-48c6-4479-b6a4-ac0792717084");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "415a34c3-3961-4c72-abb6-0a36197fa78b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "1452634b-ebc5-459c-8f13-d7d8b4699151");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "eba6ad05-9118-4c39-84a4-d084b47e5a79");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("71db1fdc-3193-4e97-a966-c56318776aaa"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("8c038079-5fa6-45b8-943f-5bd4a1f11231"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_MajorNew",
                table: "RequestChangeMajor",
                column: "MajorNew");

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_MajorOld",
                table: "RequestChangeMajor",
                column: "MajorOld");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestChangeMajor_Major_MajorNew",
                table: "RequestChangeMajor",
                column: "MajorNew",
                principalTable: "Major",
                principalColumn: "MajorID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestChangeMajor_Major_MajorOld",
                table: "RequestChangeMajor",
                column: "MajorOld",
                principalTable: "Major",
                principalColumn: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestChangeMajor_Major_MajorNew",
                table: "RequestChangeMajor");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestChangeMajor_Major_MajorOld",
                table: "RequestChangeMajor");

            migrationBuilder.DropIndex(
                name: "IX_RequestChangeMajor_MajorNew",
                table: "RequestChangeMajor");

            migrationBuilder.DropIndex(
                name: "IX_RequestChangeMajor_MajorOld",
                table: "RequestChangeMajor");

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("00849b37-cbeb-4c09-a724-a32807cd0cf3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("01621697-7158-4b22-9481-d26860a316a0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0f040a2e-2920-41e5-8e46-86b1aaf58235"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("34df1aeb-472f-4570-9307-e2a87e88718b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("4f22b695-59d0-400e-85b3-ef59af7f4260"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("55aa24ce-a42f-45b4-bdb0-ddbe69ead993"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("580c7014-ae9d-4d30-9554-7b1c7a7ab04a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("650b31ab-2cc1-4dbd-abad-b2debf0154cf"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("66a2653a-6602-4695-9cc8-c27a9f08154f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("69cec51d-db45-41fc-a7a4-a4c158378313"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("71675006-24fe-4658-baf9-161c17241a5a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7855ea4d-e19b-4ca2-b31b-dfde8def4620"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8723a23f-eee8-4131-964d-13355156497c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8cdbbe1b-a232-43a1-9abf-bc394267f5a0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("908f37fe-21e3-44d1-b602-88dc58c7ebe4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9401c2b1-3761-43ef-89a1-e92e2a128e0d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a498b9ba-8c31-4479-976a-5180a3da2e58"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("aab1e9c1-c339-4d2d-9705-aea79701b7ae"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c81ec6db-aa6b-4d3c-99de-d97188fa4aed"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c8416c32-bf6b-452d-8d25-b18e3716f892"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("df44b8c8-fe8e-49e4-aa92-96a52fa1243f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("df8909cb-6a86-4b08-aa9f-8cc835ed522b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e82faf95-618f-4e6b-b445-3d6e8e7b6d58"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("fd38a9df-b626-48e6-a259-1b8c98109e40"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("71db1fdc-3193-4e97-a966-c56318776aaa"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8c038079-5fa6-45b8-943f-5bd4a1f11231"));

            migrationBuilder.AlterColumn<string>(
                name: "MajorOld",
                table: "RequestChangeMajor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MajorNew",
                table: "RequestChangeMajor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d7cedbf-dbe2-470e-b921-5d4cb1df6873", "AQAAAAEAACcQAAAAEKyODORpvuE5dyHju8wqaua8QJ666BzqFq266HMxJg+wMWcSszlqlg6x2+yrxjq0yA==", "9a06e8fb-bed5-4495-ac5b-05617da0e069" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20d68d74-62a3-4ef7-804f-293c56065f1a", "AQAAAAEAACcQAAAAEDNtgwTk3OMXMfFEbSjIgYS5mVJzN6SEv6G1IFUzkgl2V1P08xrEfCpXzRnb1sQL7w==", "c0389c8e-562c-4ee3-8119-308c4b6508b4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2bbd9bf-5508-4c2a-b0d4-570f5a3b7823", "AQAAAAEAACcQAAAAEN/J9XZ2ehuco7Cb/la+h7o/QGgycYYKmXkSHMnbf+xYsIn78+PRcFdL8974+QL0Kw==", "6c33d504-bb81-4d44-881a-a6e7358562c6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0292b0a4-bf7a-40f6-874c-89dab33cd4b7", "AQAAAAEAACcQAAAAEEEX9HdmFuLChq7ryyQ74GmQb6p4gQzJScioT9Xo1Bc7QkTTNFLchWbI6mES7dPTAw==", "9864ae15-1529-4632-b5c5-6f7ef40de9a8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5246047-58b0-40aa-93ed-07a8e8bdd850", "AQAAAAEAACcQAAAAEJUk74y3JaRG4KHD3j3+tg7Ir76jqoZSa+K2PRM2vc9e6chpCEovTGOebIqmAo8Enw==", "002eb3cb-6f4f-4852-aebe-858414e71380" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("024b4564-2eb5-4db3-b2a5-c691fd009cbe"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("02ac385d-fba4-45ed-a215-fbb38074f88b"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1cf46754-bc68-48e9-b8d6-af099f3a2d79"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("286f1f9a-7827-431a-b4db-8781dcf2f8c8"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3ae3621c-851f-43f4-a3f5-5064c7211a91"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3e1eeb9e-7c96-4c9f-a634-68f8a5cf91cd"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("46475fc3-c96a-4ec9-9aff-f34060291f4a"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("50c66f5c-adb9-45ae-b588-b2cc3a609a72"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("64f26da2-bd25-4378-b85a-507611b97370"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6fb5e1d5-8138-4342-9923-2a704f6fb3b2"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("708d75bb-3c3f-45a4-8903-4bde0305b011"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("72222663-1ed9-4025-83fe-71ae4f3ab77a"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7cd21a77-4b9e-4b32-aad9-fe2b89c79b54"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("865b01b2-7ae7-48ed-9660-346e7f2ad7c9"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8a51a83e-66c7-4113-9b10-c92699952326"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("94a6bc43-6a27-430a-9dd0-64576f4a1cca"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9c014ed4-38b9-4287-9b95-66241ffb1b6b"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a65b7105-d7bb-43ca-ac4d-0db1891de4f5"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bd5f8c5d-3315-43ca-b61c-efe11bbce23b"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bff32112-fa83-41cf-9440-96d6dfd2f6ce"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("c5e0d0d9-4c7f-4f24-b6b5-de46f04afab3"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ca40e8a1-b3a6-4cd9-93ee-8d683c0d9bac"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cca2d610-680b-4688-a5ff-ff7793957340"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ed1ce9ff-16ca-4bb0-9434-57bcc5fa0480"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "5632d3b7-e8b2-463f-ac83-6e8fae36ba66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "5d30de03-3e0c-45d3-af6f-e987425fbf4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "179dbf2b-0141-4821-aea9-39ef6b6d31f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "1a96b3dc-e430-4bae-afec-0526c43277e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "0889bee9-3a04-4db8-a920-0b413fe9c745");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("1e7a5547-0e6e-4fbd-b943-747aaf6611d5"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("c82405ad-07fe-4a04-b186-0e16eaaa2c2a"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
