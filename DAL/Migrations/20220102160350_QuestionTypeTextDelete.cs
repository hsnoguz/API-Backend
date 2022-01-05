using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class QuestionTypeTextDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionTextTypes_QuestionTextTypeId1",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionTextTypeId1",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionTextTypeId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionTextTypeId1",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 65, 54, 239, 65, 97, 133, 129, 207, 212, 109, 36, 183, 226, 252, 121, 64, 157, 212, 9, 73, 228, 177, 237, 124, 109, 33, 171, 6, 237, 5, 211, 10, 52, 165, 127, 126, 242, 255, 230, 110, 54, 130, 67, 37, 61, 189, 76, 190, 173, 140, 139, 23, 35, 82, 208, 117, 253, 160, 212, 42, 168, 152, 167, 69 }, new byte[] { 83, 248, 194, 141, 6, 157, 34, 101, 7, 65, 109, 52, 185, 175, 206, 197, 190, 91, 179, 39, 103, 45, 230, 183, 220, 148, 168, 214, 219, 157, 71, 233, 224, 13, 177, 215, 151, 17, 57, 212, 211, 56, 155, 148, 190, 212, 8, 105, 98, 154, 100, 196, 102, 181, 174, 133, 218, 29, 138, 14, 196, 169, 4, 55, 22, 85, 210, 32, 39, 211, 109, 225, 196, 131, 230, 198, 158, 97, 32, 57, 255, 45, 126, 89, 122, 173, 158, 132, 45, 46, 165, 86, 251, 35, 112, 192, 245, 204, 194, 41, 224, 135, 22, 188, 254, 107, 126, 252, 249, 54, 25, 241, 54, 223, 213, 25, 205, 253, 78, 175, 91, 102, 160, 219, 201, 65, 136, 181 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionTextTypeId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "QuestionTextTypeId1",
                table: "Questions",
                type: "smallint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 215, 179, 181, 57, 240, 21, 60, 187, 112, 207, 252, 35, 40, 174, 176, 60, 27, 3, 0, 65, 5, 210, 179, 168, 95, 184, 66, 68, 100, 153, 64, 139, 21, 191, 47, 45, 115, 5, 185, 205, 56, 42, 167, 234, 180, 101, 189, 125, 218, 43, 148, 67, 97, 153, 216, 61, 184, 68, 37, 222, 192, 151, 79 }, new byte[] { 177, 198, 94, 100, 111, 111, 162, 43, 57, 155, 21, 147, 27, 94, 74, 115, 156, 138, 186, 25, 112, 36, 54, 161, 89, 176, 54, 58, 163, 10, 170, 90, 46, 224, 8, 8, 145, 146, 79, 103, 113, 72, 228, 32, 129, 45, 220, 24, 73, 174, 86, 50, 171, 202, 144, 233, 58, 235, 59, 207, 70, 59, 157, 92, 232, 150, 134, 216, 119, 81, 188, 158, 246, 17, 105, 16, 230, 228, 2, 155, 24, 78, 132, 58, 119, 196, 148, 161, 211, 168, 251, 144, 82, 118, 209, 0, 3, 123, 193, 186, 42, 30, 128, 216, 82, 196, 203, 13, 12, 36, 122, 76, 6, 90, 153, 20, 87, 161, 166, 37, 216, 33, 229, 244, 77, 21, 254, 137 } });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTextTypeId1",
                table: "Questions",
                column: "QuestionTextTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionTextTypes_QuestionTextTypeId1",
                table: "Questions",
                column: "QuestionTextTypeId1",
                principalTable: "QuestionTextTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
