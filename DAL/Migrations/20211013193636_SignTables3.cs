using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SignTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new byte[] { 192, 152, 23, 4, 25, 237, 144, 212, 239, 235, 185, 191, 72, 19, 186, 157, 208, 181, 131, 161, 106, 11, 60, 99, 94, 212, 103, 145, 171, 85, 53, 61, 15, 243, 139, 187, 151, 238, 167, 210, 203, 83, 96, 171, 49, 200, 167, 249, 255, 52, 65, 34, 238, 140, 240, 55, 49, 103, 253, 154, 37, 169, 113, 56 }, new byte[] { 38, 9, 87, 32, 203, 52, 92, 105, 19, 146, 163, 221, 95, 71, 82, 58, 198, 185, 232, 225, 25, 43, 85, 143, 54, 64, 137, 177, 169, 239, 254, 157, 0, 238, 178, 72, 0, 255, 229, 41, 237, 175, 92, 80, 84, 32, 145, 205, 44, 145, 228, 134, 24, 147, 214, 25, 65, 103, 129, 70, 193, 239, 184, 39, 177, 254, 110, 199, 86, 28, 220, 209, 101, 215, 60, 107, 214, 164, 141, 206, 103, 56, 118, 224, 1, 185, 110, 70, 225, 160, 205, 55, 160, 138, 132, 7, 104, 141, 18, 219, 17, 1, 27, 137, 143, 249, 72, 215, 252, 33, 45, 219, 31, 152, 60, 49, 24, 204, 224, 18, 119, 166, 9, 23, 169, 157, 152, 110 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
