using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RTokenId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 32, 166, 53, 210, 199, 243, 155, 70, 49, 56, 203, 254, 36, 149, 30, 61, 37, 211, 163, 136, 130, 48, 114, 47, 15, 230, 119, 141, 24, 5, 190, 108, 23, 53, 176, 159, 39, 255, 190, 201, 138, 2, 127, 50, 114, 148, 29, 90, 56, 213, 244, 194, 113, 231, 138, 21, 89, 164, 114, 207, 204, 10, 0, 101 }, new byte[] { 85, 5, 144, 117, 15, 124, 93, 140, 79, 60, 231, 34, 41, 250, 172, 233, 236, 179, 32, 173, 91, 199, 86, 154, 95, 160, 20, 245, 72, 248, 28, 42, 122, 26, 88, 158, 226, 135, 50, 41, 93, 197, 68, 135, 144, 6, 116, 191, 105, 226, 13, 66, 122, 124, 210, 38, 116, 90, 21, 129, 221, 120, 151, 242, 80, 240, 204, 166, 147, 228, 150, 70, 42, 161, 81, 217, 19, 241, 203, 0, 158, 98, 188, 83, 51, 32, 209, 86, 142, 246, 252, 226, 217, 70, 118, 17, 24, 115, 25, 121, 156, 110, 243, 229, 35, 227, 229, 55, 132, 158, 49, 165, 253, 62, 98, 147, 168, 165, 27, 189, 125, 30, 140, 143, 79, 87, 58, 105 } });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshToken_Users_UserId",
                table: "RefreshToken",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_Users_UserId",
                table: "RefreshToken");

            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken");

            migrationBuilder.DropColumn(
                name: "RTokenId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 241, 57, 58, 58, 148, 161, 152, 56, 219, 146, 141, 74, 112, 31, 15, 67, 96, 61, 189, 206, 187, 233, 54, 227, 22, 23, 23, 10, 55, 220, 222, 204, 38, 178, 116, 125, 59, 111, 115, 202, 116, 25, 218, 143, 49, 253, 171, 18, 41, 250, 88, 181, 61, 138, 113, 80, 197, 116, 127, 9, 111, 55, 70, 93 }, new byte[] { 73, 204, 28, 155, 189, 120, 126, 48, 73, 105, 51, 250, 253, 164, 118, 192, 227, 9, 247, 159, 50, 75, 61, 88, 160, 189, 13, 34, 94, 1, 64, 218, 214, 110, 177, 89, 42, 123, 159, 117, 87, 30, 106, 189, 103, 195, 219, 211, 254, 252, 28, 63, 172, 220, 178, 124, 174, 237, 22, 186, 128, 104, 5, 131, 132, 126, 244, 76, 255, 38, 49, 200, 252, 127, 122, 149, 10, 208, 214, 184, 31, 10, 162, 91, 22, 204, 131, 38, 153, 82, 245, 177, 112, 6, 63, 82, 42, 80, 83, 5, 21, 197, 222, 135, 107, 69, 184, 38, 151, 12, 18, 193, 16, 221, 57, 8, 166, 139, 81, 156, 166, 171, 225, 207, 176, 77, 23, 160 } });
        }
    }
}
