using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajorupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Reply",
                table: "RequestChangeMajor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63686cca-8555-4116-a363-bcb74e7cfe39", "AQAAAAEAACcQAAAAEANN83ICojxo98lBhn1O4Qpgpv+Phyy7zp08Z6aLacDE9hgi9/Zl/qIQc3CD++q+6Q==", "950eaedb-0b08-463c-8293-5c356142aff3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d21f043e-2891-49bc-a23b-b078d3ad552a", "AQAAAAEAACcQAAAAENVjryZPQgtdM/SgKFooAmvH7VVybWFqtZqBOAaAXgZ4jRgZtDcHQk6zOglITdwnFA==", "8681f451-7419-4246-b150-e97ee9eee7f4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db15af82-a175-4c80-93d6-f909001c8771", "AQAAAAEAACcQAAAAEKA0hXZrxrg4Pk+e8yipaHIEl9lhL+CEgKrlhoqngXbi8wfV5T3RmTth81bSYNitqQ==", "4737959e-15db-4547-bd3d-6d8a0128730a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78825175-ac0e-498f-b912-496abac98948", "AQAAAAEAACcQAAAAEEVmZ/955Td9qUC6i5JlwRm60d9NcjIZBs2+hUydHHCBhZ5aEc4PEKSp35L2kPbTng==", "b2331bdf-0a3c-4e1a-a1a1-b8fda7df0673" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b0646fa-47cf-4043-9e23-85df9e41f694", "AQAAAAEAACcQAAAAEGqKGTRxv5jHmwT1TYcqmGZZ13PTsGl0pCLRv2S+doUy2b9gguxT1ihIsr90jZUdXQ==", "2a24cead-cec3-4deb-93c9-845253be5700" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("048e9410-4ffb-468f-b75c-5d118607ea5b"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("05a2515c-f95c-4d86-bc07-7d02c9dd192b"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("25588555-3d2f-4f2a-b8e7-c5dc985e2107"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2c9d301d-96a2-49e2-a88c-82de1a664499"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3a368fc6-d43d-4881-85ec-24c717a26618"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("42336222-a133-408b-bdfd-086a754c60b9"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("426601e4-f1b5-40ce-bbda-ef58414ed182"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("465d0c7d-807a-41f1-aefd-7e703a5a17f6"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("49581f5e-a344-4a67-9016-346a04475b58"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("585e6710-0c9e-4267-acb6-893e945fd0be"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("607ee92e-c930-49bc-b08a-d02e87342929"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("743f7050-cffc-4c7f-b509-74448386fefb"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("850d1e84-4e36-4ca3-885f-f7d9c126eab2"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("867ed94d-1b96-41d4-a6f8-08ec19c59fe0"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a26d2fe1-6222-489a-96c8-d772d7d4d57d"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("af2b87a1-ae55-4f5a-ad09-9323265f0315"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c8473e3e-61ff-492c-9595-9a9c206e748f"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d4eac446-5083-4d29-8ecb-f9938aff49e3"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("db7649ed-30be-4985-95da-6c48776296ad"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e5d31470-61ec-4026-ac7c-87f3c141f4f7"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e937d69b-9540-4ca8-8b68-b0f4ebc72e65"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f360899d-cfc3-4ef8-85a4-f998caca81cb"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f8931ad4-6141-4b53-ad63-9c08d95508a2"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f8d7b3d4-fca8-411b-b372-064f288a9445"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "7ea61577-80c5-41dc-ae51-410a05e04cfd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "f31189ae-7eaa-46cc-8911-7aef51aa734f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "9b1d2b8b-9982-42eb-9a21-92223da8cf28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "4a935023-6c58-43b8-9d96-9158eaa64d66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "0b42c05d-b4d7-4d26-8241-d7982a848bf2");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("8ae49961-aac3-430d-8746-bd61fd3b9728"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("fab5b11a-881c-4c1b-b3d4-30b6b2efd4c7"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("048e9410-4ffb-468f-b75c-5d118607ea5b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("05a2515c-f95c-4d86-bc07-7d02c9dd192b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("25588555-3d2f-4f2a-b8e7-c5dc985e2107"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2c9d301d-96a2-49e2-a88c-82de1a664499"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3a368fc6-d43d-4881-85ec-24c717a26618"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("42336222-a133-408b-bdfd-086a754c60b9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("426601e4-f1b5-40ce-bbda-ef58414ed182"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("465d0c7d-807a-41f1-aefd-7e703a5a17f6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("49581f5e-a344-4a67-9016-346a04475b58"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("585e6710-0c9e-4267-acb6-893e945fd0be"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("607ee92e-c930-49bc-b08a-d02e87342929"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("743f7050-cffc-4c7f-b509-74448386fefb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("850d1e84-4e36-4ca3-885f-f7d9c126eab2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("867ed94d-1b96-41d4-a6f8-08ec19c59fe0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a26d2fe1-6222-489a-96c8-d772d7d4d57d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("af2b87a1-ae55-4f5a-ad09-9323265f0315"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c8473e3e-61ff-492c-9595-9a9c206e748f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d4eac446-5083-4d29-8ecb-f9938aff49e3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("db7649ed-30be-4985-95da-6c48776296ad"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e5d31470-61ec-4026-ac7c-87f3c141f4f7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e937d69b-9540-4ca8-8b68-b0f4ebc72e65"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f360899d-cfc3-4ef8-85a4-f998caca81cb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f8931ad4-6141-4b53-ad63-9c08d95508a2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f8d7b3d4-fca8-411b-b372-064f288a9445"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8ae49961-aac3-430d-8746-bd61fd3b9728"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("fab5b11a-881c-4c1b-b3d4-30b6b2efd4c7"));

            migrationBuilder.DropColumn(
                name: "Reply",
                table: "RequestChangeMajor");

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
        }
    }
}
