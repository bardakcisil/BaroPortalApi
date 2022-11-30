using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class _2nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.CreateTable(
                name: "ContactUsTopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsTopics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactUs_ContactUsTopics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ContactUsTopics",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "ContactUsTopics",
                columns: new[] { "Id", "CreateDate", "Name", "TopicId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 29, 16, 43, 43, 509, DateTimeKind.Local).AddTicks(1399), "Öneri", 1 },
                    { 2, new DateTime(2022, 11, 29, 16, 43, 43, 510, DateTimeKind.Local).AddTicks(893), "Bilgi", 2 },
                    { 3, new DateTime(2022, 11, 29, 16, 43, 43, 510, DateTimeKind.Local).AddTicks(903), "Şikayet", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_TopicId",
                table: "ContactUs",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "ContactUsTopics");

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertId = table.Column<int>(type: "int", maxLength: 10000, nullable: false),
                    AdvertTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdvertiserEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdvertiserLwork = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdvertiserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdvertiserPhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdvertiserSname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConscriptionStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 25, 10, 7, 24, 554, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 25, 10, 7, 24, 556, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 25, 10, 7, 24, 556, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 25, 10, 7, 24, 556, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 11, 25, 10, 7, 24, 556, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 11, 25, 10, 7, 24, 556, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 11, 25, 10, 7, 24, 556, DateTimeKind.Local).AddTicks(2024));
        }
    }
}
