using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class May4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "Targets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubActionId",
                table: "Actions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 139, 126, 142, 103, 79, 170, 92, 68, 123, 152, 88, 130, 104, 204, 125, 248, 123, 148, 109, 75, 224, 146, 197, 190, 77, 67, 207, 16, 212, 197, 240, 175, 191, 194, 5, 46, 250, 235, 123, 58, 72, 92, 253, 65, 96, 39, 228, 190, 15, 209, 192, 17, 102, 249, 208, 216, 58, 107, 73, 16, 6, 58, 201, 50 }, new byte[] { 182, 85, 200, 142, 239, 153, 152, 143, 19, 155, 143, 224, 39, 35, 108, 21, 105, 229, 33, 49, 1, 95, 237, 116, 244, 30, 136, 125, 189, 96, 133, 209, 100, 172, 43, 149, 219, 49, 173, 14, 92, 157, 233, 210, 199, 175, 121, 203, 20, 61, 84, 255, 223, 207, 182, 6, 111, 104, 207, 253, 50, 216, 241, 69, 51, 25, 241, 109, 222, 4, 128, 214, 31, 210, 31, 60, 23, 165, 118, 150, 94, 85, 65, 161, 216, 172, 89, 94, 69, 180, 203, 156, 227, 22, 7, 141, 7, 97, 173, 201, 9, 230, 126, 107, 72, 142, 66, 176, 58, 196, 208, 110, 62, 88, 105, 85, 104, 79, 207, 132, 122, 32, 8, 145, 79, 131, 49, 56 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "Targets");

            migrationBuilder.DropColumn(
                name: "SubActionId",
                table: "Actions");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 139, 24, 205, 172, 211, 0, 49, 103, 49, 72, 42, 195, 173, 143, 240, 10, 217, 17, 47, 66, 58, 220, 106, 223, 226, 161, 77, 189, 84, 239, 89, 168, 205, 240, 44, 154, 27, 220, 241, 45, 244, 113, 144, 60, 114, 244, 5, 204, 53, 242, 167, 123, 179, 63, 213, 52, 0, 212, 100, 59, 17, 179, 223, 0 }, new byte[] { 15, 228, 41, 163, 153, 68, 95, 74, 204, 101, 94, 184, 225, 128, 230, 48, 175, 105, 200, 205, 55, 199, 115, 92, 184, 33, 83, 144, 209, 123, 65, 199, 113, 24, 133, 128, 152, 177, 238, 15, 164, 125, 90, 33, 139, 145, 129, 59, 161, 232, 244, 13, 2, 209, 252, 181, 230, 125, 189, 194, 37, 243, 14, 120, 205, 69, 197, 39, 165, 244, 255, 223, 16, 28, 24, 33, 237, 100, 79, 175, 156, 42, 138, 125, 101, 159, 173, 236, 26, 243, 220, 176, 214, 255, 97, 62, 122, 202, 74, 184, 173, 145, 129, 121, 91, 117, 6, 55, 223, 195, 72, 223, 144, 142, 218, 235, 39, 101, 222, 208, 88, 132, 65, 97, 139, 50, 0, 246 } });
        }
    }
}
