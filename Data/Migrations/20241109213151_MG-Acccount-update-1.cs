using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAcccountupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "MajorId",
                table: "Account",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "MajorId", "PasswordHash", "SecurityStamp", "StudentCode" },
                values: new object[] { "a34ac3c7-31b6-477a-ba1f-7900dd7e581e", "HWE", "AQAAAAEAACcQAAAAEG/vYzaJV0YN7x3bLlQeKYU7BAFB/mrqmTRss55pT3Es9sIU5G1aoWzAi1Az8eAXog==", "af5265c6-88cb-4b7f-a010-2f61f3f5a579", "HWE160153" });

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
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 4, 31, 48, 530, DateTimeKind.Local).AddTicks(2308));

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
                name: "IX_Account_MajorId",
                table: "Account",
                column: "MajorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Major_MajorId",
                table: "Account",
                column: "MajorId",
                principalTable: "Major",
                principalColumn: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Major_MajorId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_MajorId",
                table: "Account");

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

            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "Account");

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
    }
}
