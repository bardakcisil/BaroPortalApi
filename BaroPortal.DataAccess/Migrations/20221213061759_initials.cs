using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaroPortal.DataAccess.Migrations
{
    public partial class initials : Migration
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
                name: "Court",
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
                    table.PrimaryKey("PK_Court", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "SurveyOps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyId = table.Column<int>(type: "int", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    AnswerId = table.Column<int>(type: "int", nullable: true),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    QuestionDetail = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyOps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyOps_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SurveyOps_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SurveyOps_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AdvertTypes",
                columns: new[] { "Id", "CreateDate", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 13, 9, 17, 59, 394, DateTimeKind.Local).AddTicks(9017), "İş Arıyorum", 1 },
                    { 2, new DateTime(2022, 12, 13, 9, 17, 59, 394, DateTimeKind.Local).AddTicks(9037), "Avukat Arıyorum", 2 },
                    { 3, new DateTime(2022, 12, 13, 9, 17, 59, 394, DateTimeKind.Local).AddTicks(9038), "Katip/Sekreter Arıyorum", 3 },
                    { 4, new DateTime(2022, 12, 13, 9, 17, 59, 394, DateTimeKind.Local).AddTicks(9039), "Staj Yeri Arıyorum", 4 },
                    { 5, new DateTime(2022, 12, 13, 9, 17, 59, 394, DateTimeKind.Local).AddTicks(9040), "Ortak Arıyorum", 5 },
                    { 6, new DateTime(2022, 12, 13, 9, 17, 59, 394, DateTimeKind.Local).AddTicks(9044), "Stajyer Av. Arıyorum", 6 },
                    { 7, new DateTime(2022, 12, 13, 9, 17, 59, 394, DateTimeKind.Local).AddTicks(9044), "Diğer", 7 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerId", "AnswerName", "CreateDate" },
                values: new object[,]
                {
                    { 1, 1, "Strongly Disagree", new DateTime(2022, 12, 13, 9, 17, 59, 397, DateTimeKind.Local).AddTicks(2880) },
                    { 2, 2, "Disagree", new DateTime(2022, 12, 13, 9, 17, 59, 397, DateTimeKind.Local).AddTicks(2895) },
                    { 3, 3, "Neutral", new DateTime(2022, 12, 13, 9, 17, 59, 397, DateTimeKind.Local).AddTicks(2896) },
                    { 4, 4, "Agree", new DateTime(2022, 12, 13, 9, 17, 59, 397, DateTimeKind.Local).AddTicks(2896) },
                    { 5, 5, "Strongly Agree", new DateTime(2022, 12, 13, 9, 17, 59, 397, DateTimeKind.Local).AddTicks(2897) }
                });

            migrationBuilder.InsertData(
                table: "ContactUsTopics",
                columns: new[] { "Id", "CreateDate", "Name", "TopicId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 13, 9, 17, 59, 390, DateTimeKind.Local).AddTicks(2210), "Öneri", 1 },
                    { 2, new DateTime(2022, 12, 13, 9, 17, 59, 392, DateTimeKind.Local).AddTicks(462), "Bilgi", 2 },
                    { 3, new DateTime(2022, 12, 13, 9, 17, 59, 392, DateTimeKind.Local).AddTicks(475), "Şikayet", 3 }
                });

            migrationBuilder.InsertData(
                table: "Court",
                columns: new[] { "Id", "CreateDate", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 13, 9, 17, 59, 398, DateTimeKind.Local).AddTicks(7966), "İcra Mahkemeleri", 1 },
                    { 2, new DateTime(2022, 12, 13, 9, 17, 59, 398, DateTimeKind.Local).AddTicks(7983), "Sulh Hukuk Mahkemeleri", 2 },
                    { 3, new DateTime(2022, 12, 13, 9, 17, 59, 398, DateTimeKind.Local).AddTicks(7984), "Sulh Ceza/İnfaz Hakimlikleri", 3 },
                    { 4, new DateTime(2022, 12, 13, 9, 17, 59, 398, DateTimeKind.Local).AddTicks(7985), "Asliye Mahkemeleri", 4 },
                    { 5, new DateTime(2022, 12, 13, 9, 17, 59, 398, DateTimeKind.Local).AddTicks(7986), "Tüketici Mahkemeleri", 5 },
                    { 6, new DateTime(2022, 12, 13, 9, 17, 59, 398, DateTimeKind.Local).AddTicks(8039), "Fikri ve Sınai Haklar Mahkemeleri", 6 },
                    { 7, new DateTime(2022, 12, 13, 9, 17, 59, 398, DateTimeKind.Local).AddTicks(8040), "İdare ve Vergi Mahkemeleri-Duruşmalı", 7 },
                    { 8, new DateTime(2022, 12, 13, 9, 17, 59, 398, DateTimeKind.Local).AddTicks(8041), "İdare ve Vergi Mahkemeleri-Duruşmasız", 8 }
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
                name: "IX_Questions_AnswerId",
                table: "Questions",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyId",
                table: "Questions",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyOps_AnswerId",
                table: "SurveyOps",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyOps_QuestionId",
                table: "SurveyOps",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyOps_SurveyId",
                table: "SurveyOps",
                column: "SurveyId");
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
                name: "Court");

            migrationBuilder.DropTable(
                name: "Duyurular");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Etkinlikler");

            migrationBuilder.DropTable(
                name: "Haberler");

            migrationBuilder.DropTable(
                name: "SurveyOps");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Uygulamalarimiz");

            migrationBuilder.DropTable(
                name: "AdvertTypes");

            migrationBuilder.DropTable(
                name: "ContactUsTopics");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
