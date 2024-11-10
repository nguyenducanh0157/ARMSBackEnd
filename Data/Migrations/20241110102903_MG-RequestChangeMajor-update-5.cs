using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajorupdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("126bac67-36b7-4965-ad69-7aca86c18e76"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("141f789b-aa22-4f14-b972-d3456ecae5b0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1c641bea-7b20-43ee-aee7-d7a0cb7bdd77"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1dd58d41-4130-4b57-8517-b7a97c2eb2e8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3b47cf01-04c9-40d3-bfcb-6b4d2a4fe854"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("458863e6-2f29-41e6-8e19-0458b6b34826"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("460ba87c-d3ed-43df-9b06-c7d908bc50dc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("56cb82a6-3c92-4cf9-ab12-c3f9c3c52ab2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5e48da43-3d06-4859-bfb1-c45bde8c7f34"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8334861e-4a0b-412f-920c-4a19e35ec399"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8bf2f990-d78c-446f-abfa-ee331c1fe49e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8ca5b73e-70a3-4a7c-917b-5c8b5d66aa74"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8cae36ca-d251-49d5-adfe-36beeb58e719"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9bebb193-d186-4fa0-a4f8-4fa7304e5019"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9db8b9a3-aa36-4f50-8fb6-bf05807d012b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("aea5d487-ba6f-4ff7-a171-57f01ab85fab"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b4cb854e-5e3a-41ae-bae4-58b6f19df071"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bd1ae070-2e4a-4ded-a263-746b858b47cc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c4b0620f-247d-41e9-91e4-3a351d35d3e0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d57a01da-c2b6-4b19-9da7-b5c744b384d0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d5f88473-39a0-43c6-9bf3-f1b6fc18a843"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dac97855-9a1d-41af-96b9-e134d5960c26"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f0996cee-ded4-4e50-8b59-0afd83f5be20"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f66f76a0-41fc-4f11-b4ba-3e8fb0e83c72"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("4c18691d-4415-4c5f-9d7a-cdec275453c2"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("95755f05-5f23-4f51-9f16-843e02b5cb68"));

            migrationBuilder.AlterColumn<string>(
                name: "MajorOld",
                table: "Request",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MajorNew",
                table: "Request",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dee2ce29-ea39-432c-9611-467188294814", "AQAAAAEAACcQAAAAEO8GDRnqGqjGH3XCPtm0kbuf+HzVNRXTo2kfG36niDPkAsReCyb6xbOAaQIkFpbBSw==", "8521a98d-a3bd-4a39-a568-bcc3bcb80df4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bc47080-1788-4d63-841a-8afe5daa903a", "AQAAAAEAACcQAAAAEKtH+JYILwmRgna3KjYzHiNufjO4pr1ePRMRYw2Hd531QnSQiehq+PUiVi3YMWm+Dg==", "f55ddcab-5188-4e18-bc04-7439c27f9562" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f4aadc9-2653-4d4d-a0d7-f56ec35d26ea", "AQAAAAEAACcQAAAAEOa3yrLrkUF4v3u6CkkkyYUGy6e/pPdkP5i1GuCcRSdNm7Q3Dxeb3lPmwS1US/mnww==", "d551d881-787f-4e80-a514-88358eb7fd7c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "966020ff-b8f3-4377-99a9-85f3c8c2fcde", "AQAAAAEAACcQAAAAEAWYNPnvP951tf757ERIFidTa/2j1cUo+uDgwejTUujEDIkm6FtgmA8jRqTXPAvTfw==", "cac04436-5842-4346-aaca-a11aeccaeb2b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "533cfea7-0fe5-4aae-b7f5-246aaf766fb3", "AQAAAAEAACcQAAAAEHpUgCRwzHO8DHvsHSH6aaqOJv0UxsPs8CtmRs6aMAIwzakd4uN7fSdRSaPIGx2VXA==", "76687afa-8ae6-46b4-a884-bc8cf295c458" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("01ffeaa7-9b07-42f5-ba2a-dc3777cdf2fd"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0dcad245-62c1-4da0-8873-c2392efa6d13"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("176c6363-2a48-4459-ac19-679cf8305adf"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1bad9c87-c899-405a-8e2e-8da09a538172"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("202115f4-17df-4afe-a44f-e87cdf58c7c4"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("214ebaa8-3931-4a21-a8f5-f0f337a58387"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("223a8cd6-a4cf-4684-838c-817963379c9d"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2a28b57e-9707-4861-950a-ece63fef345f"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2e92ee8e-0da7-4b63-a2a5-a5da5d2e6ef2"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("4348edc8-2eb1-4dce-9018-55bcdde72267"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("4a217dae-42f2-45ed-adb7-bdba994de305"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("52d7ee98-a784-4e0a-8a70-aea57cee26a4"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5f70c0fb-9ecf-4c06-8d75-fc32fb2bd8a4"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("657d8c09-2cbc-43be-87c2-aab1c3ea0a2f"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7baa4338-44ef-4c92-88fc-f1e7c40c03bd"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("83a311e5-6afa-4868-9e52-2b2f163ad303"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("913ec173-8038-48ac-bc41-2fc87786dc61"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b09084b0-cabe-4d43-9494-8b7a69650bd3"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bd8c9076-0c74-410b-96f4-95d7de445976"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c0cd88c8-b026-48f5-9994-bd59a194e08c"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("db8162d9-31b1-4cbd-9f08-90cb1fb32bb9"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f1284b39-3815-4525-a716-618eb086102c"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f23de93e-e156-46e6-8ac0-e1111c09a7fc"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("fd01eab4-4f74-4a40-9e40-7fa3e19bd62a"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 17, 29, 2, 599, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "0eaca778-7133-4d3a-8ae2-188498d1dd72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "07f50f28-c15c-45a0-ac1a-bac4a3668271");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e087e240-11a7-436f-a607-c62b5ba8b415");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "ffc0386b-6665-4d36-89fb-5248add92df2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "582cb584-11a7-49b5-98e2-de4296cfdf2b");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("a4fa37fd-9ccb-4645-9462-ab6f1263f26b"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("a566e01d-4527-4dd3-9988-e7e412ed7a74"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("01ffeaa7-9b07-42f5-ba2a-dc3777cdf2fd"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0dcad245-62c1-4da0-8873-c2392efa6d13"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("176c6363-2a48-4459-ac19-679cf8305adf"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1bad9c87-c899-405a-8e2e-8da09a538172"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("202115f4-17df-4afe-a44f-e87cdf58c7c4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("214ebaa8-3931-4a21-a8f5-f0f337a58387"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("223a8cd6-a4cf-4684-838c-817963379c9d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2a28b57e-9707-4861-950a-ece63fef345f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2e92ee8e-0da7-4b63-a2a5-a5da5d2e6ef2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("4348edc8-2eb1-4dce-9018-55bcdde72267"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("4a217dae-42f2-45ed-adb7-bdba994de305"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("52d7ee98-a784-4e0a-8a70-aea57cee26a4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5f70c0fb-9ecf-4c06-8d75-fc32fb2bd8a4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("657d8c09-2cbc-43be-87c2-aab1c3ea0a2f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7baa4338-44ef-4c92-88fc-f1e7c40c03bd"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("83a311e5-6afa-4868-9e52-2b2f163ad303"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("913ec173-8038-48ac-bc41-2fc87786dc61"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b09084b0-cabe-4d43-9494-8b7a69650bd3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bd8c9076-0c74-410b-96f4-95d7de445976"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c0cd88c8-b026-48f5-9994-bd59a194e08c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("db8162d9-31b1-4cbd-9f08-90cb1fb32bb9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f1284b39-3815-4525-a716-618eb086102c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f23de93e-e156-46e6-8ac0-e1111c09a7fc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("fd01eab4-4f74-4a40-9e40-7fa3e19bd62a"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a4fa37fd-9ccb-4645-9462-ab6f1263f26b"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a566e01d-4527-4dd3-9988-e7e412ed7a74"));

            migrationBuilder.AlterColumn<string>(
                name: "MajorOld",
                table: "Request",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MajorNew",
                table: "Request",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cf52b2a-e0a3-4939-9f1c-8e2ae2b4d7f0", "AQAAAAEAACcQAAAAEDNJVMs92cIrT3a43r5bYtFNuQ/s3GqhPwe5e/v41Ik92fR512Ss3cJTqyChC6fbHw==", "de43b098-952e-48e0-88b2-2f64b554b5fe" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea0c3bbf-b407-449a-8fd8-3e65b863f3c2", "AQAAAAEAACcQAAAAED+zWP6L1cHe5Oj/Sjm90i9EhRXdDeRqgLpFI69NH2ukY099FmicE7E6LPTtNbCqCg==", "9c29febb-7f0c-433f-b58f-57131ace5cec" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d976c567-3373-4815-b023-5c7434a8140a", "AQAAAAEAACcQAAAAEJGZCMvplUbZG1PsG9FjA8pfTgtopQstKirY8ET0YgetoTl6U4++FAO3xsoxLiPBfw==", "d5ce95d5-6fb4-4d35-a1f0-09177f5c525a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a44cd20-7b64-4f78-9fec-8462ea698f79", "AQAAAAEAACcQAAAAELHLHPACs+gRG4IzCCThssH1pSGEzNBAXZYikognmqgk1gzmePmNzXUHKhKv3AMGnw==", "6da57077-fada-4f6d-a0f7-932c7b90b39b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "170630f7-da57-47d1-ac9f-5d36b6f95a54", "AQAAAAEAACcQAAAAEHAZJv05o0JvrTGvc46nT0X1St+DUzvYn4Jqv4d0DneDrUOe9azOBd0l8Fg68c1+cw==", "74f83d01-568b-4a51-9e05-9b2774176e5f" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("126bac67-36b7-4965-ad69-7aca86c18e76"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("141f789b-aa22-4f14-b972-d3456ecae5b0"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1c641bea-7b20-43ee-aee7-d7a0cb7bdd77"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1dd58d41-4130-4b57-8517-b7a97c2eb2e8"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3b47cf01-04c9-40d3-bfcb-6b4d2a4fe854"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("458863e6-2f29-41e6-8e19-0458b6b34826"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("460ba87c-d3ed-43df-9b06-c7d908bc50dc"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("56cb82a6-3c92-4cf9-ab12-c3f9c3c52ab2"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5e48da43-3d06-4859-bfb1-c45bde8c7f34"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8334861e-4a0b-412f-920c-4a19e35ec399"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8bf2f990-d78c-446f-abfa-ee331c1fe49e"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8ca5b73e-70a3-4a7c-917b-5c8b5d66aa74"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8cae36ca-d251-49d5-adfe-36beeb58e719"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("9bebb193-d186-4fa0-a4f8-4fa7304e5019"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9db8b9a3-aa36-4f50-8fb6-bf05807d012b"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("aea5d487-ba6f-4ff7-a171-57f01ab85fab"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b4cb854e-5e3a-41ae-bae4-58b6f19df071"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bd1ae070-2e4a-4ded-a263-746b858b47cc"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c4b0620f-247d-41e9-91e4-3a351d35d3e0"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d57a01da-c2b6-4b19-9da7-b5c744b384d0"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d5f88473-39a0-43c6-9bf3-f1b6fc18a843"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dac97855-9a1d-41af-96b9-e134d5960c26"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f0996cee-ded4-4e50-8b59-0afd83f5be20"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f66f76a0-41fc-4f11-b4ba-3e8fb0e83c72"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "f96f4650-9036-4fde-a011-528b8a98551f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "f0dc8871-d5a6-4364-8e46-17493aeeadf4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "5535194d-1260-4a01-88d9-1e6da65916ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "b18ae560-565f-49cb-8cdc-4aad48248fda");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "6249c2d6-c5e3-4961-a22b-5fca51ff5b0b");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("4c18691d-4415-4c5f-9d7a-cdec275453c2"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("95755f05-5f23-4f51-9f16-843e02b5cb68"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
