using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class _4th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BarSearchs",
                table: "BarSearchs");

            migrationBuilder.DeleteData(
                table: "BarSearchs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BarSearchs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BarSearchs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BarSearchs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BarSearchs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BarSearchs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BarSearchs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BarSearchs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameTable(
                name: "BarSearchs",
                newName: "BarUserSearch");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BarUserSearch",
                table: "BarUserSearch",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 582, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 582, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 582, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 582, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 582, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 582, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 582, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 579, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 580, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 57, 30, 580, DateTimeKind.Local).AddTicks(1172));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BarUserSearch",
                table: "BarUserSearch");

            migrationBuilder.RenameTable(
                name: "BarUserSearch",
                newName: "BarSearchs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BarSearchs",
                table: "BarSearchs",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.InsertData(
                table: "BarSearchs",
                columns: new[] { "Id", "BaroNumber", "CreateDate", "Name", "Surname", "TypeId" },
                values: new object[,]
                {
                    { 1, 1111, new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(7013), "Işıl", "Bardakcı", 1 },
                    { 2, 2222, new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(7031), "Hussain", "Alburki", 1 },
                    { 3, 3333, new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(7032), "İrem", "Turanlı", 1 },
                    { 4, 4444, new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(7033), "Berkay", "Demir", 1 },
                    { 5, 5555, new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(7033), "Işıl", "Bardakcı", 2 },
                    { 6, 6666, new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(7037), "Hussain", "Alburki", 2 },
                    { 7, 7777, new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(7038), "İrem", "Turanlı", 2 },
                    { 8, 8888, new DateTime(2022, 11, 30, 10, 51, 30, 490, DateTimeKind.Local).AddTicks(7039), "Berkay", "Demir", 2 }
                });

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 486, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 487, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 30, 10, 51, 30, 487, DateTimeKind.Local).AddTicks(2539));
        }
    }
}
