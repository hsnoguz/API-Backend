using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AimChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aims_Periots_periotID",
                table: "Aims");

            migrationBuilder.RenameColumn(
                name: "periotID",
                table: "Aims",
                newName: "PeriotId");

            migrationBuilder.RenameIndex(
                name: "IX_Aims_periotID",
                table: "Aims",
                newName: "IX_Aims_PeriotId");

            migrationBuilder.AlterColumn<string>(
                name: "Explanation",
                table: "Aims",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 78, 157, 43, 28, 111, 126, 109, 133, 33, 135, 133, 16, 230, 177, 224, 58, 8, 74, 61, 171, 127, 85, 34, 179, 141, 205, 90, 221, 173, 167, 163, 65, 57, 109, 27, 213, 162, 166, 11, 108, 213, 104, 119, 137, 95, 218, 198, 34, 62, 126, 164, 232, 4, 212, 159, 43, 11, 59, 44, 183, 147, 57, 20 }, new byte[] { 204, 37, 44, 224, 78, 105, 115, 220, 63, 111, 201, 33, 213, 185, 205, 75, 212, 72, 160, 172, 122, 193, 233, 9, 127, 157, 151, 1, 245, 116, 236, 168, 223, 55, 250, 31, 237, 118, 182, 76, 112, 227, 60, 227, 174, 150, 154, 80, 79, 130, 234, 191, 116, 179, 93, 205, 22, 73, 251, 60, 25, 23, 31, 129, 10, 101, 122, 166, 6, 140, 163, 66, 218, 172, 170, 10, 138, 0, 168, 67, 73, 223, 129, 247, 246, 142, 2, 174, 210, 12, 220, 252, 80, 254, 185, 39, 46, 235, 199, 199, 240, 12, 169, 219, 236, 69, 128, 18, 193, 187, 116, 211, 170, 128, 248, 200, 205, 205, 213, 66, 224, 216, 168, 243, 134, 93, 148, 205 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Aims_Periots_PeriotId",
                table: "Aims",
                column: "PeriotId",
                principalTable: "Periots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aims_Periots_PeriotId",
                table: "Aims");

            migrationBuilder.RenameColumn(
                name: "PeriotId",
                table: "Aims",
                newName: "periotID");

            migrationBuilder.RenameIndex(
                name: "IX_Aims_PeriotId",
                table: "Aims",
                newName: "IX_Aims_periotID");

            migrationBuilder.AlterColumn<int>(
                name: "Explanation",
                table: "Aims",
                type: "int",
                maxLength: 500,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 234, 131, 213, 46, 18, 163, 138, 173, 81, 24, 252, 56, 54, 145, 175, 226, 76, 107, 254, 13, 158, 52, 14, 174, 240, 122, 130, 178, 184, 49, 210, 74, 158, 116, 174, 137, 77, 25, 37, 209, 126, 214, 101, 242, 71, 56, 125, 92, 142, 49, 221, 138, 29, 66, 149, 189, 132, 100, 131, 176, 143, 159, 6, 151 }, new byte[] { 129, 201, 201, 140, 170, 61, 83, 237, 11, 39, 193, 78, 48, 167, 199, 97, 36, 61, 113, 242, 20, 65, 163, 191, 78, 205, 131, 127, 53, 194, 103, 30, 134, 224, 204, 129, 212, 192, 224, 27, 187, 4, 223, 31, 57, 226, 65, 129, 102, 101, 108, 145, 68, 110, 101, 105, 69, 180, 127, 49, 160, 237, 34, 32, 141, 120, 185, 174, 60, 217, 69, 72, 8, 30, 200, 92, 163, 102, 43, 114, 227, 248, 82, 204, 37, 57, 233, 219, 3, 198, 89, 95, 43, 237, 173, 107, 245, 52, 51, 218, 234, 87, 96, 158, 6, 180, 119, 159, 141, 205, 9, 138, 167, 13, 168, 229, 221, 60, 39, 160, 43, 166, 70, 28, 170, 240, 154, 44 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Aims_Periots_periotID",
                table: "Aims",
                column: "periotID",
                principalTable: "Periots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
