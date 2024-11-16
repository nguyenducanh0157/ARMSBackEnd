using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionDetailForMajor");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0b8a3cff-23bd-4ecf-a994-2a16057263a0"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("b5231b72-b081-4630-b7b3-1909e7c1d98a"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalScoreAcademic",
                table: "MajorAdmission",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalScore",
                table: "MajorAdmission",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "RequestNotification",
                columns: table => new
                {
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestNotification", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_RequestNotification_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2247ff-114a-4d16-913a-43a92516aeb5", "AQAAAAEAACcQAAAAEBBQtXJU/t+5ytJKu7MUp2JUn02DjrrZxmsosFWZndWtSK87g0nZK7FezOQt4A+4Tw==", "29de30c4-cf97-42d3-a1f3-8f5b1af9cfe6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46966d84-fe29-4074-b92f-51e44509079e", "AQAAAAEAACcQAAAAEPX4FNtRfX7AoFMdfdUAC+yCSXubUC2ZrWJH+NvDaONKU7LzrPW/Jb7hAiP/g4Hp0A==", "fe459fa8-4eb7-4d5f-9b6e-05e957a09bca" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f3e3f23-6d48-49d2-861f-a34b46153d81", "AQAAAAEAACcQAAAAEM45qmEBk8dtSl/91I7pISk1P1bCFGtSkaEpq/0xYo1p5vhx0ZUW2ZH1LmXWJniIZg==", "a15d250c-98ca-46e1-bc9b-f166cf736bf7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c69d2a1-a589-48fa-9858-b7d8f6dfae7f", "AQAAAAEAACcQAAAAEGaN2vc/wwNC2E/OB3zgkibqX3Wukxqxk9v2ZfjkdzZG06NYZJkkOA70Gu+2W99BtQ==", "5e38538a-6203-4e87-90cb-d5174adba82a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0bc2964-7d8a-49ef-8489-5471e2460edd", "AQAAAAEAACcQAAAAENMjDNO22L5k4/X0rzmuO7YVpVaYTJ30xkoubhcZSsutxhj8Z9g78htvxBHuJwsnHw==", "85650f72-442b-49e9-b7ba-1639e7f5c92d" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "8b39f430-671c-4afb-841d-19d5431111b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "4f0a0fdb-634a-4337-857b-644146edf0b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "9194e149-dbab-4d48-9671-71113fdaa9d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "ca1deff3-dabe-43ad-a81a-4f80ce73fb77");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "edbd0c35-ecb4-465a-81a4-54553b342b55");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("631a84b2-6de9-4c17-9756-bdaa4273008e"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("c3da8247-0ef0-460c-815b-b49d669a7ac8"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "Major2", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2777), new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2779), "HWE", new DateTime(2024, 11, 16, 10, 39, 33, 101, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.CreateIndex(
                name: "IX_RequestNotification_AccountId",
                table: "RequestNotification",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestNotification");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("631a84b2-6de9-4c17-9756-bdaa4273008e"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c3da8247-0ef0-460c-815b-b49d669a7ac8"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalScoreAcademic",
                table: "MajorAdmission",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalScore",
                table: "MajorAdmission",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AdmissionDetailForMajor",
                columns: table => new
                {
                    ADMId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusScore = table.Column<bool>(type: "bit", nullable: false),
                    StatusScoreAcademic = table.Column<bool>(type: "bit", nullable: false),
                    SubjectGroupsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalScoreAcademic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
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
                    { new Guid("257447a5-016c-40d9-9c5f-1a2cc68e0654"), "HWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("340eef4b-0121-4d02-b688-88d550f1a81a"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3ed63cec-79a4-4304-bfa0-a326a4dbb03d"), "HJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("47b76a63-7bf5-47a4-8197-074f1611fec6"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5c8e9972-7642-4b08-9642-c510e3cd40dc"), "HME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("623c324b-ecb5-4c33-8160-b8417fba7568"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("63493933-1606-4ade-b0de-bec814266b20"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("63e1baff-59f4-4e29-b369-4b2b86e9891c"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("66310733-99cc-41e9-b3e1-0e010aa14d40"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("664b31e7-4a22-4d47-a46c-2e2876337ac7"), "HGE", true, true, "[0,1]", 24m, 24m, 2024 },
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
                    { new Guid("b7328cad-128f-4da3-9cfa-0bd91116275a"), "HTE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("bfc2312a-7cee-4a1c-93b1-f15241b219ca"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cfb75e89-ecd3-4071-9245-2e7286b6f84d"), "HEA", true, true, "[44,1]", 24m, 24m, 2024 },
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
                columns: new[] { "CIDate", "Dob", "Major2", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5501), null, new DateTime(2024, 11, 16, 3, 0, 53, 231, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionDetailForMajor_MajorID",
                table: "AdmissionDetailForMajor",
                column: "MajorID");
        }
    }
}
