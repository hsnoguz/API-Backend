using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken18 : Migration
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
                values: new object[] { new byte[] { 180, 13, 81, 146, 56, 79, 136, 76, 210, 106, 147, 245, 236, 211, 184, 57, 81, 199, 134, 106, 83, 2, 210, 99, 39, 137, 45, 229, 6, 14, 191, 66, 15, 140, 209, 195, 159, 187, 123, 184, 89, 142, 215, 75, 179, 16, 217, 12, 57, 96, 135, 238, 68, 26, 1, 182, 87, 230, 116, 145, 3, 8, 229, 33 }, new byte[] { 117, 111, 9, 112, 95, 107, 164, 151, 192, 91, 85, 145, 238, 83, 192, 58, 62, 9, 243, 158, 85, 178, 139, 170, 30, 28, 207, 70, 230, 56, 251, 87, 89, 249, 72, 176, 134, 110, 72, 189, 57, 113, 221, 232, 52, 188, 1, 171, 132, 28, 232, 201, 65, 233, 55, 186, 210, 88, 107, 251, 107, 210, 123, 71, 3, 153, 231, 49, 172, 101, 227, 33, 190, 243, 62, 110, 44, 170, 173, 86, 77, 64, 247, 110, 196, 54, 119, 203, 192, 194, 79, 106, 25, 15, 203, 55, 78, 149, 147, 11, 23, 134, 228, 98, 60, 175, 146, 248, 182, 37, 134, 81, 101, 107, 250, 125, 51, 72, 106, 17, 150, 92, 172, 127, 56, 74, 102, 139 } });
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
                values: new object[] { new byte[] { 73, 193, 37, 144, 56, 80, 198, 69, 122, 255, 243, 63, 27, 80, 95, 118, 237, 247, 93, 202, 154, 87, 205, 69, 28, 209, 42, 194, 146, 0, 253, 73, 160, 165, 90, 233, 198, 91, 184, 244, 85, 133, 94, 237, 127, 180, 164, 140, 99, 53, 82, 51, 187, 104, 218, 223, 101, 139, 156, 213, 251, 26, 114, 55 }, new byte[] { 135, 186, 17, 127, 107, 55, 211, 203, 34, 54, 65, 157, 204, 150, 28, 1, 164, 56, 169, 234, 226, 109, 49, 74, 140, 234, 221, 151, 121, 113, 236, 177, 69, 175, 252, 168, 74, 235, 135, 210, 160, 101, 133, 184, 242, 175, 173, 218, 185, 105, 248, 147, 213, 186, 4, 224, 54, 165, 194, 203, 39, 41, 227, 9, 198, 121, 75, 50, 64, 160, 216, 110, 39, 205, 254, 103, 172, 204, 250, 245, 252, 82, 78, 178, 61, 252, 95, 216, 156, 113, 68, 92, 213, 199, 206, 143, 86, 244, 120, 177, 41, 242, 193, 27, 153, 162, 227, 95, 6, 201, 2, 77, 39, 12, 177, 54, 95, 34, 197, 234, 121, 197, 163, 174, 63, 206, 19, 49 } });

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
