using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("16d9b2eb-a54e-472b-961d-8727d9423519"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1838dd15-9ca5-4fa4-b1c0-39154a3240d7"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"));

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
                keyValues: new object[] { 1, "HWE", 1 });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7266290-ee05-4e5b-b089-3cd04c319dc9", "AQAAAAEAACcQAAAAEBlH6Zd0Ana5go9YAusVT/ch/ojFIxhJYuB6MoRIwzYVbxpt1+veu1OOGGhxUbAEvg==", "a4c88cc7-aeb1-4b6b-b190-8b11ea2b30e9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3808deae-5015-4daa-893e-f455a616df75", "AQAAAAEAACcQAAAAEFUDqgJWt0GDn0ya+whLIFh7yihMLfOMZ63piy3y8bGu44HGiAVHDk13yxqEApSdGw==", "d449fab4-afe7-464d-aac6-22fbf8655db9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "058a72ef-2c7e-487a-a332-2854b9869304", "AQAAAAEAACcQAAAAEEar08I5gmv1DrhLUQNbnG7T6cGYOXV1vzv59xTbXauwvyDSpzMNVw64dtOYCzz2lQ==", "927a7211-8e01-4446-854a-040246681712" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87686328-d7f3-4d83-80f1-8237366777c7", "AQAAAAEAACcQAAAAEAC53pnomfsDwvXEKffQ+B1/OKdpppeZ0Avxy1i19djYpIMA4SEr9TNi9Zn1VyqfSA==", "ef090bb4-9f2b-4b6c-96b5-4f6a1b12a84a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e79d2fd-b404-4213-af15-cced82a61b48", "AQAAAAEAACcQAAAAEAI9e3qlWZ3TEToDSdLbN1LTtDrkMCSZPCboOCOadAv6+Rvk8L95t7FSbefWmwaN9Q==", "1a3a09d6-c23f-41b9-847b-50d7cfb332d0" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 23, 18, 27, 0, 15, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "d3f87afe-32d5-4fee-bd6e-2d250794ccf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "0e409c04-d7bf-4339-ac92-26df5c621b83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "aeebc4f7-3020-453a-9eaa-3d056ebda7c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "cf4d9a14-34d9-4599-9910-97e2bc58b64e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "ed134558-d3e4-4f1e-861d-47a702d3d12a");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0b240e03-52e5-4ec7-ba0c-4ee7cd7abdf3"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("c87e03d9-cb8b-4ae6-b4c3-03b4ac11a52b"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HEA", 3 },
                column: "TypeOfTranscript",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HJA", 3 },
                column: "TypeOfTranscript",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HTE", 3 },
                column: "TypeOfTranscript",
                value: 3);

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 1, "HGE", 3, 0 },
                    { 1, "HGE", 4, null },
                    { 1, "HTE", 0, null },
                    { 1, "HWE", 4, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0b240e03-52e5-4ec7-ba0c-4ee7cd7abdf3"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c87e03d9-cb8b-4ae6-b4c3-03b4ac11a52b"));

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HGE", 3 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HGE", 4 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HTE", 0 });

            migrationBuilder.DeleteData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HWE", 4 });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64f2b9eb-e91a-415d-ab5e-ad2832564739", "AQAAAAEAACcQAAAAEDehSB5iwJLUCyWic7fJrpt5fABn4+40+Phc2hPP0NktAlQ9WkJEsAYfbLu8C7njfA==", "9af40f0c-65da-4503-a0ce-9c7fceebac8f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca890697-ea9f-4a34-a389-dbcd1b915934", "AQAAAAEAACcQAAAAEOgTh0VA/9qri6e/JtDG090+zzJZ6HaEYG0ELuJsY+4F9SsoAweYy4zEDoQCFrvVxA==", "a53d53e6-3ab1-469d-854f-43f7a6bc386a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f36b277d-bf5e-47f3-bcfa-81855a70a86f", "AQAAAAEAACcQAAAAEL4trl6UumJWX++U/mS+ubIqG7VAQKbkT57a0qcGSvs2pbKp49B7UBFgfGHJtPmR9w==", "45bf4637-e0cb-49d9-baa1-27c5c2e10521" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87a02881-e7c6-488a-afdc-5a6630f02ee9", "AQAAAAEAACcQAAAAENH3aOAvb/U6KUdw7AOs8RBZkx0AOeAVvok1nndaegBUOwLCBD98+nRGml/Ee25w0Q==", "7f32db16-0cd2-4769-8393-cb19bce3b026" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "930f030f-c6af-4366-9bdc-1b539e24267e", "AQAAAAEAACcQAAAAEFvAvv1cH/nzP50Wjho8ekckwawVx/8Yphvnq5aLpKih+CRZhAB5Gv44Aj/2GWwJGA==", "0b30a3c6-79d5-4070-8016-51d7ce825c30" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "d1157fcd-48ae-41ea-a469-6b45a1022f26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "557198a0-f4d5-4580-998c-83f608d494b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "45c527c0-5094-4337-858f-7e34f65a448f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "48e9ecd5-167d-48f9-9f0c-c2169ed6e987");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "41e73ef4-83b3-4343-8267-2dcaf027a3e9");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("16d9b2eb-a54e-472b-961d-8727d9423519"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("1838dd15-9ca5-4fa4-b1c0-39154a3240d7"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AIId", "AccountId", "AddressRecipientResults", "AdmissionForm", "BirthCertificate", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgAcademicTranscript6", "ImgAcademicTranscript7", "ImgAcademicTranscript8", "ImgAcademicTranscript9", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiplomaMajor1", "ImgDiplomaMajor2", "Imgpriority", "Major1", "Major2", "Nation", "Note", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailPriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TimeRegister", "TypeOfDiplomaMajor1", "TypeOfDiplomaMajor2", "TypeOfTranscriptMajor1", "TypeOfTranscriptMajor2", "TypeofStatusMajor1", "TypeofStatusMajor2", "TypeofStatusProfile", "Ward", "YearOfGraduation" },
                values: new object[,]
                {
                    { new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), 1, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, null, null, "HCM", new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4036), "Hanoi", "038301011111", null, new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4037), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "SME", "SME", null, null, null, null, "0971341555", 1, null, null, null, null, null, new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4039), 5, 5, null, null, 1, 3, 6, null, null },
                    { new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"), 1, null, null, null, null, "Thanh Hóa", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hanoi", "038301012222", "Quảng Xương", new DateTime(2001, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoaithu1707.25@gmail.com", "Trương Thị Thu", "Nguyễn Văn A", false, "", "", "", "", "", "", "", "", "", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fcccd1.jpg?alt=media&token=a72b40d8-50e9-439a-9ded-977a7cf6eed9", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fcccd2.jpg?alt=media&token=36141516-93fa-440d-adaa-55f707818621", "", "", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fgiay-to-xac-nhan-doi-tuong-uu-tien-tuyen-sinh.jpg?alt=media&token=704b6826-0b67-4242-ad66-c515deec95fb", "HME", "HGE", "Kinh", null, true, "0971341555", "0971341555", 1, "Thanh Hóa", true, "Trường THPT A", "Số nhà 129", null, new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4050), 5, 5, null, null, 1, 3, 6, "Quảng Ninh", 2024 }
                });

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HEA", 3 },
                column: "TypeOfTranscript",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HJA", 3 },
                column: "TypeOfTranscript",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TypeAdmission",
                keyColumns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma" },
                keyValues: new object[] { 1, "HTE", 3 },
                column: "TypeOfTranscript",
                value: 1);

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "AdmissionInformationID", "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { 1, "HGE", 1, null },
                    { 1, "HGE", 2, null },
                    { 1, "HTE", 1, null },
                    { 1, "HWE", 1, null }
                });
        }
    }
}
