using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 168, 115, 145, 86, 58, 117, 173, 155, 7, 171, 127, 218, 175, 116, 220, 210, 41, 98, 113, 209, 249, 217, 207, 106, 229, 199, 198, 179, 24, 165, 137, 238, 157, 70, 221, 20, 178, 93, 115, 168, 169, 175, 217, 88, 133, 180, 141, 69, 42, 234, 0, 224, 98, 195, 219, 75, 126, 229, 21, 164, 255, 2, 214 }, new byte[] { 10, 10, 42, 84, 132, 250, 141, 155, 132, 24, 234, 114, 241, 120, 214, 166, 100, 32, 125, 201, 11, 131, 73, 183, 11, 88, 40, 215, 152, 142, 33, 204, 162, 49, 234, 6, 104, 116, 71, 239, 205, 246, 231, 32, 46, 227, 95, 87, 233, 109, 40, 236, 169, 156, 85, 210, 187, 253, 119, 223, 202, 151, 166, 70, 6, 213, 93, 220, 149, 89, 156, 90, 14, 54, 29, 90, 47, 77, 211, 90, 76, 87, 106, 94, 110, 148, 87, 94, 201, 101, 206, 247, 47, 212, 194, 103, 135, 154, 175, 221, 60, 122, 218, 40, 249, 97, 244, 227, 27, 36, 85, 37, 146, 24, 242, 206, 204, 136, 46, 239, 208, 211, 142, 44, 107, 120, 124, 106 } });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 181, 33, 43, 209, 207, 164, 57, 147, 226, 86, 204, 109, 65, 135, 123, 198, 68, 174, 155, 59, 110, 127, 147, 0, 144, 185, 22, 253, 214, 156, 82, 129, 126, 63, 10, 36, 7, 155, 153, 54, 68, 255, 45, 36, 200, 219, 76, 52, 176, 235, 39, 119, 113, 221, 132, 68, 222, 34, 110, 31, 146, 50, 4 }, new byte[] { 198, 103, 237, 16, 11, 115, 106, 232, 196, 135, 92, 187, 35, 19, 142, 244, 1, 12, 176, 114, 44, 201, 26, 35, 116, 150, 235, 83, 152, 59, 220, 24, 41, 18, 86, 122, 102, 231, 1, 90, 109, 211, 209, 75, 21, 7, 167, 109, 1, 40, 96, 135, 173, 5, 58, 58, 219, 182, 247, 179, 107, 244, 6, 34, 121, 15, 171, 72, 245, 202, 32, 175, 179, 218, 133, 148, 228, 91, 226, 90, 69, 118, 8, 242, 249, 60, 208, 152, 230, 42, 252, 192, 101, 64, 174, 81, 139, 212, 197, 12, 125, 35, 160, 11, 13, 18, 176, 215, 193, 92, 0, 135, 195, 217, 161, 236, 6, 82, 33, 82, 187, 185, 30, 173, 44, 106, 134, 160 } });
        }
    }
}
