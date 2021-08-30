using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken9 : Migration
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
                values: new object[] { new byte[] { 36, 231, 4, 40, 100, 161, 55, 232, 250, 145, 82, 72, 18, 241, 120, 113, 189, 37, 72, 108, 84, 130, 173, 203, 11, 0, 201, 62, 168, 121, 147, 69, 212, 67, 56, 155, 211, 159, 250, 68, 141, 150, 27, 141, 32, 251, 51, 37, 108, 61, 174, 103, 233, 32, 145, 130, 245, 42, 69, 40, 173, 228, 67, 195 }, new byte[] { 44, 209, 155, 144, 139, 11, 61, 38, 88, 49, 0, 141, 197, 239, 232, 139, 61, 100, 232, 160, 204, 238, 58, 89, 240, 17, 56, 205, 248, 74, 34, 151, 208, 93, 223, 207, 233, 17, 136, 53, 7, 117, 236, 50, 249, 37, 21, 178, 211, 176, 74, 155, 247, 155, 28, 82, 214, 42, 140, 219, 207, 181, 250, 11, 194, 153, 234, 23, 85, 180, 137, 191, 182, 253, 238, 38, 211, 245, 122, 69, 169, 50, 160, 47, 242, 176, 14, 81, 194, 243, 128, 48, 149, 134, 93, 233, 239, 125, 187, 81, 176, 84, 181, 184, 220, 171, 132, 16, 172, 231, 217, 83, 143, 55, 90, 135, 246, 30, 185, 163, 143, 194, 176, 82, 71, 192, 145, 153 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
