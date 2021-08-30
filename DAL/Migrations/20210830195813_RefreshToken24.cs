using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken24 : Migration
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
                values: new object[] { new byte[] { 241, 57, 58, 58, 148, 161, 152, 56, 219, 146, 141, 74, 112, 31, 15, 67, 96, 61, 189, 206, 187, 233, 54, 227, 22, 23, 23, 10, 55, 220, 222, 204, 38, 178, 116, 125, 59, 111, 115, 202, 116, 25, 218, 143, 49, 253, 171, 18, 41, 250, 88, 181, 61, 138, 113, 80, 197, 116, 127, 9, 111, 55, 70, 93 }, new byte[] { 73, 204, 28, 155, 189, 120, 126, 48, 73, 105, 51, 250, 253, 164, 118, 192, 227, 9, 247, 159, 50, 75, 61, 88, 160, 189, 13, 34, 94, 1, 64, 218, 214, 110, 177, 89, 42, 123, 159, 117, 87, 30, 106, 189, 103, 195, 219, 211, 254, 252, 28, 63, 172, 220, 178, 124, 174, 237, 22, 186, 128, 104, 5, 131, 132, 126, 244, 76, 255, 38, 49, 200, 252, 127, 122, 149, 10, 208, 214, 184, 31, 10, 162, 91, 22, 204, 131, 38, 153, 82, 245, 177, 112, 6, 63, 82, 42, 80, 83, 5, 21, 197, 222, 135, 107, 69, 184, 38, 151, 12, 18, 193, 16, 221, 57, 8, 166, 139, 81, 156, 166, 171, 225, 207, 176, 77, 23, 160 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
