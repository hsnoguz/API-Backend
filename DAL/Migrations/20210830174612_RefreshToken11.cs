using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RefreshToken11 : Migration
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
                values: new object[] { new byte[] { 90, 47, 215, 26, 38, 164, 72, 49, 50, 60, 140, 39, 120, 218, 27, 208, 48, 142, 201, 178, 183, 84, 33, 199, 106, 23, 47, 148, 140, 86, 234, 84, 67, 107, 224, 34, 186, 37, 143, 99, 134, 135, 118, 76, 239, 35, 31, 102, 110, 254, 190, 57, 44, 37, 97, 159, 185, 17, 181, 192, 101, 204, 149, 121 }, new byte[] { 190, 98, 103, 235, 18, 149, 117, 218, 220, 12, 184, 88, 55, 216, 142, 168, 96, 83, 169, 192, 133, 209, 152, 239, 179, 176, 252, 221, 250, 17, 245, 178, 70, 230, 253, 116, 192, 66, 19, 50, 63, 169, 230, 129, 125, 2, 134, 198, 70, 210, 149, 52, 196, 51, 61, 6, 113, 164, 210, 28, 131, 14, 169, 102, 161, 70, 253, 60, 239, 160, 73, 47, 224, 73, 248, 208, 180, 210, 237, 136, 205, 238, 131, 86, 189, 238, 18, 252, 72, 220, 131, 10, 122, 171, 235, 234, 246, 99, 176, 82, 248, 36, 130, 105, 194, 61, 26, 236, 58, 102, 77, 53, 179, 165, 6, 216, 220, 175, 203, 156, 172, 182, 100, 46, 160, 236, 94, 61 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
