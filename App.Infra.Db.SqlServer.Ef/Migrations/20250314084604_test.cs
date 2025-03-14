using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ServiceRequests_ServiceRequestId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ServiceRequestId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRequestId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 303, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3daa6fbc-1ead-4fd7-8a73-e839f126dba3", "AQAAAAIAAYagAAAAEEm4Gu9aS4vddkdsQgnmFEwK8jLZx/fYmiklrULB69suw191+PHU07xPWbKa0Kg3kA==", "9c10e9f5-7157-4896-97cc-12d12967eed6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2db0b4e6-cda7-4cb4-9f47-9f54315ad14f", "AQAAAAIAAYagAAAAEMgI0t76OYV4DjRvNK34gcqaasTdb+DakxD62iqBiH6VWMV+AjqtqhZoLsA0HitBew==", "a4dc6205-8f07-48e4-a3a4-5281f8425fb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90394784-ab96-40fb-9899-176024221493", "AQAAAAIAAYagAAAAEH50tWxImAGdZj0D4AWuXmeiraoSAzo7TsMEQzlH/oM6f854R9FCgldKjh+HtHTZ8Q==", "f907b36e-ad95-428a-96e7-9c80b599443b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2283900f-6b7c-4150-a33a-2d8cac889190", "AQAAAAIAAYagAAAAECalVaQYPoLYpGVEii9HEECbdwVFCyw0L1yCx2BwuEhD+cTfYpRFxZt2YSg6yiZboA==", "0b102006-f7bc-4b1f-8d1d-f739446332df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d23b569a-1921-48e5-9a7b-4fe0063db431", "AQAAAAIAAYagAAAAEOgdeKM4ncl0q9jkZLPQfIo2mNxppnnclWG+M0AbgYhyFlUR33joQg2zy9vwNssxDw==", "2439ec62-aacc-403a-95b9-b7c131ec226b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5545df14-28ca-43b8-bc54-ae77821a707b", "AQAAAAIAAYagAAAAEMtTtMLHupvbDZED/DkmzABdxD/IPrHR3fPMC7FAhJnkmMBRZ5kuI388t3ie3cyVbw==", "2e33e71e-16b5-44eb-a07f-c2200b0911b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20227f08-4336-4c69-8e3e-ec258a80fba8", "AQAAAAIAAYagAAAAECDMVLXWA+FUYj2b/FC7MzXANP7/nnjN9WUnKNl5hPBjc0ZIJLWX9rBcbv6Wfbc/4Q==", "a4f2e191-db25-4ef0-9a72-057b86ad1e3e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 306, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 306, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 306, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 309, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 14, 12, 16, 3, 308, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ServiceRequestId",
                table: "Comments",
                column: "ServiceRequestId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ServiceRequests_ServiceRequestId",
                table: "Comments",
                column: "ServiceRequestId",
                principalTable: "ServiceRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ServiceRequests_ServiceRequestId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ServiceRequestId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRequestId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 233, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afbed000-ff43-4a76-9870-efc3e147b380", "AQAAAAIAAYagAAAAEHIItauFxGRu0MZ4wDCvTrDPXBHMZ9rejF94trlmT7eneGKeKeQ69gasZrREcRynyw==", "bb0a7e36-07d5-4604-af4c-275b5abb53be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ee2d194-5a33-4241-87d6-e0fbbcb31977", "AQAAAAIAAYagAAAAEMqZ1PiuzBo+u26/tCxCxmcUPQIbjFHtF2jz3JTeZV+q0ieRdK5oJy7NDWVp8BQE5g==", "f7abda0d-8f66-4f34-a7d5-3454a95e698f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f907f3cc-97df-44ec-8e0b-ece8445b9897", "AQAAAAIAAYagAAAAEB0vlMdDGew3L4IKRapebKGTKP+dOgIQrQCNdM+zdnntQuj0by+KdCSCEu+xtp+AXQ==", "3f36a261-aab0-4f12-9f69-ecd8f85516aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "330eb658-9811-4650-9a11-ff2b92373461", "AQAAAAIAAYagAAAAEIbtzuvmH0rIlIYGttr6LceQjEhz72OOJDwfey+xix0mb5nOQ8b+7wD9fUfQcXTQ3A==", "c949ab21-b1ee-41b0-a89a-08bf3fa59c02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db19a206-e1f4-4e47-9100-46b50b93120e", "AQAAAAIAAYagAAAAEAgU+xjs4OJ6wEUoJ9O6EInt9kW49vbZZgvhl81ho+yENI3eHL9C9tXeK/osD1lNZg==", "b23776a3-c00b-420b-afaf-cb442dbe6b33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26a13728-a70e-4878-9235-3c649b2c6c69", "AQAAAAIAAYagAAAAELfEdyUp6nzow4XWrjapsNzIS81zdxS9jQH90sjCC3pk41h0v+RpedJ0hx2q+7NYtw==", "1d1d79f6-6394-4206-b9af-826051335caf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fd620fd-0d07-4c03-8cde-818c835256a3", "AQAAAAIAAYagAAAAEO4d9Cs1SS7H7jHgVIHDT9C8U4MxrSHVF7ntYnkbD1kk1Tl0qEEmA8DnR2Xmv5DUaQ==", "503c685e-0183-4d13-8945-224257f04c38" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 237, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 237, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 237, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 236, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 236, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 236, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 239, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 3, 11, 27, 238, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ServiceRequestId",
                table: "Comments",
                column: "ServiceRequestId",
                unique: true,
                filter: "[ServiceRequestId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ServiceRequests_ServiceRequestId",
                table: "Comments",
                column: "ServiceRequestId",
                principalTable: "ServiceRequests",
                principalColumn: "Id");
        }
    }
}
