using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class init10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceName",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 409, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf6d2f77-e50f-46dc-8647-41a402caa396", "AQAAAAIAAYagAAAAEDZRUvoFimlJpRLmr1j7RBwicT2BXznTlxIWYiUlsYTOcvofAZYOMV6dYpY2+9XLcw==", "f12de742-be65-47d8-a751-fdba01db91b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93f4e2f3-c90f-4d66-9c38-e0230cbb269e", "AQAAAAIAAYagAAAAEEbEfxGAR+AdaEC4PNnMKcjkdwbiMQeUjzCCfDBb43foeHhES9xgzGa0H+2IECsQbw==", "5151e0ea-7778-49b1-8c40-1bbd36ba67a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0562bd1-204b-4674-94a6-603c6b3d9397", "AQAAAAIAAYagAAAAEOjYeNK95shfbU8cKYJWGCtWUyu7aixlYVDiD4b9oWzPZDw+t77cZlheHysFirG58Q==", "afdb3c1c-f50a-4b2d-a27f-684b0e061c85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e40c9ad4-0d6a-48cf-8c0c-f11cf73518fe", "AQAAAAIAAYagAAAAEDFsZPfFeu5r/6RElraIg1PheU2Bz2qJmGkCXk5Ty+mJc//UWybcJBHoxNwUBbANeQ==", "bf6cfe22-ed36-41bd-a859-88921f2ff043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c79393f-8b36-4a0f-ad58-baab2581f3e9", "AQAAAAIAAYagAAAAELz0uiWlGPG1pIZthvAOHz3ogA3v0lnCSDApAx5n2CAwF7dwRDAiieL+OuzoYxV1PQ==", "d5fa324f-3e1a-4bde-9a53-db47b447c68d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4084cbbd-ac80-4858-87a5-e206387693f7", "AQAAAAIAAYagAAAAEMq6AGF2IUd9G1XjLroq3eHGEhJrlDkKPmz+JIAzDEeN/X4pTCyfcklBkTu8IkRTsQ==", "415e1cc2-df62-4683-82bf-59797f67bd01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3046a3fe-6e96-46b7-8a9d-3e789c00d33d", "AQAAAAIAAYagAAAAEFSdfvHXn0N97sZzTo9kdLil2G8VgKCRB3nKtkyPElcNHAK4MoLLq8oOrRHSY37qJQ==", "f805a0d5-5f85-4d14-9b2f-99e5811cc057" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 414, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 411, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 411, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 411, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 28, 15, 36, 20, 413, DateTimeKind.Local).AddTicks(6936));
        }
    }
}
