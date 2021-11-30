using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MAtchChange2e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Organizations_OrganizationId",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Performances_OrganizationId",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Performances");

            migrationBuilder.CreateTable(
                name: "PerformanceMatchTargets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformanceId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<short>(type: "smallint", nullable: false),
                    TargetId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    SubActionId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceMatchTargets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceMatchTargets_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerformanceMatchTargets_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 38, 207, 187, 105, 145, 164, 93, 131, 5, 207, 153, 87, 229, 99, 156, 93, 37, 160, 102, 66, 218, 207, 150, 56, 225, 3, 183, 140, 218, 76, 44, 132, 129, 237, 63, 59, 163, 63, 52, 74, 235, 54, 138, 218, 96, 175, 81, 56, 146, 66, 227, 125, 74, 109, 98, 113, 189, 147, 126, 163, 39, 46, 149, 135 }, new byte[] { 237, 93, 50, 233, 198, 103, 42, 247, 196, 92, 125, 64, 102, 154, 109, 205, 49, 33, 27, 242, 35, 128, 159, 237, 7, 172, 127, 235, 121, 98, 154, 13, 149, 96, 47, 107, 226, 41, 160, 17, 147, 152, 187, 176, 216, 249, 120, 58, 30, 222, 139, 207, 82, 84, 9, 25, 11, 120, 43, 184, 31, 202, 155, 141, 32, 75, 127, 94, 161, 201, 113, 123, 218, 21, 239, 143, 182, 234, 48, 244, 230, 244, 216, 246, 166, 175, 40, 134, 8, 23, 151, 164, 98, 137, 113, 236, 121, 181, 188, 33, 192, 159, 89, 117, 155, 58, 70, 250, 211, 161, 121, 69, 114, 141, 234, 189, 84, 60, 73, 127, 149, 23, 251, 255, 202, 169, 232, 137 } });

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceMatchTargets_OrganizationId",
                table: "PerformanceMatchTargets",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceMatchTargets_PerformanceId",
                table: "PerformanceMatchTargets",
                column: "PerformanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerformanceMatchTargets");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Performances",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 46, 79, 85, 100, 132, 81, 113, 119, 150, 10, 164, 94, 47, 238, 6, 147, 98, 232, 11, 25, 189, 193, 166, 223, 214, 245, 144, 108, 143, 171, 12, 250, 163, 146, 101, 89, 120, 246, 128, 31, 251, 79, 245, 116, 196, 173, 191, 128, 37, 187, 73, 188, 13, 22, 108, 196, 227, 168, 13, 45, 47, 85, 37 }, new byte[] { 31, 251, 237, 221, 169, 208, 60, 140, 101, 219, 21, 105, 87, 199, 21, 97, 247, 27, 231, 174, 154, 38, 197, 159, 129, 223, 230, 101, 116, 188, 93, 122, 104, 249, 128, 131, 101, 54, 8, 203, 122, 80, 243, 130, 197, 103, 156, 15, 165, 249, 206, 5, 122, 143, 96, 58, 102, 251, 117, 167, 234, 130, 136, 63, 198, 82, 232, 235, 83, 169, 198, 212, 190, 88, 1, 241, 123, 206, 61, 206, 126, 30, 2, 237, 253, 168, 62, 68, 240, 184, 185, 98, 90, 109, 25, 185, 97, 255, 74, 172, 28, 170, 201, 43, 61, 200, 10, 160, 136, 3, 97, 233, 69, 165, 54, 234, 203, 48, 243, 205, 63, 243, 209, 142, 239, 124, 176, 24 } });

            migrationBuilder.CreateIndex(
                name: "IX_Performances_OrganizationId",
                table: "Performances",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Organizations_OrganizationId",
                table: "Performances",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
