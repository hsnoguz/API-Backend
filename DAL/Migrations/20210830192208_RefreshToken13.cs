using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
    
            migrationBuilder.DropColumn(
                name: "RefreshTokenId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 181, 33, 43, 209, 207, 164, 57, 147, 226, 86, 204, 109, 65, 135, 123, 198, 68, 174, 155, 59, 110, 127, 147, 0, 144, 185, 22, 253, 214, 156, 82, 129, 126, 63, 10, 36, 7, 155, 153, 54, 68, 255, 45, 36, 200, 219, 76, 52, 176, 235, 39, 119, 113, 221, 132, 68, 222, 34, 110, 31, 146, 50, 4 }, new byte[] { 198, 103, 237, 16, 11, 115, 106, 232, 196, 135, 92, 187, 35, 19, 142, 244, 1, 12, 176, 114, 44, 201, 26, 35, 116, 150, 235, 83, 152, 59, 220, 24, 41, 18, 86, 122, 102, 231, 1, 90, 109, 211, 209, 75, 21, 7, 167, 109, 1, 40, 96, 135, 173, 5, 58, 58, 219, 182, 247, 179, 107, 244, 6, 34, 121, 15, 171, 72, 245, 202, 32, 175, 179, 218, 133, 148, 228, 91, 226, 90, 69, 118, 8, 242, 249, 60, 208, 152, 230, 42, 252, 192, 101, 64, 174, 81, 139, 212, 197, 12, 125, 35, 160, 11, 13, 18, 176, 215, 193, 92, 0, 135, 195, 217, 161, 236, 6, 82, 33, 82, 187, 185, 30, 173, 44, 106, 134, 160 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new byte[] { 27, 253, 106, 74, 238, 144, 87, 16, 58, 250, 206, 82, 205, 224, 254, 206, 107, 64, 176, 124, 59, 241, 108, 119, 90, 35, 113, 157, 77, 166, 60, 16, 200, 9, 246, 108, 91, 211, 38, 252, 201, 21, 64, 76, 68, 53, 53, 65, 16, 33, 218, 191, 165, 40, 160, 220, 249, 83, 99, 16, 234, 88, 138, 7 }, new byte[] { 200, 173, 255, 149, 21, 211, 146, 110, 180, 107, 179, 145, 46, 12, 196, 103, 43, 52, 149, 40, 34, 162, 85, 81, 54, 131, 188, 112, 136, 216, 140, 165, 1, 202, 183, 115, 211, 4, 229, 161, 212, 235, 59, 167, 84, 206, 119, 104, 209, 32, 128, 203, 81, 240, 148, 160, 204, 67, 232, 82, 115, 227, 37, 16, 5, 150, 203, 213, 34, 75, 174, 230, 159, 126, 182, 249, 209, 143, 71, 212, 144, 12, 219, 41, 87, 120, 173, 168, 161, 93, 116, 142, 245, 113, 223, 149, 62, 243, 202, 142, 120, 31, 198, 155, 227, 25, 96, 71, 25, 211, 155, 60, 68, 112, 195, 207, 202, 193, 225, 100, 208, 32, 181, 29, 116, 246, 127, 199 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_RefreshToken_RefreshTokenId",
                table: "Users",
                column: "RefreshTokenId",
                principalTable: "RefreshToken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
