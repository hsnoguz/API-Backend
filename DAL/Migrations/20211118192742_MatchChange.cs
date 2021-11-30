using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MatchChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Organizations_OrganizationId",
                table: "Performances");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "Performances",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 119, 172, 89, 34, 246, 147, 105, 45, 163, 221, 125, 58, 38, 227, 237, 57, 40, 111, 14, 114, 224, 9, 25, 4, 100, 207, 184, 39, 144, 181, 179, 216, 191, 221, 128, 19, 42, 182, 75, 156, 204, 166, 83, 223, 38, 157, 202, 126, 127, 187, 111, 80, 219, 21, 56, 60, 85, 8, 50, 210, 133, 239, 131 }, new byte[] { 20, 70, 88, 202, 198, 56, 180, 88, 82, 68, 214, 214, 247, 129, 32, 41, 152, 89, 53, 16, 11, 2, 98, 172, 6, 1, 184, 205, 221, 58, 220, 110, 219, 108, 167, 229, 53, 172, 43, 46, 72, 123, 146, 176, 98, 49, 64, 89, 32, 78, 22, 139, 241, 13, 1, 24, 240, 189, 232, 226, 65, 17, 82, 0, 28, 220, 192, 248, 150, 179, 28, 130, 134, 42, 250, 138, 139, 131, 43, 13, 176, 50, 110, 181, 223, 14, 167, 69, 21, 71, 204, 153, 104, 225, 141, 175, 5, 232, 85, 248, 71, 248, 233, 55, 19, 251, 78, 126, 45, 174, 18, 227, 241, 206, 94, 244, 76, 206, 200, 183, 124, 11, 166, 167, 151, 165, 208, 185 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Organizations_OrganizationId",
                table: "Performances",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Organizations_OrganizationId",
                table: "Performances");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "Performances",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 17, 110, 150, 156, 145, 207, 196, 247, 29, 42, 113, 96, 65, 132, 49, 230, 206, 241, 252, 251, 150, 13, 53, 124, 110, 107, 26, 1, 107, 117, 56, 88, 61, 32, 182, 21, 25, 79, 107, 107, 160, 72, 246, 55, 106, 124, 70, 123, 8, 192, 41, 76, 116, 53, 8, 88, 93, 101, 97, 149, 78, 218, 146, 48 }, new byte[] { 136, 217, 75, 213, 202, 179, 220, 105, 13, 26, 190, 176, 232, 72, 52, 120, 26, 35, 65, 211, 68, 123, 74, 191, 227, 109, 234, 135, 138, 32, 209, 234, 98, 154, 69, 34, 240, 30, 192, 131, 159, 124, 221, 253, 44, 157, 194, 245, 70, 225, 151, 61, 223, 6, 81, 26, 26, 118, 243, 46, 154, 219, 100, 60, 82, 161, 245, 230, 21, 153, 163, 118, 161, 253, 11, 45, 96, 79, 113, 72, 171, 114, 81, 16, 68, 55, 172, 81, 147, 229, 245, 129, 2, 49, 9, 65, 227, 51, 91, 112, 39, 162, 126, 202, 223, 104, 26, 135, 107, 236, 70, 11, 43, 1, 118, 100, 198, 211, 232, 221, 170, 145, 116, 159, 132, 238, 17, 34 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Organizations_OrganizationId",
                table: "Performances",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
