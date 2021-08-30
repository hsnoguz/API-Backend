using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new byte[] { 212, 231, 87, 208, 182, 5, 17, 112, 26, 103, 215, 21, 103, 230, 253, 9, 217, 225, 219, 15, 3, 110, 45, 102, 228, 18, 155, 83, 4, 238, 180, 205, 12, 38, 79, 204, 149, 37, 193, 27, 142, 13, 198, 223, 192, 99, 69, 160, 230, 146, 135, 79, 124, 110, 38, 155, 243, 19, 110, 84, 64, 95, 156, 64 }, new byte[] { 112, 176, 19, 116, 123, 208, 50, 169, 12, 13, 5, 161, 157, 178, 202, 198, 205, 34, 224, 197, 225, 183, 153, 86, 48, 38, 41, 123, 231, 68, 104, 77, 53, 245, 243, 103, 245, 62, 212, 174, 12, 245, 169, 209, 132, 177, 152, 195, 93, 172, 125, 90, 153, 72, 147, 176, 192, 153, 179, 18, 227, 248, 104, 51, 5, 95, 21, 180, 123, 163, 128, 93, 104, 192, 106, 65, 50, 136, 51, 161, 180, 37, 90, 233, 216, 23, 252, 238, 199, 148, 233, 216, 21, 137, 164, 239, 32, 201, 26, 72, 6, 159, 19, 31, 117, 162, 203, 229, 111, 212, 133, 160, 45, 193, 161, 76, 132, 224, 6, 86, 251, 5, 55, 37, 83, 11, 0, 119 } });

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
                values: new object[] { new byte[] { 36, 231, 4, 40, 100, 161, 55, 232, 250, 145, 82, 72, 18, 241, 120, 113, 189, 37, 72, 108, 84, 130, 173, 203, 11, 0, 201, 62, 168, 121, 147, 69, 212, 67, 56, 155, 211, 159, 250, 68, 141, 150, 27, 141, 32, 251, 51, 37, 108, 61, 174, 103, 233, 32, 145, 130, 245, 42, 69, 40, 173, 228, 67, 195 }, new byte[] { 44, 209, 155, 144, 139, 11, 61, 38, 88, 49, 0, 141, 197, 239, 232, 139, 61, 100, 232, 160, 204, 238, 58, 89, 240, 17, 56, 205, 248, 74, 34, 151, 208, 93, 223, 207, 233, 17, 136, 53, 7, 117, 236, 50, 249, 37, 21, 178, 211, 176, 74, 155, 247, 155, 28, 82, 214, 42, 140, 219, 207, 181, 250, 11, 194, 153, 234, 23, 85, 180, 137, 191, 182, 253, 238, 38, 211, 245, 122, 69, 169, 50, 160, 47, 242, 176, 14, 81, 194, 243, 128, 48, 149, 134, 93, 233, 239, 125, 187, 81, 176, 84, 181, 184, 220, 171, 132, 16, 172, 231, 217, 83, 143, 55, 90, 135, 246, 30, 185, 163, 143, 194, 176, 82, 71, 192, 145, 153 } });
        }
    }
}
