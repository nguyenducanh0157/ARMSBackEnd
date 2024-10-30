using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGPayFee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("17dcd0fc-7c03-4b48-985f-ebc8c207bacd"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("5616f974-ef24-43dd-ae5d-01d67fc60760"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("75079555-a728-42a3-9d8e-5d8592dce42b"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("a3a418d3-b1f7-407c-b7c5-c8e5a44b643e"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("a67b3343-7af3-45f7-88c2-280b74440616"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("c20c30d5-1249-4865-bed6-a0133333d9ef"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("2efa31dc-b3bc-4fb9-8304-5b7d5b738cf6"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("eb36eb92-495e-4d27-a336-b139bae9dfad"));

            migrationBuilder.CreateTable(
                name: "PayFeeAdmission",
                columns: table => new
                {
                    TxnRef = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankTranNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TmnCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecureHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isFeeRegister = table.Column<bool>(type: "bit", nullable: false),
                    SpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayFeeAdmission", x => x.TxnRef);
                    table.ForeignKey(
                        name: "FK_PayFeeAdmission_StudentProfile_SpId",
                        column: x => x.SpId,
                        principalTable: "StudentProfile",
                        principalColumn: "SpId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PayFeeAdmission_SpId",
                table: "PayFeeAdmission",
                column: "SpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayFeeAdmission");

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

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[,]
                {
                    { new Guid("17dcd0fc-7c03-4b48-985f-ebc8c207bacd"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2 },
                    { new Guid("5616f974-ef24-43dd-ae5d-01d67fc60760"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0 },
                    { new Guid("75079555-a728-42a3-9d8e-5d8592dce42b"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1 },
                    { new Guid("a3a418d3-b1f7-407c-b7c5-c8e5a44b643e"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1 },
                    { new Guid("a67b3343-7af3-45f7-88c2-280b74440616"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2 },
                    { new Guid("c20c30d5-1249-4865-bed6-a0133333d9ef"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1872e60-3dd3-46c2-a092-6a1d7643dbf7", "AQAAAAEAACcQAAAAEF4OkqOKjCKZ26/yZ5sJ6P/CU5UP9wCeytGG8hGSx01lBH7ixdDJx6POZBTgSFLnBw==", "22a3f075-1c00-4315-948e-463b0f36a3b9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba426350-1ec4-4c73-838b-5447c495c6d7", "AQAAAAEAACcQAAAAEAhIdD9TSddliZkuuuVgFSefiA9DPxZYZlxj70yvQjka8mToHmoP6t3xKvHUebYeHA==", "b8e1ddd3-ae64-4046-b283-422e72516029" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8562a953-5fd6-4858-9ce8-283e6d68589a", "AQAAAAEAACcQAAAAEPvDJzlIfh7U4eaughd+N2wEBWkFVIN1vYtZxfCHgKMhRBmNAAkqpQyEWbZZB4fvxQ==", "cc6c4127-1f75-442e-969a-42445c4552c8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea09c4b4-330b-4551-bed5-58d3b505558e", "AQAAAAEAACcQAAAAEKYdEged4bJmBuApvjqUNMIzGo55zSfgz43KAS3YleZcCGJdz73/imRoMulvtrJa5A==", "807a6226-464c-40fc-82d2-7f1528b71e54" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35fe0019-57db-4927-99d6-f4d859c73366", "AQAAAAEAACcQAAAAEF55f2I0b0yxPm0oKYt3L6cC45OmlBdiiXNc/wjPvnBJ7iosSrggYxnEFvMtbi8vuQ==", "c0484e23-e771-423a-924f-6c6d2503297b" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "64e7d734-b990-4d0b-8dbf-1e9ddc829859");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "4ea8ecee-e127-4dd0-8297-9e08c58bad29");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d9f75ca7-3168-42db-872a-54ba4d0b8d48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "bf3dbfb0-d3b7-4c95-b920-d84bffe37aa8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "b77f6ca5-a5f7-4636-adb7-f1389fa13687");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("2efa31dc-b3bc-4fb9-8304-5b7d5b738cf6"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("eb36eb92-495e-4d27-a336-b139bae9dfad"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(816), new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 10, 30, 17, 44, 52, 118, DateTimeKind.Local).AddTicks(824) });
        }
    }
}
