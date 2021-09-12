using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RelationShip2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 240, 72, 59, 123, 185, 16, 229, 237, 21, 200, 22, 174, 191, 178, 53, 41, 107, 63, 245, 164, 251, 152, 246, 208, 120, 12, 73, 215, 41, 205, 81, 236, 165, 65, 227, 118, 245, 31, 189, 150, 59, 152, 121, 25, 249, 110, 244, 191, 181, 255, 208, 197, 55, 87, 86, 96, 182, 1, 40, 245, 250, 254, 166, 68 }, new byte[] { 65, 22, 75, 217, 241, 13, 219, 249, 50, 133, 203, 24, 200, 81, 39, 53, 146, 188, 36, 108, 65, 21, 122, 86, 143, 218, 230, 59, 72, 8, 82, 178, 255, 52, 210, 139, 128, 176, 111, 12, 180, 109, 34, 209, 174, 78, 89, 245, 19, 238, 30, 134, 47, 159, 17, 47, 245, 9, 80, 148, 205, 204, 204, 5, 191, 96, 127, 59, 109, 95, 173, 35, 85, 44, 28, 67, 29, 102, 101, 122, 207, 179, 140, 194, 231, 196, 52, 144, 65, 250, 15, 154, 208, 56, 120, 110, 101, 39, 46, 27, 17, 20, 128, 12, 162, 80, 41, 52, 55, 69, 114, 155, 232, 251, 192, 48, 240, 250, 221, 89, 79, 246, 126, 123, 112, 118, 126, 144 } });

           
            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branch_BranchId",
                table: "Users",
                column: "BranchId",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Jop_JopId",
                table: "Users",
                column: "JopId",
                principalTable: "Jops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organization_OrganizationId",
                table: "Users",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
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
        }
    }
}
