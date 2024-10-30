using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGStudentProfileupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "TypeofStatus",
                table: "StudentProfile",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9401a0dc-46bf-438b-8b6c-e0a702b4714e", "AQAAAAEAACcQAAAAEKnEZxXxqTv3aP+OTPqDFsQSR4Zww/QYTQ087e3/nC7u5r6U48iQKWslcdz0nVn/3Q==", "8e9e4f49-24c6-419d-b455-42a3a7766fc1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42a3787b-2d58-460c-8320-9505ad6f8d0a", "AQAAAAEAACcQAAAAEL39sCr8K+1+FjTSkxsQGM+cWceqaTl7cnulPZCq75flWw9l2R6SWuKHSO+xvc4gew==", "4d30dfbf-ac3f-4604-a45a-45227b5ae03e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e94af06-b90f-410a-9a64-101ea3b82970", "AQAAAAEAACcQAAAAEDcQnfiIu6SgCLH7PCgW7a+cVqsklpPETDhmVDES9rHJEX2UL2uWptAKzP3UYDSVLQ==", "363301d2-6f79-41cf-b95f-2626d6d9ffea" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af305abf-3949-48cd-b561-0cfdaac24c1b", "AQAAAAEAACcQAAAAELfrYg5VlxspWMEzSPESPtJMjlmB3+XhVbh7S+H6jXDxGu2asl8gip2jjrQ785OgWw==", "a3a57e29-aca0-452b-b90d-57b65efd3add" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2db63efd-a3e4-46a3-8827-0d77e3a7050e", "AQAAAAEAACcQAAAAELmoKWOVPocPUR+Ii4XDyGC5hx84eGUtaeSNws0wFAZJf2LOQ7gjxGzkSJTx1RU0hg==", "c5791371-c90d-476a-a2d3-e66c57058ce3" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "acc6f57f-eaec-4f0f-aed7-8e6942160fa5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "25d9f4df-19bb-4589-a260-505f60ed983a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "40e4a6b1-4468-42d7-9d82-f0bbd2ddc308");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "42e66bb1-a1fc-48b3-820b-241ae680abd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "60bd60b3-b84a-448e-9035-4f595f88ffa6");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("26ab7b98-c27b-4802-bf19-101a307c1b36"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("bb031d07-12f2-41a9-b565-c544ab587826"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailsPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "TypeofStatus", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("08d6820d-f66c-4483-a84e-e8c2e08e0d40"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9923), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 11, 53, 31, 672, DateTimeKind.Local).AddTicks(9926), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, 0, null, null, null, null, null, null, null, 0, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("26ab7b98-c27b-4802-bf19-101a307c1b36"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("bb031d07-12f2-41a9-b565-c544ab587826"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("08d6820d-f66c-4483-a84e-e8c2e08e0d40"));

            migrationBuilder.DropColumn(
                name: "TypeofStatus",
                table: "StudentProfile");

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
    }
}
