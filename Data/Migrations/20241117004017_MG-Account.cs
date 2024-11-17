using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e6e708e2-468b-4b97-8b23-d182b2c899c1"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f4030b5c-5135-46da-b7e2-63db7ab6a2eb"));

            migrationBuilder.AddColumn<int>(
                name: "TypeAccount",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86c5f059-6cf1-46db-8bc8-9ff4dbc2d5a6", "AQAAAAEAACcQAAAAECItkLjg7Xz0tcOCKDSv/EcuUeiv3vHH74STnwAs66Up5RfWu5mywaUmssJTJ15VbQ==", "77eb27c9-9b7f-4fb2-a801-7d7237fef0f9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "TypeAccount" },
                values: new object[] { "0b9d7ee1-d20b-4c72-be48-ff1d3f1320b3", "AQAAAAEAACcQAAAAEBr+GUyVKgjj8HLvd35jM27mvqbwVolImKockI+HXP5Q5BkjOaoyuEXiIzKnkXqVDA==", "843703de-35e3-4dd1-8ca3-d1bdd50f03e4", 2 });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23978d9d-2ec1-4b73-ae29-3764a8e967a4", "AQAAAAEAACcQAAAAEG58E6NsjZUeZbB+9DmzceFwN46XqEt2+6Q0ejnDtd5/YxqyVH6JYafbM2E1bMn7LA==", "fd0b90af-d81a-4e2e-b47b-1a19dfa4b755" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7010dac4-1856-4f2b-8a33-262b9febe5c6", "AQAAAAEAACcQAAAAEIuJ/2fXaGSw7lynuy0w4+MsbZQwQqp4iB1MUsqBrzdptrYF8AgNK3TKlz5IuYVXFw==", "348c255f-2d11-4f40-a99a-872d40efcc22" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4df5e206-b1a5-4a10-9733-5c483a2e359e", "AQAAAAEAACcQAAAAEM4/9O99/B2qAg1oStcBB9B7Qhgkx/d/1YCKscpT5rInARghZRCKsq+Yiky0adgypQ==", "455a98cc-c0b9-4eb9-a638-fa7eac7d3d40" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "3d8a607b-e266-419d-9bf5-320c26fe0e05");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "9fb17b38-248a-43f2-a66a-a98bc2a96611");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "e3a47ebd-301d-4cf4-a636-cfb204b9745d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "568c9497-93f1-4a43-8837-bea9a5d1101d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "aaccdf3b-776e-4dda-98f5-c536ca6703eb");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("944b2933-c39b-4328-b917-26e1f30bfdc6"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("f57e8be2-ead7-480c-91b3-1a5892b0a519"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(658), new DateTime(2024, 11, 17, 7, 40, 16, 366, DateTimeKind.Local).AddTicks(660) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("944b2933-c39b-4328-b917-26e1f30bfdc6"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f57e8be2-ead7-480c-91b3-1a5892b0a519"));

            migrationBuilder.DropColumn(
                name: "TypeAccount",
                table: "Account");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53462b37-701e-4f92-aefc-c3ee1a21ad8f", "AQAAAAEAACcQAAAAELjhQzO7Y1H0JK+akd+ZMe+anP3GwSIhylYsXXXIY1RLRzJTS17hJbPnybCmzE7jgA==", "4c4d7da1-8676-4610-8a0e-fd874f9f3312" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fc4d0fe-7d6b-4378-8b49-d8e5c3cba77d", "AQAAAAEAACcQAAAAEAo/pZ/yBWTW6WvcB4L7xlP9cg/w1QIQSjpnBwX2RQJ81aguy5pR9wj8QqPuDzgU+Q==", "b2e535ea-669a-4637-95fa-3f2fb71c2017" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0889a346-b1dd-4a18-b3e2-259932bb18ff", "AQAAAAEAACcQAAAAEMbtFWGYv/i/U6H1ee9iLsfU/LUL0d5D/g15q57hYJX5BsVM/gYA7jMgx0vzuWZHHg==", "052d152b-daef-496b-b3f1-1f92399761d6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ba9fa91-df2d-433b-8a63-fb33751f187e", "AQAAAAEAACcQAAAAEEnUL2qW+zQAzhY3VFaWG0voHEs0J0tpzxzX9Qe1qLJQPJIhVBt6vN1boQ2GDlgBYQ==", "2122f96a-3007-45c4-b772-434263db75c3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c543ead6-ed49-40cc-84a3-4cde18ab4429", "AQAAAAEAACcQAAAAEPA5ftuNaTaz/x67o9XALyzfEtH7ZJQGZZFEmuOHR+r10lFbYW6xoOBJT4Qkjc5A7g==", "e7afc25e-5f4f-4643-8c8d-0c1e980bbc7a" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 461, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 462, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 15, 18, 53, 462, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "cf880944-1fed-40a2-b10c-72c9ff553178");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "eea329f6-6d43-4772-bce1-e65302aab477");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7999bd02-eb03-4f0d-a7e6-3b81cf6f033a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "03f0a8b1-ab74-4817-b4e5-729b8cff305f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "29e1f05e-86fa-44e8-8789-3c810f625a18");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("e6e708e2-468b-4b97-8b23-d182b2c899c1"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("f4030b5c-5135-46da-b7e2-63db7ab6a2eb"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 18, 53, 462, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 11, 16, 15, 18, 53, 462, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 11, 16, 15, 18, 53, 462, DateTimeKind.Local).AddTicks(18) });
        }
    }
}
