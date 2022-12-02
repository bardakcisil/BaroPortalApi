using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class duyurular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Duyurular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PdfFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DetailImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    ListImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyurular", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Duyurular");

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 855, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 855, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 855, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 855, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 855, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 855, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 855, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 852, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 853, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 2, 9, 10, 47, 853, DateTimeKind.Local).AddTicks(3566));
        }
    }
}
