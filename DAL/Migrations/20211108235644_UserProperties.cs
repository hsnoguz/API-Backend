using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UserProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Branch_BranchId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Jop_JopId",
                table: "Users");


 

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 191, 16, 31, 243, 138, 145, 177, 4, 79, 206, 230, 2, 75, 71, 55, 53, 95, 74, 5, 7, 120, 172, 192, 165, 78, 118, 72, 143, 124, 59, 177, 51, 128, 16, 10, 160, 82, 141, 60, 83, 30, 209, 225, 132, 91, 192, 25, 53, 159, 7, 48, 113, 66, 54, 100, 8, 156, 84, 35, 104, 13, 227, 166 }, new byte[] { 92, 211, 129, 13, 214, 157, 44, 220, 135, 214, 96, 71, 80, 23, 219, 80, 159, 85, 127, 56, 79, 160, 134, 19, 186, 224, 1, 201, 251, 183, 243, 118, 71, 132, 168, 125, 63, 144, 95, 62, 162, 187, 87, 171, 97, 97, 203, 33, 230, 187, 229, 197, 208, 239, 125, 5, 217, 229, 220, 121, 193, 81, 34, 97, 232, 35, 208, 18, 143, 104, 159, 161, 221, 55, 185, 57, 93, 107, 220, 87, 202, 79, 124, 176, 28, 112, 70, 239, 49, 94, 157, 201, 170, 73, 40, 76, 15, 197, 172, 13, 40, 37, 51, 88, 19, 240, 175, 23, 175, 129, 112, 71, 94, 168, 41, 206, 31, 203, 42, 128, 104, 67, 69, 31, 239, 67, 158, 22 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branchs_BranchId",
                table: "Users",
                column: "BranchId",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Jops_JopId",
                table: "Users",
                column: "JopId",
                principalTable: "Jops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organizations_OrganizationId",
                table: "Users",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Branchs_BranchId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Jops_JopId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Organizations_OrganizationId",
                table: "Users");

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
                values: new object[] { new byte[] { 244, 245, 216, 217, 241, 108, 232, 33, 184, 64, 120, 64, 79, 56, 241, 120, 146, 197, 40, 138, 128, 6, 214, 173, 36, 60, 204, 181, 8, 189, 218, 191, 195, 67, 171, 15, 103, 163, 109, 208, 170, 239, 131, 206, 13, 154, 75, 161, 63, 222, 192, 115, 219, 32, 65, 97, 198, 98, 96, 96, 48, 221, 77, 210 }, new byte[] { 74, 45, 143, 167, 35, 245, 114, 95, 8, 229, 96, 117, 39, 103, 230, 91, 227, 103, 45, 178, 106, 107, 65, 49, 164, 128, 137, 255, 252, 83, 177, 106, 231, 63, 30, 248, 70, 74, 25, 176, 227, 29, 232, 121, 114, 227, 149, 232, 58, 46, 217, 83, 243, 94, 181, 75, 120, 225, 215, 150, 198, 206, 45, 55, 6, 204, 74, 69, 255, 240, 7, 74, 46, 22, 129, 81, 124, 205, 143, 51, 71, 82, 70, 13, 51, 95, 44, 219, 216, 55, 238, 36, 150, 161, 177, 32, 119, 214, 73, 116, 16, 155, 211, 173, 98, 121, 38, 203, 180, 74, 107, 187, 151, 182, 135, 30, 208, 155, 171, 59, 174, 239, 192, 179, 243, 99, 207, 180 } });

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
