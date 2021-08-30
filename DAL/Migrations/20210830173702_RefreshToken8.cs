using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken8 : Migration
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
                values: new object[] { new byte[] { 186, 161, 10, 229, 147, 84, 2, 216, 225, 143, 79, 101, 171, 96, 194, 185, 124, 47, 54, 238, 198, 181, 41, 201, 115, 77, 68, 124, 94, 9, 183, 3, 25, 97, 194, 101, 234, 181, 2, 60, 19, 198, 119, 250, 231, 51, 164, 145, 155, 13, 36, 6, 162, 200, 72, 147, 221, 152, 181, 24, 95, 213, 181, 56 }, new byte[] { 225, 65, 141, 120, 82, 143, 153, 113, 230, 112, 107, 135, 78, 143, 85, 3, 85, 62, 153, 228, 64, 57, 204, 113, 231, 165, 125, 164, 104, 164, 140, 121, 142, 28, 147, 133, 28, 58, 50, 12, 29, 165, 173, 24, 204, 170, 168, 186, 155, 37, 234, 47, 15, 96, 195, 93, 135, 138, 93, 15, 188, 144, 55, 58, 108, 93, 211, 86, 165, 93, 144, 180, 217, 252, 145, 236, 211, 110, 161, 21, 180, 185, 251, 247, 67, 127, 167, 119, 154, 56, 21, 72, 252, 216, 37, 98, 237, 84, 4, 155, 232, 239, 89, 168, 50, 251, 118, 210, 73, 183, 206, 231, 43, 67, 102, 9, 205, 231, 115, 178, 208, 122, 232, 12, 126, 182, 209, 170 } });

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
    }
}
