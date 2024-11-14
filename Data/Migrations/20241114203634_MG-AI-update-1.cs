using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAIupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0a2ef77d-b807-4873-9ca7-aec1234813ac"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0af20ea2-41ef-4308-aa94-1271da4e245c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0e18981a-bcd3-4412-81be-0265369ea233"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("27a8d09a-5127-4094-8daf-8105f56084f2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2b957490-9a65-4207-9b65-c89798fc9042"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("35e4b167-2601-4a90-9306-b3bb8ae22c6f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("457ddbfe-c1dd-4f52-9191-86aa99687bdf"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("52658528-5be3-4386-8916-1292fbfc3c55"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("65f10a9e-3ef7-44cc-9051-918768aa8af0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7b9ec832-32f6-4fde-82ea-80cdcd44c2f5"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8053f1a7-e896-49b1-beec-60d4b6163f8b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8267667f-2321-415e-afc4-d5a276d8212e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("83f8d4d1-7f08-4008-9b9e-8955ee9574e1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("84763dfc-57bc-4e33-962f-65eb9ff61ca6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8bb397eb-1867-4947-9e3b-dfe3f598a385"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("8f45cc65-4138-420e-9eb2-5d9198e99851"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("90ee8468-b29e-446c-a233-596a218dc8c6"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9d2ebf40-39cd-4d1d-808d-fbc554f7cc32"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a029c455-99d4-472c-8cb3-10b0b54428f3"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a93a4a0b-c1bf-471c-873a-dda038f06588"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("b8e28b56-2926-4a58-ac07-abd9899a8227"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c39fe8e3-35ec-48b2-918a-595ed73094db"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c9ea8880-4dc4-4e77-870e-9f1d0a17cc15"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f1000507-ed3b-4a3c-9ce8-6db48a3e8d02"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("75d12c81-6c25-4b74-8edd-602f97098745"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d860dfdc-ed6c-428e-929e-b140d4aaf4c0"));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "AdmissionInformation",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1e61497-190e-4b29-a07f-1f70ca3f4161", "AQAAAAEAACcQAAAAEEr1NsaUkpIWVlvOVPgNQ1I+O46rXQATIC4IXR5svyaQY/KPwHDv7vSjU6MRv/m/Bg==", "f7dc0019-3936-419c-8d1e-d08a24596eea" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d39470b9-2537-4fb9-9c9f-be787975a7e7", "AQAAAAEAACcQAAAAEKNz3N4xEjTjbyWUWddtL/RuhIK9qxgb74NGi1ugMrLNKnKQI618ygiM7Pdeb4uT+g==", "fd651367-7aee-4c92-9638-143996e4d400" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04908347-1786-4da8-911c-9d38766b9def", "AQAAAAEAACcQAAAAECO2qI8mlho68JWEjGTJaf+BpN4SvmqfVqWnQz7tQZN/v4mzjnqh+Gl7qxv4NDKaAA==", "1a853a6f-637f-4b57-b264-5394691a03fb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f381f2ac-4159-4123-9e9f-435247b8c7e0", "AQAAAAEAACcQAAAAELfFjLk2/yhcYXXmVaR5Lv2128kI6uv2hmPnv3RQT21FDchlOBd9dBfTmltfK9Wsxg==", "3aba857b-0340-4417-ab34-7792d873402d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d48d7196-9986-4850-8bfc-8ba13d73d07c", "AQAAAAEAACcQAAAAEHCQwJ4FRpQn37QJ0EUjU1AZ/mZBvLmw+SCprwdPoTSzhfiNaKooY9vo5doRk/bOpg==", "cba781c6-e914-4f00-9123-c74a607e4f91" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("0ab2351f-0ca6-4403-9016-50c327abb57b"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0af73741-4a03-4b83-92e0-6979ec99e2b1"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("1143c408-074c-4dec-abc7-75df9e2e30eb"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2a99daf5-59bf-4f18-a313-3db130de0978"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("303d38bc-27ba-4a42-b888-e3585f3f0ac2"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("46acc71b-9aa6-4996-96ea-a08a98c95fbd"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("5a55fd66-ead6-4e28-b767-637e4d3656b5"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6258745d-e751-4550-aff4-3b783861cccc"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("6aae2f69-cd16-4290-8eac-b03d03c16835"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("79612d45-3bf5-44d9-b235-0a41b95ecf3a"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7a895569-b382-4040-b7f2-c1cece4120e2"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("7cf476fa-47d2-427a-9621-70695e42c879"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7d894ea8-6fb5-458a-b517-662b3711cc5a"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9052109a-a8c5-4730-a543-b66d4a736e9e"), "SME", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("937633c0-2266-44a2-bc60-f9fd8dfe131c"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("94813c38-d1e9-47ff-9e43-e674e3b66143"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a6bf07c8-c54a-4433-9387-c0df073bff58"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c0b50822-83b9-47b6-a0a2-642cf30c0e92"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c0ddeb3e-d353-4b5c-82b7-32c1899ea9dc"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c1c38421-4c8f-4cb8-9d03-d3c99d6b9bd1"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c32fcdb7-cab8-4527-be00-4fb9b048228a"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c811ce07-8d53-4f1c-9825-ebb6c863604f"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("d79d4365-aad0-4098-a9e4-e2d5f1e576c0"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f7bb1048-c92d-41bf-8c4d-d13ab969c1ee"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 4,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 5,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 6,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 3, 36, 33, 1, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "9f90366b-471b-4cf8-8819-4f790305611e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "dc46c642-fe92-418c-96c0-b1dca62f21c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "25bf293f-872c-4328-8957-866d7a0581b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "00ee626f-bea1-41b3-8852-69ae9dd8d9bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "0651c779-029e-47ac-a307-de6d2f890120");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("a02ac614-a9d8-4592-9d8d-9ec3c69e2c82"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("d891ec48-36eb-4742-a28b-55cef9a5c5dd"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0ab2351f-0ca6-4403-9016-50c327abb57b"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("0af73741-4a03-4b83-92e0-6979ec99e2b1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("1143c408-074c-4dec-abc7-75df9e2e30eb"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("2a99daf5-59bf-4f18-a313-3db130de0978"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("303d38bc-27ba-4a42-b888-e3585f3f0ac2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("46acc71b-9aa6-4996-96ea-a08a98c95fbd"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("5a55fd66-ead6-4e28-b767-637e4d3656b5"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6258745d-e751-4550-aff4-3b783861cccc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("6aae2f69-cd16-4290-8eac-b03d03c16835"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("79612d45-3bf5-44d9-b235-0a41b95ecf3a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7a895569-b382-4040-b7f2-c1cece4120e2"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7cf476fa-47d2-427a-9621-70695e42c879"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("7d894ea8-6fb5-458a-b517-662b3711cc5a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("9052109a-a8c5-4730-a543-b66d4a736e9e"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("937633c0-2266-44a2-bc60-f9fd8dfe131c"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("94813c38-d1e9-47ff-9e43-e674e3b66143"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("a6bf07c8-c54a-4433-9387-c0df073bff58"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c0b50822-83b9-47b6-a0a2-642cf30c0e92"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c0ddeb3e-d353-4b5c-82b7-32c1899ea9dc"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c1c38421-4c8f-4cb8-9d03-d3c99d6b9bd1"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c32fcdb7-cab8-4527-be00-4fb9b048228a"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("c811ce07-8d53-4f1c-9825-ebb6c863604f"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("d79d4365-aad0-4098-a9e4-e2d5f1e576c0"));

            migrationBuilder.DeleteData(
                table: "AdmissionDetailForMajor",
                keyColumn: "ADMId",
                keyValue: new Guid("f7bb1048-c92d-41bf-8c4d-d13ab969c1ee"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a02ac614-a9d8-4592-9d8d-9ec3c69e2c82"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d891ec48-36eb-4742-a28b-55cef9a5c5dd"));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "AdmissionInformation",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bdc0c5f-47ad-4e67-9b4e-2501c55c34dc", "AQAAAAEAACcQAAAAEONkpztUAYFo7PyBKJjzy9odkxgQ4jYGwsuyvQ6hwhSZmKz5qGmzwBWyVdW01mHtVg==", "a97cbab6-2316-4a87-8ac3-e97a15ea52a5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b2a7a42-6688-4b1f-8202-c4d0c6c71353", "AQAAAAEAACcQAAAAEDiY9DFwjTNNuOmgfBvM59KyLreCfSdn/Zi9F3ACwsoDVoyvB7nuLUkQ5vtyqYCizg==", "4db24dab-7e77-4a38-90c9-7b8cbce03fd7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5559c804-d175-48cf-8b22-1e6288145792", "AQAAAAEAACcQAAAAELizGQw2XulLXE5CFr9fYpqI59/XLpMnFDgaOA2SVMUuuMudfyx/LtczOAUjAe7tWw==", "df41cdd3-cd34-414b-8ecd-82767bd1c311" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2dfc260-da60-4500-bcfb-c55f74d90970", "AQAAAAEAACcQAAAAEJNEMwOfFVwVx9N6/yYm4nKe7UytsUAVnLlxm/FeKJRcsyDlypF4FaVtFFS++qZpXg==", "842aa640-a71b-4e9c-ab9a-b11f944871e2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3969d26-7ac5-40d6-8008-a4fa65949fcd", "AQAAAAEAACcQAAAAENSO8zwEw0rNpSPY8S2q0UthpkeXOPqkjD06sYocodr5+1Vzr3U2ar+EyNHAKGlWPg==", "02a3fff7-f1dd-458c-a21e-8e925c7849a0" });

            migrationBuilder.InsertData(
                table: "AdmissionDetailForMajor",
                columns: new[] { "ADMId", "MajorID", "StatusScore", "StatusScoreAcademic", "SubjectGroupsJson", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { new Guid("0a2ef77d-b807-4873-9ca7-aec1234813ac"), "HBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("0af20ea2-41ef-4308-aa94-1271da4e245c"), "SEA", true, true, "[44,1]", 24m, 24m, 2024 },
                    { new Guid("0e18981a-bcd3-4412-81be-0265369ea233"), "SBS", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("27a8d09a-5127-4094-8daf-8105f56084f2"), "SFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("2b957490-9a65-4207-9b65-c89798fc9042"), "SSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("35e4b167-2601-4a90-9306-b3bb8ae22c6f"), "SAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("457ddbfe-c1dd-4f52-9191-86aa99687bdf"), "HFO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("52658528-5be3-4386-8916-1292fbfc3c55"), "SBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("65f10a9e-3ef7-44cc-9051-918768aa8af0"), "HAO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("7b9ec832-32f6-4fde-82ea-80cdcd44c2f5"), "SWE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8053f1a7-e896-49b1-beec-60d4b6163f8b"), "HRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8267667f-2321-415e-afc4-d5a276d8212e"), "SHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("83f8d4d1-7f08-4008-9b9e-8955ee9574e1"), "STE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("84763dfc-57bc-4e33-962f-65eb9ff61ca6"), "SSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8bb397eb-1867-4947-9e3b-dfe3f598a385"), "HSO", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("8f45cc65-4138-420e-9eb2-5d9198e99851"), "HKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("90ee8468-b29e-446c-a233-596a218dc8c6"), "SGE", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("9d2ebf40-39cd-4d1d-808d-fbc554f7cc32"), "SKA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a029c455-99d4-472c-8cb3-10b0b54428f3"), "SJA", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("a93a4a0b-c1bf-471c-873a-dda038f06588"), "HBT", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("b8e28b56-2926-4a58-ac07-abd9899a8227"), "SRM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c39fe8e3-35ec-48b2-918a-595ed73094db"), "HHM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("c9ea8880-4dc4-4e77-870e-9f1d0a17cc15"), "HSM", true, true, "[0,1]", 24m, 24m, 2024 },
                    { new Guid("f1000507-ed3b-4a3c-9ce8-6db48a3e8d02"), "SME", true, true, "[0,1]", 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 1,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 2,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 3,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 4,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 5,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "AdmissionInformation",
                keyColumn: "AdmissionInformationID",
                keyValue: 6,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 15, 3, 11, 38, 876, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "3b93e1bf-759c-4ed7-8cb6-e2179dd4755f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "21ecfdf6-019f-43f9-bf12-8dbd994da3f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "a1a2db2f-382b-4d17-947e-604dba56b801");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "6d65c1a8-acc6-4d9e-be06-920db1cb2041");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "edf51237-f58e-4811-82f5-f6c561b1ccdb");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("75d12c81-6c25-4b74-8edd-602f97098745"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("d860dfdc-ed6c-428e-929e-b140d4aaf4c0"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }
    }
}
