using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MatchChange2g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "PerformanceMatchTargets");

            migrationBuilder.DropColumn(
                name: "SubActionId",
                table: "PerformanceMatchTargets");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 215, 197, 25, 243, 200, 190, 95, 19, 23, 203, 167, 185, 130, 174, 177, 82, 94, 103, 106, 192, 179, 18, 89, 27, 143, 92, 66, 62, 125, 246, 42, 48, 125, 34, 37, 242, 150, 225, 143, 130, 81, 202, 45, 96, 221, 129, 18, 160, 240, 21, 232, 134, 64, 79, 215, 110, 6, 96, 43, 191, 52, 108, 149, 48 }, new byte[] { 188, 88, 67, 59, 38, 245, 169, 27, 198, 50, 147, 73, 73, 87, 82, 66, 146, 161, 117, 215, 83, 164, 79, 227, 82, 48, 190, 57, 20, 164, 33, 239, 156, 37, 44, 33, 114, 80, 144, 159, 173, 87, 79, 252, 134, 240, 221, 155, 212, 191, 43, 178, 146, 169, 77, 192, 125, 155, 29, 114, 25, 153, 71, 157, 251, 182, 136, 106, 8, 127, 131, 154, 108, 96, 248, 185, 74, 216, 160, 36, 24, 78, 49, 226, 43, 56, 238, 9, 213, 23, 106, 144, 134, 242, 206, 126, 228, 158, 40, 30, 176, 149, 211, 38, 78, 229, 128, 228, 123, 150, 195, 108, 25, 199, 94, 229, 80, 115, 127, 252, 86, 125, 130, 46, 219, 103, 136, 149 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "PerformanceMatchTargets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubActionId",
                table: "PerformanceMatchTargets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 247, 217, 64, 105, 4, 140, 83, 64, 183, 21, 17, 86, 37, 190, 130, 46, 99, 128, 141, 40, 174, 229, 24, 214, 19, 8, 9, 68, 174, 193, 174, 221, 248, 53, 27, 178, 175, 233, 88, 151, 105, 222, 144, 249, 125, 78, 237, 74, 145, 227, 91, 241, 146, 144, 161, 12, 127, 24, 213, 8, 242, 117, 191 }, new byte[] { 200, 209, 188, 202, 229, 75, 6, 37, 28, 204, 92, 251, 179, 154, 91, 187, 75, 47, 237, 169, 177, 26, 182, 187, 229, 196, 30, 233, 222, 59, 185, 86, 25, 206, 94, 125, 215, 101, 129, 249, 241, 220, 129, 13, 214, 108, 187, 206, 211, 162, 154, 0, 69, 133, 147, 13, 161, 16, 221, 245, 171, 0, 21, 174, 167, 98, 153, 232, 171, 124, 83, 83, 117, 246, 158, 74, 125, 95, 108, 195, 196, 96, 102, 27, 193, 82, 28, 88, 184, 244, 124, 64, 156, 182, 252, 216, 92, 117, 158, 213, 201, 64, 29, 191, 32, 49, 141, 253, 195, 39, 13, 92, 192, 52, 110, 148, 58, 68, 159, 182, 173, 141, 18, 190, 74, 167, 254, 11 } });
        }
    }
}
