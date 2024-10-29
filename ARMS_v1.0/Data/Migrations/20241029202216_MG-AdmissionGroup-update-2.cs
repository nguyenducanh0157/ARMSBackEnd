using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGAdmissionGroupupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("24f93fa1-ff97-4b3e-b233-d4c6a16f92d7"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c44d79e6-a8d2-4430-b8c4-27878abdb10c"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("ed7d03b4-499e-4888-aac0-48d288d543d0"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40b1a282-77ce-4a48-8e87-fffe41aabd5d", "AQAAAAEAACcQAAAAEOUs9KKUxA2qrI26s3Z2xQzfs72ZFRfgflw39gw0t9pU6BSDOCOmkckSOutaEMCThQ==", "3d30daf3-74c0-41be-96d0-d1c1553c778b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97840a64-547f-46dd-9407-2b21d362817a", "AQAAAAEAACcQAAAAEDbNGwySPZo9I47/s07JWXJxyTcR5t8wjS4Sa55qCTrurQPj3He7nTnosyvX+8DRKg==", "359910a3-d5d4-4e33-87d5-ace777cc8fbf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90ba75d4-1d0d-4b11-877e-db4d5b0f965b", "AQAAAAEAACcQAAAAENSj3+aRqhW6MyHingPjrp2X0e/WE6p80l/hXss49G6dTzd8pBMQeTV7Oeiz2Lv2zg==", "2c8b54b3-40cb-4ab9-9b15-90617c4dd41e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c8e3139-73c7-43cb-a356-10364bcfe412", "AQAAAAEAACcQAAAAEJHNo3jH5BCmE9w+GDjaVx7AI5bzX8z5xiUnNADQqT2TxWuVhy5mXyARHJLJ6gRt2w==", "6f02f9ab-cfb8-4abf-a389-ca4e2ec0f838" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d61b0457-faf8-4749-bcea-46e03f730029", "AQAAAAEAACcQAAAAECocfILlpOoU/Y+fAbvrkLnAftnq7NUhxh0fsBGu8ZclrDyS9baHMh1SW31ffq3+7A==", "1f6db048-6bb7-4936-9d6c-b98aaa416354" });

            migrationBuilder.InsertData(
                table: "AdmissionGroup",
                columns: new[] { "AdmissionGroupId", "CampusId", "StatusScore", "StatusScoreAcademic", "SubjectGroup", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { 1, "Hanoi", true, true, 0, 24m, 24m, 2024 },
                    { 2, "Hanoi", true, true, 1, 24m, 24m, 2024 },
                    { 3, "Hanoi", true, true, 2, 24m, 24m, 2024 },
                    { 4, "Hanoi", true, true, 3, 24m, 24m, 2024 },
                    { 5, "Hanoi", true, true, 4, 24m, 24m, 2024 },
                    { 6, "Hanoi", true, true, 5, 24m, 24m, 2024 },
                    { 7, "Hanoi", true, true, 6, 24m, 24m, 2024 },
                    { 8, "Hanoi", true, true, 7, 24m, 24m, 2024 },
                    { 9, "Hanoi", true, true, 8, 24m, 24m, 2024 },
                    { 10, "Hanoi", true, true, 9, 24m, 24m, 2024 },
                    { 11, "Hanoi", true, true, 10, 24m, 24m, 2024 },
                    { 12, "Hanoi", true, true, 11, 24m, 24m, 2024 },
                    { 13, "Hanoi", true, true, 18, 24m, 24m, 2024 },
                    { 14, "Hanoi", true, true, 19, 24m, 24m, 2024 },
                    { 15, "Hanoi", true, true, 20, 24m, 24m, 2024 },
                    { 16, "Hanoi", true, true, 21, 24m, 24m, 2024 },
                    { 17, "Hanoi", true, true, 22, 24m, 24m, 2024 },
                    { 18, "Hanoi", true, true, 24, 24m, 24m, 2024 },
                    { 19, "Hanoi", true, true, 25, 24m, 24m, 2024 },
                    { 20, "Hanoi", true, true, 26, 24m, 24m, 2024 },
                    { 21, "Hanoi", true, true, 27, 24m, 24m, 2024 },
                    { 22, "Hanoi", true, true, 28, 24m, 24m, 2024 },
                    { 23, "Hanoi", true, true, 29, 24m, 24m, 2024 },
                    { 24, "Hanoi", true, true, 30, 24m, 24m, 2024 },
                    { 25, "Hanoi", true, true, 31, 24m, 24m, 2024 },
                    { 26, "Hanoi", true, true, 32, 24m, 24m, 2024 },
                    { 27, "Hanoi", true, true, 33, 24m, 24m, 2024 },
                    { 28, "Hanoi", true, true, 34, 24m, 24m, 2024 },
                    { 29, "Hanoi", true, true, 35, 24m, 24m, 2024 },
                    { 30, "Hanoi", true, true, 36, 24m, 24m, 2024 },
                    { 31, "Hanoi", true, true, 37, 24m, 24m, 2024 },
                    { 32, "Hanoi", true, true, 38, 24m, 24m, 2024 },
                    { 33, "Hanoi", true, true, 40, 24m, 24m, 2024 },
                    { 34, "Hanoi", true, true, 41, 24m, 24m, 2024 },
                    { 35, "Hanoi", true, true, 42, 24m, 24m, 2024 },
                    { 36, "Hanoi", true, true, 43, 24m, 24m, 2024 },
                    { 37, "Hanoi", true, true, 44, 24m, 24m, 2024 }
                });

            migrationBuilder.InsertData(
                table: "AdmissionGroup",
                columns: new[] { "AdmissionGroupId", "CampusId", "StatusScore", "StatusScoreAcademic", "SubjectGroup", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { 38, "Hanoi", true, true, 45, 24m, 24m, 2024 },
                    { 39, "Hanoi", true, true, 50, 24m, 24m, 2024 },
                    { 40, "Hanoi", true, true, 51, 24m, 24m, 2024 },
                    { 41, "Hanoi", true, true, 52, 24m, 24m, 2024 },
                    { 42, "Hanoi", true, true, 53, 24m, 24m, 2024 },
                    { 43, "Hanoi", true, true, 54, 24m, 24m, 2024 },
                    { 44, "Hanoi", true, true, 55, 24m, 24m, 2024 },
                    { 45, "Hanoi", true, true, 56, 24m, 24m, 2024 },
                    { 46, "Hanoi", true, true, 57, 24m, 24m, 2024 },
                    { 47, "Hanoi", true, true, 58, 24m, 24m, 2024 }
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "ec924e3f-13d7-4e6b-8ddc-f09925e4027e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ca63c412-6d66-4be3-9997-9cdca704ea25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "97520b98-fcf4-4b43-a37e-c3ae56ec0903");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "45e3cdc0-f289-4178-b2f9-c4724829e7ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "f8f2b4b4-7796-4108-9e36-249267de5692");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("65576c48-9b57-4dad-b7e2-5f15eed68d6f"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("a22836d5-3625-4c9c-bb1b-c35b7f3e29e2"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailsPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("a721c619-7b55-4796-884a-a1ff24a41ec2"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8291), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 3, 22, 14, 651, DateTimeKind.Local).AddTicks(8295), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, 0, null, null, null, null, null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AdmissionGroup",
                keyColumn: "AdmissionGroupId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("65576c48-9b57-4dad-b7e2-5f15eed68d6f"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("a22836d5-3625-4c9c-bb1b-c35b7f3e29e2"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("a721c619-7b55-4796-884a-a1ff24a41ec2"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f885ba81-b9e8-4388-b225-52c9c8053122", "AQAAAAEAACcQAAAAEH6h1H/BvSFJdQkR/NPgceU04q/kTfpoXODmuJ7Un7OqH30RgsLcv9sqcTHSOJuWhg==", "788afbc8-b0b4-40d3-935b-828b074bf330" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a9e456-3eee-4def-883b-b3a189e09315", "AQAAAAEAACcQAAAAEODhkOLgBc5jbClRwX2y6kkqVxkcDic2IzkjW53pxtilTuy5uwldirNSML+TrL4tKw==", "2b40c028-9afd-4224-a3f5-9d66c2f6fa8c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "651cf3e9-233d-4b40-aa0e-962eb170772a", "AQAAAAEAACcQAAAAEOZRqmnSxcmmyYVK0zz1Ji9Yc/+fB8p66pbBgGFl1Ua4oCX5L4gB4iBVEV231S3TAA==", "ffd7d169-87fc-48b8-97f1-759977d02cfd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51fec304-6c7e-4eaf-a00f-197340813dae", "AQAAAAEAACcQAAAAENDag5ltFrkrM54XPhR9u1++M+45Dqo7WdmhR82NHpTsa21tQbQrIM0fpE1TzNEPQA==", "121ca51a-45f0-47e0-8c50-d00d67689310" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc74b99f-14e9-42d8-a901-76ea33267256", "AQAAAAEAACcQAAAAEMYBQmukpkktbMsjZWNiNsWYcDnZ1MbF1kiBUa23g5iKvEhnwStErbDQ8BhUs2ieRQ==", "ac925dd3-d2e9-4668-93ec-2eb1ce160ec1" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "ab951d8f-6c97-4695-bf2a-c8206e523a6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "793496c7-407e-4b9b-94a0-c3e38259c8b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "32a4be4b-2d0f-479b-b3d7-a7997c3de877");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "9666d004-83a2-49ef-a3b9-8587ad83fac8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "9c864b3f-6afa-4e12-8b11-0af2121a6890");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("24f93fa1-ff97-4b3e-b233-d4c6a16f92d7"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("c44d79e6-a8d2-4430-b8c4-27878abdb10c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailsPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("ed7d03b4-499e-4888-aac0-48d288d543d0"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7738), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 2, 39, 34, 535, DateTimeKind.Local).AddTicks(7741), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, 0, null, null, null, null, null, null, null, null, null });
        }
    }
}
