using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdateDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cde31aa7-b3bf-4abc-9114-66fc04ee5933", "AQAAAAEAACcQAAAAEN58kqR1A3lridcSQYswSW/etIYxgo6BKqPExTMuQrEaF8oT6yRP/1L+ap5eY30L8A==", "bdfac616-4b43-422f-b2db-79e287b874e8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8b3805f-1fe7-475b-b7ba-ea81b30fb28d", "AQAAAAEAACcQAAAAEJNH4+4EWgi18fHS2uJ7t+iHeuf7gtnwsBR4BVSDUhYGm4FPHTO3/oxfdsLMvsukVg==", "ab2ada46-a34a-4a48-9bc1-c954c04fe32f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edefde48-dc66-4684-b018-0a74f11a596c", "AQAAAAEAACcQAAAAEDL44hzc+V+Q5FTTZt9POq0oxN16ljUZu5/Trz0SBNj5Buv+kLFQ5F1hYUWQDA4KaQ==", "1717587e-a65e-4c7e-8066-29055daf2ab3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd74437c-e3b3-42cc-af61-0a2d1f1e5834", "AQAAAAEAACcQAAAAEJxh9IqdnpGaMhuvqDDpn+EGD/FZC7nUcCQhwpt2OeBY7zkflGsh0ujwJxw00gkUww==", "7c49a9cd-1f97-4d09-ba7a-208c0d4d9abf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c579f1b1-5c95-4f71-a073-09b3f18b5881", "AQAAAAEAACcQAAAAEMkYlU93iAPW+/BuFe95VK+W0nFIuiKGFTEX4QVKKtarjmsE5nTuwcZ0jmxrepL0VQ==", "08936bf2-f0ab-4f37-9fdb-1413e11c17b6" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("0652816e-c655-4a59-9a8a-bc3d4ff0a955"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("08b588a1-8a40-4a1b-8856-5a8680d9090e"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("15ba29ca-7eb4-4572-88cb-abf21580d69c"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1ed66c16-878c-4761-adea-567a03d7e14c"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("47d4aa7b-cac9-419e-8058-8e9613d00f3b"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("494683b4-78ee-49cd-9df0-6fe05bae3db9"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("69f528d4-7cf9-4d34-be4f-01af5867c5cd"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7e5b8776-af1b-4cbc-b93b-bc6c008c19e8"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7f9627dd-c4cb-435e-aa57-bad6dcb5b3c5"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("987884e0-769a-4413-8db9-4308d91cc052"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9a3903f7-c37d-4738-841b-b98f8289ee92"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a7fac2cc-a864-432e-9b62-e7add6ee6143"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b5f6cfa2-e67e-46ca-95df-b40cf65891da"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c25e85f7-8b9b-49b3-a8bb-edaf435dee99"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("d25dd19a-cce8-4d62-840b-c06fca6940b7"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d7ede4e0-b736-44d6-adce-e0e0b096250d"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("dd955c41-9b02-4553-b67b-12ba1bd7f22b"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e517c425-5093-4647-8f14-0221cd1c8198"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("e671fe99-03d9-4443-9fd5-931d0532734c"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ea514736-f033-4535-b70a-5d9bdeea1816"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ed2e382f-1b9c-458e-bacf-5ec27e17d79d"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ef8a36eb-0dcc-4e43-a7ec-3ad54bf6eb2e"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f3280b57-5444-48ce-b656-cbf1714dfae2"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("ff31e470-12e4-4d34-976e-bb0a3b1fa0d4"), "STE", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 11, 1, 20, 31, 331, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "99bb4d2a-8622-4a36-994e-c0e993e3c346");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "4cd81fd9-4ea6-4988-8ca2-ad05c55f5777");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7b2a8769-bb2f-40d2-973f-350241f7200c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "fe8fd156-ef9c-45c8-9a14-b04f05bc8cc5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "49078656-6549-4b02-a567-8c5bca4363d2");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 1,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs1.jpg?alt=media&token=def52f7a-933d-4747-94df-985375b51f56");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 2,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs2.jpg?alt=media&token=af2de147-6722-4723-a91a-5e5521093fa5");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 4,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs1.jpg?alt=media&token=def52f7a-933d-4747-94df-985375b51f56");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 5,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs2.jpg?alt=media&token=af2de147-6722-4723-a91a-5e5521093fa5");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 7,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs1.jpg?alt=media&token=def52f7a-933d-4747-94df-985375b51f56");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 8,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs2.jpg?alt=media&token=af2de147-6722-4723-a91a-5e5521093fa5");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 10,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs1.jpg?alt=media&token=def52f7a-933d-4747-94df-985375b51f56");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 11,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs2.jpg?alt=media&token=af2de147-6722-4723-a91a-5e5521093fa5");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 13,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs1.jpg?alt=media&token=def52f7a-933d-4747-94df-985375b51f56");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 14,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2Fs2.jpg?alt=media&token=af2de147-6722-4723-a91a-5e5521093fa5");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("38e7cf81-d3af-4f31-a5dc-e7ada507a190"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("81f1d90e-e5d0-4332-a75a-15a06a09972e"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0652816e-c655-4a59-9a8a-bc3d4ff0a955"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("08b588a1-8a40-4a1b-8856-5a8680d9090e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("15ba29ca-7eb4-4572-88cb-abf21580d69c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1ed66c16-878c-4761-adea-567a03d7e14c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("47d4aa7b-cac9-419e-8058-8e9613d00f3b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("494683b4-78ee-49cd-9df0-6fe05bae3db9"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("69f528d4-7cf9-4d34-be4f-01af5867c5cd"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7e5b8776-af1b-4cbc-b93b-bc6c008c19e8"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7f9627dd-c4cb-435e-aa57-bad6dcb5b3c5"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("987884e0-769a-4413-8db9-4308d91cc052"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9a3903f7-c37d-4738-841b-b98f8289ee92"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a7fac2cc-a864-432e-9b62-e7add6ee6143"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b5f6cfa2-e67e-46ca-95df-b40cf65891da"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c25e85f7-8b9b-49b3-a8bb-edaf435dee99"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d25dd19a-cce8-4d62-840b-c06fca6940b7"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d7ede4e0-b736-44d6-adce-e0e0b096250d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("dd955c41-9b02-4553-b67b-12ba1bd7f22b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e517c425-5093-4647-8f14-0221cd1c8198"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("e671fe99-03d9-4443-9fd5-931d0532734c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ea514736-f033-4535-b70a-5d9bdeea1816"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ed2e382f-1b9c-458e-bacf-5ec27e17d79d"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ef8a36eb-0dcc-4e43-a7ec-3ad54bf6eb2e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f3280b57-5444-48ce-b656-cbf1714dfae2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("ff31e470-12e4-4d34-976e-bb0a3b1fa0d4"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("38e7cf81-d3af-4f31-a5dc-e7ada507a190"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("81f1d90e-e5d0-4332-a75a-15a06a09972e"));

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

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 1,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 2,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 4,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 5,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 7,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 8,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 10,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 11,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 13,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce");

            migrationBuilder.UpdateData(
                table: "Slider",
                keyColumn: "SliderId",
                keyValue: 14,
                column: "Img",
                value: "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("a4fa37fd-9ccb-4645-9462-ab6f1263f26b"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("a566e01d-4527-4dd3-9988-e7e412ed7a74"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
