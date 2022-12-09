using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class Newinitials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertTypes", x => x.Id);
                });

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
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageData = table.Column<byte[]>(type: "image", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BarSearch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaroNumber = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarSearch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bildirimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    DetailImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bildirimler", x => x.Id);
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
                    ListImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    DetailImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyurular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PdfFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Etkinlikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    DetailImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etkinlikler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haberler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    DetailImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haberler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertId = table.Column<int>(type: "int", maxLength: 10000, nullable: false),
                    Advertiser = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdvertiserPhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdvertiserEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisements_AdvertTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AdvertTypes",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "AdvertTypes",
                columns: new[] { "Id", "CreateDate", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 6, 14, 2, 26, 532, DateTimeKind.Local).AddTicks(9321), "İş Arıyorum", 1 },
                    { 2, new DateTime(2022, 12, 6, 14, 2, 26, 532, DateTimeKind.Local).AddTicks(9341), "Avukat Arıyorum", 2 },
                    { 3, new DateTime(2022, 12, 6, 14, 2, 26, 532, DateTimeKind.Local).AddTicks(9342), "Katip/Sekreter Arıyorum", 3 },
                    { 4, new DateTime(2022, 12, 6, 14, 2, 26, 532, DateTimeKind.Local).AddTicks(9343), "Staj Yeri Arıyorum", 4 },
                    { 5, new DateTime(2022, 12, 6, 14, 2, 26, 532, DateTimeKind.Local).AddTicks(9343), "Ortak Arıyorum", 5 },
                    { 6, new DateTime(2022, 12, 6, 14, 2, 26, 532, DateTimeKind.Local).AddTicks(9346), "Stajyer Av. Arıyorum", 6 },
                    { 7, new DateTime(2022, 12, 6, 14, 2, 26, 532, DateTimeKind.Local).AddTicks(9347), "Diğer", 7 }
                });

            migrationBuilder.InsertData(
                table: "Cevap",
                columns: new[] { "Id", "AnswerId", "AnswerName", "CreateDate" },
                values: new object[,]
                {
                    { 1, 1, "Strongly Disagree", new DateTime(2022, 12, 6, 14, 2, 26, 535, DateTimeKind.Local).AddTicks(1770) },
                    { 2, 2, "Disagree", new DateTime(2022, 12, 6, 14, 2, 26, 535, DateTimeKind.Local).AddTicks(1787) },
                    { 3, 3, "Neutral", new DateTime(2022, 12, 6, 14, 2, 26, 535, DateTimeKind.Local).AddTicks(1788) },
                    { 4, 4, "Agree", new DateTime(2022, 12, 6, 14, 2, 26, 535, DateTimeKind.Local).AddTicks(1789) },
                    { 5, 5, "Strongly Agree", new DateTime(2022, 12, 6, 14, 2, 26, 535, DateTimeKind.Local).AddTicks(1789) }
                });

            migrationBuilder.InsertData(
                table: "ContactUsTopics",
                columns: new[] { "Id", "CreateDate", "Name", "TopicId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 6, 14, 2, 26, 529, DateTimeKind.Local).AddTicks(1302), "Öneri", 1 },
                    { 2, new DateTime(2022, 12, 6, 14, 2, 26, 530, DateTimeKind.Local).AddTicks(4103), "Bilgi", 2 },
                    { 3, new DateTime(2022, 12, 6, 14, 2, 26, 530, DateTimeKind.Local).AddTicks(4112), "Şikayet", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_TypeId",
                table: "Advertisements",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_TopicId",
                table: "ContactUs",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Soru_AnswerId",
                table: "Soru",
                column: "AnswerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "BarSearch");

            migrationBuilder.DropTable(
                name: "Bildirimler");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "Duyurular");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Etkinlikler");

            migrationBuilder.DropTable(
                name: "Haberler");

            migrationBuilder.DropTable(
                name: "Soru");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Uygulamalarimiz");

            migrationBuilder.DropTable(
                name: "AdvertTypes");

            migrationBuilder.DropTable(
                name: "ContactUsTopics");

            migrationBuilder.DropTable(
                name: "Anket");

            migrationBuilder.DropTable(
                name: "Cevap");
        }
    }
}
