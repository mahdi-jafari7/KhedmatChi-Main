using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Categories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AddColumn<int>(
                name: "MainCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 795, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a07e2612-5951-4a2f-ae49-1495548c184a", "AQAAAAIAAYagAAAAEISKFUha7m8eyZPo+VwMNAlspaU+9WG2gqO/5pVjJKHqWk0n3IQvaP64COjLBxhPCA==", "e944b579-effe-42a3-823a-7ff2e7556dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "242dc396-c4a2-4e26-adde-2d7dd6440470", "AQAAAAIAAYagAAAAELyXTX/I3RNfrAylDleWdl3YpmlfpJr58GhObX70xGF4bygMJLqIhgSxC7oQHumedg==", "ebb91c23-bee6-470d-a179-e72579f60e45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa510914-1c60-4ffb-a520-9cc059dce408", "AQAAAAIAAYagAAAAEPpzwNr5bukC7m/jcFK20FsRALbiQNbXk2XYyN+YHJP+ILgHOQFiXsQ2cNDnQINdzA==", "63dfa1e9-e61e-461f-83c6-14019ee38494" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "387372e0-68c6-485c-b48b-7d9c4523bc67", "AQAAAAIAAYagAAAAEKNZQ8/eaalCWIqcHy84U1cd2IIpeFZaHkCMZGGopnq18dSXEki7PqGLrHfJS1sZxQ==", "1a9be5ce-bd41-4787-9b6e-67c3990c03d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "836c795f-bc8b-46c5-8cfd-75a69cc77bf2", "AQAAAAIAAYagAAAAEB3kl1ULe5KnrJAHN39/lS2L5treSQnbHhLczBKqIgGg0jO+1rgWRiA5hFA7n3f7Dw==", "2db94b68-159a-4000-835f-35b3f777aac0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d154d53b-90a3-4a96-be74-30ba374e5212", "AQAAAAIAAYagAAAAEL/oig+BZLFWyhpUV/tT0Uz5OkezHBpkBbZ2XwvFbZdsBf2Sk1UVUcNBcmqg88uOkQ==", "d3455d59-9e0c-4613-8487-294ec21356af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61df4429-acb4-42ea-a666-1000e38541a2", "AQAAAAIAAYagAAAAEOzqd+NfriXAMwZDqa0EuOsj43urgdDUtTBeSo9xIZG6N4S+nYxaUUH0kxvZ/oBgvg==", "2c5e9cbf-ef64-4512-a106-809540bb4775" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7879), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7884), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7886), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7887), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7888), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7889), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7890), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7892), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "MainCategoryId" },
                values: new object[] { new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7893), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 801, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 797, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 797, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 797, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 800, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MainCategoryId",
                table: "Categories",
                column: "MainCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_MainCategories_MainCategoryId",
                table: "Categories",
                column: "MainCategoryId",
                principalTable: "MainCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_MainCategories_MainCategoryId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_MainCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MainCategoryId",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Categories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 960, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6ba4daa-5829-41be-b916-76e0f62351c7", "AQAAAAIAAYagAAAAEG5A8l8pjZ1ySEmfstsPnt4EJt/WX3I0yXYpAoUtR2iDP5bCIG071XzvNxUvcREWnQ==", "eed41b2b-7ba5-4a67-a581-a360d0d07ce4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cb37185-06be-4ff7-80ea-00cfe36719bd", "AQAAAAIAAYagAAAAEAKGyF2BIr0Y/wbDy8g456D/TRM4zOWtgdFDSaJmE1rY65fF9K1/5ZnyF1JHRODdXQ==", "b3de8d21-8eb3-4217-b622-a1b105d05a17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dd1d969-f96a-4942-ad82-3f9cac4f3fe1", "AQAAAAIAAYagAAAAEC53wpvalNxISR2FSGO+1SKhp4WUdvs5PQ9RGX135OinV47CzWap+jbJ/ftCkPXCNA==", "8da0c155-8ee2-43c2-936f-78f5f44f93cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c016398-7857-4253-a94b-8a7b7100e8be", "AQAAAAIAAYagAAAAEIXepBKbvC+mQ2kn+U1apnuRyRGGb1IXeGnGlgNWT8hYQVGSRiizhe1NFwyFxQa9Og==", "34e463c7-2d81-400d-9d6a-8dbb0446e167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e118aa-ff91-44c5-8cc6-72a6051e7bd6", "AQAAAAIAAYagAAAAEJIbP3Kux0iOJ73mASi+wrW42j5hZW8zfn/CnrVS4vJleyFYZuzc/ByzHl9bIw7NOQ==", "d3170c8f-6617-4944-9317-1d432af3ca6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7db1b196-4302-4c80-bade-bad2d8c5d549", "AQAAAAIAAYagAAAAECeNSrAGSpHBpIWVbNyAI34f1xbM2t6xuLI+wcxP3u7bM9F0ABkttHopWCSaoinIfA==", "74cf1fb3-823e-4c03-ac6b-0696a37c9850" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41725373-4670-46c4-a143-e9b528809e66", "AQAAAAIAAYagAAAAEFl8saq7exX/gCaT+iJ5gnQdEh+b45D7hdaLGE/J4rFtP1mFaPuvp4sYCiSgUhTtwQ==", "829a6281-27b3-4f6a-a7e6-5129be450e67" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 968, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 963, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 963, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 963, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 10, 53, 19, 966, DateTimeKind.Local).AddTicks(6559));
        }
    }
}
