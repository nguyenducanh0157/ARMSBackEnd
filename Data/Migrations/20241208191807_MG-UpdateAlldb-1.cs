using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGUpdateAlldb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("27936ee8-bf7a-440b-ac3f-9dd0c60d0950"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("7dbe6c5e-5c15-4595-afbc-84e5df4dbb4f"));

            migrationBuilder.RenameColumn(
                name: "ImgCitizenIdentification",
                table: "StudentProfile",
                newName: "ImgCitizenIdentification2");

            migrationBuilder.AddColumn<string>(
                name: "ImgCitizenIdentification1",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c60dc3db-3130-4cf9-93fe-c3b985f8e272", "AQAAAAEAACcQAAAAEMHWNU5DFYvxwATkPQ5Y34HRJUYjEs7wPtI18NxgakVOMZvwCSDsK8AMPfaxNhoyyQ==", "5177b53a-f758-4cb0-a21b-a176adf009bf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a91ac35e-2188-453a-9e1d-59fb8033e81e", "AQAAAAEAACcQAAAAEOQWioix5EoRfecVOKIaNJrvZiMVDQ0a0mQRUL5nAZs9JaoyN4MNf5BGEcILvtuVPw==", "c60888c4-b1b1-48a5-a5ee-aa408c78a658" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f685bf31-7d9a-433b-860e-a1a272be14da", "AQAAAAEAACcQAAAAEE8PgUjpEQhuIkSfbsHz39Hcus2C9uuYhZJRu735Vo9wsNUuMiRTmOO/QDxqwxqPbA==", "b98556b7-c6a8-431f-8b91-26e7a348df8c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02c074d5-f96b-4d36-9da7-ef1727aae454", "AQAAAAEAACcQAAAAEF7PUk2jee2SW+cTCUjPSaPwL0bQA6bh6aQ9sfiK6o7JkavWLeOcKuHhNona6eRh9Q==", "7902aa2b-c75a-408e-a590-48f7d9bf2a12" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "036e4779-a151-4216-a2bf-17e1c5157dcf", "AQAAAAEAACcQAAAAEL3yuPRvKMg0i7rjyilb+hrofhiajc4stvHDuaPYAUR7M6wlrA6aQV9irDJomy+UaA==", "2104f0e5-e1d8-48df-be42-90c616ed89ad" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 12, 9, 2, 18, 5, 852, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "e8b6869b-062a-4b15-98d0-edcd2fb60bb7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "075b620e-9955-49aa-bb56-7482924e65ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "d3aee74d-a7e2-48c0-b713-1f7c633847f3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "2dcf854b-0e2f-411f-8cab-4422d16cd494");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "37dfb911-069d-4f8e-b2d7-c485060d6dbf");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("b4f0b0b4-d8ad-427f-91fe-159cd3007a97"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("e5ac9f1b-8fc5-4c9f-acda-f8da0a4b840d"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("b4f0b0b4-d8ad-427f-91fe-159cd3007a97"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("e5ac9f1b-8fc5-4c9f-acda-f8da0a4b840d"));

            migrationBuilder.DropColumn(
                name: "ImgCitizenIdentification1",
                table: "StudentProfile");

            migrationBuilder.RenameColumn(
                name: "ImgCitizenIdentification2",
                table: "StudentProfile",
                newName: "ImgCitizenIdentification");

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
        }
    }
}
