using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class TargetRisk4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TargetRiskStrategyThreatenedNeeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetId = table.Column<int>(type: "int", nullable: false),
                    Risk = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Strategy = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Threatened = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Need = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetRiskStrategyThreatenedNeeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetRiskStrategyThreatenedNeeds_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 192, 226, 236, 37, 41, 107, 38, 246, 191, 236, 39, 225, 184, 169, 15, 229, 115, 63, 62, 165, 225, 221, 171, 95, 136, 204, 246, 15, 239, 247, 64, 130, 239, 245, 93, 106, 142, 59, 41, 238, 152, 77, 27, 47, 179, 228, 238, 124, 158, 102, 59, 228, 135, 224, 84, 196, 72, 101, 89, 17, 55, 92, 35, 233 }, new byte[] { 75, 134, 138, 94, 13, 110, 215, 247, 144, 141, 240, 228, 161, 92, 253, 161, 51, 215, 71, 22, 101, 140, 141, 176, 165, 16, 170, 145, 203, 241, 71, 0, 6, 91, 132, 209, 60, 51, 190, 123, 178, 79, 204, 133, 146, 144, 130, 118, 134, 89, 252, 108, 227, 23, 175, 3, 121, 35, 41, 177, 100, 175, 86, 13, 50, 0, 217, 144, 151, 227, 50, 3, 135, 126, 89, 3, 109, 62, 0, 207, 20, 197, 165, 155, 2, 242, 123, 104, 11, 77, 28, 189, 158, 174, 25, 93, 68, 2, 94, 31, 146, 65, 115, 11, 177, 229, 194, 178, 17, 179, 182, 33, 155, 107, 179, 127, 166, 34, 223, 7, 177, 90, 245, 63, 30, 90, 175, 231 } });

            migrationBuilder.CreateIndex(
                name: "IX_TargetRiskStrategyThreatenedNeeds_TargetId",
                table: "TargetRiskStrategyThreatenedNeeds",
                column: "TargetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TargetRiskStrategyThreatenedNeeds");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 40, 94, 231, 89, 109, 68, 192, 85, 134, 244, 193, 147, 114, 18, 74, 214, 54, 197, 161, 11, 99, 125, 121, 64, 161, 36, 183, 237, 43, 118, 147, 244, 125, 119, 49, 99, 244, 228, 58, 106, 69, 28, 0, 189, 18, 201, 56, 53, 162, 20, 178, 213, 148, 204, 65, 166, 200, 143, 187, 127, 78, 112, 69, 135 }, new byte[] { 5, 102, 155, 173, 115, 167, 71, 137, 65, 19, 185, 36, 36, 59, 240, 3, 95, 45, 87, 233, 79, 88, 106, 37, 52, 104, 87, 65, 95, 201, 185, 188, 238, 86, 5, 138, 37, 39, 227, 26, 23, 167, 210, 232, 217, 163, 11, 154, 7, 27, 127, 240, 203, 155, 204, 215, 242, 184, 212, 150, 143, 162, 82, 160, 243, 206, 250, 23, 81, 131, 23, 90, 244, 40, 209, 9, 226, 59, 0, 229, 142, 32, 181, 177, 168, 231, 248, 184, 238, 115, 72, 107, 9, 65, 104, 211, 166, 223, 46, 137, 168, 232, 121, 229, 180, 130, 96, 77, 152, 83, 144, 88, 145, 97, 41, 212, 71, 62, 144, 17, 58, 73, 68, 217, 168, 9, 31, 52 } });
        }
    }
}
