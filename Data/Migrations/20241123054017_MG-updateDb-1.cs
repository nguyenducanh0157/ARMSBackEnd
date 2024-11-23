using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdateDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("2d21615e-f68e-4b52-9501-a07392fa4af5"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("9ff2d15d-b75e-4bee-bccb-26772375d547"));

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

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"),
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4036), new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"),
                column: "TimeRegister",
                value: new DateTime(2024, 11, 23, 12, 40, 15, 531, DateTimeKind.Local).AddTicks(4050));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("16d9b2eb-a54e-472b-961d-8727d9423519"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("1838dd15-9ca5-4fa4-b1c0-39154a3240d7"));

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
                columns: new[] { "CIDate", "Dob", "TimeRegister" },
                values: new object[] { new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2311), new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "SpId",
                keyValue: new Guid("f2ecd63d-b1c3-4112-aa7e-2634e7aa2dde"),
                column: "TimeRegister",
                value: new DateTime(2024, 11, 22, 21, 28, 10, 794, DateTimeKind.Local).AddTicks(2331));
        }
    }
}
