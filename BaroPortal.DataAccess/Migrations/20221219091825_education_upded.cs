using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class education_upded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionDetail",
                table: "SurveyOps",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuestionTitle",
                table: "SurveyOps",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AdvertTypes",
                columns: new[] { "Id", "CreateDate", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 19, 12, 18, 25, 392, DateTimeKind.Local).AddTicks(7987), "İş Arıyorum", 1 },
                    { 2, new DateTime(2022, 12, 19, 12, 18, 25, 392, DateTimeKind.Local).AddTicks(8003), "Avukat Arıyorum", 2 },
                    { 3, new DateTime(2022, 12, 19, 12, 18, 25, 392, DateTimeKind.Local).AddTicks(8004), "Katip/Sekreter Arıyorum", 3 },
                    { 4, new DateTime(2022, 12, 19, 12, 18, 25, 392, DateTimeKind.Local).AddTicks(8005), "Staj Yeri Arıyorum", 4 },
                    { 5, new DateTime(2022, 12, 19, 12, 18, 25, 392, DateTimeKind.Local).AddTicks(8006), "Ortak Arıyorum", 5 },
                    { 6, new DateTime(2022, 12, 19, 12, 18, 25, 392, DateTimeKind.Local).AddTicks(8008), "Stajyer Av. Arıyorum", 6 },
                    { 7, new DateTime(2022, 12, 19, 12, 18, 25, 392, DateTimeKind.Local).AddTicks(8009), "Diğer", 7 }
                });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 395, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 395, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 395, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 395, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 395, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 389, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 390, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 390, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 396, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 396, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 396, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 396, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 396, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 396, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 396, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2022, 12, 19, 12, 18, 25, 396, DateTimeKind.Local).AddTicks(5897));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "QuestionDetail",
                table: "SurveyOps");

            migrationBuilder.DropColumn(
                name: "QuestionTitle",
                table: "SurveyOps");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 228, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 228, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 228, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 228, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 228, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 223, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 224, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 224, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 229, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 229, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 229, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 229, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 229, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 229, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 229, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Court",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 13, 33, 229, DateTimeKind.Local).AddTicks(8020));
        }
    }
}
