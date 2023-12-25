using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yuzuncuYilProje.Repository.Migrations
{
    public partial class yuzuncuYılDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 21, 5, 31, 300, DateTimeKind.Local).AddTicks(4276));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 20, 53, 2, 918, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 20, 53, 2, 918, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 20, 53, 2, 918, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 20, 53, 2, 918, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 20, 53, 2, 918, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 20, 53, 2, 918, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 20, 53, 2, 918, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 20, 53, 2, 918, DateTimeKind.Local).AddTicks(2376));
        }
    }
}
