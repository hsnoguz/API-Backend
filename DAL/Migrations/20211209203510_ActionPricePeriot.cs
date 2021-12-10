using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ActionPricePeriot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionPrices_Performances_PerformanceId",
                table: "ActionPrices");

            migrationBuilder.DropIndex(
                name: "IX_ActionPrices_PerformanceId",
                table: "ActionPrices");

            migrationBuilder.DropColumn(
                name: "PerformanceId",
                table: "ActionPrices");

            migrationBuilder.AddColumn<short>(
                name: "MatchId1",
                table: "ActionPrices",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeriotId",
                table: "ActionPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 134, 241, 54, 175, 44, 34, 241, 53, 120, 6, 223, 225, 156, 213, 191, 5, 126, 55, 129, 175, 135, 208, 84, 147, 124, 46, 56, 169, 182, 167, 63, 150, 126, 234, 211, 105, 207, 209, 85, 42, 144, 251, 241, 43, 217, 63, 19, 50, 161, 10, 105, 99, 116, 7, 212, 185, 37, 91, 91, 170, 221, 44, 39 }, new byte[] { 49, 147, 25, 6, 203, 124, 144, 62, 201, 37, 142, 137, 196, 96, 218, 212, 139, 84, 150, 187, 53, 127, 26, 101, 143, 81, 99, 245, 92, 27, 225, 51, 115, 128, 15, 126, 156, 3, 86, 39, 204, 56, 188, 0, 109, 53, 176, 181, 131, 4, 44, 144, 218, 161, 186, 34, 253, 102, 58, 210, 117, 225, 17, 123, 228, 145, 196, 193, 142, 142, 227, 136, 227, 249, 195, 128, 34, 198, 161, 55, 151, 183, 120, 154, 62, 29, 67, 93, 69, 176, 0, 213, 76, 132, 219, 243, 89, 122, 78, 145, 72, 51, 67, 86, 146, 23, 153, 55, 192, 85, 232, 143, 183, 76, 252, 110, 96, 243, 29, 171, 162, 5, 95, 197, 235, 159, 103, 74 } });

            migrationBuilder.CreateIndex(
                name: "IX_ActionPrices_MatchId1",
                table: "ActionPrices",
                column: "MatchId1");

            migrationBuilder.CreateIndex(
                name: "IX_ActionPrices_PeriotId",
                table: "ActionPrices",
                column: "PeriotId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionPrices_Matchs_MatchId1",
                table: "ActionPrices",
                column: "MatchId1",
                principalTable: "Matchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionPrices_Periots_PeriotId",
                table: "ActionPrices",
                column: "PeriotId",
                principalTable: "Periots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionPrices_Matchs_MatchId1",
                table: "ActionPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ActionPrices_Periots_PeriotId",
                table: "ActionPrices");

            migrationBuilder.DropIndex(
                name: "IX_ActionPrices_MatchId1",
                table: "ActionPrices");

            migrationBuilder.DropIndex(
                name: "IX_ActionPrices_PeriotId",
                table: "ActionPrices");

            migrationBuilder.DropColumn(
                name: "MatchId1",
                table: "ActionPrices");

            migrationBuilder.DropColumn(
                name: "PeriotId",
                table: "ActionPrices");

            migrationBuilder.AddColumn<int>(
                name: "PerformanceId",
                table: "ActionPrices",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 115, 77, 230, 126, 212, 193, 96, 63, 78, 195, 6, 79, 37, 34, 224, 180, 16, 1, 131, 232, 28, 227, 184, 140, 101, 46, 71, 6, 71, 230, 78, 149, 85, 65, 23, 47, 12, 246, 62, 70, 38, 72, 129, 50, 231, 45, 228, 89, 91, 91, 143, 26, 199, 82, 58, 103, 219, 20, 55, 30, 17, 4, 149, 106 }, new byte[] { 173, 155, 111, 139, 20, 106, 157, 1, 250, 99, 113, 59, 84, 60, 231, 123, 161, 51, 59, 126, 148, 234, 10, 154, 123, 241, 230, 198, 20, 239, 82, 24, 234, 197, 33, 133, 243, 166, 14, 182, 151, 122, 62, 166, 44, 220, 153, 182, 53, 238, 179, 184, 228, 254, 126, 225, 235, 79, 22, 23, 78, 186, 24, 138, 66, 171, 242, 209, 42, 108, 66, 171, 107, 152, 27, 168, 38, 191, 16, 22, 18, 153, 16, 207, 49, 33, 102, 166, 204, 46, 178, 79, 99, 47, 33, 230, 154, 28, 214, 195, 191, 106, 214, 194, 113, 133, 183, 88, 77, 115, 246, 43, 173, 240, 0, 69, 192, 193, 53, 190, 212, 147, 93, 215, 19, 17, 42, 49 } });

            migrationBuilder.CreateIndex(
                name: "IX_ActionPrices_PerformanceId",
                table: "ActionPrices",
                column: "PerformanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionPrices_Performances_PerformanceId",
                table: "ActionPrices",
                column: "PerformanceId",
                principalTable: "Performances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
