using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGPriorityDetailupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("dff8236f-8a4d-4cc7-9d6f-aab8149d1883"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f78668c8-42f8-4edc-affa-e8e1a72b2dab"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("7f8fce9b-7ee9-44e6-8ca5-50f751dea36a"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24dc9a02-f774-4e32-a8f5-22c5dcb57502", "AQAAAAEAACcQAAAAECtllLo0sqqLjykc6/yK8/+ZSng7CrkEJvM0LBV/tbM9BUk9EZn0GaCclD5XQFcioQ==", "766f6c76-7c42-40f7-b3d6-bb54dcaad648" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daaf6e71-2da7-4f2f-bceb-2831db701cd7", "AQAAAAEAACcQAAAAEF+Rz6Ki/fUFeQSadaUFpIuKHH6VpsY49PsByoiMuxfm4tg4CY5ulD9IA2mIl0ZBbQ==", "0112270f-9a46-4b73-85c0-045e4b3fae0d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b279c5e-65d4-4dae-87b4-5b388210e956", "AQAAAAEAACcQAAAAEO3+94WarZuCvwWeoamJ3nNCxuwrYpcrhk6XSUgEP57z4LvoVWtTtghtfX70uJ6j7Q==", "60d00837-9729-45cb-b6b2-60673670a98c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "563b2d33-d467-4004-bdfc-438d0c478cde", "AQAAAAEAACcQAAAAEAmyVONwc47lNGH9GeDVPGqlSx0VIcJUsB88xiYxeebhajDSXGXVkIUt3049qDkrkA==", "1e325f84-4b0d-4d3e-ad42-14b24aef3b54" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cae34a7c-b802-4d53-bd41-9e09f742abc2", "AQAAAAEAACcQAAAAEGjzwEyG3m7ybdwC7semuDCIc83jg/wAcGVtMRnd+itNbP81Qao8RR7LZAgErfm9hg==", "f223e458-bf6b-45d0-998e-64f83935d51e" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.InsertData(
                table: "PriorityDetail",
                columns: new[] { "PriorityID", "PriorityDescription", "PriorityName", "TypeOfPriority" },
                values: new object[,]
                {
                    { 1, "Công dân Việt Nam là người dân tộc thiểu số có nơi thường trú trong thời gian học THPT hoặc trung cấp trên 18 tháng tại Khu vực 1.", "Đối tượng 01", 0 },
                    { 2, "Công nhân trực tiếp sản xuất đã làm việc liên tục 5 năm trở lên, trong đó có ít nhất 2 năm là chiến sĩ thi đua được cấp tỉnh trở lên công nhận và cấp bằng khen.", "Đối tượng 02", 0 },
                    { 3, "a) Thương binh, bệnh binh, người có \"Giấy chứng nhận người được hưởng chính sách như thương binh;\r\n\r\nb) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ từ 12 tháng trở lên tại Khu vực 1;\r\n\r\nc) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ từ 18 tháng trở lên;\r\n\r\nd) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân đã xuất ngũ, được công nhận hoàn thành nghĩa vụ phục vụ tại ngũ theo quy định;", "Đối tượng 03", 0 },
                    { 4, "a) Thân nhân liệt sĩ;\r\n\r\nb) Con thương binh, con bệnh binh, con của người được hưởng chính sách như thương binh bị suy giảm khả năng lao động từ 81% trở lên;\r\n\r\nc) Con của người hoạt động kháng chiến bị nhiễm chất độc hóa học bị suy giảm khả năng lao động 81% trở lên;\r\n\r\nd) Con của Anh hùng Lực lượng vũ trang nhân dân; con của Anh hùng Lao động trong thời kỳ kháng chiến;\r\n\r\nđ) Con của người hoạt động kháng chiến bị dị dạng, dị tật do hậu quả của chất độc hóa học đang hưởng trợ cấp hàng tháng.", "Đối tượng 04", 0 },
                    { 5, "a) Thanh niên xung phong tập trung được cử đi học;\r\n\r\nb) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ dưới 12 tháng ở Khu vực 1 và dưới 18 tháng ở khu vực khác;\r\n\r\nc) Chỉ huy trưởng, Chỉ huy phó ban chỉ huy quân sự xã, phường, thị trấn; Thôn đội trưởng, Trung đội trưởng Dân quân tự vệ nòng cốt, Dân quân tự vệ đã hoàn thành nghĩa vụ tham gia Dân quân tự vệ nòng cốt từ 12 tháng trở lên, dự thi vào ngành Quân sự cơ sở. Thời hạn tối đa được hưởng ưu tiên là 18 tháng kể từ ngày ký quyết định xuất ngũ đến ngày ĐKXT.", "Đối tượng 05", 1 },
                    { 6, "a) Công dân Việt Nam là người dân tộc thiểu số có nơi thường trú ở ngoài khu vực đã quy định thuộc đối tượng 01;\r\n\r\nb) Con thương binh, con bệnh binh, con của người được hưởng chính sách như thương binh bị suy giảm khả năng lao động dưới 81%;\r\n\r\nc) Con của người hoạt động kháng chiến bị nhiễm chất độc hóa học có tỷ lệ suy giảm khả năng lao động dưới 81%.", "Đối tượng 06", 1 },
                    { 7, "a) Người khuyết tật nặng có giấy xác nhận khuyết tật của cơ quan có thẩm quyền cấp theo quy định tại Thông tư liên tịch số 37/2012/TTLT- BLĐTBXH-BYT-BTC-BGDĐT ngày 28 tháng 12 năm 2012 của Bộ Lao động - Thương binh và Xã hội, Bộ Y tế, Bộ Tài chính và Bộ GDĐT quy định về việc xác định mức độ khuyết tật do Hội đồng xác định mức độ khuyết tật thực hiện;\r\n\r\nb) Người lao động ưu tú thuộc tất cả thành phần kinh tế từ cấp tỉnh, cấp bộ trở lên được công nhận danh hiệu thợ giỏi, nghệ nhân, được cấp bằng hoặc huy hiệu Lao động sáng tạo của Tổng Liên đoàn Lao động Việt Nam hoặc Trung ương Đoàn TNCS Hồ Chí Minh;\r\n\r\nc) Giáo viên đã giảng dạy đủ 3 năm trở lên dự tuyển vào các ngành đào tạo giáo viên;\r\n\r\nd) Y tá, dược tá, hộ lý, y sĩ, điều dưỡng viên, hộ sinh viên, kỹ thuật viên, người có bằng trung cấp Dược đã công tác đủ 3 năm trở lên dự tuyển vào đúng ngành tốt nghiệp thuộc lĩnh vực sức khỏe.", "Đối tượng 07", 1 }
                });

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "b10873b0-a9cb-4a76-bd2f-040f4da4af18");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "c067c005-f557-46d5-95d7-0732d5b8a4c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "8c1272d7-8e21-489e-96f3-8bc8c21ac5a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "edf252fa-02d5-47c5-b546-23fdd50dee44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "c1c30030-7277-4614-af7f-c73986963fd5");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("b735881f-8a18-4cf5-8831-b2b9b72dfce8"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("e4608a42-d507-4020-882f-58ef5cebe3b1"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("4055539e-e722-4338-8a9b-352ec234200d"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2519), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 0, 42, 38, 737, DateTimeKind.Local).AddTicks(2523), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PriorityDetail",
                keyColumn: "PriorityID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PriorityDetail",
                keyColumn: "PriorityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PriorityDetail",
                keyColumn: "PriorityID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PriorityDetail",
                keyColumn: "PriorityID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PriorityDetail",
                keyColumn: "PriorityID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PriorityDetail",
                keyColumn: "PriorityID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PriorityDetail",
                keyColumn: "PriorityID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("b735881f-8a18-4cf5-8831-b2b9b72dfce8"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e4608a42-d507-4020-882f-58ef5cebe3b1"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("4055539e-e722-4338-8a9b-352ec234200d"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e317723-ebeb-4a11-91ce-b64197175986", "AQAAAAEAACcQAAAAEGufOBdnn4PBc5mbuNAhznZkW+M0Bf+e/eru8LQyDZq8D0081ekyxU4YHgl3lx+j2g==", "5df19b9b-8c36-4b3e-bd86-b7e6456c6215" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df3ffd6d-171c-4aa6-b84e-4cb9e5748e0f", "AQAAAAEAACcQAAAAEDR6YqVRznpley1CQe4K2QJIyX993NPhuGoNKmm/hLUeXvGiOm1ZJRX8YF5UHjBTyw==", "d32ff22d-d591-4118-b84f-2f53d6edb57e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bb6fee3-b1b3-4709-859a-4945fa233b05", "AQAAAAEAACcQAAAAEJscBCqB+anjO9sTb5IBCljJgRIp63KbTFDR0SMcZRdEblmlJztGOluVvRgcOfrvPw==", "6db6bd33-d01f-4299-a790-4aa5e58181c1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a549258-7163-4ca6-ad16-5923cb33b9db", "AQAAAAEAACcQAAAAEKlhbAvFbgG7OvD21ICSDRB1fcqYFd/GxQJwmeJH8QIBnfUz6F84g1NzS+K0zUnhTw==", "1a3c8eb9-9407-4a12-8d40-975744682a50" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1225e677-8a55-41d2-a230-ed189a12356b", "AQAAAAEAACcQAAAAENxExQZPKgQsUIW+0rZhYxZdJ41UC7wQkUUZbZUn+l1Q3wMAYSlcWrd3YRuSAInMJw==", "3b2d6e27-d958-4ec6-b188-0a66b5ee4383" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "RequestChangeMajor",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "c708d143-2582-47fd-961e-8389c853cf47");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "05dd8c12-b6b0-468b-86b0-6965b646b66a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "c1bce356-c7a0-4cf7-8559-b5bd55759287");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "8651952f-76a9-4f0e-894e-f66da6fb95e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "79bfe744-dc08-470c-a59b-bdb3b10bded8");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("dff8236f-8a4d-4cc7-9d6f-aab8149d1883"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("f78668c8-42f8-4edc-affa-e8e1a72b2dab"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("7f8fce9b-7ee9-44e6-8ca5-50f751dea36a"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4700), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 0, 31, 3, 356, DateTimeKind.Local).AddTicks(4707), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, null, null, null, null, null, null, null, null });
        }
    }
}
