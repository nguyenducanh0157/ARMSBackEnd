using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGStudentProfleupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "TypeofStatus",
                table: "StudentProfile",
                newName: "TypeofStatusProfile");

            migrationBuilder.AddColumn<int>(
                name: "TypeofStatusMajor1",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeofStatusMajor2",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab00009b-0689-4cbe-96b1-6663b39da00f", "AQAAAAEAACcQAAAAEOvddd6Al4yw1rHQomZX1QMO1L5NVNKzAlm1DU375ljAPCGnXD51p7/2s6bgXIkM1w==", "ce9d8345-2ea7-4743-b61d-1bc16379f02e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0193b291-ed89-45e6-9697-67c1c469d9a2", "AQAAAAEAACcQAAAAEJ+esqhp5GG0UL0bEYUtEeFBancEyyZJkC5AlUAA8b7TzGpWrIaTmE1L+yOhNouwFw==", "9040af85-bb1f-4f3d-b23e-0858da28e1f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbae08ae-1943-4f8b-9d3f-7c27e7bbfba7", "AQAAAAEAACcQAAAAEIS9k8BWkfrwCJ6MFA2XIud+Thg5CwsciwYcGMTcH9ZlgGz9r/pJv4kaNE9LjoXlvQ==", "b8aafb01-422c-44b4-844a-da447dd29a08" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8317315-7a75-40b8-9150-d68a6184415a", "AQAAAAEAACcQAAAAEHYNIXDE69bvwTOOV/5AnPEInPfRAdZmQEtQdo72b8TkInL/eEIiras8QcZzweDI0A==", "237cde95-54c9-4c60-914f-8517727984ba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cfcaaa2-7ba7-4ddc-b050-ae1330d097f0", "AQAAAAEAACcQAAAAEGGP5VrLGKAQFch/LU6k6XDcImIUhky8U7fB+ZGUhjAlNBZJVjfrmHcNQXPjRQ5bbg==", "cfedd439-985c-410f-8e9c-f5f51963b587" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("0ea7e6e0-795e-4f03-9515-1826ba82081c"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("232d8811-4967-4205-ba93-43fa11f7c330"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3ee8a752-5dc1-4c72-9c3a-4ae08c8028c6"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("4534c1dc-af42-46e7-8508-dd1320f45da6"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("483d4cf6-9f97-4b60-b459-1dc03a039208"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("4e8b510f-b40c-45af-b17e-cd2ae2639c83"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("530b0ce4-a890-4a11-aaca-7ece117c8eab"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("55587a08-cf19-493a-a870-31c696f37c06"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5c12db96-5d62-4e25-837a-c18f68bc2d48"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5d8cb7b2-9872-499e-a446-7ea92f3bf0a7"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("67ed8221-262a-4c48-9951-3384c560b7be"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("72bc70e4-641c-4aa3-8eba-78b265a1edc8"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7a8047a4-1f20-4801-8481-261fc17567e0"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8c506cf8-9a4b-43a7-93ed-d161072644b1"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8e126599-a881-4b00-a9c7-063fa78a4419"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("92029e1a-bbb7-46bc-b116-6283973a0436"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9b5a2c63-1d34-47aa-bd7e-250965d8a6b2"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("a2f33cc4-d59d-45c6-87f3-6b89ff0eb4ef"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b5cb301d-15ac-42e6-a693-292eb444c526"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b8e1c0f9-cc5e-4fdf-9c94-9cf7ec8b8364"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("baadb1fc-2c2c-4eb5-a73a-1f6a23e645fc"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cd6d5a1b-e475-4fbd-8870-f92fb5f16c75"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d7e17d02-9471-45b9-802b-f86cc5eaf8e3"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dddb3e1a-5873-4435-b894-531dc1ea6da9"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 2, 23, 0, 54, 924, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "3754de25-57fb-4dbc-a441-ffbf0823f0c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "81411822-0be5-46f8-b388-55b96277ef04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d214b45d-83dc-4581-8ae7-c693d88ce46a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "7e5b139b-1837-4717-872b-6097c5fe126b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "b2c40029-06c2-4c24-b671-858c8977af6b");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("24e8a4d4-eae7-4f67-a8d3-9f928aafdc4b"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("94523a49-0f48-4653-a650-9581eb67c7a0"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0ea7e6e0-795e-4f03-9515-1826ba82081c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("232d8811-4967-4205-ba93-43fa11f7c330"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3ee8a752-5dc1-4c72-9c3a-4ae08c8028c6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("4534c1dc-af42-46e7-8508-dd1320f45da6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("483d4cf6-9f97-4b60-b459-1dc03a039208"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("4e8b510f-b40c-45af-b17e-cd2ae2639c83"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("530b0ce4-a890-4a11-aaca-7ece117c8eab"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("55587a08-cf19-493a-a870-31c696f37c06"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5c12db96-5d62-4e25-837a-c18f68bc2d48"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5d8cb7b2-9872-499e-a446-7ea92f3bf0a7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("67ed8221-262a-4c48-9951-3384c560b7be"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("72bc70e4-641c-4aa3-8eba-78b265a1edc8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7a8047a4-1f20-4801-8481-261fc17567e0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8c506cf8-9a4b-43a7-93ed-d161072644b1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8e126599-a881-4b00-a9c7-063fa78a4419"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("92029e1a-bbb7-46bc-b116-6283973a0436"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9b5a2c63-1d34-47aa-bd7e-250965d8a6b2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a2f33cc4-d59d-45c6-87f3-6b89ff0eb4ef"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b5cb301d-15ac-42e6-a693-292eb444c526"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b8e1c0f9-cc5e-4fdf-9c94-9cf7ec8b8364"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("baadb1fc-2c2c-4eb5-a73a-1f6a23e645fc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cd6d5a1b-e475-4fbd-8870-f92fb5f16c75"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d7e17d02-9471-45b9-802b-f86cc5eaf8e3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dddb3e1a-5873-4435-b894-531dc1ea6da9"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("24e8a4d4-eae7-4f67-a8d3-9f928aafdc4b"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("94523a49-0f48-4653-a650-9581eb67c7a0"));

            migrationBuilder.DropColumn(
                name: "TypeofStatusMajor1",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "TypeofStatusMajor2",
                table: "StudentProfile");

            migrationBuilder.RenameColumn(
                name: "TypeofStatusProfile",
                table: "StudentProfile",
                newName: "TypeofStatus");

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
    }
}
