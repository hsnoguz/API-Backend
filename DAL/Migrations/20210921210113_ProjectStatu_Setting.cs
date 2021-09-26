using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectStatu_Setting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOpen",
                table: "QuestionVerticals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "SurveyStatu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Statu = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyStatu", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 171, 133, 147, 14, 22, 51, 232, 25, 168, 116, 181, 84, 92, 37, 186, 147, 126, 10, 105, 194, 136, 183, 82, 108, 55, 235, 46, 75, 90, 229, 182, 87, 14, 130, 30, 139, 120, 246, 28, 195, 2, 158, 55, 28, 117, 50, 186, 223, 47, 139, 23, 125, 189, 213, 2, 41, 228, 158, 109, 121, 107, 51, 20, 217 }, new byte[] { 51, 198, 40, 201, 168, 207, 172, 84, 186, 8, 235, 227, 124, 5, 156, 222, 39, 109, 11, 205, 80, 25, 170, 216, 102, 125, 143, 135, 182, 47, 99, 73, 71, 215, 109, 190, 220, 52, 43, 160, 122, 126, 120, 249, 99, 78, 13, 165, 53, 86, 91, 66, 66, 213, 161, 234, 4, 36, 217, 183, 175, 41, 178, 72, 31, 50, 64, 140, 7, 233, 152, 106, 70, 230, 49, 35, 179, 37, 85, 182, 83, 134, 236, 120, 254, 59, 100, 242, 233, 189, 190, 176, 49, 107, 128, 244, 126, 210, 200, 29, 165, 112, 10, 151, 35, 172, 214, 117, 208, 7, 37, 117, 172, 231, 2, 91, 242, 14, 56, 198, 233, 206, 110, 79, 42, 162, 250, 149 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyStatu");

            migrationBuilder.DropColumn(
                name: "IsOpen",
                table: "QuestionVerticals");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 200, 119, 20, 27, 252, 74, 14, 91, 57, 104, 120, 24, 165, 211, 39, 190, 159, 106, 224, 204, 150, 143, 151, 231, 2, 205, 248, 219, 29, 79, 117, 134, 197, 174, 22, 22, 33, 105, 118, 4, 245, 207, 194, 194, 62, 177, 164, 186, 38, 231, 250, 64, 104, 152, 112, 195, 120, 198, 122, 107, 202, 170, 130, 97 }, new byte[] { 186, 139, 185, 6, 30, 143, 124, 180, 49, 111, 131, 241, 69, 126, 191, 252, 131, 11, 33, 9, 196, 178, 192, 220, 56, 77, 114, 99, 53, 169, 185, 8, 46, 136, 108, 166, 19, 224, 252, 248, 22, 140, 67, 179, 182, 211, 215, 153, 85, 211, 222, 212, 243, 158, 144, 31, 208, 192, 0, 142, 123, 48, 20, 67, 67, 35, 88, 8, 27, 240, 198, 26, 30, 229, 207, 228, 123, 32, 109, 53, 111, 192, 134, 52, 10, 207, 165, 40, 65, 211, 230, 11, 0, 52, 4, 114, 144, 229, 49, 165, 31, 132, 222, 123, 16, 146, 79, 93, 88, 74, 103, 239, 187, 245, 62, 93, 138, 88, 150, 249, 222, 173, 28, 101, 203, 253, 4, 188 } });
        }
    }
}
