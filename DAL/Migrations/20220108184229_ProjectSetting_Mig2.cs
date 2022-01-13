using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectSetting_Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectSettings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectSettings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "ProjectSettings",
                newName: "SettingValue");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProjectSettings",
                newName: "SettingName");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 37, 107, 97, 30, 201, 96, 26, 126, 188, 7, 109, 253, 109, 152, 0, 89, 147, 239, 78, 78, 251, 161, 180, 74, 96, 110, 50, 169, 32, 2, 85, 141, 81, 96, 111, 240, 74, 24, 137, 233, 8, 102, 221, 196, 143, 250, 6, 55, 65, 171, 155, 107, 15, 209, 28, 125, 112, 151, 200, 234, 116, 43, 100, 200 }, new byte[] { 86, 24, 158, 203, 246, 110, 242, 209, 4, 121, 61, 168, 217, 178, 175, 25, 26, 87, 45, 67, 11, 237, 141, 56, 132, 29, 231, 9, 55, 98, 119, 45, 71, 5, 252, 182, 52, 212, 93, 196, 156, 147, 1, 88, 64, 115, 48, 95, 237, 86, 248, 10, 190, 196, 192, 220, 48, 90, 148, 134, 225, 67, 119, 205, 227, 168, 9, 59, 217, 176, 126, 138, 235, 194, 161, 77, 105, 181, 198, 0, 72, 138, 11, 156, 69, 130, 45, 236, 54, 108, 43, 93, 160, 151, 198, 247, 48, 82, 1, 240, 65, 246, 68, 35, 222, 116, 185, 154, 45, 46, 114, 13, 93, 82, 61, 190, 227, 242, 179, 244, 30, 127, 145, 73, 91, 154, 125, 50 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SettingValue",
                table: "ProjectSettings",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "SettingName",
                table: "ProjectSettings",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "ProjectSettings",
                columns: new[] { "Id", "Name", "Value", "projectID" },
                values: new object[] { 1, "Analiz Count", "0", 0 });

            migrationBuilder.InsertData(
                table: "ProjectSettings",
                columns: new[] { "Id", "Name", "Value", "projectID" },
                values: new object[] { 2, "Analiz DateTime", null, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 114, 79, 216, 9, 151, 59, 130, 156, 249, 82, 70, 39, 52, 33, 173, 0, 208, 167, 137, 147, 198, 36, 176, 5, 129, 69, 247, 240, 166, 6, 215, 123, 59, 223, 98, 211, 41, 88, 4, 104, 16, 185, 21, 18, 107, 99, 90, 235, 136, 32, 55, 50, 114, 36, 35, 58, 57, 176, 13, 127, 177, 97, 174 }, new byte[] { 118, 123, 235, 46, 1, 96, 72, 159, 19, 49, 187, 94, 116, 35, 82, 60, 135, 165, 231, 155, 203, 197, 191, 135, 5, 218, 186, 146, 104, 194, 184, 246, 202, 56, 18, 178, 19, 190, 186, 225, 26, 58, 43, 32, 235, 107, 72, 38, 155, 132, 111, 99, 70, 35, 151, 182, 220, 194, 96, 35, 127, 40, 245, 135, 37, 19, 27, 170, 105, 225, 192, 50, 74, 73, 134, 206, 96, 125, 148, 28, 180, 187, 5, 232, 50, 171, 214, 183, 125, 232, 218, 10, 107, 235, 148, 87, 118, 11, 131, 178, 97, 103, 106, 228, 192, 41, 226, 48, 165, 38, 64, 55, 234, 4, 41, 108, 178, 107, 58, 125, 114, 122, 130, 3, 148, 164, 81, 39 } });
        }
    }
}
