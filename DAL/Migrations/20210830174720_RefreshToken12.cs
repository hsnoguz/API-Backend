using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefreshTokenId",
                table: "Users",
                type: "int",
                nullable: true);

        /*    migrationBuilder.AddColumn<int>(
                name: "RefreshTokenId1",
                table: "Users",
                type: "int",
                nullable: true);*/

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 27, 253, 106, 74, 238, 144, 87, 16, 58, 250, 206, 82, 205, 224, 254, 206, 107, 64, 176, 124, 59, 241, 108, 119, 90, 35, 113, 157, 77, 166, 60, 16, 200, 9, 246, 108, 91, 211, 38, 252, 201, 21, 64, 76, 68, 53, 53, 65, 16, 33, 218, 191, 165, 40, 160, 220, 249, 83, 99, 16, 234, 88, 138, 7 }, new byte[] { 200, 173, 255, 149, 21, 211, 146, 110, 180, 107, 179, 145, 46, 12, 196, 103, 43, 52, 149, 40, 34, 162, 85, 81, 54, 131, 188, 112, 136, 216, 140, 165, 1, 202, 183, 115, 211, 4, 229, 161, 212, 235, 59, 167, 84, 206, 119, 104, 209, 32, 128, 203, 81, 240, 148, 160, 204, 67, 232, 82, 115, 227, 37, 16, 5, 150, 203, 213, 34, 75, 174, 230, 159, 126, 182, 249, 209, 143, 71, 212, 144, 12, 219, 41, 87, 120, 173, 168, 161, 93, 116, 142, 245, 113, 223, 149, 62, 243, 202, 142, 120, 31, 198, 155, 227, 25, 96, 71, 25, 211, 155, 60, 68, 112, 195, 207, 202, 193, 225, 100, 208, 32, 181, 29, 116, 246, 127, 199 } });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RefreshTokenId1",
                table: "Users",
                column: "RefreshTokenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_RefreshToken_RefreshTokenId1",
                table: "Users",
                column: "RefreshTokenId",
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
                values: new object[] { new byte[] { 90, 47, 215, 26, 38, 164, 72, 49, 50, 60, 140, 39, 120, 218, 27, 208, 48, 142, 201, 178, 183, 84, 33, 199, 106, 23, 47, 148, 140, 86, 234, 84, 67, 107, 224, 34, 186, 37, 143, 99, 134, 135, 118, 76, 239, 35, 31, 102, 110, 254, 190, 57, 44, 37, 97, 159, 185, 17, 181, 192, 101, 204, 149, 121 }, new byte[] { 190, 98, 103, 235, 18, 149, 117, 218, 220, 12, 184, 88, 55, 216, 142, 168, 96, 83, 169, 192, 133, 209, 152, 239, 179, 176, 252, 221, 250, 17, 245, 178, 70, 230, 253, 116, 192, 66, 19, 50, 63, 169, 230, 129, 125, 2, 134, 198, 70, 210, 149, 52, 196, 51, 61, 6, 113, 164, 210, 28, 131, 14, 169, 102, 161, 70, 253, 60, 239, 160, 73, 47, 224, 73, 248, 208, 180, 210, 237, 136, 205, 238, 131, 86, 189, 238, 18, 252, 72, 220, 131, 10, 122, 171, 235, 234, 246, 99, 176, 82, 248, 36, 130, 105, 194, 61, 26, 236, 58, 102, 77, 53, 179, 165, 6, 216, 220, 175, 203, 156, 172, 182, 100, 46, 160, 236, 94, 61 } });
        }
    }
}
