using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_Users_UserId",
                table: "RefreshToken");

            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken");

            migrationBuilder.AddColumn<int>(
                name: "RefreshTokenId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RefreshTokenId1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 187, 249, 39, 226, 92, 53, 54, 105, 197, 216, 107, 37, 161, 146, 217, 247, 249, 176, 96, 140, 168, 154, 54, 22, 61, 114, 27, 147, 99, 31, 30, 37, 21, 67, 2, 176, 168, 188, 66, 60, 173, 250, 225, 238, 136, 237, 147, 213, 211, 92, 104, 249, 188, 155, 45, 118, 179, 183, 247, 241, 233, 99, 90, 154 }, new byte[] { 168, 234, 6, 253, 42, 125, 17, 247, 64, 152, 29, 100, 217, 1, 113, 132, 226, 103, 139, 99, 43, 58, 250, 243, 121, 168, 3, 227, 232, 223, 35, 134, 117, 19, 164, 114, 245, 248, 85, 7, 207, 101, 116, 72, 75, 6, 213, 44, 29, 41, 69, 172, 181, 114, 239, 27, 58, 19, 29, 95, 15, 115, 194, 202, 133, 138, 53, 0, 253, 145, 150, 166, 175, 184, 168, 215, 81, 2, 255, 253, 182, 245, 139, 232, 245, 28, 200, 142, 235, 219, 62, 249, 148, 89, 213, 144, 39, 43, 2, 1, 118, 114, 22, 254, 65, 77, 16, 162, 44, 186, 162, 142, 10, 80, 6, 106, 48, 52, 177, 132, 224, 169, 76, 93, 44, 180, 236, 83 } });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RefreshTokenId1",
                table: "Users",
                column: "RefreshTokenId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_RefreshToken_RefreshTokenId1",
                table: "Users",
                column: "RefreshTokenId1",
                principalTable: "RefreshToken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_RefreshToken_RefreshTokenId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RefreshTokenId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenId1",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 110, 105, 225, 155, 137, 90, 0, 157, 37, 112, 78, 0, 215, 29, 151, 212, 59, 62, 95, 246, 43, 109, 52, 190, 187, 233, 126, 170, 76, 2, 167, 240, 193, 175, 188, 190, 214, 51, 96, 150, 0, 18, 167, 234, 58, 4, 22, 247, 236, 112, 160, 18, 246, 147, 42, 245, 36, 127, 132, 9, 153, 42, 130, 216 }, new byte[] { 29, 23, 197, 20, 130, 192, 18, 60, 1, 181, 222, 190, 75, 23, 209, 35, 228, 108, 136, 105, 171, 107, 134, 254, 114, 48, 48, 146, 244, 138, 141, 132, 120, 26, 54, 157, 110, 0, 254, 114, 185, 57, 62, 109, 130, 98, 153, 248, 42, 29, 99, 208, 231, 84, 172, 13, 42, 37, 124, 178, 188, 5, 219, 132, 159, 237, 253, 152, 16, 129, 238, 118, 79, 82, 40, 216, 89, 221, 70, 112, 240, 136, 146, 203, 17, 200, 115, 161, 224, 191, 96, 147, 88, 215, 110, 121, 73, 19, 42, 156, 123, 219, 142, 8, 92, 151, 219, 242, 204, 243, 126, 41, 34, 196, 159, 174, 216, 127, 90, 206, 80, 196, 54, 195, 82, 97, 248, 217 } });

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
