using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UserChage2b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 26, 21, 50, 15, 519, DateTimeKind.Local).AddTicks(861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 26, 20, 36, 16, 967, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 200, 185, 38, 114, 175, 33, 125, 226, 154, 148, 7, 134, 192, 105, 246, 31, 39, 36, 173, 196, 150, 129, 93, 43, 66, 89, 76, 110, 176, 29, 14, 138, 245, 55, 235, 201, 99, 197, 128, 158, 199, 19, 93, 77, 121, 55, 4, 4, 163, 131, 153, 186, 96, 8, 105, 171, 64, 133, 154, 62, 227, 123, 13, 15 }, new byte[] { 5, 252, 36, 212, 206, 245, 246, 192, 214, 85, 35, 216, 0, 74, 137, 45, 209, 40, 59, 155, 128, 205, 162, 250, 255, 17, 96, 19, 29, 227, 197, 227, 250, 187, 255, 169, 4, 247, 125, 75, 89, 116, 154, 183, 143, 38, 31, 202, 165, 176, 183, 5, 246, 164, 178, 27, 39, 225, 236, 171, 168, 239, 91, 238, 116, 217, 146, 225, 255, 211, 118, 157, 144, 88, 234, 250, 211, 182, 7, 205, 189, 80, 40, 120, 78, 119, 180, 214, 55, 233, 34, 124, 192, 17, 163, 118, 81, 103, 200, 214, 139, 124, 54, 35, 23, 33, 181, 254, 238, 236, 141, 225, 134, 164, 169, 223, 157, 222, 38, 131, 42, 64, 120, 106, 57, 80, 214, 31 } });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 26, 20, 36, 16, 967, DateTimeKind.Local).AddTicks(9564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 26, 21, 50, 15, 519, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 112, 170, 119, 22, 158, 102, 76, 62, 6, 137, 76, 47, 255, 116, 151, 213, 226, 150, 89, 246, 137, 107, 57, 164, 166, 63, 223, 179, 250, 238, 254, 185, 227, 86, 218, 213, 101, 179, 11, 140, 237, 174, 145, 51, 51, 223, 92, 202, 207, 80, 31, 93, 158, 153, 222, 244, 158, 97, 112, 48, 226, 126, 30, 156 }, new byte[] { 52, 116, 209, 110, 149, 232, 118, 53, 77, 177, 144, 67, 1, 147, 223, 131, 132, 185, 211, 26, 209, 165, 195, 165, 162, 43, 82, 14, 100, 244, 134, 88, 84, 57, 213, 83, 24, 29, 211, 49, 180, 34, 66, 188, 7, 230, 198, 153, 216, 231, 14, 141, 194, 220, 46, 107, 128, 133, 125, 204, 242, 143, 233, 204, 155, 128, 220, 179, 72, 30, 115, 70, 7, 140, 56, 138, 101, 51, 155, 216, 131, 214, 181, 25, 255, 236, 230, 117, 225, 128, 51, 223, 143, 129, 162, 47, 136, 62, 49, 81, 226, 29, 171, 252, 113, 11, 100, 198, 149, 203, 148, 172, 107, 212, 147, 252, 203, 199, 29, 32, 206, 112, 212, 149, 28, 134, 95, 53 } });
        }
    }
}
