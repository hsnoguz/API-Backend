using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class PerformacePeriot4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MatchId",
                table: "PerformanceMatchTargets",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 135, 9, 96, 194, 208, 121, 159, 93, 31, 115, 210, 187, 142, 98, 129, 114, 234, 39, 239, 219, 235, 35, 25, 183, 219, 18, 214, 76, 36, 53, 146, 68, 241, 176, 176, 64, 222, 109, 35, 142, 22, 246, 84, 106, 27, 53, 129, 81, 255, 36, 121, 10, 6, 155, 42, 43, 102, 105, 174, 105, 127, 232, 170 }, new byte[] { 235, 241, 234, 122, 139, 236, 91, 118, 0, 218, 71, 107, 24, 133, 85, 62, 51, 65, 170, 58, 46, 139, 158, 152, 146, 220, 168, 14, 236, 2, 160, 65, 30, 176, 205, 156, 136, 239, 64, 226, 110, 117, 7, 85, 151, 118, 31, 39, 94, 198, 123, 22, 195, 189, 45, 202, 133, 227, 251, 248, 129, 204, 125, 16, 37, 238, 199, 229, 48, 126, 212, 81, 15, 134, 138, 140, 110, 243, 5, 11, 7, 211, 32, 62, 99, 220, 86, 24, 49, 154, 171, 78, 247, 187, 2, 54, 199, 145, 71, 221, 104, 159, 69, 216, 73, 47, 176, 239, 38, 54, 154, 24, 61, 96, 240, 112, 94, 84, 191, 30, 107, 28, 18, 110, 142, 157, 238, 6 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "MatchId",
                table: "PerformanceMatchTargets",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 217, 55, 184, 77, 150, 254, 131, 174, 206, 18, 235, 209, 61, 201, 195, 245, 142, 104, 245, 109, 36, 186, 126, 122, 79, 100, 173, 147, 72, 162, 71, 190, 195, 85, 233, 172, 146, 118, 197, 209, 67, 124, 184, 43, 5, 144, 226, 255, 173, 19, 3, 5, 174, 10, 235, 61, 199, 143, 43, 49, 58, 162, 138, 232 }, new byte[] { 41, 178, 188, 183, 114, 110, 105, 57, 198, 119, 89, 182, 119, 236, 200, 7, 185, 75, 176, 208, 149, 254, 223, 58, 154, 169, 63, 70, 190, 129, 239, 103, 199, 138, 223, 207, 6, 19, 17, 187, 163, 85, 50, 48, 207, 161, 173, 3, 122, 166, 139, 11, 102, 188, 53, 251, 39, 7, 184, 249, 135, 36, 93, 250, 137, 198, 219, 43, 198, 161, 87, 24, 95, 23, 106, 88, 153, 33, 26, 228, 193, 182, 58, 81, 65, 94, 89, 25, 93, 53, 51, 142, 242, 128, 38, 239, 228, 200, 177, 236, 143, 19, 13, 118, 83, 231, 41, 161, 236, 169, 143, 22, 126, 38, 248, 200, 136, 64, 215, 104, 130, 46, 113, 107, 151, 19, 254, 17 } });
        }
    }
}
