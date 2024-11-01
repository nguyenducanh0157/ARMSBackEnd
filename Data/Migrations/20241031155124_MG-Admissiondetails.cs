using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissiondetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionGroup");

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

            migrationBuilder.CreateTable(
                name: "AdmissionDetailForMajor",
                columns: table => new
                {
                    ADMId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalScoreAcademic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusScore = table.Column<bool>(type: "bit", nullable: false),
                    StatusScoreAcademic = table.Column<bool>(type: "bit", nullable: false),
                    SubjectGroup = table.Column<int>(type: "int", nullable: false),
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionDetailForMajor", x => x.ADMId);
                    table.ForeignKey(
                        name: "FK_AdmissionDetailForMajor_Major_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionDetailForMajor_MajorID",
                table: "AdmissionDetailForMajor",
                column: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionDetailForMajor");

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

            migrationBuilder.CreateTable(
                name: "AdmissionGroup",
                columns: table => new
                {
                    AdmissionGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusScore = table.Column<bool>(type: "bit", nullable: false),
                    StatusScoreAcademic = table.Column<bool>(type: "bit", nullable: false),
                    SubjectGroup = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalScoreAcademic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionGroup", x => x.AdmissionGroupId);
                    table.ForeignKey(
                        name: "FK_AdmissionGroup_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                });

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

            migrationBuilder.InsertData(
                table: "AdmissionGroup",
                columns: new[] { "AdmissionGroupId", "CampusId", "StatusScore", "StatusScoreAcademic", "SubjectGroup", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { 1, "Hanoi", true, true, 0, 24m, 24m, 2024 },
                    { 2, "Hanoi", true, true, 1, 24m, 24m, 2024 },
                    { 3, "Hanoi", true, true, 2, 24m, 24m, 2024 },
                    { 4, "Hanoi", true, true, 3, 24m, 24m, 2024 },
                    { 5, "Hanoi", true, true, 4, 24m, 24m, 2024 },
                    { 6, "Hanoi", true, true, 5, 24m, 24m, 2024 },
                    { 7, "Hanoi", true, true, 6, 24m, 24m, 2024 },
                    { 8, "Hanoi", true, true, 7, 24m, 24m, 2024 },
                    { 9, "Hanoi", true, true, 8, 24m, 24m, 2024 },
                    { 10, "Hanoi", true, true, 9, 24m, 24m, 2024 },
                    { 11, "Hanoi", true, true, 10, 24m, 24m, 2024 },
                    { 12, "Hanoi", true, true, 11, 24m, 24m, 2024 },
                    { 13, "Hanoi", true, true, 18, 24m, 24m, 2024 },
                    { 14, "Hanoi", true, true, 19, 24m, 24m, 2024 },
                    { 15, "Hanoi", true, true, 20, 24m, 24m, 2024 },
                    { 16, "Hanoi", true, true, 21, 24m, 24m, 2024 },
                    { 17, "Hanoi", true, true, 22, 24m, 24m, 2024 },
                    { 18, "Hanoi", true, true, 24, 24m, 24m, 2024 },
                    { 19, "Hanoi", true, true, 25, 24m, 24m, 2024 },
                    { 20, "Hanoi", true, true, 26, 24m, 24m, 2024 },
                    { 21, "Hanoi", true, true, 27, 24m, 24m, 2024 },
                    { 22, "Hanoi", true, true, 28, 24m, 24m, 2024 },
                    { 23, "Hanoi", true, true, 29, 24m, 24m, 2024 },
                    { 24, "Hanoi", true, true, 30, 24m, 24m, 2024 },
                    { 25, "Hanoi", true, true, 31, 24m, 24m, 2024 },
                    { 26, "Hanoi", true, true, 32, 24m, 24m, 2024 },
                    { 27, "Hanoi", true, true, 33, 24m, 24m, 2024 },
                    { 28, "Hanoi", true, true, 34, 24m, 24m, 2024 },
                    { 29, "Hanoi", true, true, 35, 24m, 24m, 2024 },
                    { 30, "Hanoi", true, true, 36, 24m, 24m, 2024 },
                    { 31, "Hanoi", true, true, 37, 24m, 24m, 2024 }
                });

            migrationBuilder.InsertData(
                table: "AdmissionGroup",
                columns: new[] { "AdmissionGroupId", "CampusId", "StatusScore", "StatusScoreAcademic", "SubjectGroup", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { 32, "Hanoi", true, true, 38, 24m, 24m, 2024 },
                    { 33, "Hanoi", true, true, 40, 24m, 24m, 2024 },
                    { 34, "Hanoi", true, true, 41, 24m, 24m, 2024 },
                    { 35, "Hanoi", true, true, 42, 24m, 24m, 2024 },
                    { 36, "Hanoi", true, true, 43, 24m, 24m, 2024 },
                    { 37, "Hanoi", true, true, 44, 24m, 24m, 2024 },
                    { 38, "Hanoi", true, true, 45, 24m, 24m, 2024 },
                    { 39, "Hanoi", true, true, 50, 24m, 24m, 2024 },
                    { 40, "Hanoi", true, true, 51, 24m, 24m, 2024 },
                    { 41, "Hanoi", true, true, 52, 24m, 24m, 2024 },
                    { 42, "Hanoi", true, true, 53, 24m, 24m, 2024 },
                    { 43, "Hanoi", true, true, 54, 24m, 24m, 2024 },
                    { 44, "Hanoi", true, true, 55, 24m, 24m, 2024 },
                    { 45, "Hanoi", true, true, 56, 24m, 24m, 2024 },
                    { 46, "Hanoi", true, true, 57, 24m, 24m, 2024 },
                    { 47, "Hanoi", true, true, 58, 24m, 24m, 2024 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionGroup_CampusId",
                table: "AdmissionGroup",
                column: "CampusId");
        }
    }
}
