using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_Users_UserId",
                table: "RefreshToken");

            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken");

            migrationBuilder.DropColumn(
                name: "TokenId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 186, 39, 168, 89, 19, 55, 211, 8, 172, 92, 69, 8, 81, 222, 159, 3, 146, 163, 245, 174, 255, 10, 164, 109, 232, 194, 190, 93, 31, 57, 8, 227, 26, 0, 169, 177, 4, 41, 156, 227, 143, 120, 18, 164, 170, 130, 219, 44, 253, 117, 117, 104, 217, 113, 171, 167, 229, 205, 45, 105, 205, 199, 1, 116 }, new byte[] { 95, 219, 236, 123, 148, 150, 105, 243, 2, 170, 151, 77, 72, 55, 241, 157, 38, 186, 196, 50, 148, 66, 108, 203, 210, 169, 231, 216, 24, 113, 107, 81, 25, 123, 65, 229, 238, 66, 225, 22, 93, 251, 56, 241, 77, 75, 130, 211, 152, 5, 105, 234, 121, 207, 18, 66, 109, 107, 145, 234, 142, 1, 240, 246, 28, 253, 156, 15, 108, 129, 122, 81, 157, 62, 12, 177, 18, 237, 101, 152, 164, 216, 238, 246, 10, 14, 253, 51, 194, 58, 80, 51, 237, 193, 28, 167, 96, 9, 223, 235, 12, 154, 131, 128, 142, 175, 218, 135, 3, 111, 19, 205, 130, 179, 130, 23, 173, 110, 162, 202, 175, 60, 21, 2, 39, 157, 249, 220 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TokenId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 234, 41, 205, 22, 165, 208, 110, 162, 235, 80, 195, 103, 185, 42, 55, 145, 200, 172, 141, 79, 95, 15, 76, 187, 164, 133, 74, 61, 78, 59, 245, 139, 132, 170, 231, 105, 21, 206, 23, 57, 216, 182, 241, 44, 184, 214, 233, 57, 83, 204, 45, 133, 51, 164, 170, 89, 133, 216, 111, 251, 151, 189, 83 }, new byte[] { 13, 201, 21, 186, 92, 157, 37, 58, 27, 54, 150, 87, 34, 149, 120, 58, 209, 174, 127, 148, 98, 23, 184, 36, 232, 252, 122, 107, 39, 170, 202, 94, 150, 170, 235, 203, 247, 108, 109, 19, 69, 78, 247, 85, 112, 157, 231, 29, 183, 65, 10, 22, 94, 87, 165, 227, 13, 214, 251, 6, 182, 171, 69, 30, 234, 251, 17, 205, 124, 0, 45, 40, 251, 145, 135, 31, 29, 68, 1, 100, 141, 32, 34, 247, 175, 222, 152, 142, 221, 239, 36, 93, 125, 95, 58, 88, 75, 191, 208, 152, 81, 249, 233, 200, 5, 102, 219, 215, 10, 251, 207, 24, 60, 51, 44, 79, 30, 96, 180, 250, 51, 151, 157, 31, 211, 156, 30, 219 } });

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
    }
}
