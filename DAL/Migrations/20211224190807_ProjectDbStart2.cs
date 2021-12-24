using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectDbStart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Periots",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 55, 28, 186, 175, 213, 126, 7, 117, 225, 115, 38, 143, 165, 146, 98, 196, 194, 250, 112, 208, 251, 121, 137, 135, 2, 169, 122, 30, 3, 169, 30, 146, 80, 89, 176, 104, 20, 28, 220, 88, 56, 140, 234, 144, 217, 1, 46, 192, 229, 199, 163, 185, 152, 57, 136, 57, 9, 1, 178, 63, 205, 123, 79, 68 }, new byte[] { 160, 144, 13, 164, 162, 242, 18, 235, 8, 113, 140, 234, 57, 163, 56, 46, 87, 172, 217, 250, 36, 101, 195, 183, 215, 123, 187, 84, 115, 129, 211, 183, 91, 32, 151, 250, 185, 4, 216, 236, 111, 7, 122, 87, 250, 164, 80, 87, 31, 122, 231, 224, 196, 68, 139, 196, 10, 26, 95, 147, 197, 44, 165, 176, 49, 194, 103, 182, 204, 245, 63, 171, 176, 190, 115, 139, 221, 114, 115, 19, 74, 147, 149, 220, 160, 97, 127, 224, 131, 212, 88, 245, 33, 171, 112, 229, 192, 35, 137, 96, 24, 205, 92, 124, 40, 229, 229, 240, 11, 105, 105, 159, 69, 247, 147, 141, 3, 75, 4, 10, 220, 160, 141, 147, 53, 58, 16, 7 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Periots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 34, 201, 114, 89, 155, 205, 55, 251, 174, 184, 10, 252, 222, 96, 91, 118, 245, 89, 190, 2, 188, 89, 157, 168, 183, 110, 90, 102, 13, 209, 2, 7, 150, 127, 231, 234, 37, 0, 82, 198, 193, 125, 213, 5, 204, 22, 113, 57, 155, 206, 79, 149, 89, 254, 250, 236, 73, 88, 17, 67, 179, 157, 208 }, new byte[] { 254, 73, 57, 153, 36, 224, 46, 87, 62, 159, 213, 94, 26, 33, 79, 229, 44, 129, 189, 215, 212, 109, 7, 176, 35, 215, 225, 58, 9, 42, 166, 1, 227, 131, 201, 171, 38, 30, 136, 119, 38, 55, 222, 244, 187, 246, 177, 64, 35, 240, 175, 176, 218, 25, 113, 170, 205, 11, 108, 198, 167, 114, 80, 247, 101, 43, 176, 126, 94, 105, 219, 20, 74, 97, 92, 238, 154, 168, 40, 181, 67, 181, 223, 26, 41, 55, 87, 209, 106, 21, 92, 58, 252, 137, 152, 172, 243, 233, 164, 91, 245, 158, 133, 161, 26, 213, 0, 104, 213, 184, 52, 220, 100, 201, 83, 58, 21, 151, 2, 232, 212, 129, 77, 169, 37, 109, 146, 14 } });
        }
    }
}
