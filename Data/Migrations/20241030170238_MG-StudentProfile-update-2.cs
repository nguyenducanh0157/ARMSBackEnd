using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGStudentProfileupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicTranscript_StudentProfile_SpId",
                table: "AcademicTranscript");

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("0faf37af-9d45-4e59-b916-753f4b4bb10f"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("26e3453a-b513-4168-a905-ba2ea6ed49c7"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("74ce332b-890d-44ac-a517-7a26829e714c"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("91df776a-75c4-4f87-9912-4209a3c24f3c"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("a6a51aba-1df1-456c-ac4b-770b721ad172"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("d6cc64ce-58ea-4bbf-85b0-b4416bc6c7dc"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("41191147-419f-41e0-b907-c28dbfa0bd4a"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("b10a0692-4a7a-4b3c-acd9-e7fe7b2468aa"));

            migrationBuilder.AlterColumn<bool>(
                name: "isFeeRegister",
                table: "PayFeeAdmission",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "Success",
                table: "PayFeeAdmission",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isMajor1",
                table: "AcademicTranscript",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript", "isMajor1" },
                values: new object[,]
                {
                    { new Guid("33e2e824-e475-42c1-a099-faec49cb7814"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0, false },
                    { new Guid("394a8ae3-85aa-4bca-8aee-39e1a0b1c0fa"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2, false },
                    { new Guid("4e969aec-4a77-43c0-bcf6-b7db9ff331f6"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0, false },
                    { new Guid("e10d2613-d3c4-46b5-a5c0-6b351c5b6273"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2, false },
                    { new Guid("ebbf62e3-f1f4-4017-a8a1-1119baa51eb1"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1, false },
                    { new Guid("ee70ee0d-afa2-4cdd-b1f2-d9494310ce6c"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1, false }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09778b97-4876-4ab7-bd8c-37ed1ede3760", "AQAAAAEAACcQAAAAEA+e5gOigyvZueCyS8GbTXrTWzk7Ew7DmZA92lePlIaMok5Gi+JNNfAf5hp60Du/1A==", "16bcd91d-c277-4291-b6f4-35139cff29a4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "270559a9-ca14-4a55-89f8-5b084f58f8a4", "AQAAAAEAACcQAAAAENolODoP2prrj7vGAVWKSZc48MHASO4zFXseQfa/y8mdtoX8kU1AXxh9Wmk4YKAgwQ==", "eca23981-d78f-4858-805e-07b1127c2a52" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36760477-1bee-4fa1-af17-c93754ad1ddf", "AQAAAAEAACcQAAAAEFKgVmie/XkZ6uvunPBxljGSCQKClh11wv3Wurjun4vVRVg+wMx1XDlAyqNEvKvGfw==", "e4e8b871-4efe-4629-b786-8e29beeba4e9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6277102-df91-49e4-8814-cc23a0096e4f", "AQAAAAEAACcQAAAAEE3qQp2oYYJTGm61Q+3Lea/ClynYdhJ1SRWyihtWdP5YLOBfkRvKzwOAh9IZQ/2RCQ==", "e409c44e-c0b5-4813-bc8e-f4ee20339ef1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bc04b04-f45a-46d4-9b18-fb64ff6fa0f4", "AQAAAAEAACcQAAAAENtUHpsyy6QPr0/N1jsquDtJ0+u7+v69tq3JqNAGYWHBjvmewoEyBk48HGRU3nMBPQ==", "c5ad0287-d1ed-45d1-b2d0-44b71b555b29" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "77ffa1f2-bbda-419d-81e7-dfd6bfac6995");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "f233add9-4df0-4a72-9af6-5795a3e4582b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "a1590b67-8b65-49f6-81c8-84e891450978");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "96d5027f-75a1-4309-8d10-83e455e2243d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "5abf5f52-4695-4869-b8ca-85fd3ae6a484");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("46d1e475-9c18-4e7f-a1c6-763e471ca6b7"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("bc4846d1-f9c8-44e9-9456-c1bc81d9cc8c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1451), new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1456), new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1464), new DateTime(2024, 10, 31, 0, 2, 36, 9, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicTranscript_StudentProfile_SpId",
                table: "AcademicTranscript",
                column: "SpId",
                principalTable: "StudentProfile",
                principalColumn: "SpId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicTranscript_StudentProfile_SpId",
                table: "AcademicTranscript");

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("33e2e824-e475-42c1-a099-faec49cb7814"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("394a8ae3-85aa-4bca-8aee-39e1a0b1c0fa"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("4e969aec-4a77-43c0-bcf6-b7db9ff331f6"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("e10d2613-d3c4-46b5-a5c0-6b351c5b6273"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("ebbf62e3-f1f4-4017-a8a1-1119baa51eb1"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("ee70ee0d-afa2-4cdd-b1f2-d9494310ce6c"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("46d1e475-9c18-4e7f-a1c6-763e471ca6b7"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("bc4846d1-f9c8-44e9-9456-c1bc81d9cc8c"));

            migrationBuilder.DropColumn(
                name: "Success",
                table: "PayFeeAdmission");

            migrationBuilder.DropColumn(
                name: "isMajor1",
                table: "AcademicTranscript");

            migrationBuilder.AlterColumn<bool>(
                name: "isFeeRegister",
                table: "PayFeeAdmission",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[,]
                {
                    { new Guid("0faf37af-9d45-4e59-b916-753f4b4bb10f"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2 },
                    { new Guid("26e3453a-b513-4168-a905-ba2ea6ed49c7"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1 },
                    { new Guid("74ce332b-890d-44ac-a517-7a26829e714c"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2 },
                    { new Guid("91df776a-75c4-4f87-9912-4209a3c24f3c"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1 },
                    { new Guid("a6a51aba-1df1-456c-ac4b-770b721ad172"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0 },
                    { new Guid("d6cc64ce-58ea-4bbf-85b0-b4416bc6c7dc"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "826ec15b-ab8f-4781-aba4-4ac765f69df4", "AQAAAAEAACcQAAAAEGBRnM2IQmC+dYHXr7pNLbgIIWBnhN0yLAwMQOR7sTnh5tE2wS4toOaKeFPW4lalIQ==", "bf81328d-49bc-4afd-b91c-a9ee55a32058" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae6c2cec-e931-4d78-89f4-1fdb5d24b5f4", "AQAAAAEAACcQAAAAEJQT+Wt6TU9+KI8ZRYKs4uo38Iy1wKXQuKCxMOsLXClPnjJ/DmgXaOmC3UfXU9CGRA==", "173dccae-a285-4d9e-965e-12dcfddd6955" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f993342f-ac57-4925-8750-71ab18c07b94", "AQAAAAEAACcQAAAAEGSViKMp45ntRth7BJrjvDru66Zc+mOuji8TTXuCu0XfA9t/7INiS4MTnP0BtudRdw==", "09fac44b-297f-4690-822c-70d30eabcf0d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f22f565-2dc6-4bec-9e46-3026c648ded2", "AQAAAAEAACcQAAAAEJqP9GFfvMxJTIica0qsp16nslzdN/ErPkSub7IZmWyoAq4XQ6AbZdGdammKRxDGBA==", "1bf5e0d8-6521-4847-af67-dfb424f2fa17" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "920c78f3-8356-4312-964a-ceb035c59f05", "AQAAAAEAACcQAAAAEKJd6tY8oenuHOJcFnMPET4WSZZ6YBriqLVkxS6rMSp6gfNtSdchuMpKtvzAkyS6Iw==", "c56805a3-0556-41a3-8aea-e999a66623de" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "a9784780-65b4-48b6-a418-c74885d3a9d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "471ef44c-3e6a-43b9-a786-7e95b9dd9ea5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "79918ecd-f306-4a73-bd8b-7bc6f5517c18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "f420aa2a-242e-42ee-b019-d2ca3f3144e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "203f2b40-640c-4988-934a-816c4f50dbe5");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("41191147-419f-41e0-b907-c28dbfa0bd4a"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("b10a0692-4a7a-4b3c-acd9-e7fe7b2468aa"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5468), new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5473), new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 10, 30, 22, 47, 57, 681, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicTranscript_StudentProfile_SpId",
                table: "AcademicTranscript",
                column: "SpId",
                principalTable: "StudentProfile",
                principalColumn: "SpId");
        }
    }
}
