using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectQuestionCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Projects",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "(newid())");

            migrationBuilder.CreateTable(
                name: "Aims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    periotID = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aims_Periots_periotID",
                        column: x => x.periotID,
                        principalTable: "Periots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<int>(type: "int", maxLength: 700, nullable: false),
                    AimId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Targets_Aims_AimId",
                        column: x => x.AimId,
                        principalTable: "Aims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 234, 131, 213, 46, 18, 163, 138, 173, 81, 24, 252, 56, 54, 145, 175, 226, 76, 107, 254, 13, 158, 52, 14, 174, 240, 122, 130, 178, 184, 49, 210, 74, 158, 116, 174, 137, 77, 25, 37, 209, 126, 214, 101, 242, 71, 56, 125, 92, 142, 49, 221, 138, 29, 66, 149, 189, 132, 100, 131, 176, 143, 159, 6, 151 }, new byte[] { 129, 201, 201, 140, 170, 61, 83, 237, 11, 39, 193, 78, 48, 167, 199, 97, 36, 61, 113, 242, 20, 65, 163, 191, 78, 205, 131, 127, 53, 194, 103, 30, 134, 224, 204, 129, 212, 192, 224, 27, 187, 4, 223, 31, 57, 226, 65, 129, 102, 101, 108, 145, 68, 110, 101, 105, 69, 180, 127, 49, 160, 237, 34, 32, 141, 120, 185, 174, 60, 217, 69, 72, 8, 30, 200, 92, 163, 102, 43, 114, 227, 248, 82, 204, 37, 57, 233, 219, 3, 198, 89, 95, 43, 237, 173, 107, 245, 52, 51, 218, 234, 87, 96, 158, 6, 180, 119, 159, 141, 205, 9, 138, 167, 13, 168, 229, 221, 60, 39, 160, 43, 166, 70, 28, 170, 240, 154, 44 } });

            migrationBuilder.CreateIndex(
                name: "IX_Aims_periotID",
                table: "Aims",
                column: "periotID");

            migrationBuilder.CreateIndex(
                name: "IX_Targets_AimId",
                table: "Targets",
                column: "AimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Targets");

            migrationBuilder.DropTable(
                name: "Aims");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 171, 133, 147, 14, 22, 51, 232, 25, 168, 116, 181, 84, 92, 37, 186, 147, 126, 10, 105, 194, 136, 183, 82, 108, 55, 235, 46, 75, 90, 229, 182, 87, 14, 130, 30, 139, 120, 246, 28, 195, 2, 158, 55, 28, 117, 50, 186, 223, 47, 139, 23, 125, 189, 213, 2, 41, 228, 158, 109, 121, 107, 51, 20, 217 }, new byte[] { 51, 198, 40, 201, 168, 207, 172, 84, 186, 8, 235, 227, 124, 5, 156, 222, 39, 109, 11, 205, 80, 25, 170, 216, 102, 125, 143, 135, 182, 47, 99, 73, 71, 215, 109, 190, 220, 52, 43, 160, 122, 126, 120, 249, 99, 78, 13, 165, 53, 86, 91, 66, 66, 213, 161, 234, 4, 36, 217, 183, 175, 41, 178, 72, 31, 50, 64, 140, 7, 233, 152, 106, 70, 230, 49, 35, 179, 37, 85, 182, 83, 134, 236, 120, 254, 59, 100, 242, 233, 189, 190, 176, 49, 107, 128, 244, 126, 210, 200, 29, 165, 112, 10, 151, 35, 172, 214, 117, 208, 7, 37, 117, 172, 231, 2, 91, 242, 14, 56, 198, 233, 206, 110, 79, 42, 162, 250, 149 } });
        }
    }
}
