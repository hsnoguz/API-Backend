using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken4 : Migration
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
                values: new object[] { new byte[] { 141, 29, 136, 208, 29, 30, 152, 173, 112, 202, 144, 236, 58, 43, 137, 153, 175, 58, 195, 184, 219, 51, 42, 110, 143, 226, 30, 70, 70, 5, 227, 105, 101, 156, 103, 178, 75, 187, 177, 120, 188, 166, 226, 48, 242, 88, 213, 145, 152, 248, 216, 203, 255, 66, 79, 172, 89, 144, 128, 17, 20, 76, 138, 88 }, new byte[] { 226, 173, 110, 193, 41, 253, 59, 112, 2, 67, 126, 117, 29, 209, 12, 215, 16, 164, 225, 243, 52, 167, 93, 11, 171, 99, 119, 125, 0, 7, 98, 204, 91, 223, 78, 15, 108, 8, 216, 38, 121, 56, 177, 228, 110, 194, 154, 30, 204, 134, 86, 104, 26, 200, 181, 138, 172, 144, 183, 74, 130, 141, 223, 26, 240, 205, 132, 254, 111, 1, 171, 46, 101, 253, 92, 18, 245, 212, 133, 194, 0, 105, 10, 146, 100, 238, 110, 220, 109, 96, 169, 156, 156, 134, 125, 13, 113, 18, 218, 24, 182, 230, 7, 70, 92, 100, 149, 60, 113, 248, 67, 245, 140, 66, 144, 129, 166, 184, 255, 22, 42, 3, 243, 152, 205, 37, 253, 196 } });

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
    }
}
