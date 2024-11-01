using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissiondetailsupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("5f0910bd-402e-450c-931b-01a1b35bc7bf"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("6fa1148d-ac55-4652-bc09-e57f80679bc4"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("7c88d057-62e0-49ce-b7c0-109234f2ec5a"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("b3b7b60b-94cc-4b89-bff0-de724d409733"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("e3c82444-b430-43a8-b1de-d6c4ea35b9fb"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("fbe1c854-96cd-4dd5-b97f-5d38ee11aff9"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0eef6cf1-1994-4b1a-a98d-db8fb675b580"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1b58e24b-3363-484c-8321-9dd5227a0902"));

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript", "isMajor1" },
                values: new object[,]
                {
                    { new Guid("080515fc-f18d-4519-9fba-450e8177f17b"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1, false },
                    { new Guid("5ff5b4b7-1ce1-44c2-b1f1-b7329a0066d6"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0, false },
                    { new Guid("88cbc868-10d9-4fc6-8700-7beb67acc672"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0, false },
                    { new Guid("d6b03007-2c37-4fff-a7b6-dd14860e2395"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2, false },
                    { new Guid("de51e095-f3aa-45ea-8273-2cd749c76c74"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2, false },
                    { new Guid("f8acd77b-4d98-4be7-b6ff-780484d7ba37"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1, false }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c1422ec-8048-4379-904a-58de5417a035", "AQAAAAEAACcQAAAAEHb+s/Ih6Zj0uH66BJGRWtp0k1EZnq9glnseWlg4ujocm7qYFLyPsBNs7uQcHt36TA==", "46b104f6-303a-4f9f-b7b3-d88f5a694c91" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a66b7f8-d6f1-4c97-9c72-102df9626d42", "AQAAAAEAACcQAAAAEDfZmIjewUlb495ceGwiwmzhBwGiulVnzUYLWUK8p3mRdi5H0XZUTKv/VWXGRzpQZg==", "5f015e65-eee5-4245-8eb4-6416285c95ec" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b1c794f-cbcc-4129-8940-7405030830d6", "AQAAAAEAACcQAAAAEOGoGX2HUYUHk4TL9yxZj9sD4XEb07nDd+1rGLmlBLjo/9tQAdeadMzeuBZRegGR6w==", "d95b942f-c45f-4ddb-acf7-7ae4582f9374" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdf4237f-47ce-455e-ac1d-0036a3bacf7f", "AQAAAAEAACcQAAAAEC4h+pQj4itVRWxlQomDQR5TSmxcBZ7iJhQW0py4wSLksT4VfSd+gMPB9WuiPcHFng==", "89046d71-2d16-423d-8831-f3d4d976acfa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa19d83d-ab9c-4f60-a1ba-b87cda3ef812", "AQAAAAEAACcQAAAAEHsbRRpARhFwAW/BJa0XojD3mbxARvBFcHaQDL0553GgyfThVAwk/k6KXjVh7xO5ZA==", "49a1f03f-627e-44bc-b1b9-0c79af80e8fe" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("083eb73e-6174-4fba-b958-94649505e110"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("17a6015f-faef-42e8-991b-1cc0c9d662ab"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1c692cce-60d3-4370-a2de-eb67aa22a429"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("257447a5-016c-40d9-9c5f-1a2cc68e0654"), "HWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("29f934b5-ea79-4a16-a9e5-b114636e79eb"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("30584818-dc5c-478e-a7b2-0f99657fd92e"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("3ed63cec-79a4-4304-bfa0-a326a4dbb03d"), "HJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("40730ce5-604e-4ed7-b318-dd8e54f35419"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("52ad5905-4a40-49bd-88e1-982e0a4af50d"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("55f040d8-5a7d-4562-857d-5449aebeb68d"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5c8e9972-7642-4b08-9642-c510e3cd40dc"), "HME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("664b31e7-4a22-4d47-a46c-2e2876337ac7"), "HGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("72a1d287-2314-4e8f-841b-8db0faaa47e3"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("797546e9-eba9-4d3f-bceb-1438fbf49d75"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7e2aca9f-5674-4235-862a-322cf19a4164"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("854d4092-aeea-4a8f-8b8e-c48236e0c103"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8b8e8c92-6a72-4eed-b2b3-c92f798001b6"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("913850df-f750-4df2-9ecf-ae88539ba20e"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a32991f6-07ad-420f-8cd9-44482de5fc8f"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a5ccf6b9-b645-44e4-8398-e7a81be18bf2"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a9ba5e37-00e9-48ad-8123-dc101808b543"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ab0701a8-37f9-47f9-a35e-dbe7f8ebc4aa"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b72777e7-2af2-4a3a-beb6-03919d3e6497"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b7328cad-128f-4da3-9cfa-0bd91116275a"), "HTE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cc6f4e99-43d8-41c9-b7d0-e46419ebeb13"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("cf751575-d3a7-4d51-9290-29ff0e5ced8b"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("cfb75e89-ecd3-4071-9245-2e7286b6f84d"), "HEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("d3810344-5151-46d2-81e1-25eda54b9dea"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d3b1c857-8b47-486d-aadc-100fd7c02603"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e428b199-d050-4ed0-ac88-f69c44431526"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "580f6672-5ef5-4e01-8252-48c1b4a3d3f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ca0c0607-8a1c-41bb-9a38-9d2aa3fa8c30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "76ab16d0-4dcb-434d-98a3-1806bf4419c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "b9b00d34-88dc-4791-a284-8559a23e00e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "98bf1db7-6134-4959-9218-ccad653f5f53");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("6e24f869-ee7a-4b88-b3ac-edcccfa9436b"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("f731ed83-63eb-4b8a-95b3-108225c89abf"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3699), new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3703), new DateTime(2024, 11, 1, 0, 21, 56, 816, DateTimeKind.Local).AddTicks(3704) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("080515fc-f18d-4519-9fba-450e8177f17b"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("5ff5b4b7-1ce1-44c2-b1f1-b7329a0066d6"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("88cbc868-10d9-4fc6-8700-7beb67acc672"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("d6b03007-2c37-4fff-a7b6-dd14860e2395"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("de51e095-f3aa-45ea-8273-2cd749c76c74"));

            migrationBuilder.DeleteData(
                table: "AcademicTranscript",
                keyColumn: "ATId",
                keyValue: new Guid("f8acd77b-4d98-4be7-b6ff-780484d7ba37"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("083eb73e-6174-4fba-b958-94649505e110"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("17a6015f-faef-42e8-991b-1cc0c9d662ab"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1c692cce-60d3-4370-a2de-eb67aa22a429"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("257447a5-016c-40d9-9c5f-1a2cc68e0654"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("29f934b5-ea79-4a16-a9e5-b114636e79eb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("30584818-dc5c-478e-a7b2-0f99657fd92e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("3ed63cec-79a4-4304-bfa0-a326a4dbb03d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("40730ce5-604e-4ed7-b318-dd8e54f35419"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("52ad5905-4a40-49bd-88e1-982e0a4af50d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("55f040d8-5a7d-4562-857d-5449aebeb68d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5c8e9972-7642-4b08-9642-c510e3cd40dc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("664b31e7-4a22-4d47-a46c-2e2876337ac7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("72a1d287-2314-4e8f-841b-8db0faaa47e3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("797546e9-eba9-4d3f-bceb-1438fbf49d75"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7e2aca9f-5674-4235-862a-322cf19a4164"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("854d4092-aeea-4a8f-8b8e-c48236e0c103"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8b8e8c92-6a72-4eed-b2b3-c92f798001b6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("913850df-f750-4df2-9ecf-ae88539ba20e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a32991f6-07ad-420f-8cd9-44482de5fc8f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a5ccf6b9-b645-44e4-8398-e7a81be18bf2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a9ba5e37-00e9-48ad-8123-dc101808b543"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ab0701a8-37f9-47f9-a35e-dbe7f8ebc4aa"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b72777e7-2af2-4a3a-beb6-03919d3e6497"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b7328cad-128f-4da3-9cfa-0bd91116275a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cc6f4e99-43d8-41c9-b7d0-e46419ebeb13"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cf751575-d3a7-4d51-9290-29ff0e5ced8b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("cfb75e89-ecd3-4071-9245-2e7286b6f84d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d3810344-5151-46d2-81e1-25eda54b9dea"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d3b1c857-8b47-486d-aadc-100fd7c02603"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e428b199-d050-4ed0-ac88-f69c44431526"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("6e24f869-ee7a-4b88-b3ac-edcccfa9436b"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f731ed83-63eb-4b8a-95b3-108225c89abf"));

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript", "isMajor1" },
                values: new object[,]
                {
                    { new Guid("5f0910bd-402e-450c-931b-01a1b35bc7bf"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1, false },
                    { new Guid("6fa1148d-ac55-4652-bc09-e57f80679bc4"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Văn", 9m, 1, false },
                    { new Guid("7c88d057-62e0-49ce-b7c0-109234f2ec5a"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0, false },
                    { new Guid("b3b7b60b-94cc-4b89-bff0-de724d409733"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Anh", 9m, 2, false },
                    { new Guid("e3c82444-b430-43a8-b1de-d6c4ea35b9fb"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2, false },
                    { new Guid("fbe1c854-96cd-4dd5-b97f-5d38ee11aff9"), new Guid("795b3e70-1312-4889-8352-a696757d1730"), "Toán", 9m, 0, false }
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98663f88-285e-45d6-b3fe-6289405449b6", "AQAAAAEAACcQAAAAEI2mpvL00R9RX3SgtwQLrcxJSDSxJgKO5Wm17/7Pu0tHvS11CGFTQm+fwK9fGcrqeA==", "05d18455-ca11-4da5-b542-aca01fe99d86" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31845da1-0b33-48ca-8aed-718b48bf4ebf", "AQAAAAEAACcQAAAAEJ0Q6PIL2KXwFw4H8zGQUv+X209nPm45EHfIocq3yn+mmL1mcJ8NQi5N75mCT0Edlw==", "c259d6f0-0f9f-451a-a1ae-441a985e8966" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5fad91c-96f6-47ee-834d-780ea5205322", "AQAAAAEAACcQAAAAEAR5OW/e9Bv26lLJkz7D6P2atYiq4B/aKls0JU5JFKFj55TgO36yDwLig9omuJf8Dw==", "48273c05-77f1-485b-92a9-6e4c85cf71ce" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae4e33c7-2e45-491c-b19f-7fb2aaf0a334", "AQAAAAEAACcQAAAAEG9R396OIcA+BFhFu352recQN/KAJ/WZcd33NL2mQKOYVK/o6vZ+4NGBUskWzWOrsQ==", "518e29c7-00d8-43f2-88a8-b0885f5267e8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b1a6b0a-b75f-4632-b75e-8a93255ad0f8", "AQAAAAEAACcQAAAAEHkCyoNDjZjNAwFtYijBvJmwfIcg7ra+FsmyC5r4b8BrTKIFdpLXv3BmCtoEZA1JgA==", "fb87eaa3-9ae4-441e-96e2-21f91eaaad97" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "85dac92e-cfaf-418b-a1da-62b3c8fab906");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "b8b360d9-b097-4324-8cc8-10afe529605b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "37867c6d-8439-44bc-8663-0447fff11548");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "59c33030-a019-44a2-a14f-730af3ca7725");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "26dd211a-fbba-4f7f-9102-6bce3177cf52");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0eef6cf1-1994-4b1a-a98d-db8fb675b580"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("1b58e24b-3363-484c-8321-9dd5227a0902"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1687), new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("795b3e70-1312-4889-8352-a696757d1730"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1691), new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1692), new DateTime(2024, 11, 1, 0, 18, 52, 765, DateTimeKind.Local).AddTicks(1693) });
        }
    }
}
