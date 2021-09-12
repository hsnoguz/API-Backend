using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class QuestionVerticalPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Point",
                table: "QuestionVerticals",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new byte[] { 179, 167, 10, 126, 205, 141, 177, 179, 168, 240, 42, 184, 122, 192, 6, 253, 86, 222, 163, 38, 157, 190, 178, 1, 120, 169, 10, 205, 16, 15, 113, 14, 115, 13, 162, 163, 246, 36, 125, 183, 119, 243, 238, 173, 112, 202, 172, 112, 233, 99, 163, 130, 159, 110, 27, 170, 119, 168, 121, 255, 33, 153, 207, 62 }, new byte[] { 175, 23, 63, 233, 180, 69, 216, 129, 217, 77, 62, 16, 191, 190, 110, 43, 59, 147, 57, 140, 114, 28, 165, 175, 103, 91, 248, 64, 222, 16, 147, 219, 190, 47, 252, 57, 180, 61, 135, 206, 244, 1, 134, 149, 19, 94, 33, 9, 179, 17, 32, 44, 61, 3, 103, 36, 251, 116, 34, 136, 241, 131, 83, 134, 155, 108, 89, 53, 115, 166, 131, 185, 112, 232, 220, 96, 108, 186, 127, 37, 68, 225, 45, 192, 129, 192, 89, 198, 201, 6, 193, 232, 69, 53, 74, 78, 74, 155, 65, 108, 173, 187, 198, 197, 220, 113, 122, 222, 61, 97, 102, 88, 28, 242, 35, 184, 84, 6, 224, 40, 154, 56, 171, 119, 190, 203, 121, 129 }, "admin@arastirmaturk.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Point",
                table: "QuestionVerticals",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new byte[] { 249, 136, 39, 4, 36, 160, 41, 189, 148, 140, 214, 137, 231, 14, 104, 107, 154, 91, 22, 29, 23, 138, 64, 144, 115, 148, 84, 238, 220, 141, 222, 101, 81, 31, 145, 174, 58, 173, 166, 141, 119, 27, 156, 50, 17, 201, 113, 116, 42, 198, 99, 63, 115, 37, 171, 238, 155, 238, 158, 205, 80, 57, 118, 63 }, new byte[] { 9, 239, 197, 10, 141, 64, 98, 219, 139, 49, 11, 28, 41, 161, 84, 112, 206, 134, 170, 45, 79, 117, 240, 9, 62, 223, 38, 57, 203, 15, 70, 178, 214, 134, 48, 189, 81, 56, 176, 219, 244, 138, 244, 141, 218, 245, 146, 233, 33, 141, 168, 157, 210, 71, 126, 79, 36, 61, 78, 29, 166, 93, 225, 191, 130, 238, 248, 207, 143, 104, 200, 253, 245, 161, 193, 207, 30, 6, 51, 75, 7, 145, 133, 141, 6, 202, 98, 196, 74, 148, 254, 92, 61, 78, 27, 229, 152, 100, 225, 24, 57, 72, 17, 238, 49, 230, 219, 9, 232, 18, 137, 90, 161, 151, 29, 162, 113, 152, 40, 246, 217, 22, 183, 173, 160, 229, 125, 187 }, null });
        }
    }
}
