using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectIsSucces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Value",
                table: "QuestionVerticals",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

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
                defaultValue: new DateTime(2021, 8, 24, 22, 48, 14, 854, DateTimeKind.Local).AddTicks(1639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 24, 22, 22, 0, 101, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.AddColumn<bool>(
                name: "IsSuccess",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 7, 132, 216, 78, 28, 42, 113, 97, 76, 247, 254, 52, 151, 19, 162, 211, 206, 8, 26, 97, 107, 245, 226, 202, 153, 246, 253, 160, 65, 32, 12, 75, 141, 138, 56, 190, 212, 27, 210, 193, 199, 3, 68, 144, 68, 147, 107, 141, 154, 28, 90, 172, 119, 239, 169, 116, 139, 120, 51, 86, 38, 88, 35, 40 }, new byte[] { 35, 92, 201, 80, 252, 255, 183, 194, 10, 253, 160, 189, 155, 124, 181, 142, 238, 31, 128, 221, 37, 238, 84, 9, 254, 99, 11, 123, 99, 201, 204, 157, 67, 64, 156, 41, 255, 0, 162, 246, 233, 51, 199, 71, 178, 186, 34, 32, 238, 17, 0, 218, 181, 118, 9, 79, 199, 134, 37, 190, 64, 104, 18, 66, 35, 217, 184, 109, 87, 112, 96, 40, 74, 55, 124, 211, 145, 70, 195, 248, 15, 117, 215, 61, 75, 57, 84, 72, 56, 215, 186, 175, 166, 109, 105, 98, 251, 210, 56, 212, 212, 150, 128, 21, 119, 136, 39, 104, 120, 92, 215, 154, 171, 212, 248, 16, 220, 13, 168, 55, 139, 210, 99, 19, 172, 79, 249, 205 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "QuestionVerticals");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "QuestionHorizontals");

            migrationBuilder.DropColumn(
                name: "IsSuccess",
                table: "Projects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 24, 22, 22, 0, 101, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 24, 22, 48, 14, 854, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 162, 111, 45, 103, 20, 75, 66, 34, 171, 157, 29, 58, 250, 169, 8, 207, 188, 165, 166, 239, 226, 245, 19, 7, 169, 86, 230, 128, 50, 21, 148, 96, 158, 30, 79, 91, 11, 152, 198, 181, 157, 183, 52, 250, 101, 61, 156, 172, 78, 174, 109, 43, 50, 185, 163, 2, 195, 112, 188, 98, 194, 113, 2, 32 }, new byte[] { 5, 202, 38, 148, 93, 213, 0, 154, 63, 204, 86, 86, 229, 103, 83, 191, 47, 89, 148, 173, 225, 82, 88, 143, 104, 42, 155, 156, 135, 196, 196, 146, 65, 186, 127, 63, 253, 85, 224, 241, 200, 187, 112, 63, 178, 198, 150, 47, 188, 150, 245, 221, 164, 58, 86, 162, 244, 24, 139, 10, 174, 0, 195, 110, 166, 79, 144, 88, 168, 182, 63, 98, 100, 69, 198, 10, 14, 29, 8, 189, 211, 88, 171, 128, 84, 31, 39, 145, 56, 4, 65, 51, 232, 222, 206, 109, 183, 254, 163, 110, 95, 193, 182, 45, 161, 87, 57, 103, 17, 7, 92, 19, 51, 182, 196, 188, 165, 227, 186, 196, 165, 133, 62, 11, 184, 130, 32, 2 } });
        }
    }
}
