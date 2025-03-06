using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class init12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MainCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "MainCategories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MainCategories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Title" },
                values: new object[] { 1, new DateTime(2025, 3, 6, 14, 14, 44, 662, DateTimeKind.Local).AddTicks(9974), "", "", false, "ساختمان" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MainCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "MainCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MainCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

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
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 6, 14, 10, 56, 799, DateTimeKind.Local).AddTicks(7893));

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
        }
    }
}
