using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new byte[] { 43, 7, 5, 12, 46, 143, 87, 11, 143, 2, 53, 70, 184, 76, 26, 137, 150, 216, 24, 240, 6, 238, 103, 54, 161, 86, 90, 195, 195, 174, 191, 215, 230, 236, 175, 233, 180, 186, 119, 25, 129, 248, 40, 199, 85, 217, 219, 14, 27, 101, 12, 72, 231, 143, 30, 52, 72, 10, 244, 125, 54, 156, 246, 246 }, new byte[] { 15, 222, 223, 48, 95, 15, 237, 95, 140, 126, 179, 119, 96, 116, 137, 67, 73, 197, 158, 212, 251, 83, 75, 235, 131, 101, 176, 13, 171, 126, 50, 191, 196, 147, 104, 25, 17, 216, 196, 138, 250, 36, 145, 76, 146, 119, 191, 112, 158, 200, 33, 64, 224, 88, 52, 63, 204, 83, 230, 213, 223, 22, 38, 122, 28, 105, 110, 27, 156, 148, 59, 60, 232, 224, 208, 86, 54, 118, 182, 57, 14, 199, 85, 173, 54, 217, 14, 196, 230, 122, 93, 6, 6, 31, 255, 50, 155, 241, 168, 129, 17, 51, 209, 99, 243, 56, 112, 28, 208, 151, 35, 165, 212, 205, 128, 211, 10, 10, 91, 135, 85, 73, 106, 215, 137, 31, 206, 253 } });

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

            migrationBuilder.AddColumn<int>(
                name: "RefreshTokenId",
                table: "Users",
                type: "int",
                nullable: true);

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
                values: new object[] { new byte[] { 169, 26, 91, 8, 0, 111, 36, 24, 190, 11, 251, 245, 186, 82, 33, 113, 31, 103, 232, 220, 19, 234, 143, 86, 214, 247, 65, 244, 143, 84, 47, 43, 8, 179, 40, 91, 33, 124, 45, 253, 65, 47, 237, 33, 206, 92, 173, 76, 128, 154, 209, 162, 230, 200, 180, 204, 131, 158, 13, 15, 236, 82, 135, 101 }, new byte[] { 227, 61, 85, 30, 65, 233, 223, 77, 72, 109, 128, 215, 252, 122, 255, 182, 173, 2, 186, 101, 172, 44, 224, 147, 146, 201, 35, 218, 190, 146, 53, 106, 29, 204, 69, 14, 245, 36, 219, 17, 255, 33, 184, 223, 7, 24, 8, 65, 41, 45, 100, 22, 123, 241, 19, 176, 210, 140, 96, 161, 222, 3, 53, 75, 252, 84, 17, 76, 86, 215, 21, 45, 79, 163, 172, 70, 22, 114, 8, 74, 16, 181, 70, 52, 208, 226, 65, 148, 166, 22, 244, 144, 184, 95, 112, 67, 169, 131, 7, 161, 93, 180, 69, 242, 131, 125, 173, 137, 166, 144, 124, 243, 153, 225, 185, 165, 0, 161, 227, 228, 187, 5, 246, 123, 113, 255, 145, 20 } });

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
    }
}
