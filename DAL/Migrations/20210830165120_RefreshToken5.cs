using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken5 : Migration
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
                values: new object[] { new byte[] { 89, 115, 107, 114, 19, 131, 222, 167, 67, 37, 227, 118, 168, 47, 120, 56, 163, 41, 83, 111, 99, 220, 52, 50, 234, 105, 110, 37, 42, 105, 5, 241, 122, 243, 95, 148, 221, 101, 88, 129, 150, 255, 41, 156, 30, 201, 179, 24, 97, 187, 144, 54, 94, 55, 119, 29, 213, 7, 48, 112, 42, 164, 96, 22 }, new byte[] { 64, 154, 106, 30, 131, 43, 11, 151, 75, 170, 27, 86, 156, 247, 252, 19, 207, 126, 48, 113, 221, 134, 249, 105, 43, 64, 48, 55, 33, 176, 194, 73, 149, 62, 131, 177, 116, 112, 247, 90, 7, 156, 77, 4, 187, 94, 113, 171, 58, 197, 224, 121, 187, 154, 99, 232, 21, 16, 102, 74, 12, 212, 180, 180, 245, 79, 77, 85, 60, 47, 183, 160, 2, 206, 99, 65, 14, 75, 112, 118, 150, 213, 17, 146, 92, 177, 16, 199, 78, 87, 210, 88, 13, 129, 65, 156, 201, 74, 209, 12, 97, 251, 102, 202, 49, 144, 17, 204, 75, 155, 64, 93, 145, 10, 0, 113, 252, 92, 214, 203, 49, 67, 125, 252, 169, 196, 111, 234 } });

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
    }
}
