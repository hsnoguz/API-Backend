using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_Users_UserId",
                table: "RefreshToken");

            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken");

            migrationBuilder.RenameColumn(
                name: "TokenId",
                table: "Users",
                newName: "RefreshTokenId1");

            migrationBuilder.AddColumn<int>(
                name: "RefreshTokenId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 73, 193, 37, 144, 56, 80, 198, 69, 122, 255, 243, 63, 27, 80, 95, 118, 237, 247, 93, 202, 154, 87, 205, 69, 28, 209, 42, 194, 146, 0, 253, 73, 160, 165, 90, 233, 198, 91, 184, 244, 85, 133, 94, 237, 127, 180, 164, 140, 99, 53, 82, 51, 187, 104, 218, 223, 101, 139, 156, 213, 251, 26, 114, 55 }, new byte[] { 135, 186, 17, 127, 107, 55, 211, 203, 34, 54, 65, 157, 204, 150, 28, 1, 164, 56, 169, 234, 226, 109, 49, 74, 140, 234, 221, 151, 121, 113, 236, 177, 69, 175, 252, 168, 74, 235, 135, 210, 160, 101, 133, 184, 242, 175, 173, 218, 185, 105, 248, 147, 213, 186, 4, 224, 54, 165, 194, 203, 39, 41, 227, 9, 198, 121, 75, 50, 64, 160, 216, 110, 39, 205, 254, 103, 172, 204, 250, 245, 252, 82, 78, 178, 61, 252, 95, 216, 156, 113, 68, 92, 213, 199, 206, 143, 86, 244, 120, 177, 41, 242, 193, 27, 153, 162, 227, 95, 6, 201, 2, 77, 39, 12, 177, 54, 95, 34, 197, 234, 121, 197, 163, 174, 63, 206, 19, 49 } });

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

            migrationBuilder.RenameColumn(
                name: "RefreshTokenId1",
                table: "Users",
                newName: "TokenId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 116, 14, 134, 40, 81, 77, 231, 72, 224, 199, 13, 156, 242, 240, 99, 113, 19, 158, 149, 161, 156, 64, 129, 29, 184, 255, 248, 162, 64, 151, 212, 68, 85, 164, 243, 101, 201, 109, 139, 120, 124, 244, 66, 249, 57, 142, 69, 165, 157, 205, 19, 2, 28, 8, 248, 132, 150, 30, 160, 80, 30, 96, 222, 136 }, new byte[] { 37, 24, 112, 151, 71, 199, 35, 245, 214, 113, 90, 187, 134, 49, 49, 175, 92, 20, 178, 69, 185, 170, 233, 208, 168, 40, 27, 72, 6, 27, 120, 195, 202, 58, 17, 228, 135, 199, 111, 59, 174, 255, 85, 236, 91, 61, 13, 121, 251, 28, 69, 41, 53, 251, 105, 9, 28, 61, 179, 245, 116, 87, 208, 211, 52, 177, 238, 163, 179, 56, 112, 185, 195, 127, 39, 79, 52, 237, 183, 31, 13, 38, 24, 32, 229, 108, 204, 81, 45, 192, 85, 187, 141, 27, 149, 61, 233, 102, 59, 183, 148, 18, 252, 47, 68, 86, 57, 217, 109, 252, 210, 17, 118, 194, 101, 229, 108, 84, 129, 206, 234, 254, 48, 238, 254, 100, 57, 13 } });

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
