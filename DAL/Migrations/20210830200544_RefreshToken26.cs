using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_Users_UserId",
                table: "RefreshToken");

            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken");

            migrationBuilder.DropColumn(
                name: "RTokenId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 9, 60, 203, 53, 95, 193, 54, 139, 235, 26, 85, 225, 206, 210, 204, 58, 165, 103, 66, 106, 189, 72, 102, 39, 233, 17, 222, 87, 193, 235, 184, 124, 100, 56, 103, 201, 88, 138, 8, 162, 43, 18, 190, 202, 49, 6, 213, 229, 205, 26, 248, 100, 143, 251, 117, 191, 183, 179, 55, 228, 77, 163, 14 }, new byte[] { 30, 77, 29, 170, 218, 138, 38, 56, 150, 91, 12, 233, 133, 13, 126, 135, 77, 73, 251, 16, 200, 58, 87, 162, 59, 79, 105, 151, 181, 225, 56, 94, 33, 179, 27, 29, 41, 216, 237, 83, 118, 153, 22, 82, 202, 135, 215, 57, 27, 180, 244, 84, 91, 144, 86, 5, 226, 17, 46, 158, 135, 101, 128, 26, 102, 85, 161, 136, 45, 121, 55, 33, 155, 84, 15, 154, 186, 219, 96, 71, 12, 238, 82, 26, 37, 82, 172, 78, 91, 173, 247, 20, 55, 109, 225, 194, 115, 206, 222, 161, 61, 182, 37, 129, 178, 90, 149, 73, 251, 76, 109, 255, 151, 68, 225, 70, 200, 146, 153, 200, 134, 243, 210, 137, 5, 105, 51, 111 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RTokenId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 32, 166, 53, 210, 199, 243, 155, 70, 49, 56, 203, 254, 36, 149, 30, 61, 37, 211, 163, 136, 130, 48, 114, 47, 15, 230, 119, 141, 24, 5, 190, 108, 23, 53, 176, 159, 39, 255, 190, 201, 138, 2, 127, 50, 114, 148, 29, 90, 56, 213, 244, 194, 113, 231, 138, 21, 89, 164, 114, 207, 204, 10, 0, 101 }, new byte[] { 85, 5, 144, 117, 15, 124, 93, 140, 79, 60, 231, 34, 41, 250, 172, 233, 236, 179, 32, 173, 91, 199, 86, 154, 95, 160, 20, 245, 72, 248, 28, 42, 122, 26, 88, 158, 226, 135, 50, 41, 93, 197, 68, 135, 144, 6, 116, 191, 105, 226, 13, 66, 122, 124, 210, 38, 116, 90, 21, 129, 221, 120, 151, 242, 80, 240, 204, 166, 147, 228, 150, 70, 42, 161, 81, 217, 19, 241, 203, 0, 158, 98, 188, 83, 51, 32, 209, 86, 142, 246, 252, 226, 217, 70, 118, 17, 24, 115, 25, 121, 156, 110, 243, 229, 35, 227, 229, 55, 132, 158, 49, 165, 253, 62, 98, 147, 168, 165, 27, 189, 125, 30, 140, 143, 79, 87, 58, 105 } });

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
