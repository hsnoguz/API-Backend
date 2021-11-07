using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SignTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
  }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "SignTypes",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "SignPeriots",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 3, 98, 57, 163, 20, 148, 233, 110, 113, 3, 77, 31, 13, 224, 119, 249, 0, 184, 82, 15, 153, 47, 118, 167, 43, 165, 255, 105, 3, 4, 220, 95, 47, 155, 51, 197, 40, 242, 120, 31, 184, 142, 176, 25, 164, 168, 55, 0, 119, 16, 43, 2, 145, 171, 186, 36, 30, 173, 146, 65, 32, 101, 32 }, new byte[] { 131, 153, 83, 73, 39, 101, 208, 164, 106, 65, 253, 119, 35, 38, 178, 123, 176, 226, 93, 224, 166, 186, 132, 217, 145, 235, 147, 139, 33, 14, 61, 182, 244, 151, 240, 65, 105, 230, 202, 75, 156, 72, 80, 98, 185, 104, 90, 203, 136, 4, 136, 190, 22, 33, 15, 60, 98, 173, 106, 224, 143, 83, 96, 212, 20, 22, 218, 206, 208, 124, 95, 174, 252, 81, 30, 176, 72, 127, 65, 238, 151, 27, 105, 84, 121, 58, 85, 26, 110, 31, 245, 228, 189, 45, 183, 77, 113, 56, 125, 230, 218, 67, 108, 59, 34, 238, 223, 170, 63, 73, 249, 239, 235, 1, 89, 142, 10, 25, 63, 70, 215, 36, 199, 80, 192, 13, 241, 166 } });
        }
    }
}
