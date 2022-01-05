using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class QuestionTypeText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionTextTypeId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "QuestionTextTypeId1",
                table: "Questions",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AimQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AimQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTextTypes",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTextTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TargetQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AimQuestionId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetQuestion_AimQuestions_AimQuestionId",
                        column: x => x.AimQuestionId,
                        principalTable: "AimQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "QuestionTextTypes",
                columns: new[] { "Id", "Explanation" },
                values: new object[,]
                {
                    { (short)1, "Amaç" },
                    { (short)2, "Hedef" },
                    { (short)3, "Soru" },
                    { (short)9, "Pestle Sorusu" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 215, 179, 181, 57, 240, 21, 60, 187, 112, 207, 252, 35, 40, 174, 176, 60, 27, 3, 0, 65, 5, 210, 179, 168, 95, 184, 66, 68, 100, 153, 64, 139, 21, 191, 47, 45, 115, 5, 185, 205, 56, 42, 167, 234, 180, 101, 189, 125, 218, 43, 148, 67, 97, 153, 216, 61, 184, 68, 37, 222, 192, 151, 79 }, new byte[] { 177, 198, 94, 100, 111, 111, 162, 43, 57, 155, 21, 147, 27, 94, 74, 115, 156, 138, 186, 25, 112, 36, 54, 161, 89, 176, 54, 58, 163, 10, 170, 90, 46, 224, 8, 8, 145, 146, 79, 103, 113, 72, 228, 32, 129, 45, 220, 24, 73, 174, 86, 50, 171, 202, 144, 233, 58, 235, 59, 207, 70, 59, 157, 92, 232, 150, 134, 216, 119, 81, 188, 158, 246, 17, 105, 16, 230, 228, 2, 155, 24, 78, 132, 58, 119, 196, 148, 161, 211, 168, 251, 144, 82, 118, 209, 0, 3, 123, 193, 186, 42, 30, 128, 216, 82, 196, 203, 13, 12, 36, 122, 76, 6, 90, 153, 20, 87, 161, 166, 37, 216, 33, 229, 244, 77, 21, 254, 137 } });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTextTypeId1",
                table: "Questions",
                column: "QuestionTextTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TargetQuestionId",
                table: "Questions",
                column: "TargetQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetQuestion_AimQuestionId",
                table: "TargetQuestion",
                column: "AimQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionTextTypes_QuestionTextTypeId1",
                table: "Questions",
                column: "QuestionTextTypeId1",
                principalTable: "QuestionTextTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_TargetQuestion_TargetQuestionId",
                table: "Questions",
                column: "TargetQuestionId",
                principalTable: "TargetQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionTextTypes_QuestionTextTypeId1",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_TargetQuestion_TargetQuestionId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "QuestionTextTypes");

            migrationBuilder.DropTable(
                name: "TargetQuestion");

            migrationBuilder.DropTable(
                name: "AimQuestions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionTextTypeId1",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TargetQuestionId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionTextTypeId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionTextTypeId1",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 165, 88, 152, 106, 182, 200, 117, 254, 114, 83, 133, 152, 104, 195, 117, 107, 134, 59, 144, 77, 65, 128, 239, 207, 112, 73, 110, 220, 5, 102, 20, 156, 75, 140, 75, 188, 196, 75, 38, 247, 24, 41, 159, 93, 35, 127, 216, 128, 70, 248, 20, 49, 23, 94, 31, 32, 34, 192, 75, 218, 76, 117, 241, 134 }, new byte[] { 8, 53, 143, 162, 115, 5, 55, 123, 36, 51, 196, 123, 225, 218, 37, 46, 57, 40, 34, 197, 210, 98, 47, 76, 155, 116, 205, 142, 89, 198, 232, 209, 135, 253, 103, 47, 164, 155, 153, 142, 84, 236, 45, 248, 213, 184, 240, 3, 48, 217, 177, 223, 32, 173, 56, 83, 160, 70, 241, 253, 253, 173, 8, 138, 134, 75, 204, 202, 105, 78, 27, 149, 23, 3, 51, 48, 74, 147, 70, 48, 18, 161, 234, 171, 28, 64, 39, 80, 41, 80, 66, 229, 104, 109, 16, 22, 70, 18, 99, 212, 133, 35, 102, 226, 14, 204, 55, 91, 66, 33, 192, 69, 215, 151, 213, 101, 76, 212, 185, 70, 59, 0, 171, 56, 89, 132, 175, 34 } });
        }
    }
}
