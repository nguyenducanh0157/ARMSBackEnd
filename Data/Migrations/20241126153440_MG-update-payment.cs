using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGupdatepayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PayFeeAdmission",
                table: "PayFeeAdmission");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("0764f7b0-0147-42ce-9047-bdd53c3cde39"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("c6b1243f-e357-4583-b0e5-2ae77fe214e1"));

            migrationBuilder.AlterColumn<string>(
                name: "TxnRef",
                table: "PayFeeAdmission",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PayFeeAdmission",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PayFeeAdmission",
                table: "PayFeeAdmission",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e452016-e8fc-40d1-bcf0-3c1f1bd1fd18", "AQAAAAEAACcQAAAAEGC8h/hQEquN+P529UC4c1EdvdH+yjBpigOo6leuDhW+X7fHVHDxy0UX6VmWtLNNdA==", "fa183d47-b697-4d78-a361-3880efe7c4af" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ae367e1-9a9a-45fe-8acf-a54e151d228b", "AQAAAAEAACcQAAAAENsGExXiRnqpy65YNoDyOrjnDx7Z0m18whIfg6efnhjHs0Gb4m1618Eq4dQeKdwKdg==", "48ba6b8d-e24f-4dde-9ccb-88ceed7b511b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f802a4b-58fd-4ba5-acb1-ff6445979c0d", "AQAAAAEAACcQAAAAEGExf7BCocbfsLfI9R7vIGFEiuiFLTT6wQ5iYZztyxWc+ts8pZiTIiLAbOfbbpk2YA==", "4813adff-f933-4417-835b-4c0e1a8bc9f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0020b670-3e2c-4dda-a679-f2073b0ade04", "AQAAAAEAACcQAAAAEERM4nNxNccp/a0SLmuQ0IxGqyOA7IDcjuzMiPiM09Xp1oXD874mes3TkFFsWBOkiw==", "13a16a85-48ca-47d0-8fa0-7ac0146c99f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0159b95-921f-404a-9b10-3b5f595ed438", "AQAAAAEAACcQAAAAEOJxyK9gimvgWy8R4t0bbAK6rDx9ucv9BoiJVbpdPYEUeaQHH+IPhuYV1JNGbY+TfQ==", "56ef9ae4-3c34-45bf-82ea-15f376c32922" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 22, 34, 37, 927, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "57bf4ca0-ef27-43a9-96e8-ce8b3baee87b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "ee2f11ec-08ee-48c9-96ee-39167d2803b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "5fe5f0b0-1dd8-4849-b045-38b84e33d580");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "d461392d-2684-4091-aac4-e5bef562c1b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "3aa3da03-19c7-44cf-9be2-5d3f2f9d7a05");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("77550752-bddc-4a10-88ca-4b2028b421f5"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("d4668c5d-0801-42a6-9694-a135ee78ecc0"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PayFeeAdmission",
                table: "PayFeeAdmission");

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("77550752-bddc-4a10-88ca-4b2028b421f5"));

            migrationBuilder.DeleteData(
                table: "StudentConsultation",
                keyColumn: "StudentConsultationId",
                keyValue: new Guid("d4668c5d-0801-42a6-9694-a135ee78ecc0"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PayFeeAdmission");

            migrationBuilder.AlterColumn<string>(
                name: "TxnRef",
                table: "PayFeeAdmission",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PayFeeAdmission",
                table: "PayFeeAdmission",
                column: "TxnRef");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("17baf918-d5d2-4628-aad1-8a4926520676"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38c9a5c3-b5aa-4566-a203-5c68d4efc133", "AQAAAAEAACcQAAAAEDesTQLZeSN851iZApPQVDkPilsxzNDySqRyZUENh4zHp0InyG03+/RyqaXDVVw10Q==", "cd970654-c802-44a1-8c79-c148489b92c8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e01396a-0871-4586-b4ba-adc0f6fddf4c", "AQAAAAEAACcQAAAAEL+K2IDreNodLA5Gt1ob1Dm9Jd5tFWhKDW7QU3nvia8OQoRC+HG5ptuYkIFasiLfeA==", "0ce44571-f1e1-4a3f-a0fe-50cf56e9cdc3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c182303-7d6c-486a-83d6-a0436e77f84b", "AQAAAAEAACcQAAAAEFE3Ek394FOGPQ9Sj/1o5dXl38HQInGhgcCiVzv6z1o0Enquj6qMpmUlA6l62/2g7w==", "2eabb1a5-27b3-4cf1-9209-b0b5b360b298" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fadfd2df-acc6-4545-a2b6-4222cd85911a", "AQAAAAEAACcQAAAAEMdbBt9a8TGffcdykCM93v4Q4bshhWpGbU1ex5txZfUStZdFZgNyiHYpqk5GtSpATQ==", "1bba8f16-040d-48c8-8c20-b4f46b5a57c5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f57cc6e-06a0-49f2-8a86-b790e605acfd", "AQAAAAEAACcQAAAAELzsm9jCug+umXTAn57vGVdFi9mzFqjwK78evPgyBxHvorxmMJeN/LX7+vdkvnl14g==", "f907e8f8-0713-44d1-8baf-852727d4a3f3" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 7,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 8,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 9,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 10,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 11,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 12,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 13,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 14,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 15,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 16,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 17,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 18,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 19,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 20,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 21,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 22,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 23,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 24,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 25,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 26,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 27,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 28,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 29,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 30,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 31,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 32,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 33,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 34,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 35,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 36,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 37,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 38,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 39,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 40,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 41,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 42,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 43,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 44,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 45,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 46,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 47,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 48,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 49,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 50,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 51,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 52,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 53,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 54,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 55,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 56,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 57,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 58,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 59,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 60,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 61,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 62,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 63,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 64,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 65,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 66,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 67,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 68,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 69,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 70,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 71,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 72,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 73,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 74,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 75,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 76,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 77,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 78,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 79,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 80,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 81,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 82,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 83,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 84,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 85,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 86,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 87,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 88,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 89,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 90,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 91,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 92,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 93,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 94,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 95,
                column: "DateCreate",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 2,
                column: "DateRequest",
                value: new DateTime(2024, 11, 26, 1, 21, 35, 433, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"),
                column: "ConcurrencyStamp",
                value: "30480fc5-09fc-4234-865b-667d84efc54a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"),
                column: "ConcurrencyStamp",
                value: "666ba211-9a05-44b4-83a4-a2dc3cc57665");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7b05101d-bd7e-44d1-8999-8f397f60f6bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"),
                column: "ConcurrencyStamp",
                value: "056d3ad3-0fc6-481e-a6e1-7580e07a9cca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"),
                column: "ConcurrencyStamp",
                value: "b9e3e7cc-afb4-4c44-9bd1-c4b8bc725933");

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "CreateBy", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("0764f7b0-0147-42ce-9047-bdd53c3cde39"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("c6b1243f-e357-4583-b0e5-2ae77fe214e1"), "Hanoi", null, new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });
        }
    }
}
