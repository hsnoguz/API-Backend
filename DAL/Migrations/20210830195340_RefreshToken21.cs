using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TokenId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 234, 41, 205, 22, 165, 208, 110, 162, 235, 80, 195, 103, 185, 42, 55, 145, 200, 172, 141, 79, 95, 15, 76, 187, 164, 133, 74, 61, 78, 59, 245, 139, 132, 170, 231, 105, 21, 206, 23, 57, 216, 182, 241, 44, 184, 214, 233, 57, 83, 204, 45, 133, 51, 164, 170, 89, 133, 216, 111, 251, 151, 189, 83 }, new byte[] { 13, 201, 21, 186, 92, 157, 37, 58, 27, 54, 150, 87, 34, 149, 120, 58, 209, 174, 127, 148, 98, 23, 184, 36, 232, 252, 122, 107, 39, 170, 202, 94, 150, 170, 235, 203, 247, 108, 109, 19, 69, 78, 247, 85, 112, 157, 231, 29, 183, 65, 10, 22, 94, 87, 165, 227, 13, 214, 251, 6, 182, 171, 69, 30, 234, 251, 17, 205, 124, 0, 45, 40, 251, 145, 135, 31, 29, 68, 1, 100, 141, 32, 34, 247, 175, 222, 152, 142, 221, 239, 36, 93, 125, 95, 58, 88, 75, 191, 208, 152, 81, 249, 233, 200, 5, 102, 219, 215, 10, 251, 207, 24, 60, 51, 44, 79, 30, 96, 180, 250, 51, 151, 157, 31, 211, 156, 30, 219 } });

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

            migrationBuilder.DropColumn(
                name: "TokenId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 180, 13, 81, 146, 56, 79, 136, 76, 210, 106, 147, 245, 236, 211, 184, 57, 81, 199, 134, 106, 83, 2, 210, 99, 39, 137, 45, 229, 6, 14, 191, 66, 15, 140, 209, 195, 159, 187, 123, 184, 89, 142, 215, 75, 179, 16, 217, 12, 57, 96, 135, 238, 68, 26, 1, 182, 87, 230, 116, 145, 3, 8, 229, 33 }, new byte[] { 117, 111, 9, 112, 95, 107, 164, 151, 192, 91, 85, 145, 238, 83, 192, 58, 62, 9, 243, 158, 85, 178, 139, 170, 30, 28, 207, 70, 230, 56, 251, 87, 89, 249, 72, 176, 134, 110, 72, 189, 57, 113, 221, 232, 52, 188, 1, 171, 132, 28, 232, 201, 65, 233, 55, 186, 210, 88, 107, 251, 107, 210, 123, 71, 3, 153, 231, 49, 172, 101, 227, 33, 190, 243, 62, 110, 44, 170, 173, 86, 77, 64, 247, 110, 196, 54, 119, 203, 192, 194, 79, 106, 25, 15, 203, 55, 78, 149, 147, 11, 23, 134, 228, 98, 60, 175, 146, 248, 182, 37, 134, 81, 101, 107, 250, 125, 51, 72, 106, 17, 150, 92, 172, 127, 56, 74, 102, 139 } });
        }
    }
}
