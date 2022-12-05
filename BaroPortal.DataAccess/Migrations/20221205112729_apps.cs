using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class apps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uygulamalarimiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    DetailImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uygulamalarimiz", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 364, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 364, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 364, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 364, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 364, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 364, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 364, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 360, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 361, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 14, 27, 29, 361, DateTimeKind.Local).AddTicks(8710));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uygulamalarimiz");

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 817, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 817, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 817, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 817, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 817, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 817, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 817, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 813, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 814, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 13, 53, 43, 814, DateTimeKind.Local).AddTicks(9652));
        }
    }
}
