using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 24, 21, 42, 20, 317, DateTimeKind.Local).AddTicks(940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 22, 17, 16, 1, 869, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 72, 167, 252, 122, 240, 0, 114, 250, 163, 200, 246, 189, 96, 135, 218, 123, 1, 9, 219, 193, 119, 161, 165, 67, 6, 191, 55, 139, 24, 57, 167, 72, 115, 202, 3, 181, 57, 69, 88, 15, 214, 145, 241, 71, 8, 149, 48, 187, 71, 92, 175, 149, 110, 93, 181, 160, 188, 5, 135, 19, 2, 215, 207 }, new byte[] { 205, 89, 112, 20, 30, 41, 97, 63, 135, 123, 160, 241, 33, 40, 180, 9, 33, 168, 60, 78, 254, 129, 128, 249, 250, 75, 222, 181, 113, 167, 19, 47, 227, 28, 153, 175, 34, 183, 182, 235, 5, 3, 43, 188, 224, 34, 250, 143, 235, 138, 1, 6, 176, 110, 225, 71, 146, 43, 130, 53, 29, 77, 247, 10, 149, 177, 36, 138, 154, 200, 222, 107, 158, 152, 229, 77, 113, 167, 92, 7, 22, 81, 252, 176, 225, 155, 123, 23, 162, 2, 156, 179, 13, 67, 207, 218, 227, 31, 139, 112, 157, 222, 139, 64, 72, 123, 144, 188, 18, 173, 76, 104, 172, 136, 88, 209, 231, 43, 183, 201, 124, 153, 192, 123, 44, 105, 20, 216 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 22, 17, 16, 1, 869, DateTimeKind.Local).AddTicks(2950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 24, 21, 42, 20, 317, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name", "UserOperationClaimId" },
                values: new object[] { 1, "Admin", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 90, 184, 185, 230, 121, 254, 40, 152, 46, 210, 0, 194, 124, 200, 241, 185, 220, 255, 24, 15, 31, 126, 75, 165, 77, 70, 198, 5, 139, 70, 251, 230, 214, 141, 231, 100, 127, 173, 65, 36, 120, 140, 192, 44, 6, 67, 185, 223, 206, 141, 88, 21, 10, 37, 225, 48, 137, 240, 61, 115, 23, 254, 253, 239 }, new byte[] { 114, 215, 198, 55, 38, 133, 41, 41, 82, 31, 213, 96, 174, 253, 66, 85, 121, 22, 134, 200, 234, 47, 224, 160, 125, 113, 76, 26, 249, 215, 254, 194, 103, 50, 54, 64, 88, 147, 253, 213, 34, 121, 209, 46, 53, 30, 75, 148, 50, 214, 124, 167, 79, 99, 119, 225, 42, 66, 102, 17, 147, 236, 123, 2, 224, 215, 54, 142, 168, 157, 135, 192, 137, 43, 16, 8, 131, 73, 180, 205, 60, 158, 2, 231, 76, 240, 58, 17, 46, 93, 88, 11, 221, 94, 69, 20, 195, 52, 201, 19, 23, 60, 74, 128, 133, 56, 116, 48, 153, 29, 174, 160, 6, 240, 90, 184, 115, 44, 218, 59, 6, 88, 149, 228, 173, 57, 222, 215 } });
        }
    }
}
