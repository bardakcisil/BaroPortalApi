using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class _3th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 690, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 690, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 690, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 690, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 690, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 690, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 690, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 687, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 688, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 28, 56, 688, DateTimeKind.Local).AddTicks(1981));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 513, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 513, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 513, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 513, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 513, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 513, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 513, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 509, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 510, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 29, 16, 43, 43, 510, DateTimeKind.Local).AddTicks(903));
        }
    }
}
