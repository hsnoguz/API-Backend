using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectQuestionCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1);

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
                oldDefaultValue: new DateTime(2021, 8, 22, 17, 16, 1, 869, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 92, 203, 100, 195, 87, 83, 245, 234, 205, 95, 12, 206, 219, 70, 28, 45, 116, 194, 32, 121, 205, 64, 158, 64, 150, 53, 35, 194, 237, 169, 236, 3, 68, 137, 127, 34, 176, 237, 78, 173, 52, 121, 92, 48, 101, 86, 20, 222, 231, 124, 194, 133, 68, 37, 104, 253, 125, 116, 46, 33, 251, 69, 248, 200 }, new byte[] { 59, 187, 54, 164, 148, 109, 163, 105, 176, 63, 7, 200, 253, 164, 101, 136, 124, 139, 191, 112, 201, 97, 173, 170, 68, 215, 24, 18, 117, 109, 142, 141, 64, 155, 76, 189, 45, 183, 40, 57, 65, 214, 102, 130, 63, 20, 13, 45, 131, 180, 183, 206, 240, 232, 5, 4, 255, 168, 60, 214, 189, 49, 92, 15, 242, 165, 117, 29, 181, 135, 92, 232, 206, 140, 123, 49, 181, 128, 30, 194, 8, 220, 185, 77, 252, 49, 26, 115, 202, 209, 153, 30, 4, 25, 82, 65, 32, 127, 206, 91, 136, 8, 238, 181, 251, 40, 151, 7, 171, 6, 155, 232, 154, 189, 168, 107, 173, 215, 12, 160, 191, 192, 241, 237, 35, 0, 137, 175 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2021, 8, 22, 17, 16, 1, 869, DateTimeKind.Local).AddTicks(2950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 23, 22, 16, 54, 432, DateTimeKind.Local).AddTicks(4108));

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
