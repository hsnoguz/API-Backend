using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class PerformacePeriot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEntry",
                table: "Performance_Target_Results",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsManual",
                table: "Performance_Target_Results",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 52, 222, 182, 18, 1, 154, 155, 115, 63, 130, 171, 79, 181, 202, 98, 214, 237, 156, 238, 127, 206, 188, 197, 220, 7, 127, 186, 133, 248, 247, 97, 91, 171, 131, 127, 185, 97, 102, 177, 112, 149, 206, 153, 134, 239, 222, 99, 212, 244, 173, 29, 44, 172, 53, 71, 135, 67, 160, 183, 90, 235, 29, 238, 3 }, new byte[] { 76, 179, 148, 125, 21, 129, 155, 134, 234, 218, 15, 173, 224, 2, 113, 212, 26, 133, 186, 26, 203, 112, 204, 0, 19, 89, 121, 69, 106, 188, 20, 64, 224, 122, 235, 241, 118, 135, 80, 119, 39, 174, 120, 68, 30, 96, 240, 191, 61, 47, 197, 192, 218, 89, 192, 118, 24, 190, 139, 204, 190, 124, 186, 179, 231, 176, 171, 95, 118, 29, 29, 172, 37, 178, 231, 156, 56, 238, 31, 230, 185, 71, 31, 131, 58, 25, 11, 85, 89, 210, 106, 48, 113, 34, 8, 191, 100, 242, 135, 229, 102, 168, 138, 135, 83, 166, 141, 53, 174, 208, 61, 196, 51, 34, 89, 214, 68, 117, 191, 9, 67, 137, 202, 109, 17, 229, 19, 140 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEntry",
                table: "Performance_Target_Results");

            migrationBuilder.DropColumn(
                name: "IsManual",
                table: "Performance_Target_Results");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 78, 120, 250, 24, 86, 175, 20, 176, 240, 176, 49, 131, 253, 54, 97, 106, 49, 34, 141, 209, 167, 98, 198, 165, 26, 30, 226, 123, 210, 146, 87, 8, 242, 75, 150, 148, 206, 59, 1, 62, 163, 150, 26, 123, 150, 69, 24, 96, 139, 13, 129, 21, 68, 16, 214, 214, 249, 225, 204, 84, 145, 61, 227, 203 }, new byte[] { 34, 82, 140, 95, 194, 123, 141, 91, 65, 181, 139, 162, 245, 175, 161, 69, 209, 206, 28, 176, 184, 146, 218, 3, 166, 31, 118, 238, 133, 91, 4, 143, 106, 248, 60, 131, 243, 167, 72, 28, 128, 164, 62, 105, 153, 130, 14, 32, 220, 28, 188, 199, 183, 169, 237, 138, 149, 173, 170, 14, 83, 20, 123, 245, 135, 8, 46, 152, 22, 118, 255, 102, 103, 158, 206, 240, 167, 255, 228, 187, 252, 66, 85, 32, 91, 131, 203, 205, 192, 113, 95, 75, 33, 65, 30, 179, 76, 230, 227, 86, 195, 136, 38, 88, 174, 35, 183, 74, 18, 198, 84, 47, 123, 48, 198, 223, 135, 140, 112, 217, 80, 183, 92, 180, 106, 88, 44, 115 } });
        }
    }
}
