using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGStudentProfileupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("0cb26f50-b8b9-4453-bb5c-124d3f54a3f2"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("1239dda9-8e76-4d34-8173-856296571ba1"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("22616d95-e5d1-4541-a6c1-6b4bcfeea572"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("6078ab31-524b-4648-8210-df385f495fc5"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("a725828c-09ba-44a4-8802-927c9a5da044"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("f1d591e1-4e63-40aa-829e-7f4e5375408e"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1a21bae9-6bca-4a82-8a34-251ea592a98e"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("63756a2c-1b47-481e-aa4f-0af08552b3f0"));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Note",
                table: "StudentProfile");

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[,]
                {
                    { new Guid("0cb26f50-b8b9-4453-bb5c-124d3f54a3f2"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2 },
                    { new Guid("1239dda9-8e76-4d34-8173-856296571ba1"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0 },
                    { new Guid("22616d95-e5d1-4541-a6c1-6b4bcfeea572"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1 },
                    { new Guid("6078ab31-524b-4648-8210-df385f495fc5"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2 },
                    { new Guid("a725828c-09ba-44a4-8802-927c9a5da044"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1 },
                    { new Guid("f1d591e1-4e63-40aa-829e-7f4e5375408e"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "689aeb56-2b8f-426f-955b-b65eddd0a9f4", "AQAAAAEAACcQAAAAEBu6+kymwYZdPmyfle2uHtm5da5PAsbM0XSNqakGSdN7E+meePR9Cz/Mb9RDn/am7Q==", "3d58308c-13ac-4136-93e4-098a392d289c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcf93b58-4287-45c6-93d6-5072f05dcbce", "AQAAAAEAACcQAAAAEPBhyPByGTkQpwpEZ/kX8jWXV0pHbF8VrRqV5Cp0ubvp/xmWdGbNmnzZIBL8jz1p7Q==", "d34e7d34-a848-4e1f-95b5-16a5dbf2f1e3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31aae94e-893a-40d5-a522-4e5856520b63", "AQAAAAEAACcQAAAAEHxyjqoUQDLeFvzky+XHSVGCam06s5xmtmn35am3VWio3jtv27CG++olHVGxr5sK1Q==", "4971ef1b-c580-4927-b287-3c3b6b630787" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0165c5f8-b1d9-4a69-bca1-145dcc05008b", "AQAAAAEAACcQAAAAEK25IKCKho5bGkIvZ6N1QpywVHO/imcWFOkPC1YQ5SZnzwfdOgGYhbiSmhYFvFSYqg==", "7fa65d6c-ad54-4d47-89ae-159635ef87d4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90612813-d29b-41b3-96a6-8dc1a51b4930", "AQAAAAEAACcQAAAAEKwecpNPBeNxyiuBSSOxBMMW8Rh0sVarD8+kW9XhYo9hkMEm1qt1c+UecfzSdXX/FA==", "99a817e7-990f-4cee-928d-950bff0a71f9" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "f5e618cb-f9e2-4e78-8fbe-4b972a935692");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "b8ab4db4-99d3-49cc-b5e2-d654dd5e5a4c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "03590bc2-9636-4198-aac5-e3dd3449f597");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "02aab197-e04b-463c-9b35-27b1df5316dd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "fbf8e310-fd6b-4d24-b388-dff6289653be");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("1a21bae9-6bca-4a82-8a34-251ea592a98e"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("63756a2c-1b47-481e-aa4f-0af08552b3f0"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1826), new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1828), new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1833), new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1834), new DateTime(2024, 10, 30, 17, 14, 15, 212, DateTimeKind.Local).AddTicks(1835) });
        }
    }
}
