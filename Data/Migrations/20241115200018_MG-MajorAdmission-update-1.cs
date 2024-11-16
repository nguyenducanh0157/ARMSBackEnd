using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGMajorAdmissionupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("13b6e191-cff1-44cb-96df-ed311f23a083"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3516a1e1-7f36-42c1-84df-3a1f32a123e2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3c637b85-93b9-4b41-9246-ee4731e3bb4a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("4035e90f-da41-437f-b43b-4991de99ef59"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("42213182-76ff-4b9f-bbfd-899d210bbaf3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("42f9c58a-d63c-4460-a1a3-3798d9622897"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5da7b723-3e7e-4c4a-a34a-f9c50e03a136"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("71737a91-2339-40c4-987f-9ffd1951ba8d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7e3be7f4-7ef3-4cf1-a578-d364615cfd9b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("82769faa-f4d9-477c-8256-80b77fd7f672"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("87bf1e4c-1715-47c9-ae8e-b192c423fa99"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8ab5528b-de85-401f-b2bc-125d30608d6a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8aeccf0b-847d-40ed-88db-d67e6ef75db1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("94814fcd-295d-477c-8dc2-572efcea32a8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a1d1a52d-505b-4680-974f-4e13beb333f2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a48c706b-b3cf-4758-930d-057841fd2792"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("aaaf47fd-396e-480c-a0b3-7485f9a6bced"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("aaee54ce-2325-4e79-87f7-4f4a6112256a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c5463e60-fdf0-4a44-bb45-aa3c410df516"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c829b2f4-9230-447d-b4e7-edfc23dd7667"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cd0d92f5-a5ed-40cd-b645-1534b95a01c8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d8a529fc-5d79-41c5-baf9-9722639374e6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f5f88d06-0760-4d0f-a744-c0037bfed7f6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f6bf1785-96e2-449e-8a79-b7996d06c90b"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("28f4b6cb-b7bc-42c6-b0d3-1027ef68a38e"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("745afc82-539a-4599-a099-7e7a10252853"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea3a09fa-c941-47bc-9ed6-ea292c9b8a40", "AQAAAAEAACcQAAAAEG/heEi/Go8BEWutGgaeXXpNGKORyYLH6QpW22Bk9kRALFsG1EUCvTBj+E+37EnWEw==", "c98baaa7-b1ba-44f3-a28d-7b369ab9867b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bba4de76-a4b8-4dd0-b71c-af4464f8df4c", "AQAAAAEAACcQAAAAEA0gDnPauzMunoSOVpp3B7zgPqq2mOqZq+qhV9Wwwn2R+AzZEi1OIFUD7zW2eRs/Dg==", "61af256e-8280-42c5-b41a-847fd7925bc7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c31ca51-23b0-4a47-a48f-fa24956f891b", "AQAAAAEAACcQAAAAEAa8ldkjVra2mUMyCmUMXs1vAKbsHqkhBx3LHVkjEpP1Gb8Inh9f2A+25AsJH+s2XA==", "5b8ee33c-9bfa-4fb4-a3b7-cd8ba24fb1ce" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c7505a9-28f3-4b7a-b1aa-e5eba48dd558", "AQAAAAEAACcQAAAAEOOcPtzId05irqOt6Ehj5OHF9xt/pjpDglkJt1kXNXdwkykYgqpnXEmugVGGcd8q9g==", "9349c5e1-715c-41f5-8b04-c86f3da404cb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "162beaec-f4d2-4dd3-8599-f49122ab31ce", "AQAAAAEAACcQAAAAEFxZ67lzcolwKm765yr0AISs+0WJXLo+enqMFKtW6KzD11O6ewcIOUiT2m9OnUb39A==", "b79eecee-9f78-4d4c-80f7-94a5d2d651da" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("1500abdc-e465-42fd-951f-dfb0098b3782"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1a1f1a62-d60f-49c0-be7d-b4fd87d791d4"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("245f6abd-466e-42ab-8123-7593c709ee44"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2d906746-edff-4f63-a06b-4516d46f2afa"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2e88c9f2-a435-48c3-af0d-749e39ae44e0"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2e892c02-89c5-4ceb-8ce2-c40676e1b867"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("30de15a9-3a07-4db0-8d29-5ff85b04d67c"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5258b7e0-72c4-45e8-bf90-bcaa66536a6c"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("838dd4e7-a982-46b8-82b1-573a58227767"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("90ddbfe5-b20a-4398-b4b3-6c5df0086082"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9e1d1827-75b0-47f9-8910-9ae5353e6548"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a4b307f6-37ed-4970-b399-dce4bfa02df2"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ab63fbfb-6bf9-4ace-a276-7ba7e751e8f2"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("b523fbd5-f16d-4933-8d17-3dcc85e8e560"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bb2dce83-3c2c-4d3e-9c71-5aecba2763af"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bbc2a567-18db-46a7-84f4-d00f3c132fda"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cfdb783e-91da-4933-8224-9e42a0919cb4"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e4d33c72-670e-4fa4-a9ac-805f474f3950"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("eb136806-9038-4bd2-9eb2-15c8a9f71b23"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f493cebb-6527-4f7f-957c-d1e6b76f8cc8"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f649410b-30bb-447b-a6e9-2c1021e0f676"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f961ad8e-7a8d-4e30-adb0-ca244c046eb5"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("fee30073-6f35-4b7b-a793-0348cbca2c6f"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ff1b54f6-8df9-4d91-bf67-8f0e1349b2f1"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "d0ee176c-e979-4700-9cb8-79919697262f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "de3d0662-d216-46d7-b036-3bd028b4aced");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e9a56bf6-8bf3-4d9c-a061-cfbc6c39bcf8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "0a8df5eb-7cba-4a45-85ff-f61c5e644ef5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "b27c1ad6-35d6-4ef0-9d38-40b25abb639d");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("14e0d94b-b46d-4455-93de-f0cead112165"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("5c0df781-226a-45b4-b115-56e1d54329ee"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8804), new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8806), new DateTime(2024, 11, 16, 3, 0, 16, 440, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 1, "HEA", 1, null },
                    { 1, "HEA", 2, null },
                    { 1, "HGE", 1, null },
                    { 1, "HGE", 2, null },
                    { 1, "HTE", 1, null },
                    { 1, "HTE", 2, null },
                    { 1, "HTE", 3, 1 },
                    { 1, "HWE", 1, null },
                    { 1, "HWE", 2, null },
                    { 1, "HWE", 3, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1500abdc-e465-42fd-951f-dfb0098b3782"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1a1f1a62-d60f-49c0-be7d-b4fd87d791d4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("245f6abd-466e-42ab-8123-7593c709ee44"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2d906746-edff-4f63-a06b-4516d46f2afa"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2e88c9f2-a435-48c3-af0d-749e39ae44e0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2e892c02-89c5-4ceb-8ce2-c40676e1b867"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("30de15a9-3a07-4db0-8d29-5ff85b04d67c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5258b7e0-72c4-45e8-bf90-bcaa66536a6c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("838dd4e7-a982-46b8-82b1-573a58227767"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("90ddbfe5-b20a-4398-b4b3-6c5df0086082"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9e1d1827-75b0-47f9-8910-9ae5353e6548"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a4b307f6-37ed-4970-b399-dce4bfa02df2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ab63fbfb-6bf9-4ace-a276-7ba7e751e8f2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b523fbd5-f16d-4933-8d17-3dcc85e8e560"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bb2dce83-3c2c-4d3e-9c71-5aecba2763af"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bbc2a567-18db-46a7-84f4-d00f3c132fda"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cfdb783e-91da-4933-8224-9e42a0919cb4"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e4d33c72-670e-4fa4-a9ac-805f474f3950"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("eb136806-9038-4bd2-9eb2-15c8a9f71b23"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f493cebb-6527-4f7f-957c-d1e6b76f8cc8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f649410b-30bb-447b-a6e9-2c1021e0f676"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f961ad8e-7a8d-4e30-adb0-ca244c046eb5"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("fee30073-6f35-4b7b-a793-0348cbca2c6f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ff1b54f6-8df9-4d91-bf67-8f0e1349b2f1"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("14e0d94b-b46d-4455-93de-f0cead112165"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("5c0df781-226a-45b4-b115-56e1d54329ee"));

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HEA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HEA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HGE", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HGE", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HTE", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HTE", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HTE", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HWE", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HWE", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HWE", 3 });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32df6f81-b47d-4fcf-a511-a42514e8a428", "AQAAAAEAACcQAAAAEOH3ahvQFUxkYy94U8VO3x+TukgXuKfWR9kIbhQTnUUCw3ODHvwQ2by6xlVPDBc/Nw==", "0d51f22c-34d5-42eb-bd9c-d24d482a00b7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b8893e3-e26b-4f10-92a3-4c674bba820e", "AQAAAAEAACcQAAAAEKWOF47E2fBN9Sxwy4TNq4g6Rzb9N141gQcvzRX4qiQ0AEQ1O1jkPjpzESW48uyGiA==", "140446e8-d828-4c7c-9b9f-34a1b318b78c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6b474ec-6c97-4dad-a421-d7792eeace0d", "AQAAAAEAACcQAAAAEHdtMuCy+uvL7X88PiM91OMNUCOEXNmtYDxijgYgPCdyS255srvTL/NIVKNIwd37pg==", "1bc13cff-55e0-49a3-8dc2-c04213b45e50" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a65b8b79-a392-4ed5-b0fe-d3fc1fcc91a2", "AQAAAAEAACcQAAAAEIkDiV0pBqRBWtbgpvbTuqoYSmVOVvJwWcPc0rsoYfvAOLUk3ph+MSpJCA65xwd89A==", "1ca17ebf-bd22-4926-b1b6-55ff9b93c58d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18253525-034c-4a35-b0c9-e1ecdfb7aead", "AQAAAAEAACcQAAAAEN/785/HIDFk8yvjyk8YD6HixDmRe09fshV5Vn5+rvHLG1+cOS8tdU9cedPLJKL08A==", "7d34d1f8-2a23-4aaf-ac53-2dac6fc77370" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("13b6e191-cff1-44cb-96df-ed311f23a083"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3516a1e1-7f36-42c1-84df-3a1f32a123e2"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3c637b85-93b9-4b41-9246-ee4731e3bb4a"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("4035e90f-da41-437f-b43b-4991de99ef59"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("42213182-76ff-4b9f-bbfd-899d210bbaf3"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("42f9c58a-d63c-4460-a1a3-3798d9622897"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5da7b723-3e7e-4c4a-a34a-f9c50e03a136"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("71737a91-2339-40c4-987f-9ffd1951ba8d"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7e3be7f4-7ef3-4cf1-a578-d364615cfd9b"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("82769faa-f4d9-477c-8256-80b77fd7f672"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("87bf1e4c-1715-47c9-ae8e-b192c423fa99"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8ab5528b-de85-401f-b2bc-125d30608d6a"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8aeccf0b-847d-40ed-88db-d67e6ef75db1"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("94814fcd-295d-477c-8dc2-572efcea32a8"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a1d1a52d-505b-4680-974f-4e13beb333f2"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a48c706b-b3cf-4758-930d-057841fd2792"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("aaaf47fd-396e-480c-a0b3-7485f9a6bced"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("aaee54ce-2325-4e79-87f7-4f4a6112256a"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c5463e60-fdf0-4a44-bb45-aa3c410df516"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c829b2f4-9230-447d-b4e7-edfc23dd7667"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cd0d92f5-a5ed-40cd-b645-1534b95a01c8"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d8a529fc-5d79-41c5-baf9-9722639374e6"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f5f88d06-0760-4d0f-a744-c0037bfed7f6"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f6bf1785-96e2-449e-8a79-b7996d06c90b"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "5c872630-5b25-40ed-bee7-8bb807bdcf4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "662fe8f2-4fde-48e0-b25e-ef18d86e88d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e96fd647-e742-4f7d-b4c5-a6d55481b96a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "b962fee2-39a9-402e-a203-39988e38bd70");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "a08bb7d7-56a1-42b4-996a-665dfa2df50b");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("28f4b6cb-b7bc-42c6-b0d3-1027ef68a38e"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("745afc82-539a-4599-a099-7e7a10252853"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 11, 16, 2, 59, 16, 285, DateTimeKind.Local).AddTicks(5164) });
        }
    }
}
