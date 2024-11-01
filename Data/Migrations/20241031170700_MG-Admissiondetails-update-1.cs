using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissiondetailsupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("1bd2138d-eb4a-4b30-8ca7-c20165f6c29b"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("2c3c2f6a-5d26-4fd6-b76b-51845039ece4"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("78c3df5e-883c-46b2-8b88-5c62b115b5a6"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("cf983e8c-2242-48b7-a08b-6fce9956238a"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("d23c3ec0-ff0e-4663-b753-f4e4eed7b44a"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("d3613765-6d34-46e5-8482-cdbff50c1ad5"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("334d0c75-0390-490a-bd77-b8c069554440"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("772afc98-af99-48a6-b812-e365e0cf4071"));

            migrationBuilder.DropColumn(
                name: "SubjectGroup",
                table: "AdmissionDetailForMajor");

            migrationBuilder.AddColumn<string>(
                name: "SubjectGroupsJson",
                table: "AdmissionDetailForMajor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript", "isMajor1" },
                values: new object[,]
                {
                    { new Guid("03df4c6d-2741-4a78-b690-443edaab3d80"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1, false },
                    { new Guid("0c3d6393-d0ea-4418-a013-29aba4a4814d"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1, false },
                    { new Guid("2f91f561-6a8d-433b-9b1f-978617356836"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2, false },
                    { new Guid("5f4fc661-a2e8-451d-a271-3cce62924a5c"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0, false },
                    { new Guid("7d0a7c45-f584-460f-b24a-949fbd31595f"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2, false },
                    { new Guid("8504fb6a-9d16-4d9e-bf0f-6c7d31572ebc"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0, false }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "352ac0c4-e7ac-4536-a69c-fe571ea675e9", "AQAAAAEAACcQAAAAEOE+7uwRCDyY9hV9mvXX5zomvSvVoY9+Zq7E/dvlB1OsCWG+d/531n2NhXBTNXP8Kg==", "ae935c0c-ad13-439d-ac7e-455734a29b4d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c944f4-8e82-4415-a692-aed29c7cda4b", "AQAAAAEAACcQAAAAEA9liP8nWtUjrdxLYV+7fctvUgEwku2QidQV5GAjYywp1nuz8qMYZDJuAYh3D8WkHA==", "0b8242b7-c54a-402b-8d26-9b70c74e377e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63493dbe-2501-4468-8e29-9ba6d89f7502", "AQAAAAEAACcQAAAAEG2sOBDPTzcmL5/Td6Mn2jgxTi+MvrlUlQtfhJR6JnjxRxVBry1dtE/4sX1j+qcACQ==", "ac1a3d7d-744c-4c77-b196-b1bde242e863" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9c135b-0b01-40fa-983e-130a22277af2", "AQAAAAEAACcQAAAAEEJ3XDfnPhk11LvPVlKBeAm3O1BgApRkAfzEPo13Qh4+uG2S5eRHcafkc3mc1K4AlQ==", "57dc370f-b5b0-4433-9a8d-43e7a5378514" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d0bcd18-0c3b-4ee0-a110-95ba03763d39", "AQAAAAEAACcQAAAAEMQ+IPg2DEKFvo0xPviyeTJRPBkz7UENvkeqyk9/Gr01LBhuk7WNnx94+1rfqi3dnw==", "0e82217b-5ada-4e5e-babc-367afc7620c4" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "1240a3fb-f2a8-402c-9b44-f97128a535f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "f592f4b7-ea18-4321-b111-1bdeb413ed0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "2fa6d04e-1719-4761-8fb7-3fa5be2a543c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2ce36450-14e6-40b7-a4fd-910769c991dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "28f42224-1b31-4e30-bce0-9e367596dfb4");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("8e5be200-c4a8-40d5-8d46-6b09705151ff"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("dd2cc7db-813e-4eaa-829a-52b04c04c1b8"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9495), new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9499), new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9504), new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 11, 1, 0, 6, 59, 113, DateTimeKind.Local).AddTicks(9506) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("03df4c6d-2741-4a78-b690-443edaab3d80"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("0c3d6393-d0ea-4418-a013-29aba4a4814d"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("2f91f561-6a8d-433b-9b1f-978617356836"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("5f4fc661-a2e8-451d-a271-3cce62924a5c"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("7d0a7c45-f584-460f-b24a-949fbd31595f"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("8504fb6a-9d16-4d9e-bf0f-6c7d31572ebc"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8e5be200-c4a8-40d5-8d46-6b09705151ff"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("dd2cc7db-813e-4eaa-829a-52b04c04c1b8"));

            migrationBuilder.DropColumn(
                name: "SubjectGroupsJson",
                table: "AdmissionDetailForMajor");

            migrationBuilder.AddColumn<int>(
                name: "SubjectGroup",
                table: "AdmissionDetailForMajor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript", "isMajor1" },
                values: new object[,]
                {
                    { new Guid("1bd2138d-eb4a-4b30-8ca7-c20165f6c29b"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0, false },
                    { new Guid("2c3c2f6a-5d26-4fd6-b76b-51845039ece4"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2, false },
                    { new Guid("78c3df5e-883c-46b2-8b88-5c62b115b5a6"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2, false },
                    { new Guid("cf983e8c-2242-48b7-a08b-6fce9956238a"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0, false },
                    { new Guid("d23c3ec0-ff0e-4663-b753-f4e4eed7b44a"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1, false },
                    { new Guid("d3613765-6d34-46e5-8482-cdbff50c1ad5"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1, false }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5edd3e04-71d5-4d6b-900f-28c8d0979372", "AQAAAAEAACcQAAAAEB+oCubsprPpwKJ5vyaCUlXmqoaiqjrlWLuRW/WREzOpq+s4jVpJvD/Vz1BASwSdaQ==", "2fd4d072-5f76-41a8-a5d6-273faa72f4ed" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b935024-2101-4e6f-a328-bd741b1399d6", "AQAAAAEAACcQAAAAEMuQ494Wju7XanynYiL5nVmfo4m42z6z6wLrvC0FhuPlz77vBCimo9xMrChvP8xC8A==", "864b2158-b883-4167-ae21-31dc83ac2e68" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "288b4bce-03bd-48ad-847e-7254fd086db6", "AQAAAAEAACcQAAAAEC0LvAcSRK/1coE40Do0LEnZGibjjAysKBqKk5V14i9Dfsv4BbLKvG6+Rhri+Q0w8w==", "0657fa25-10f0-49a7-8c5f-3ecc7c588950" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5571a704-55e1-4a21-b5e3-5088a0d3c038", "AQAAAAEAACcQAAAAEGQK52aLJU+duNoWBN+nLtiq6ksjFfxzFmI+3TOtJdunqifZzga44jcne0gmqEgpoA==", "cdee19d3-da2c-43b9-b8b7-0d911735fcb1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0898f5f7-c4ef-433f-a3db-20b534d9c1dc", "AQAAAAEAACcQAAAAEOfQgnHyixlSFbpmTNNWZyfidjpZG3sYe0uRzk6L+AmY3aJECeZOE6CsfpaQQsFRUw==", "3ec704be-563e-4a3c-ae5c-8e41877c9dfe" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "ead8c81b-ca37-4b97-bdb1-5563c000c6a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "cab873ba-cd89-4397-b03d-aab7f45f279d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "cc340243-3a32-45a2-9462-ab7b0d4264db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2f1fc134-c582-4a3a-97ba-02140bf21cf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "9b015b12-b61a-402e-abd4-70b09719ed4f");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("334d0c75-0390-490a-bd77-b8c069554440"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("772afc98-af99-48a6-b812-e365e0cf4071"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8833), new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8838), new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 10, 31, 22, 51, 23, 13, DateTimeKind.Local).AddTicks(8840) });
        }
    }
}
