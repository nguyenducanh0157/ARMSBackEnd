using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdateStduentProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("55eced62-26e1-49d3-9745-f4e27ba8b082"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c00b1e24-d669-4398-bd76-7d3b8f9b59c8"));

            migrationBuilder.AddColumn<string>(
                name: "AdmissionForm",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthCertificate",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e6e708e2-468b-4b97-8b23-d182b2c899c1"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f4030b5c-5135-46da-b7e2-63db7ab6a2eb"));

            migrationBuilder.DropColumn(
                name: "AdmissionForm",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "BirthCertificate",
                table: "StudentProfile");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dd439ee-1e0e-4855-a9e3-49a2a4e42e1b", "AQAAAAEAACcQAAAAEKHaKyG2xnqBmaUuPhPX2K1DeilGF8EbXeP3qW8m0P05LaTnICUgUi67V5A7Royk1w==", "1589ac53-a084-494f-8db6-9d657d2f1ef6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e4ec17b-57ea-4399-b9bf-88d8d1f079c0", "AQAAAAEAACcQAAAAEEHgsJJ7/J5uWqbmW9/yLeX14MoyQtMN3BBNkLnrsWcxrcnRALQq4P/uNHbp3hMINw==", "db3978fb-0cfe-4593-afe1-68ff6644431c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b32325e9-0cbb-4707-8671-f4c32de15e56", "AQAAAAEAACcQAAAAEGR2Jf0uW+nsIpwOlJ3PFmQMAHSCuXf+D3XNpkRZJq/FlRbECH/9fDJbUx7lufmkhQ==", "f5e02404-6395-4f0b-9599-a291ee40790a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fd2b4b8-6431-4353-887d-9bd1bf5b5ce2", "AQAAAAEAACcQAAAAEI5Br9hf1Byd74Bp+vryprAZHT4oc9DSsmRV0IFQe1Hd+MTTUFEpzadVA03+dAsOuQ==", "7377acf3-b1bd-497a-8d06-eef1544ca332" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8984006e-bf95-45f8-abb0-cb5ef82a1abb", "AQAAAAEAACcQAAAAENkE8bGT6n6bhwu38qceg4WbpenXQAN63JUX/SnmNyRbfVG9b25w1ooRbnw8O2PWsw==", "b95cd8f9-f862-48fd-b711-6ee8bc915117" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "b95f6d18-e066-4845-b238-f3ffc92e0211");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "2ee7dcd0-3915-471f-acbb-dd8f790fec28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "8362bb1a-95e9-4537-add6-e1a7c31144cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "0d8292ba-c124-4e03-9f55-d7b93e2fedb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "7f105579-df9d-4fd5-83c4-0925e252962c");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("55eced62-26e1-49d3-9745-f4e27ba8b082"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("c00b1e24-d669-4398-bd76-7d3b8f9b59c8"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2905), new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2907), new DateTime(2024, 11, 16, 14, 8, 13, 969, DateTimeKind.Local).AddTicks(2910) });
        }
    }
}
