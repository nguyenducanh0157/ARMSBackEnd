using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajorupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestChangeMajor_Major_MajorNew",
                table: "RequestChangeMajor");

            migrationBuilder.DropIndex(
                name: "IX_RequestChangeMajor_MajorNew",
                table: "RequestChangeMajor");

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("025f22ee-1ef2-4f1a-9acd-d4e3846f4d8b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("141b49ce-d0bc-4dad-a168-af00796707fe"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1b78641c-bd31-44cc-b4c4-a3d0a34a500d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1c9f162b-f641-4f8a-90e3-eef4292ac796"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("394ff38b-855a-4d0d-ba7d-e6033c86edb6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("4f182a6f-129f-49af-a4f4-816ecef5d6c3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("57c710e9-e9cf-4449-b3b9-c923c9b0ea5a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("613302b6-d5e5-40db-8bce-086f779374a1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("696c868e-e21b-4cd7-9102-36eda5e09b0f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("71bd3fa1-0ea2-49db-b0b0-b2fb934d0a20"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7c0f5293-3dbe-47a0-b39f-34e3b30536a5"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("85377867-1cbd-4ee6-88a7-7143891cdba8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8c7b5ab7-dd74-449a-a8ae-d6ae762f9c19"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8cb24a81-8b60-4974-81b1-ee7e3550a4ff"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a70d9e6d-47fd-4b75-8930-eaf4a142581e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a98eaf44-2790-428c-990d-0f909ba56431"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b8defa7f-3498-404d-b180-ffe811e0ad43"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bb72051f-651a-4e51-b03a-c17516c21433"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d7e03a0a-931e-404e-9995-8e43dbec0843"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("da6d0b3e-5833-4315-a16a-4ea543680751"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e16baa4a-1685-488a-a983-90f242af8346"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e8adfa90-4e86-4c91-8371-56d55cc119c4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e9ca0b50-d458-4d21-b0bb-d1de9b047c93"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f6c57f98-18fe-4dde-b340-d5a918aca56c"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("3fa05d1e-4c2a-4c45-bf2d-a808e7e18dff"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8057e478-493b-459c-95b9-bec184556d43"));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "RequestChangeMajor",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "MajorNew",
                table: "RequestChangeMajor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "MajorOld",
                table: "RequestChangeMajor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "DateRequest", "MajorOld", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5690), "HAO", 2 });

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                columns: new[] { "DateRequest", "MajorOld", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 7, 29, 58, 285, DateTimeKind.Local).AddTicks(5693), "HAO", 2 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "MajorOld",
                table: "RequestChangeMajor");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "RequestChangeMajor",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                values: new object[] { "3d572433-9698-4a3c-8dab-bee0bd2d15d5", "AQAAAAEAACcQAAAAEHhCLwWjnEEVASCNvgtzeyyxo6cnb7qQe5GQuSp+zTrhNKQOGpyrEZO50wioPjap+w==", "46c51115-69ee-4a85-bba4-aabbccaca244" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a34ac3c7-31b6-477a-ba1f-7900dd7e581e", "AQAAAAEAACcQAAAAEG/vYzaJV0YN7x3bLlQeKYU7BAFB/mrqmTRss55pT3Es9sIU5G1aoWzAi1Az8eAXog==", "af5265c6-88cb-4b7f-a010-2f61f3f5a579" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "063aba73-5118-42fd-95bd-ba5f6f6688c6", "AQAAAAEAACcQAAAAELJL+3jnx+skNrk+o335Dpbw8e3oLaqTYq8YAIzb/o5R38LCmAwuW7yPv3Edf3/k8g==", "243ad656-fc66-41b4-ac9b-73a14522356e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a74cddd4-7b81-4675-8d3a-a541db8260a5", "AQAAAAEAACcQAAAAEHb6B4MZmnOqYLL/8EHLaFsZN4SsvRrYRqmvfaqekZtLzhIAmMdl0Z7dh7EgqLk0uw==", "990833ec-2194-4d5f-b171-877c01dfdec3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f3840d-9176-4f2a-af9f-7025a96865d7", "AQAAAAEAACcQAAAAEFoppInquVVsSWIJ4x+1FHYl39GQPyzQr+eA5m3QM0WtJjpkGawu59b4ayOHcpzueg==", "ac537240-7200-4f17-88da-43685150799b" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("025f22ee-1ef2-4f1a-9acd-d4e3846f4d8b"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("141b49ce-d0bc-4dad-a168-af00796707fe"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1b78641c-bd31-44cc-b4c4-a3d0a34a500d"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1c9f162b-f641-4f8a-90e3-eef4292ac796"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("394ff38b-855a-4d0d-ba7d-e6033c86edb6"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("4f182a6f-129f-49af-a4f4-816ecef5d6c3"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("57c710e9-e9cf-4449-b3b9-c923c9b0ea5a"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("613302b6-d5e5-40db-8bce-086f779374a1"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("696c868e-e21b-4cd7-9102-36eda5e09b0f"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("71bd3fa1-0ea2-49db-b0b0-b2fb934d0a20"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7c0f5293-3dbe-47a0-b39f-34e3b30536a5"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("85377867-1cbd-4ee6-88a7-7143891cdba8"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("8c7b5ab7-dd74-449a-a8ae-d6ae762f9c19"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8cb24a81-8b60-4974-81b1-ee7e3550a4ff"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a70d9e6d-47fd-4b75-8930-eaf4a142581e"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a98eaf44-2790-428c-990d-0f909ba56431"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b8defa7f-3498-404d-b180-ffe811e0ad43"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bb72051f-651a-4e51-b03a-c17516c21433"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d7e03a0a-931e-404e-9995-8e43dbec0843"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("da6d0b3e-5833-4315-a16a-4ea543680751"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e16baa4a-1685-488a-a983-90f242af8346"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e8adfa90-4e86-4c91-8371-56d55cc119c4"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e9ca0b50-d458-4d21-b0bb-d1de9b047c93"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f6c57f98-18fe-4dde-b340-d5a918aca56c"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                columns: new[] { "DateRequest", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2303), false });

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                columns: new[] { "DateRequest", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2308), false });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "e7aaec4a-6154-48ab-ab8c-62e457b64ca6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "7e0e1023-36c0-48f8-a5d4-355809c9733d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "ba87d893-7ff8-4098-8fa6-cb2550165807");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "6b83b474-a61f-41be-9339-fe278e1e4267");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "6c85d312-d4ec-4d0a-b5fd-16269cbf1aeb");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("3fa05d1e-4c2a-4c45-bf2d-a808e7e18dff"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("8057e478-493b-459c-95b9-bec184556d43"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_MajorNew",
                table: "RequestChangeMajor",
                column: "MajorNew");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestChangeMajor_Major_MajorNew",
                table: "RequestChangeMajor",
                column: "MajorNew",
                principalTable: "Major",
                principalColumn: "MajorID");
        }
    }
}
