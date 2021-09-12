using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class QuestionVerticalPoint3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Value",
                table: "QuestionHorizontals",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 174, 111, 237, 217, 236, 164, 31, 238, 69, 250, 110, 81, 234, 1, 26, 154, 65, 32, 16, 178, 236, 199, 41, 230, 52, 99, 39, 30, 11, 200, 23, 193, 77, 242, 45, 158, 205, 95, 149, 171, 100, 28, 24, 35, 204, 48, 27, 226, 16, 86, 85, 184, 76, 187, 163, 186, 251, 253, 13, 162, 145, 226, 161, 47 }, new byte[] { 204, 88, 110, 254, 192, 210, 115, 29, 231, 157, 42, 240, 202, 107, 34, 72, 179, 224, 19, 212, 121, 55, 2, 244, 143, 227, 115, 113, 201, 48, 56, 145, 237, 203, 120, 240, 206, 223, 41, 55, 53, 114, 70, 244, 120, 83, 61, 67, 174, 232, 17, 201, 224, 150, 7, 234, 227, 242, 125, 137, 126, 170, 31, 75, 53, 153, 47, 117, 165, 24, 157, 170, 172, 222, 121, 12, 65, 49, 223, 153, 106, 22, 193, 43, 64, 240, 180, 31, 191, 219, 224, 242, 150, 144, 23, 237, 187, 198, 150, 127, 216, 244, 93, 29, 15, 48, 34, 211, 158, 119, 230, 246, 125, 0, 231, 22, 34, 3, 11, 152, 241, 145, 249, 102, 236, 65, 231, 34 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Value",
                table: "QuestionHorizontals",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 179, 167, 10, 126, 205, 141, 177, 179, 168, 240, 42, 184, 122, 192, 6, 253, 86, 222, 163, 38, 157, 190, 178, 1, 120, 169, 10, 205, 16, 15, 113, 14, 115, 13, 162, 163, 246, 36, 125, 183, 119, 243, 238, 173, 112, 202, 172, 112, 233, 99, 163, 130, 159, 110, 27, 170, 119, 168, 121, 255, 33, 153, 207, 62 }, new byte[] { 175, 23, 63, 233, 180, 69, 216, 129, 217, 77, 62, 16, 191, 190, 110, 43, 59, 147, 57, 140, 114, 28, 165, 175, 103, 91, 248, 64, 222, 16, 147, 219, 190, 47, 252, 57, 180, 61, 135, 206, 244, 1, 134, 149, 19, 94, 33, 9, 179, 17, 32, 44, 61, 3, 103, 36, 251, 116, 34, 136, 241, 131, 83, 134, 155, 108, 89, 53, 115, 166, 131, 185, 112, 232, 220, 96, 108, 186, 127, 37, 68, 225, 45, 192, 129, 192, 89, 198, 201, 6, 193, 232, 69, 53, 74, 78, 74, 155, 65, 108, 173, 187, 198, 197, 220, 113, 122, 222, 61, 97, 102, 88, 28, 242, 35, 184, 84, 6, 224, 40, 154, 56, 171, 119, 190, 203, 121, 129 } });
        }
    }
}
