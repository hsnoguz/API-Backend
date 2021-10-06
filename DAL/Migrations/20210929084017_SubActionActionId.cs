using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SubActionActionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubActions_Actions_ActionId",
                table: "SubActions");

            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "SubActions");

            migrationBuilder.AlterColumn<int>(
                name: "ActionId",
                table: "SubActions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 46, 184, 7, 154, 209, 169, 20, 123, 241, 210, 161, 252, 9, 8, 12, 18, 3, 122, 208, 14, 201, 3, 8, 216, 46, 250, 57, 24, 41, 17, 10, 127, 175, 77, 14, 171, 45, 12, 70, 27, 203, 85, 194, 159, 153, 154, 98, 37, 138, 48, 36, 32, 192, 58, 132, 110, 69, 177, 11, 84, 171, 52, 102, 146 }, new byte[] { 39, 141, 58, 233, 72, 232, 174, 45, 175, 130, 150, 25, 108, 125, 132, 139, 154, 217, 1, 188, 252, 100, 43, 180, 216, 12, 227, 38, 176, 206, 250, 22, 19, 210, 42, 218, 5, 24, 207, 188, 181, 237, 91, 43, 148, 97, 105, 100, 244, 91, 116, 228, 20, 226, 43, 74, 111, 105, 228, 162, 215, 47, 106, 77, 196, 39, 15, 120, 74, 155, 240, 32, 191, 25, 39, 73, 223, 77, 50, 42, 255, 68, 8, 72, 13, 147, 117, 226, 182, 177, 128, 59, 129, 89, 229, 195, 9, 64, 202, 141, 196, 133, 187, 49, 173, 31, 94, 6, 154, 247, 142, 3, 106, 44, 47, 142, 100, 134, 225, 186, 191, 184, 29, 129, 181, 179, 87, 156 } });

            migrationBuilder.AddForeignKey(
                name: "FK_SubActions_Actions_ActionId",
                table: "SubActions",
                column: "ActionId",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubActions_Actions_ActionId",
                table: "SubActions");

            migrationBuilder.AlterColumn<int>(
                name: "ActionId",
                table: "SubActions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TargetId",
                table: "SubActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 12, 31, 201, 251, 125, 43, 115, 79, 157, 36, 18, 71, 19, 50, 237, 89, 48, 172, 45, 1, 4, 245, 253, 140, 55, 206, 33, 119, 232, 94, 132, 117, 100, 113, 117, 54, 231, 242, 61, 187, 126, 137, 217, 2, 229, 25, 33, 133, 161, 35, 137, 90, 139, 254, 127, 198, 99, 146, 101, 49, 81, 169, 225, 2 }, new byte[] { 122, 212, 223, 125, 42, 73, 253, 162, 133, 92, 140, 144, 121, 241, 64, 184, 43, 140, 10, 71, 232, 65, 183, 199, 156, 212, 193, 37, 34, 53, 248, 53, 125, 241, 229, 165, 199, 137, 131, 133, 225, 2, 227, 206, 61, 229, 236, 26, 68, 15, 16, 84, 139, 12, 167, 31, 79, 14, 239, 97, 140, 245, 224, 197, 90, 180, 80, 75, 122, 250, 241, 4, 75, 30, 200, 138, 100, 24, 62, 16, 52, 11, 224, 56, 181, 166, 94, 252, 247, 13, 21, 105, 251, 222, 212, 165, 180, 199, 8, 50, 8, 223, 175, 150, 246, 161, 168, 27, 252, 99, 170, 233, 146, 30, 169, 30, 240, 14, 6, 238, 64, 156, 151, 239, 132, 40, 94, 108 } });

            migrationBuilder.AddForeignKey(
                name: "FK_SubActions_Actions_ActionId",
                table: "SubActions",
                column: "ActionId",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
