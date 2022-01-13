using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class QuestionPuan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Puan",
                table: "Questions",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Puan",
                table: "QuestionHorizontals",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 78, 120, 250, 24, 86, 175, 20, 176, 240, 176, 49, 131, 253, 54, 97, 106, 49, 34, 141, 209, 167, 98, 198, 165, 26, 30, 226, 123, 210, 146, 87, 8, 242, 75, 150, 148, 206, 59, 1, 62, 163, 150, 26, 123, 150, 69, 24, 96, 139, 13, 129, 21, 68, 16, 214, 214, 249, 225, 204, 84, 145, 61, 227, 203 }, new byte[] { 34, 82, 140, 95, 194, 123, 141, 91, 65, 181, 139, 162, 245, 175, 161, 69, 209, 206, 28, 176, 184, 146, 218, 3, 166, 31, 118, 238, 133, 91, 4, 143, 106, 248, 60, 131, 243, 167, 72, 28, 128, 164, 62, 105, 153, 130, 14, 32, 220, 28, 188, 199, 183, 169, 237, 138, 149, 173, 170, 14, 83, 20, 123, 245, 135, 8, 46, 152, 22, 118, 255, 102, 103, 158, 206, 240, 167, 255, 228, 187, 252, 66, 85, 32, 91, 131, 203, 205, 192, 113, 95, 75, 33, 65, 30, 179, 76, 230, 227, 86, 195, 136, 38, 88, 174, 35, 183, 74, 18, 198, 84, 47, 123, 48, 198, 223, 135, 140, 112, 217, 80, 183, 92, 180, 106, 88, 44, 115 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Puan",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Puan",
                table: "QuestionHorizontals");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 37, 107, 97, 30, 201, 96, 26, 126, 188, 7, 109, 253, 109, 152, 0, 89, 147, 239, 78, 78, 251, 161, 180, 74, 96, 110, 50, 169, 32, 2, 85, 141, 81, 96, 111, 240, 74, 24, 137, 233, 8, 102, 221, 196, 143, 250, 6, 55, 65, 171, 155, 107, 15, 209, 28, 125, 112, 151, 200, 234, 116, 43, 100, 200 }, new byte[] { 86, 24, 158, 203, 246, 110, 242, 209, 4, 121, 61, 168, 217, 178, 175, 25, 26, 87, 45, 67, 11, 237, 141, 56, 132, 29, 231, 9, 55, 98, 119, 45, 71, 5, 252, 182, 52, 212, 93, 196, 156, 147, 1, 88, 64, 115, 48, 95, 237, 86, 248, 10, 190, 196, 192, 220, 48, 90, 148, 134, 225, 67, 119, 205, 227, 168, 9, 59, 217, 176, 126, 138, 235, 194, 161, 77, 105, 181, 198, 0, 72, 138, 11, 156, 69, 130, 45, 236, 54, 108, 43, 93, 160, 151, 198, 247, 48, 82, 1, 240, 65, 246, 68, 35, 222, 116, 185, 154, 45, 46, 114, 13, 93, 82, 61, 190, 227, 242, 179, 244, 30, 127, 145, 73, 91, 154, 125, 50 } });
        }
    }
}
