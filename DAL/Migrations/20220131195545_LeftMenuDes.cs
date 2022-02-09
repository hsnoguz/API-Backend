using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class LeftMenuDes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LeftMenu",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 217, 219, 31, 41, 169, 62, 64, 81, 206, 71, 5, 6, 61, 9, 154, 248, 65, 120, 108, 63, 185, 47, 200, 147, 236, 57, 168, 83, 135, 197, 5, 14, 95, 144, 30, 164, 110, 239, 3, 84, 36, 237, 90, 35, 30, 97, 31, 166, 156, 89, 219, 121, 85, 174, 158, 157, 78, 68, 230, 92, 166, 83, 181, 85 }, new byte[] { 180, 128, 115, 240, 9, 17, 246, 198, 128, 33, 37, 123, 193, 140, 213, 34, 47, 239, 139, 72, 233, 201, 132, 38, 161, 230, 138, 5, 221, 195, 206, 241, 145, 51, 138, 2, 137, 45, 255, 156, 68, 187, 140, 54, 43, 160, 212, 184, 190, 210, 99, 116, 189, 113, 121, 23, 181, 123, 2, 186, 201, 222, 244, 253, 68, 186, 27, 126, 209, 211, 165, 115, 124, 201, 248, 77, 177, 96, 101, 187, 182, 50, 100, 191, 69, 22, 55, 5, 187, 245, 103, 42, 196, 229, 91, 231, 175, 17, 84, 141, 188, 225, 30, 178, 63, 139, 163, 134, 219, 251, 102, 136, 1, 89, 232, 105, 52, 139, 47, 243, 189, 64, 0, 213, 145, 121, 214, 140 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LeftMenu",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 86, 79, 138, 48, 145, 68, 73, 127, 189, 177, 222, 9, 244, 207, 60, 118, 143, 202, 47, 50, 155, 80, 45, 125, 69, 172, 224, 47, 170, 150, 202, 27, 128, 49, 241, 177, 212, 251, 211, 184, 232, 63, 65, 11, 93, 251, 187, 117, 92, 10, 154, 1, 213, 216, 45, 166, 103, 156, 65, 6, 219, 115, 154, 86 }, new byte[] { 108, 170, 190, 114, 146, 35, 186, 169, 184, 35, 135, 70, 118, 31, 12, 230, 96, 88, 79, 126, 135, 100, 86, 239, 136, 147, 18, 244, 70, 81, 172, 248, 53, 3, 134, 68, 141, 92, 127, 201, 37, 213, 191, 112, 208, 64, 188, 17, 248, 5, 72, 31, 133, 89, 19, 52, 64, 231, 87, 26, 91, 84, 137, 249, 9, 43, 137, 204, 22, 19, 63, 164, 166, 142, 107, 35, 47, 110, 237, 128, 50, 118, 95, 171, 109, 73, 152, 234, 79, 156, 58, 239, 134, 160, 1, 167, 45, 220, 190, 121, 237, 91, 100, 8, 72, 157, 143, 179, 115, 181, 220, 216, 100, 146, 188, 120, 241, 177, 121, 101, 151, 228, 151, 1, 144, 11, 140, 48 } });
        }
    }
}
