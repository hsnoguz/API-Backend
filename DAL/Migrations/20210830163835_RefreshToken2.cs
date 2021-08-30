using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            


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
                values: new object[] { new byte[] { 3, 232, 7, 206, 61, 225, 104, 90, 73, 240, 97, 247, 119, 163, 246, 92, 147, 9, 200, 240, 20, 103, 93, 199, 56, 248, 50, 143, 19, 176, 165, 214, 137, 107, 174, 145, 8, 41, 169, 117, 220, 113, 82, 2, 171, 83, 231, 124, 206, 87, 221, 75, 48, 222, 86, 113, 41, 144, 7, 65, 157, 12, 76, 194 }, new byte[] { 6, 175, 147, 44, 188, 38, 136, 17, 39, 202, 156, 63, 193, 96, 201, 161, 247, 101, 92, 61, 36, 209, 123, 235, 71, 160, 213, 121, 143, 158, 26, 33, 50, 237, 231, 93, 11, 218, 250, 9, 101, 238, 126, 215, 8, 69, 81, 51, 53, 195, 58, 151, 205, 124, 69, 101, 35, 241, 135, 55, 74, 140, 29, 135, 96, 225, 10, 205, 90, 29, 243, 13, 246, 75, 118, 254, 112, 191, 103, 190, 53, 39, 92, 38, 68, 144, 242, 31, 255, 103, 43, 176, 208, 143, 141, 57, 18, 161, 210, 160, 250, 209, 161, 218, 166, 142, 161, 113, 95, 226, 225, 123, 61, 6, 44, 149, 31, 206, 113, 72, 201, 141, 149, 81, 143, 90, 85, 13 } });

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
