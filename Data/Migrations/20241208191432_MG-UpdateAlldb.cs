using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdateAlldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_Major_Major1",
                table: "StudentProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_Major_Major2",
                table: "StudentProfile");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0adbc540-f58a-4ae3-bc54-00c1a5fb0cd0"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("af2e014d-0e1a-4f94-862f-41ebc3de3727"));

            migrationBuilder.DropColumn(
                name: "ImgCitizenIdentification1",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "ImgCitizenIdentification2",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "TypeOfDiplomaMajor1",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "TypeOfDiplomaMajor2",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "TypeOfTranscriptMajor1",
                table: "StudentProfile");

            migrationBuilder.DropColumn(
                name: "isMajor1",
                table: "AcademicTranscript");

            migrationBuilder.RenameColumn(
                name: "TypeofStatusMajor2",
                table: "StudentProfile",
                newName: "TypeofStatusMajor");

            migrationBuilder.RenameColumn(
                name: "TypeofStatusMajor1",
                table: "StudentProfile",
                newName: "TypeOfTranscriptMajor");

            migrationBuilder.RenameColumn(
                name: "TypeOfTranscriptMajor2",
                table: "StudentProfile",
                newName: "TypeOfDiplomaMajor");

            migrationBuilder.RenameColumn(
                name: "Major2",
                table: "StudentProfile",
                newName: "MajorID");

            migrationBuilder.RenameColumn(
                name: "Major1",
                table: "StudentProfile",
                newName: "Major");

            migrationBuilder.RenameColumn(
                name: "ImgDiplomaMajor2",
                table: "StudentProfile",
                newName: "ImgDiplomaMajor");

            migrationBuilder.RenameColumn(
                name: "ImgDiplomaMajor1",
                table: "StudentProfile",
                newName: "ImgCitizenIdentification");

            migrationBuilder.RenameIndex(
                name: "IX_StudentProfile_Major2",
                table: "StudentProfile",
                newName: "IX_StudentProfile_MajorID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentProfile_Major1",
                table: "StudentProfile",
                newName: "IX_StudentProfile_Major");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0763975-baae-40d2-9f9f-eec9277adce4", "AQAAAAEAACcQAAAAEHCwMk37AWJnQPJLc0vJKMhy8fpNV/nhesEsOpEUOfFPmqU7ggelT3Bc3hP2TO3QWA==", "42cee4a5-8fa3-4e3f-98ad-e86cccc06254" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abcc990a-4889-4a9c-9990-92ec77b8de3c", "AQAAAAEAACcQAAAAEDGYxIimuu7FwqJlIX6sOb0r8XYoL1oXJtmW5RLLTWW5POGnv4WCSF4huSGM1BXWZA==", "d692f77b-3ad4-41b4-b9b6-0bb5a8bb67fc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d2d7bd4-5584-4fa5-abaf-e413aaeca8ed", "AQAAAAEAACcQAAAAEBynHLT3favSGEJd+MZ96VSKIOnXfxojZqee1iTD7+XLcMRqsH6ZYTN1GUkxUml7+Q==", "9c296ea0-9553-489a-896e-5f41fb16ab17" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75422eb3-9b23-421b-aeeb-8816e72ccabd", "AQAAAAEAACcQAAAAEAp56Gttst8KmSOLmUSCGEDw1JhBFzqKSIbcTPE4CEzlp2W2vRDgX6CEuCyDM2mIvw==", "47a56d4c-5a81-41d6-8ac0-1bc5279b3e08" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e50e946-9283-4365-8b0c-f65baa50807a", "AQAAAAEAACcQAAAAEDEfjNLKuue1xKxPttQ17gB8pLPzwGcNcyM4qDD1JzSc4EF1xEz0lYz9pKA8cM+HNA==", "acb169b6-24be-441c-a17e-0a1b27acfd80" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 9, 2, 14, 30, 174, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "0c01dc16-9f90-49d8-bf36-d96e34b0cd37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "c998f2cd-5d54-4eab-9ab9-f3b5b1faecbf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "52e17035-4194-4705-91b4-a86717e71c59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "4d7162d7-11a0-4cfb-a70a-b81f4baf42ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "f884db6e-d123-40f1-b505-9e0210619d50");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("27936ee8-bf7a-440b-ac3f-9dd0c60d0950"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("7dbe6c5e-5c15-4595-afbc-84e5df4dbb4f"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_Major_Major",
                table: "StudentProfile",
                column: "Major",
                principalTable: "Major",
                principalColumn: "MajorID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_Major_MajorID",
                table: "StudentProfile",
                column: "MajorID",
                principalTable: "Major",
                principalColumn: "MajorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_Major_Major",
                table: "StudentProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_Major_MajorID",
                table: "StudentProfile");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("27936ee8-bf7a-440b-ac3f-9dd0c60d0950"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("7dbe6c5e-5c15-4595-afbc-84e5df4dbb4f"));

            migrationBuilder.RenameColumn(
                name: "TypeofStatusMajor",
                table: "StudentProfile",
                newName: "TypeofStatusMajor2");

            migrationBuilder.RenameColumn(
                name: "TypeOfTranscriptMajor",
                table: "StudentProfile",
                newName: "TypeofStatusMajor1");

            migrationBuilder.RenameColumn(
                name: "TypeOfDiplomaMajor",
                table: "StudentProfile",
                newName: "TypeOfTranscriptMajor2");

            migrationBuilder.RenameColumn(
                name: "MajorID",
                table: "StudentProfile",
                newName: "Major2");

            migrationBuilder.RenameColumn(
                name: "Major",
                table: "StudentProfile",
                newName: "Major1");

            migrationBuilder.RenameColumn(
                name: "ImgDiplomaMajor",
                table: "StudentProfile",
                newName: "ImgDiplomaMajor2");

            migrationBuilder.RenameColumn(
                name: "ImgCitizenIdentification",
                table: "StudentProfile",
                newName: "ImgDiplomaMajor1");

            migrationBuilder.RenameIndex(
                name: "IX_StudentProfile_MajorID",
                table: "StudentProfile",
                newName: "IX_StudentProfile_Major2");

            migrationBuilder.RenameIndex(
                name: "IX_StudentProfile_Major",
                table: "StudentProfile",
                newName: "IX_StudentProfile_Major1");

            migrationBuilder.AddColumn<string>(
                name: "ImgCitizenIdentification1",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgCitizenIdentification2",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfDiplomaMajor1",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfDiplomaMajor2",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfTranscriptMajor1",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isMajor1",
                table: "AcademicTranscript",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5eaa938-3d47-4a78-a333-8d5747a5fd68", "AQAAAAEAACcQAAAAEJYYVvY38+OD6/Gmr74ynoVrU7oXtU8RTsN//v5i/DfOeTcM/OzPaebiA6LnwR0rKg==", "305f0ebc-289f-46f6-bc62-56719c311cb8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb09af49-e7e8-4617-883c-c96f7d44fb64", "AQAAAAEAACcQAAAAEDHBfBCzxItZcnKIziL495MBaUnn+cbLm9KsJASwu7yq4sj+IhoP2a/aATbJcPt66w==", "803a41eb-4506-4e52-bcf0-d7884f411bb5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c9be63a-f154-4665-8e03-93fee1f4de40", "AQAAAAEAACcQAAAAEC+jObBBS5TOfgqjCtpx7UAW5cRmN/WZ18iy8x6wqCFeMlqR/St7VgqMrwWJqj1Pvg==", "fad1475c-d596-4b1b-853e-3ec9e07dcf4b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9580fed7-e9d7-498d-ab8b-4a72bfd3a0f5", "AQAAAAEAACcQAAAAEPhKmYYC1oyRIzBeWxqGUwuFpRjLbmXWVv7PdySJVZuConwF/38xV15LLgM0Wipa6A==", "5bf72e66-f7f1-44b1-a7d3-325f19680d07" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31983ad7-33fd-428b-b05c-94f3f4683309", "AQAAAAEAACcQAAAAEEoj1iJiCMPvlU64nyErnfjhx5utOx3miHw8eU2nju9RMTgoggUrdXVswXBjcfkl8A==", "20c19c28-4741-49e6-b18d-aebfc053c7db" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 3, 21, 43, 41, 768, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "feb43562-9bdf-4816-9656-01e0f2f80ab8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ac6e20fb-3910-4865-9ad7-20a4d3f8e306");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "dbf9f083-41d1-4d9c-afc3-71840171c9f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "bb1bcab2-908c-48d1-a872-7089d07bcbc5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "90a66d1c-d087-41d7-957a-0e669b24fe23");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0adbc540-f58a-4ae3-bc54-00c1a5fb0cd0"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("af2e014d-0e1a-4f94-862f-41ebc3de3727"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_Major_Major1",
                table: "StudentProfile",
                column: "Major1",
                principalTable: "Major",
                principalColumn: "MajorID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentProfile_Major_Major2",
                table: "StudentProfile",
                column: "Major2",
                principalTable: "Major",
                principalColumn: "MajorID");
        }
    }
}
