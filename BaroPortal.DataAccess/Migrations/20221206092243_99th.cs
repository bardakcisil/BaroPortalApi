using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class _99th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerId = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    AnswerName = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyId = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    SurveyName = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    QuestionDetail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    AnswerId = table.Column<int>(type: "int", nullable: true),
                    SurveyId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Questions_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 425, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 425, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 425, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 425, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 425, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 425, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 425, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerId", "AnswerName", "CreateDate" },
                values: new object[,]
                {
                    { 1, 1, "Strongly Disagree", new DateTime(2022, 12, 6, 12, 22, 42, 430, DateTimeKind.Local).AddTicks(2470) },
                    { 2, 2, "Disagree", new DateTime(2022, 12, 6, 12, 22, 42, 430, DateTimeKind.Local).AddTicks(2486) },
                    { 3, 3, "Neutral", new DateTime(2022, 12, 6, 12, 22, 42, 430, DateTimeKind.Local).AddTicks(2487) },
                    { 4, 4, "Agree", new DateTime(2022, 12, 6, 12, 22, 42, 430, DateTimeKind.Local).AddTicks(2488) },
                    { 5, 5, "Strongly Agree", new DateTime(2022, 12, 6, 12, 22, 42, 430, DateTimeKind.Local).AddTicks(2489) }
                });

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 427, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 427, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 427, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 427, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 427, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 422, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 423, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 12, 22, 42, 423, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnswerId",
                table: "Questions",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyId",
                table: "Questions",
                column: "SurveyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 512, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 512, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 512, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 512, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 512, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 512, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "AdvertTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 512, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Cevap",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 508, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 509, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "ContactUsTopics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 5, 17, 1, 2, 509, DateTimeKind.Local).AddTicks(7256));
        }
    }
}
