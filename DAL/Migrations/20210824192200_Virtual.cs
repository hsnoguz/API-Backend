using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Virtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "QuestionVerticals");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "QuestionHorizontals");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "QuestionHorizontals");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 24, 22, 22, 0, 101, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 23, 22, 16, 54, 432, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 162, 111, 45, 103, 20, 75, 66, 34, 171, 157, 29, 58, 250, 169, 8, 207, 188, 165, 166, 239, 226, 245, 19, 7, 169, 86, 230, 128, 50, 21, 148, 96, 158, 30, 79, 91, 11, 152, 198, 181, 157, 183, 52, 250, 101, 61, 156, 172, 78, 174, 109, 43, 50, 185, 163, 2, 195, 112, 188, 98, 194, 113, 2, 32 }, new byte[] { 5, 202, 38, 148, 93, 213, 0, 154, 63, 204, 86, 86, 229, 103, 83, 191, 47, 89, 148, 173, 225, 82, 88, 143, 104, 42, 155, 156, 135, 196, 196, 146, 65, 186, 127, 63, 253, 85, 224, 241, 200, 187, 112, 63, 178, 198, 150, 47, 188, 150, 245, 221, 164, 58, 86, 162, 244, 24, 139, 10, 174, 0, 195, 110, 166, 79, 144, 88, 168, 182, 63, 98, 100, 69, 198, 10, 14, 29, 8, 189, 211, 88, 171, 128, 84, 31, 39, 145, 56, 4, 65, 51, 232, 222, 206, 109, 183, 254, 163, 110, 95, 193, 182, 45, 161, 87, 57, 103, 17, 7, 92, 19, 51, 182, 196, 188, 165, 227, 186, 196, 165, 133, 62, 11, 184, 130, 32, 2 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "QuestionVerticals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "QuestionHorizontals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<short>(
                name: "Value",
                table: "QuestionHorizontals",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 23, 22, 16, 54, 432, DateTimeKind.Local).AddTicks(4108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 24, 22, 22, 0, 101, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 92, 203, 100, 195, 87, 83, 245, 234, 205, 95, 12, 206, 219, 70, 28, 45, 116, 194, 32, 121, 205, 64, 158, 64, 150, 53, 35, 194, 237, 169, 236, 3, 68, 137, 127, 34, 176, 237, 78, 173, 52, 121, 92, 48, 101, 86, 20, 222, 231, 124, 194, 133, 68, 37, 104, 253, 125, 116, 46, 33, 251, 69, 248, 200 }, new byte[] { 59, 187, 54, 164, 148, 109, 163, 105, 176, 63, 7, 200, 253, 164, 101, 136, 124, 139, 191, 112, 201, 97, 173, 170, 68, 215, 24, 18, 117, 109, 142, 141, 64, 155, 76, 189, 45, 183, 40, 57, 65, 214, 102, 130, 63, 20, 13, 45, 131, 180, 183, 206, 240, 232, 5, 4, 255, 168, 60, 214, 189, 49, 92, 15, 242, 165, 117, 29, 181, 135, 92, 232, 206, 140, 123, 49, 181, 128, 30, 194, 8, 220, 185, 77, 252, 49, 26, 115, 202, 209, 153, 30, 4, 25, 82, 65, 32, 127, 206, 91, 136, 8, 238, 181, 251, 40, 151, 7, 171, 6, 155, 232, 154, 189, 168, 107, 173, 215, 12, 160, 191, 192, 241, 237, 35, 0, 137, 175 } });
        }
    }
}
