using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SignTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SignTypes",
                table: "SignTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignPeriots",
                table: "SignPeriots");

            migrationBuilder.RenameTable(
                name: "SignTypes",
                newName: "SignType");

            migrationBuilder.RenameTable(
                name: "SignPeriots",
                newName: "SignPeriot");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignType",
                table: "SignType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignPeriot",
                table: "SignPeriot",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 143, 133, 183, 3, 0, 178, 128, 205, 91, 231, 136, 53, 211, 10, 199, 82, 38, 2, 160, 199, 211, 70, 232, 249, 125, 0, 72, 161, 156, 134, 152, 5, 114, 88, 12, 214, 121, 9, 81, 228, 240, 177, 72, 230, 25, 106, 61, 167, 33, 116, 170, 67, 46, 47, 74, 30, 250, 69, 161, 120, 0, 97, 239, 0 }, new byte[] { 211, 172, 222, 119, 214, 109, 48, 49, 199, 7, 229, 23, 95, 183, 157, 124, 148, 53, 7, 93, 24, 189, 212, 99, 132, 229, 36, 26, 144, 110, 40, 41, 87, 12, 18, 162, 178, 9, 91, 115, 150, 26, 247, 145, 145, 6, 69, 72, 185, 7, 83, 206, 2, 196, 110, 39, 214, 60, 179, 44, 83, 44, 236, 160, 65, 146, 102, 63, 205, 200, 127, 46, 14, 242, 198, 244, 114, 30, 26, 98, 122, 88, 239, 101, 62, 199, 94, 62, 129, 224, 70, 247, 66, 39, 249, 94, 223, 178, 207, 238, 15, 5, 167, 51, 232, 41, 231, 9, 72, 248, 52, 190, 61, 126, 147, 180, 111, 121, 28, 13, 140, 57, 131, 13, 15, 81, 241, 158 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SignType",
                table: "SignType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignPeriot",
                table: "SignPeriot");

            migrationBuilder.RenameTable(
                name: "SignType",
                newName: "SignTypes");

            migrationBuilder.RenameTable(
                name: "SignPeriot",
                newName: "SignPeriots");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignTypes",
                table: "SignTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignPeriots",
                table: "SignPeriots",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 170, 170, 243, 30, 21, 147, 87, 40, 40, 166, 116, 146, 175, 127, 41, 78, 108, 91, 252, 25, 252, 65, 110, 2, 114, 136, 153, 154, 165, 17, 111, 48, 142, 175, 11, 137, 230, 102, 16, 106, 188, 16, 0, 131, 140, 146, 8, 57, 88, 243, 117, 146, 60, 10, 209, 202, 70, 222, 193, 40, 221, 219, 54 }, new byte[] { 178, 139, 176, 145, 67, 101, 6, 132, 218, 24, 103, 176, 134, 12, 172, 94, 118, 139, 124, 91, 99, 38, 203, 208, 103, 129, 88, 181, 88, 121, 155, 52, 18, 154, 205, 110, 208, 175, 84, 164, 32, 119, 140, 181, 197, 82, 150, 20, 19, 206, 240, 140, 232, 100, 122, 205, 68, 215, 52, 240, 162, 205, 73, 62, 22, 11, 15, 37, 126, 84, 95, 221, 15, 117, 73, 56, 199, 154, 162, 88, 141, 136, 74, 179, 4, 231, 202, 81, 246, 164, 81, 149, 107, 68, 6, 176, 89, 168, 156, 98, 163, 228, 221, 137, 204, 135, 206, 230, 57, 29, 85, 163, 245, 44, 125, 8, 250, 220, 34, 86, 168, 191, 207, 230, 152, 199, 249, 137 } });
        }
    }
}
