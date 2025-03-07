using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class addImageurltoRequestServiceEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RequestImageUrl",
                table: "ServiceRequests",
                type: "nvarchar(max)",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestImageUrl",
                table: "ServiceRequests");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 657, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f66070d-40a9-4cfc-a49d-650cafa0307f", "AQAAAAIAAYagAAAAEEiyCiOXU/zB6PERXWMpbg181GQQy3VpukESDxAKzy1w7gGdGqlQ4vf2ARGMPggGMQ==", "13e32b84-8714-46b0-b738-433bbb9da8d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfb8f17b-76fe-4748-813d-44a06d90df2b", "AQAAAAIAAYagAAAAEI0qBh6/uAma4s+XUn9aVGGmoqjUm5NHIEF7xFZktRlXt4/Ne7/b7pkEI5YGpGyNDg==", "a422a9e3-d687-4578-810e-24c1c9aa0f17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f283536c-0b6b-4410-bc8d-84ce36e46cb8", "AQAAAAIAAYagAAAAEA9ors0BFpPe2BJhH9iPzIRa6gGb5T8/ndZ3ICuPZCP/PQcru6RiM9wpm9/ThIWRcw==", "d596f956-8107-4528-8fa5-e79f71c65cce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bb51799-4ae9-4def-abb0-2caccc697928", "AQAAAAIAAYagAAAAECSnbKcKjF1qpIl6CTmblyJhTp6082SmYXVhDvMhRteowVZR0bJLcPsCV2Pk0HJpfA==", "2cb30f65-98b6-4c37-963f-9a34c7f6cbbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00fb790d-1445-4b01-8201-1bb338b0e9c6", "AQAAAAIAAYagAAAAEEt0z3k3n9opQlMxBCyby4mL6npLsvGbd55db9bLmG/nXCsEXKmr2sPZEbQqv1yEKQ==", "f155db2f-e3fb-4ef7-9183-69cbafb3b1e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bae795cb-5e49-402f-b6ad-c74aa39d1b26", "AQAAAAIAAYagAAAAEBAdUT2V7opuj81sKZJKWRIe6rmRg1+2eUjfQMA9lmj0hO0z9hBEwgTZoLXX9IH1CQ==", "b60d02ec-7f0f-42f3-b196-f11ef1851db5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "330dd08b-6589-42dc-8366-a7edaa3a82fe", "AQAAAAIAAYagAAAAECrF4YY5E2eGQJwyDh2c3jsaH0lnnQZmqIfGA80oucRg7QBG+uPhodmXn+Yr7Z2V1A==", "4dbba6cd-83e3-40a9-8a92-6077060a0167" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 659, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 659, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 659, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 14, 44, 661, DateTimeKind.Local).AddTicks(6987));
        }
    }
}
