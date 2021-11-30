using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class PerformanceTargetResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Match",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Performance_Target_Results");

            migrationBuilder.DropColumn(
                name: "TargetActionId",
                table: "Performance_Target_Results");

            migrationBuilder.RenameTable(
                name: "Match",
                newName: "Matchs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matchs",
                table: "Matchs",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Matchs",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "Explanation",
                value: "Hedef");

            migrationBuilder.UpdateData(
                table: "Matchs",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "Explanation",
                value: "Faaliyet");

            migrationBuilder.UpdateData(
                table: "Matchs",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "Explanation",
                value: "Alt Faaliyet");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 226, 81, 85, 71, 76, 30, 125, 175, 35, 163, 88, 211, 141, 57, 137, 51, 249, 186, 3, 183, 63, 97, 16, 69, 80, 146, 120, 11, 218, 211, 38, 181, 193, 61, 223, 46, 134, 246, 245, 24, 189, 201, 141, 34, 4, 154, 108, 91, 152, 241, 226, 249, 55, 241, 146, 220, 41, 180, 241, 127, 172, 70, 249 }, new byte[] { 127, 40, 143, 116, 155, 168, 13, 104, 236, 173, 245, 249, 172, 164, 57, 168, 244, 2, 198, 206, 38, 240, 112, 67, 28, 242, 176, 241, 110, 157, 255, 79, 53, 6, 88, 62, 130, 11, 9, 22, 219, 242, 206, 227, 247, 53, 86, 29, 17, 127, 74, 80, 106, 14, 241, 121, 58, 133, 230, 186, 233, 140, 95, 246, 20, 217, 15, 71, 129, 229, 20, 250, 220, 183, 250, 178, 229, 24, 107, 251, 183, 99, 66, 99, 202, 200, 113, 49, 206, 240, 244, 154, 126, 14, 172, 95, 2, 217, 247, 10, 254, 224, 101, 99, 66, 73, 11, 196, 206, 180, 5, 170, 155, 48, 150, 155, 170, 16, 246, 206, 156, 109, 147, 121, 33, 0, 163, 174 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Matchs",
                table: "Matchs");

            migrationBuilder.RenameTable(
                name: "Matchs",
                newName: "Match");

            migrationBuilder.AddColumn<short>(
                name: "MatchId",
                table: "Performance_Target_Results",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "TargetActionId",
                table: "Performance_Target_Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match",
                table: "Match",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "Explanation",
                value: "Target");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "Explanation",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "Explanation",
                value: "SubAction");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 215, 197, 25, 243, 200, 190, 95, 19, 23, 203, 167, 185, 130, 174, 177, 82, 94, 103, 106, 192, 179, 18, 89, 27, 143, 92, 66, 62, 125, 246, 42, 48, 125, 34, 37, 242, 150, 225, 143, 130, 81, 202, 45, 96, 221, 129, 18, 160, 240, 21, 232, 134, 64, 79, 215, 110, 6, 96, 43, 191, 52, 108, 149, 48 }, new byte[] { 188, 88, 67, 59, 38, 245, 169, 27, 198, 50, 147, 73, 73, 87, 82, 66, 146, 161, 117, 215, 83, 164, 79, 227, 82, 48, 190, 57, 20, 164, 33, 239, 156, 37, 44, 33, 114, 80, 144, 159, 173, 87, 79, 252, 134, 240, 221, 155, 212, 191, 43, 178, 146, 169, 77, 192, 125, 155, 29, 114, 25, 153, 71, 157, 251, 182, 136, 106, 8, 127, 131, 154, 108, 96, 248, 185, 74, 216, 160, 36, 24, 78, 49, 226, 43, 56, 238, 9, 213, 23, 106, 144, 134, 242, 206, 126, 228, 158, 40, 30, 176, 149, 211, 38, 78, 229, 128, 228, 123, 150, 195, 108, 25, 199, 94, 229, 80, 115, 127, 252, 86, 125, 130, 46, 219, 103, 136, 149 } });
        }
    }
}
