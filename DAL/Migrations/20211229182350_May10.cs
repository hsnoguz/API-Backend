using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class May10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new byte[] { 71, 129, 42, 183, 90, 65, 220, 231, 226, 128, 146, 154, 9, 158, 203, 189, 14, 89, 169, 106, 192, 131, 172, 136, 64, 88, 86, 195, 41, 82, 77, 249, 241, 170, 57, 124, 58, 29, 230, 7, 109, 189, 13, 155, 127, 82, 129, 22, 157, 86, 255, 166, 125, 246, 53, 62, 157, 48, 243, 186, 0, 141, 148, 31 }, new byte[] { 21, 14, 212, 187, 229, 242, 83, 235, 4, 55, 168, 14, 98, 113, 102, 234, 81, 219, 179, 74, 209, 227, 15, 249, 224, 45, 250, 88, 240, 189, 97, 51, 221, 121, 152, 220, 124, 76, 95, 91, 42, 156, 48, 157, 55, 231, 80, 195, 81, 137, 188, 90, 129, 130, 159, 10, 79, 173, 194, 253, 91, 21, 218, 204, 58, 159, 61, 148, 105, 3, 3, 160, 152, 123, 162, 163, 147, 236, 38, 141, 88, 227, 236, 180, 161, 251, 228, 84, 175, 201, 110, 15, 126, 61, 233, 96, 92, 247, 139, 99, 135, 135, 238, 56, 248, 57, 23, 206, 126, 10, 248, 163, 93, 23, 100, 218, 132, 197, 49, 200, 115, 255, 112, 245, 109, 138, 109, 92 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new byte[] { 27, 139, 223, 97, 162, 97, 145, 164, 54, 150, 33, 18, 136, 198, 10, 122, 104, 7, 163, 177, 246, 239, 159, 56, 200, 238, 176, 92, 224, 229, 189, 129, 111, 140, 157, 126, 124, 193, 247, 203, 146, 134, 5, 245, 148, 157, 247, 61, 48, 252, 242, 209, 181, 196, 89, 147, 241, 17, 179, 188, 246, 142, 44, 126 }, new byte[] { 249, 45, 42, 121, 189, 21, 6, 99, 65, 42, 145, 95, 120, 175, 201, 121, 50, 80, 153, 163, 209, 196, 65, 168, 113, 112, 251, 136, 15, 30, 189, 74, 74, 128, 104, 91, 140, 240, 44, 221, 180, 199, 166, 255, 124, 110, 137, 214, 102, 46, 21, 247, 249, 47, 57, 143, 47, 103, 27, 42, 180, 87, 86, 167, 75, 59, 116, 236, 216, 67, 221, 54, 100, 37, 118, 196, 251, 174, 104, 100, 117, 139, 197, 109, 60, 17, 80, 215, 36, 103, 210, 54, 180, 35, 251, 66, 202, 63, 181, 177, 184, 73, 59, 51, 51, 191, 78, 60, 177, 125, 250, 87, 148, 212, 20, 193, 109, 141, 16, 172, 169, 44, 152, 175, 192, 219, 85, 117 } });
        }
    }
}
