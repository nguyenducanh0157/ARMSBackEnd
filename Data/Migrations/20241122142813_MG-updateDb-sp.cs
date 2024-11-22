using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdateDbsp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1916fe0a-4b70-4451-9400-e23b85037909"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("f2d5c9aa-1d08-402c-b461-0e98e93d5e8e"));

            migrationBuilder.AlterColumn<string>(
                name: "Major2",
                table: "StudentProfile",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Major1",
                table: "StudentProfile",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3664745e-7796-4d79-be6f-af9b3edbe5ec", "AQAAAAEAACcQAAAAELnM87tqNfv2S6QpSaim1hcMTu5OTZFH6Gtae9ePfWloA1sguCf/ZxEGkJmPns7Q/w==", "efafe7d3-4d37-4d1c-ab98-d62d14da0648" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0bd8eda-0286-4e4e-90f2-375dc99ca8b2", "AQAAAAEAACcQAAAAEIY63k1hPvpdkSHrAjEoKpRXnTRCtkGU7cg9PQh2lHMl+cMOOa7mr5wYW42CQvyKaQ==", "05f74a47-dba1-4513-b392-80bafa6c41b8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa02e9b4-3eb3-4a73-97e3-b8665a00eaca", "AQAAAAEAACcQAAAAEKnczhJiwM4GelQee5WGMc0zL719HCdMl2eoIzlXL4SaNl0BvB3tBTFGTjJ+EZzEBA==", "0b988cb6-5255-4028-b649-f4e3947e787b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c37fe917-39be-44e7-b347-b5d3d0d344e6", "AQAAAAEAACcQAAAAEBB1y60HSgvqCmhv65CEjWZ4VHrv8DbrE8xRikfNwjMbv+Eg23nzqkNmfnSuMYhNeg==", "d77a549d-cb43-4a06-bfbf-0a66abf333c0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3364d0e-8b3d-488e-b569-83a2dcb763b5", "AQAAAAEAACcQAAAAEP0wChUbX8KJuznixsIIx+8tN6xehXF08wCb6R3dXeDbpYgu/fllU1dOQLH5AB56Yw==", "0d64bc78-bbad-41a3-9ee4-abbcab838afe" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "62da28d7-3b7e-4475-86a2-29d6a3cc4eec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "e0b09c6d-eabc-4faa-842b-36e7c2821ebd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "f446eaf4-4fc0-40f2-b17d-b70bf4079a7a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "72b29294-4d49-4859-9441-80df53d01364");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "eb50b016-7498-42f6-a417-14ecff11c94a");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("2d21615e-f68e-4b52-9501-a07392fa4af5"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("9ff2d15d-b75e-4bee-bccb-26772375d547"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "Major2", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2311), new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2313), "SME", new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"),
                column: "TimeRegister",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_Major1",
                table: "StudentProfile",
                column: "Major1");

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_Major2",
                table: "StudentProfile",
                column: "Major2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_Major_Major1",
                table: "StudentProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentProfile_Major_Major2",
                table: "StudentProfile");

            migrationBuilder.DropIndex(
                name: "IX_StudentProfile_Major1",
                table: "StudentProfile");

            migrationBuilder.DropIndex(
                name: "IX_StudentProfile_Major2",
                table: "StudentProfile");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("2d21615e-f68e-4b52-9501-a07392fa4af5"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("9ff2d15d-b75e-4bee-bccb-26772375d547"));

            migrationBuilder.AlterColumn<string>(
                name: "Major2",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Major1",
                table: "StudentProfile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1029df6-f937-40b0-b012-c49d96a3857b", "AQAAAAEAACcQAAAAEDNDI0Iru/c3jQLOH5r91uwB+cV2xRQGah75x7nHrCdlRI77DXDoy23FHZRF1EzgYQ==", "39dfcd3b-225e-4615-a25b-d2bd0f161566" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efc3c478-8626-4db3-8a43-15c5ab1c7923", "AQAAAAEAACcQAAAAEAROwsZ1h5h3Y5YYaFkHZHXs5uJg+GzcSiUez3oJpuoBf70u0g4oT8//QCBMZ9V2MA==", "ab6f4423-a148-4e40-a539-bb2fc1d571af" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce4a2828-77c8-4b86-bbfd-28cd9a64ad9d", "AQAAAAEAACcQAAAAEDUVs4wSDnHWKkHjn6h6cMF86klOdGiOnpA33K1mWbMr7oNzMXWKSxPr/LgNtzi8kg==", "dfc8df40-e261-4d69-83e7-be1bd58481ba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f4a681b-12fe-4739-81aa-5eafb7dc4fd5", "AQAAAAEAACcQAAAAEMzdVdNnIZoJbFHgYJmfEXAmI9122WVS9pdkC+xXqAuY/RRW8DXuELpSg9Ipr+LmPQ==", "4e539117-9c46-4343-86d2-04fb583b150b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5853a80-4f5a-4967-8236-8ba2eca4b869", "AQAAAAEAACcQAAAAECeFBK9snQk1HkM63iSqfcuk4WR8N9WhipJhANqKVbNQenqwNOy5IbKZLB34w4NXbA==", "fb6715a8-aece-403d-badb-325fcb9ef342" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "1da91266-43dd-479b-88d8-ab59bb245c57");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "dcd349eb-32ec-4c40-8c34-357c56c09a84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "10dfd37b-8ce0-47f7-96bf-d9f032465d85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "531b6a81-1638-4f6b-b001-917bf6cf3bd1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "fd8736ba-b69a-43bb-ae58-62a6042f8019");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("1916fe0a-4b70-4451-9400-e23b85037909"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("f2d5c9aa-1d08-402c-b461-0e98e93d5e8e"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "Major2", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6301), new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6302), "HCM", new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"),
                column: "TimeRegister",
                value: new DateTime(2024, 11, 22, 18, 35, 1, 930, DateTimeKind.Local).AddTicks(6319));
        }
    }
}
