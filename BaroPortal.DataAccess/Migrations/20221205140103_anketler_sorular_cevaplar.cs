using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class anketler_sorular_cevaplar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anket",
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
                    table.PrimaryKey("PK_Anket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cevap",
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
                    table.PrimaryKey("PK_Cevap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soru",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    QuestionDetail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soru", x => new { x.SurveyId, x.AnswerId });
                    table.ForeignKey(
                        name: "FK_Soru_Anket_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Anket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Soru_Cevap_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Cevap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Cevap",
                columns: new[] { "Id", "AnswerId", "AnswerName", "CreateDate" },
                values: new object[,]
                {
                    { 1, 1, "Strongly Disagree", new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2104) },
                    { 2, 2, "Disagree", new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2119) },
                    { 3, 3, "Neutral", new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2120) },
                    { 4, 4, "Agree", new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2121) },
                    { 5, 5, "Strongly Agree", new DateTime(2022, 12, 5, 17, 1, 2, 514, DateTimeKind.Local).AddTicks(2122) }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Soru_AnswerId",
                table: "Soru",
                column: "AnswerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Soru");

            migrationBuilder.DropTable(
                name: "Anket");

            migrationBuilder.DropTable(
                name: "Cevap");

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
    }
}
