using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new byte[] { 45, 98, 82, 188, 83, 244, 78, 227, 208, 58, 168, 231, 27, 169, 55, 164, 160, 253, 18, 160, 28, 79, 211, 192, 11, 225, 148, 115, 160, 67, 123, 15, 181, 146, 224, 136, 188, 64, 193, 201, 169, 116, 242, 104, 165, 17, 20, 205, 137, 201, 223, 31, 154, 45, 120, 194, 64, 50, 0, 224, 19, 70, 207, 21 }, new byte[] { 161, 83, 198, 235, 181, 234, 224, 127, 69, 109, 207, 94, 35, 186, 207, 164, 172, 62, 92, 205, 81, 174, 197, 14, 176, 28, 54, 93, 14, 157, 192, 54, 223, 58, 117, 145, 183, 252, 217, 183, 79, 6, 124, 76, 62, 90, 78, 194, 10, 17, 5, 28, 239, 25, 73, 234, 150, 12, 151, 183, 115, 172, 15, 237, 67, 208, 215, 247, 209, 155, 65, 124, 130, 175, 129, 76, 155, 186, 177, 215, 60, 79, 66, 228, 16, 192, 151, 4, 97, 103, 195, 65, 3, 82, 100, 54, 19, 137, 116, 166, 187, 224, 175, 171, 46, 73, 69, 250, 90, 95, 128, 5, 221, 21, 208, 220, 89, 91, 91, 13, 116, 208, 104, 74, 132, 145, 147, 205 } });

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
                values: new object[] { new byte[] { 186, 39, 168, 89, 19, 55, 211, 8, 172, 92, 69, 8, 81, 222, 159, 3, 146, 163, 245, 174, 255, 10, 164, 109, 232, 194, 190, 93, 31, 57, 8, 227, 26, 0, 169, 177, 4, 41, 156, 227, 143, 120, 18, 164, 170, 130, 219, 44, 253, 117, 117, 104, 217, 113, 171, 167, 229, 205, 45, 105, 205, 199, 1, 116 }, new byte[] { 95, 219, 236, 123, 148, 150, 105, 243, 2, 170, 151, 77, 72, 55, 241, 157, 38, 186, 196, 50, 148, 66, 108, 203, 210, 169, 231, 216, 24, 113, 107, 81, 25, 123, 65, 229, 238, 66, 225, 22, 93, 251, 56, 241, 77, 75, 130, 211, 152, 5, 105, 234, 121, 207, 18, 66, 109, 107, 145, 234, 142, 1, 240, 246, 28, 253, 156, 15, 108, 129, 122, 81, 157, 62, 12, 177, 18, 237, 101, 152, 164, 216, 238, 246, 10, 14, 253, 51, 194, 58, 80, 51, 237, 193, 28, 167, 96, 9, 223, 235, 12, 154, 131, 128, 142, 175, 218, 135, 3, 111, 19, 205, 130, 179, 130, 23, 173, 110, 162, 202, 175, 60, 21, 2, 39, 157, 249, 220 } });
        }
    }
}
