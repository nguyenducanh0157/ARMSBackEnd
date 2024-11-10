using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGRequestChangeMajorupdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestChangeMajor");

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("048e9410-4ffb-468f-b75c-5d118607ea5b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("05a2515c-f95c-4d86-bc07-7d02c9dd192b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("25588555-3d2f-4f2a-b8e7-c5dc985e2107"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2c9d301d-96a2-49e2-a88c-82de1a664499"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3a368fc6-d43d-4881-85ec-24c717a26618"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("42336222-a133-408b-bdfd-086a754c60b9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("426601e4-f1b5-40ce-bbda-ef58414ed182"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("465d0c7d-807a-41f1-aefd-7e703a5a17f6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("49581f5e-a344-4a67-9016-346a04475b58"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("585e6710-0c9e-4267-acb6-893e945fd0be"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("607ee92e-c930-49bc-b08a-d02e87342929"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("743f7050-cffc-4c7f-b509-74448386fefb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("850d1e84-4e36-4ca3-885f-f7d9c126eab2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("867ed94d-1b96-41d4-a6f8-08ec19c59fe0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a26d2fe1-6222-489a-96c8-d772d7d4d57d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("af2b87a1-ae55-4f5a-ad09-9323265f0315"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c8473e3e-61ff-492c-9595-9a9c206e748f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d4eac446-5083-4d29-8ecb-f9938aff49e3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("db7649ed-30be-4985-95da-6c48776296ad"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e5d31470-61ec-4026-ac7c-87f3c141f4f7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e937d69b-9540-4ca8-8b68-b0f4ebc72e65"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f360899d-cfc3-4ef8-85a4-f998caca81cb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f8931ad4-6141-4b53-ad63-9c08d95508a2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f8d7b3d4-fca8-411b-b372-064f288a9445"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("8ae49961-aac3-430d-8746-bd61fd3b9728"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("fab5b11a-881c-4c1b-b3d4-30b6b2efd4c7"));

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorNew = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorOld = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileReasonRequestChangeMajor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    isRequestChangeMajor = table.Column<bool>(type: "bit", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_Request_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Request_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                    table.ForeignKey(
                        name: "FK_Request_Major_MajorNew",
                        column: x => x.MajorNew,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                    table.ForeignKey(
                        name: "FK_Request_Major_MajorOld",
                        column: x => x.MajorOld,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

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

            migrationBuilder.InsertData(
                table: "Request",
                columns: new[] { "RequestID", "AccountId", "CampusId", "DateRequest", "Description", "FileReasonRequestChangeMajor", "MajorNew", "MajorOld", "Reply", "Status", "isRequestChangeMajor" },
                values: new object[,]
                {
                    { 1, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), "Hanoi", new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(667), "Em muốn chuyển ngành!", "file", "HME", "HAO", null, 2, true },
                    { 2, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), "Hanoi", new DateTime(2024, 11, 10, 17, 1, 14, 833, DateTimeKind.Local).AddTicks(671), "Em muốn chuyển ngành!", "file", "HME", "HAO", null, 2, true }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Request_AccountId",
                table: "Request",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_CampusId",
                table: "Request",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_MajorNew",
                table: "Request",
                column: "MajorNew");

            migrationBuilder.CreateIndex(
                name: "IX_Request_MajorOld",
                table: "Request",
                column: "MajorOld");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Request");

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

            migrationBuilder.CreateTable(
                name: "RequestChangeMajor",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorNew = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorOld = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileReasonRequestChangeMajor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestChangeMajor", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_RequestChangeMajor_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestChangeMajor_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                    table.ForeignKey(
                        name: "FK_RequestChangeMajor_Major_MajorNew",
                        column: x => x.MajorNew,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                    table.ForeignKey(
                        name: "FK_RequestChangeMajor_Major_MajorOld",
                        column: x => x.MajorOld,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63686cca-8555-4116-a363-bcb74e7cfe39", "AQAAAAEAACcQAAAAEANN83ICojxo98lBhn1O4Qpgpv+Phyy7zp08Z6aLacDE9hgi9/Zl/qIQc3CD++q+6Q==", "950eaedb-0b08-463c-8293-5c356142aff3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d21f043e-2891-49bc-a23b-b078d3ad552a", "AQAAAAEAACcQAAAAENVjryZPQgtdM/SgKFooAmvH7VVybWFqtZqBOAaAXgZ4jRgZtDcHQk6zOglITdwnFA==", "8681f451-7419-4246-b150-e97ee9eee7f4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db15af82-a175-4c80-93d6-f909001c8771", "AQAAAAEAACcQAAAAEKA0hXZrxrg4Pk+e8yipaHIEl9lhL+CEgKrlhoqngXbi8wfV5T3RmTth81bSYNitqQ==", "4737959e-15db-4547-bd3d-6d8a0128730a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78825175-ac0e-498f-b912-496abac98948", "AQAAAAEAACcQAAAAEEVmZ/955Td9qUC6i5JlwRm60d9NcjIZBs2+hUydHHCBhZ5aEc4PEKSp35L2kPbTng==", "b2331bdf-0a3c-4e1a-a1a1-b8fda7df0673" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b0646fa-47cf-4043-9e23-85df9e41f694", "AQAAAAEAACcQAAAAEGqKGTRxv5jHmwT1TYcqmGZZ13PTsGl0pCLRv2S+doUy2b9gguxT1ihIsr90jZUdXQ==", "2a24cead-cec3-4deb-93c9-845253be5700" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("048e9410-4ffb-468f-b75c-5d118607ea5b"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("05a2515c-f95c-4d86-bc07-7d02c9dd192b"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("25588555-3d2f-4f2a-b8e7-c5dc985e2107"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2c9d301d-96a2-49e2-a88c-82de1a664499"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3a368fc6-d43d-4881-85ec-24c717a26618"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("42336222-a133-408b-bdfd-086a754c60b9"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("426601e4-f1b5-40ce-bbda-ef58414ed182"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("465d0c7d-807a-41f1-aefd-7e703a5a17f6"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("49581f5e-a344-4a67-9016-346a04475b58"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("585e6710-0c9e-4267-acb6-893e945fd0be"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("607ee92e-c930-49bc-b08a-d02e87342929"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("743f7050-cffc-4c7f-b509-74448386fefb"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("850d1e84-4e36-4ca3-885f-f7d9c126eab2"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("867ed94d-1b96-41d4-a6f8-08ec19c59fe0"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a26d2fe1-6222-489a-96c8-d772d7d4d57d"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("af2b87a1-ae55-4f5a-ad09-9323265f0315"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c8473e3e-61ff-492c-9595-9a9c206e748f"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d4eac446-5083-4d29-8ecb-f9938aff49e3"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("db7649ed-30be-4985-95da-6c48776296ad"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e5d31470-61ec-4026-ac7c-87f3c141f4f7"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e937d69b-9540-4ca8-8b68-b0f4ebc72e65"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f360899d-cfc3-4ef8-85a4-f998caca81cb"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f8931ad4-6141-4b53-ad63-9c08d95508a2"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f8d7b3d4-fca8-411b-b372-064f288a9445"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.InsertData(
                table: "RequestChangeMajor",
                columns: new[] { "RequestID", "AccountId", "CampusId", "DateRequest", "Description", "FileReasonRequestChangeMajor", "MajorNew", "MajorOld", "Reply", "Status" },
                values: new object[,]
                {
                    { 1, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), "Hanoi", new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9542), "Em muốn chuyển ngành!", "file", "HME", "HAO", null, 2 },
                    { 2, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), "Hanoi", new DateTime(2024, 11, 10, 7, 44, 23, 689, DateTimeKind.Local).AddTicks(9546), "Em muốn chuyển ngành!", "file", "HME", "HAO", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "7ea61577-80c5-41dc-ae51-410a05e04cfd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "f31189ae-7eaa-46cc-8911-7aef51aa734f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "9b1d2b8b-9982-42eb-9a21-92223da8cf28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "4a935023-6c58-43b8-9d96-9158eaa64d66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "0b42c05d-b4d7-4d26-8241-d7982a848bf2");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("8ae49961-aac3-430d-8746-bd61fd3b9728"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("fab5b11a-881c-4c1b-b3d4-30b6b2efd4c7"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_AccountId",
                table: "RequestChangeMajor",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_CampusId",
                table: "RequestChangeMajor",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_MajorNew",
                table: "RequestChangeMajor",
                column: "MajorNew");

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_MajorOld",
                table: "RequestChangeMajor",
                column: "MajorOld");
        }
    }
}
