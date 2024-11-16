using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGMajorAdmissionupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b3f01d7-0f61-442d-b744-87cd54cce4b6", "AQAAAAEAACcQAAAAEN069G8qfKyGDJ2GHspvnFQLTPKBWiZjNRhHCU0aKSDm6pZJxf6FWQ4pObe8qaMveA==", "a8528898-a40f-478f-82d2-d2844bd7d689" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c596661-b13e-46b7-b1bd-3ce620e9f83f", "AQAAAAEAACcQAAAAEFr696TI0JjypMJudWUiaVsV+9hKlZa2JOY2iT/baFiEHFIWYWqrmJrp+huG9TTyqA==", "632870f7-366c-4eab-a292-ed5eb7942849" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6bab66a-d5bf-41d1-8bb5-8d37484301c5", "AQAAAAEAACcQAAAAEKOCOC/ESVySuwqkaN+gL+8aY0ej1ZWz2lbMunaYApfs2YxjgoKBmIDVMD5KhFU+YQ==", "7e088ed4-7349-4e0f-9549-c2a0677828a6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d0a22e-7515-496e-9523-a617f20eb95d", "AQAAAAEAACcQAAAAEMGgKnPsi2XgsDH4SeZnPX3oIsUSl9gFdQ00tPl1YwFBBkQkgSZLXTiJtS2kRUkXMw==", "d928c991-64e7-4f68-826a-716f16b194fa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1467d3df-7777-4715-93b3-5719297e6e42", "AQAAAAEAACcQAAAAELmyIzvnrZmg+tYjsd0aBrnqiH/BK5CAYaJMujHXfSGJi1aBxkCNFLgHmFxhIbNO4A==", "e0cf2855-1ddb-4bef-8914-8502124c84da" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("340eef4b-0121-4d02-b688-88d550f1a81a"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("47b76a63-7bf5-47a4-8197-074f1611fec6"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("623c324b-ecb5-4c33-8160-b8417fba7568"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("63493933-1606-4ade-b0de-bec814266b20"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("63e1baff-59f4-4e29-b369-4b2b86e9891c"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("66310733-99cc-41e9-b3e1-0e010aa14d40"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("678a3eeb-5bda-459a-b6ac-4944b37731f3"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("689ed586-906d-4cbf-a68d-4b4606bccedc"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6c14c33c-104d-4d7d-b148-89fb3b224b70"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7867694b-ebc0-4e29-8254-d865ba863256"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("82e5113e-1ebc-4508-9650-70da696a43d9"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8582f5c7-6135-47fb-a14e-cc2788ad598e"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9e2a6b8b-3d02-4c87-93c9-5a06904c8185"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b291eaeb-63a8-4704-9dfc-d125cd9aca96"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b388476c-37f2-4939-9fec-2682a1bf2abf"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b507b6f7-a336-4433-ba67-892458001c3a"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("bfc2312a-7cee-4a1c-93b1-f15241b219ca"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d5ef1c5d-c9e5-4070-ba27-def46feaf19a"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dc26c757-5407-4b5f-91b7-938d1c0c5db3"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dc8dfa39-616f-4ee0-83e1-934d936f8324"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ed3d95be-b6ad-4be4-b1c2-52bf9f916100"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ee6bfec1-a8b8-4721-9263-2909e0a4ae79"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f0e50196-565a-44b5-a37e-8f8c97b1e239"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f749b11f-bdab-4b51-8b0f-26e06f4b55ad"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "248e00e8-0f15-4183-9ff7-76535da59c3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "c1161131-dd88-448a-b08b-b8d66a819be9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7f572bcd-ed03-4920-b21a-e47fb315293e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "544606db-86ca-4a92-979d-ad67ea3ede22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "148dff24-d3f4-4760-9b7c-423a49668f97");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0b8a3cff-23bd-4ecf-a994-2a16057263a0"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("b5231b72-b081-4630-b7b3-1909e7c1d98a"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5501), new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 1, "HAO", 1, null },
                    { 1, "HAO", 2, null },
                    { 1, "HAO", 3, 1 },
                    { 1, "HBS", 1, null },
                    { 1, "HBS", 2, null },
                    { 1, "HBS", 3, 1 },
                    { 1, "HBT", 1, null },
                    { 1, "HBT", 2, null },
                    { 1, "HBT", 3, 1 },
                    { 1, "HEA", 3, 1 },
                    { 1, "HFO", 1, null },
                    { 1, "HFO", 2, null },
                    { 1, "HFO", 3, 1 },
                    { 1, "HHM", 1, null },
                    { 1, "HHM", 2, null },
                    { 1, "HHM", 3, 1 },
                    { 1, "HJA", 1, null },
                    { 1, "HJA", 2, null },
                    { 1, "HJA", 3, 1 },
                    { 1, "HKA", 1, null },
                    { 1, "HKA", 2, null },
                    { 1, "HKA", 3, 1 },
                    { 1, "HRM", 1, null },
                    { 1, "HRM", 2, null },
                    { 1, "HRM", 3, 1 },
                    { 1, "HSM", 1, null },
                    { 1, "HSM", 2, null },
                    { 1, "HSM", 3, 1 },
                    { 1, "HSO", 1, null },
                    { 1, "HSO", 2, null },
                    { 1, "HSO", 3, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("340eef4b-0121-4d02-b688-88d550f1a81a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("47b76a63-7bf5-47a4-8197-074f1611fec6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("623c324b-ecb5-4c33-8160-b8417fba7568"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("63493933-1606-4ade-b0de-bec814266b20"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("63e1baff-59f4-4e29-b369-4b2b86e9891c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("66310733-99cc-41e9-b3e1-0e010aa14d40"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("678a3eeb-5bda-459a-b6ac-4944b37731f3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("689ed586-906d-4cbf-a68d-4b4606bccedc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6c14c33c-104d-4d7d-b148-89fb3b224b70"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7867694b-ebc0-4e29-8254-d865ba863256"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("82e5113e-1ebc-4508-9650-70da696a43d9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8582f5c7-6135-47fb-a14e-cc2788ad598e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9e2a6b8b-3d02-4c87-93c9-5a06904c8185"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b291eaeb-63a8-4704-9dfc-d125cd9aca96"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b388476c-37f2-4939-9fec-2682a1bf2abf"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b507b6f7-a336-4433-ba67-892458001c3a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("bfc2312a-7cee-4a1c-93b1-f15241b219ca"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d5ef1c5d-c9e5-4070-ba27-def46feaf19a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dc26c757-5407-4b5f-91b7-938d1c0c5db3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dc8dfa39-616f-4ee0-83e1-934d936f8324"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ed3d95be-b6ad-4be4-b1c2-52bf9f916100"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ee6bfec1-a8b8-4721-9263-2909e0a4ae79"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f0e50196-565a-44b5-a37e-8f8c97b1e239"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f749b11f-bdab-4b51-8b0f-26e06f4b55ad"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0b8a3cff-23bd-4ecf-a994-2a16057263a0"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("b5231b72-b081-4630-b7b3-1909e7c1d98a"));

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HAO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HAO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HAO", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HBS", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HBS", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HBS", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HBT", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HBT", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HBT", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HEA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HFO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HFO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HFO", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HHM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HHM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HHM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HJA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HJA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HJA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HKA", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HKA", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HKA", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HRM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HRM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HRM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HSM", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HSM", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HSM", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HSO", 1 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HSO", 2 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HSO", 3 });

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
        }
    }
}
