using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropForeignKey(
                name: "FK_Users_Branch_BranchId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Jop_JopId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Organization_OrganizationId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Jop");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Users_BranchId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_JopId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OrganizationId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 81, 67, 40, 78, 18, 230, 242, 218, 252, 253, 243, 17, 166, 95, 86, 229, 176, 184, 122, 40, 70, 185, 2, 134, 33, 191, 30, 5, 121, 144, 90, 0, 97, 234, 119, 136, 197, 134, 127, 237, 12, 76, 251, 230, 85, 132, 241, 93, 239, 241, 197, 187, 44, 143, 213, 225, 173, 143, 155, 25, 31, 186, 77, 253 }, new byte[] { 80, 113, 249, 23, 176, 105, 46, 165, 57, 9, 208, 117, 244, 189, 222, 41, 10, 28, 138, 237, 77, 243, 123, 115, 40, 228, 23, 217, 239, 159, 24, 228, 249, 201, 107, 5, 211, 52, 218, 108, 154, 83, 59, 41, 3, 193, 133, 100, 222, 135, 156, 169, 77, 30, 116, 199, 251, 55, 70, 188, 58, 124, 225, 221, 201, 43, 20, 166, 54, 144, 19, 23, 156, 181, 194, 189, 253, 148, 240, 43, 216, 250, 230, 81, 84, 19, 161, 170, 71, 108, 179, 111, 185, 87, 224, 124, 196, 186, 54, 163, 226, 137, 180, 160, 59, 24, 73, 101, 154, 15, 93, 238, 125, 154, 41, 18, 255, 110, 47, 240, 172, 107, 160, 18, 121, 232, 135, 63 } });
       */
            }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 146, 151, 191, 67, 70, 211, 38, 142, 40, 71, 95, 72, 189, 204, 83, 137, 201, 93, 59, 72, 164, 164, 113, 158, 102, 74, 192, 209, 128, 117, 11, 6, 20, 154, 101, 249, 150, 149, 215, 215, 232, 138, 237, 192, 40, 23, 215, 240, 81, 115, 73, 102, 213, 238, 5, 15, 155, 138, 132, 212, 20, 116, 145 }, new byte[] { 49, 162, 29, 213, 131, 101, 52, 135, 192, 6, 102, 73, 26, 172, 175, 161, 236, 175, 126, 101, 191, 203, 250, 36, 109, 233, 6, 209, 154, 190, 228, 136, 55, 238, 10, 168, 11, 12, 78, 236, 132, 53, 104, 59, 184, 248, 149, 11, 236, 252, 25, 154, 204, 249, 138, 69, 229, 223, 203, 167, 82, 252, 31, 108, 253, 164, 28, 222, 28, 171, 12, 154, 151, 37, 255, 85, 49, 44, 21, 65, 239, 209, 88, 166, 101, 177, 201, 251, 129, 86, 201, 101, 212, 173, 253, 231, 17, 45, 185, 189, 72, 165, 188, 203, 220, 213, 207, 186, 220, 199, 197, 84, 126, 28, 22, 8, 18, 234, 185, 155, 212, 237, 98, 130, 151, 182, 174, 187 } });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchId",
                table: "Users",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_JopId",
                table: "Users",
                column: "JopId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganizationId",
                table: "Users",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branch_BranchId",
                table: "Users",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Jop_JopId",
                table: "Users",
                column: "JopId",
                principalTable: "Jop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organization_OrganizationId",
                table: "Users",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
