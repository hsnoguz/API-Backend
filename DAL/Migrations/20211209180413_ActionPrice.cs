using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ActionPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    TargetValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ResultValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    PerformanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionPrices_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActionPrices_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 115, 77, 230, 126, 212, 193, 96, 63, 78, 195, 6, 79, 37, 34, 224, 180, 16, 1, 131, 232, 28, 227, 184, 140, 101, 46, 71, 6, 71, 230, 78, 149, 85, 65, 23, 47, 12, 246, 62, 70, 38, 72, 129, 50, 231, 45, 228, 89, 91, 91, 143, 26, 199, 82, 58, 103, 219, 20, 55, 30, 17, 4, 149, 106 }, new byte[] { 173, 155, 111, 139, 20, 106, 157, 1, 250, 99, 113, 59, 84, 60, 231, 123, 161, 51, 59, 126, 148, 234, 10, 154, 123, 241, 230, 198, 20, 239, 82, 24, 234, 197, 33, 133, 243, 166, 14, 182, 151, 122, 62, 166, 44, 220, 153, 182, 53, 238, 179, 184, 228, 254, 126, 225, 235, 79, 22, 23, 78, 186, 24, 138, 66, 171, 242, 209, 42, 108, 66, 171, 107, 152, 27, 168, 38, 191, 16, 22, 18, 153, 16, 207, 49, 33, 102, 166, 204, 46, 178, 79, 99, 47, 33, 230, 154, 28, 214, 195, 191, 106, 214, 194, 113, 133, 183, 88, 77, 115, 246, 43, 173, 240, 0, 69, 192, 193, 53, 190, 212, 147, 93, 215, 19, 17, 42, 49 } });

            migrationBuilder.CreateIndex(
                name: "IX_ActionPrices_OrganizationId",
                table: "ActionPrices",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionPrices_PerformanceId",
                table: "ActionPrices",
                column: "PerformanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionPrices");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 237, 23, 181, 254, 64, 128, 42, 233, 56, 22, 6, 197, 29, 10, 113, 110, 186, 63, 17, 134, 7, 52, 40, 20, 19, 64, 64, 182, 244, 17, 138, 75, 221, 82, 209, 191, 148, 232, 115, 25, 193, 192, 74, 241, 140, 195, 92, 16, 67, 3, 118, 128, 156, 166, 222, 4, 110, 70, 245, 75, 168, 55, 236, 244 }, new byte[] { 131, 159, 153, 77, 179, 249, 1, 31, 201, 246, 219, 239, 179, 136, 69, 167, 223, 190, 122, 242, 249, 28, 198, 80, 232, 14, 136, 154, 226, 203, 53, 146, 231, 94, 18, 248, 50, 83, 62, 57, 242, 35, 10, 157, 81, 104, 210, 121, 82, 173, 2, 221, 117, 180, 74, 115, 123, 71, 252, 170, 190, 230, 89, 157, 62, 15, 70, 114, 134, 33, 183, 252, 255, 243, 160, 167, 146, 46, 210, 38, 191, 230, 0, 79, 66, 4, 53, 199, 138, 232, 237, 135, 215, 169, 53, 228, 131, 89, 86, 157, 202, 154, 26, 108, 156, 12, 64, 9, 219, 211, 23, 190, 75, 109, 183, 106, 36, 20, 163, 82, 203, 128, 252, 46, 98, 93, 143, 34 } });
        }
    }
}
