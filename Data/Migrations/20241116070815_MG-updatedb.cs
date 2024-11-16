using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("915109af-3373-4127-90c2-e8d76e18fd35"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("98a9304a-7ff2-499d-a2ba-97a47d4452f9"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "4dd439ee-1e0e-4855-a9e3-49a2a4e42e1b", "AQAAAAEAACcQAAAAEKHaKyG2xnqBmaUuPhPX2K1DeilGF8EbXeP3qW8m0P05LaTnICUgUi67V5A7Royk1w==", "1589ac53-a084-494f-8db6-9d657d2f1ef6", true });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "6e4ec17b-57ea-4399-b9bf-88d8d1f079c0", "AQAAAAEAACcQAAAAEEHgsJJ7/J5uWqbmW9/yLeX14MoyQtMN3BBNkLnrsWcxrcnRALQq4P/uNHbp3hMINw==", "db3978fb-0cfe-4593-afe1-68ff6644431c", true });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "b32325e9-0cbb-4707-8671-f4c32de15e56", "AQAAAAEAACcQAAAAEGR2Jf0uW+nsIpwOlJ3PFmQMAHSCuXf+D3XNpkRZJq/FlRbECH/9fDJbUx7lufmkhQ==", "f5e02404-6395-4f0b-9599-a291ee40790a", true });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "1fd2b4b8-6431-4353-887d-9bd1bf5b5ce2", "AQAAAAEAACcQAAAAEI5Br9hf1Byd74Bp+vryprAZHT4oc9DSsmRV0IFQe1Hd+MTTUFEpzadVA03+dAsOuQ==", "7377acf3-b1bd-497a-8d06-eef1544ca332", true });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "8984006e-bf95-45f8-abb0-cb5ef82a1abb", "AQAAAAEAACcQAAAAENkE8bGT6n6bhwu38qceg4WbpenXQAN63JUX/SnmNyRbfVG9b25w1ooRbnw8O2PWsw==", "b95cd8f9-f862-48fd-b711-6ee8bc915117", true });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("55eced62-26e1-49d3-9745-f4e27ba8b082"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c00b1e24-d669-4398-bd76-7d3b8f9b59c8"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "c3acef0c-74eb-4e34-a898-ebf2306eddfd", "AQAAAAEAACcQAAAAEO2ETvL7f2lL+EiX/KSM3BHMZZWhdaYpmQhnJTqlO4SNckU+96Uv4ExprCXkJ8F5RQ==", "b2804cf3-07f1-4f9d-ba83-66396491492b", false });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "1bfbd41f-2410-4fad-9b3e-0fa2b5824f75", "AQAAAAEAACcQAAAAEPCkE3yM6sv6Hhq9LscOguGIj6b8V+v92qcwG2z7lcS/aDf1SKJ/2dLwgjKrIlzgUg==", "852b2442-e372-4903-821f-8998f80b42c7", false });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "42df628a-134a-453b-ace9-7c0ab4ac0c22", "AQAAAAEAACcQAAAAEPzbygPM6a/nvMnqtP5HSB2geIS7iV014ikrKelzKA0InsvmGJW0wujDUwHDx8YXXg==", "b8424a2e-9c9a-4740-8382-c532359fac52", false });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "f13655d5-1c7b-406d-bd41-1ebdff3f30a3", "AQAAAAEAACcQAAAAEM/FEAHUQGuT3eocfm+OXTgSaPLFA7ZSAbqCpC9YKG8hF4cxRwc0vKxtqZLgf+yX8g==", "360d6d47-d1fb-45de-ac3c-854c1a925066", false });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "isAccountActive" },
                values: new object[] { "a30df940-abbe-4065-a7f7-27d86217d50b", "AQAAAAEAACcQAAAAEBmza1DA8+N0iT+TxapEtMlCtpSm37bfAj1dKlfccsOrkSa/imfv5puWSTxsJ7KWdg==", "a3adf2be-c0fa-4472-9af8-015859f9a05a", false });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "dad8b1f1-5cc1-4f5b-964a-83b8f9509875");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "0fc0cb28-b843-4aea-acd1-1727c44496d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "719e6704-4bfc-49c7-989f-ade4946ee911");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2afbb223-2937-4825-bf81-e853183c5d10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "68800f98-4fe7-4b88-8ac3-52fd30f9b9d1");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("915109af-3373-4127-90c2-e8d76e18fd35"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("98a9304a-7ff2-499d-a2ba-97a47d4452f9"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5467), new DateTime(2024, 11, 16, 10, 42, 1, 325, DateTimeKind.Local).AddTicks(5469) });
        }
    }
}
