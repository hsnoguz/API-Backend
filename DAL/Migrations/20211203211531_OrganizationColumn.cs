using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class OrganizationColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TargetId",
                table: "Targets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "SubActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubActionId",
                table: "SubActions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Performance_Target_Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceMatchId",
                table: "Performance_Target_Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ActionId",
                table: "Actions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Actions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 237, 23, 181, 254, 64, 128, 42, 233, 56, 22, 6, 197, 29, 10, 113, 110, 186, 63, 17, 134, 7, 52, 40, 20, 19, 64, 64, 182, 244, 17, 138, 75, 221, 82, 209, 191, 148, 232, 115, 25, 193, 192, 74, 241, 140, 195, 92, 16, 67, 3, 118, 128, 156, 166, 222, 4, 110, 70, 245, 75, 168, 55, 236, 244 }, new byte[] { 131, 159, 153, 77, 179, 249, 1, 31, 201, 246, 219, 239, 179, 136, 69, 167, 223, 190, 122, 242, 249, 28, 198, 80, 232, 14, 136, 154, 226, 203, 53, 146, 231, 94, 18, 248, 50, 83, 62, 57, 242, 35, 10, 157, 81, 104, 210, 121, 82, 173, 2, 221, 117, 180, 74, 115, 123, 71, 252, 170, 190, 230, 89, 157, 62, 15, 70, 114, 134, 33, 183, 252, 255, 243, 160, 167, 146, 46, 210, 38, 191, 230, 0, 79, 66, 4, 53, 199, 138, 232, 237, 135, 215, 169, 53, 228, 131, 89, 86, 157, 202, 154, 26, 108, 156, 12, 64, 9, 219, 211, 23, 190, 75, 109, 183, 106, 36, 20, 163, 82, 203, 128, 252, 46, 98, 93, 143, 34 } });

            migrationBuilder.CreateIndex(
                name: "IX_Performance_Target_Results_OrganizationId",
                table: "Performance_Target_Results",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_OrganizationId",
                table: "Actions",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Organizations_OrganizationId",
                table: "Actions",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performance_Target_Results_Organizations_OrganizationId",
                table: "Performance_Target_Results",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Organizations_OrganizationId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Performance_Target_Results_Organizations_OrganizationId",
                table: "Performance_Target_Results");

            migrationBuilder.DropIndex(
                name: "IX_Performance_Target_Results_OrganizationId",
                table: "Performance_Target_Results");

            migrationBuilder.DropIndex(
                name: "IX_Actions_OrganizationId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "Targets");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "SubActions");

            migrationBuilder.DropColumn(
                name: "SubActionId",
                table: "SubActions");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Performance_Target_Results");

            migrationBuilder.DropColumn(
                name: "PerformanceMatchId",
                table: "Performance_Target_Results");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Actions");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 99, 51, 129, 182, 102, 97, 181, 123, 120, 50, 35, 26, 18, 60, 185, 183, 16, 186, 94, 60, 127, 213, 171, 115, 69, 207, 149, 235, 13, 117, 120, 133, 224, 22, 137, 24, 112, 45, 129, 60, 86, 75, 47, 244, 94, 27, 220, 232, 186, 239, 130, 117, 96, 159, 94, 243, 209, 211, 198, 122, 168, 5, 159, 58 }, new byte[] { 91, 125, 125, 196, 140, 185, 192, 78, 168, 137, 177, 201, 24, 95, 226, 75, 189, 211, 240, 244, 238, 15, 51, 137, 15, 229, 119, 154, 65, 242, 204, 113, 189, 187, 152, 159, 218, 238, 47, 22, 149, 77, 39, 45, 213, 46, 200, 111, 91, 156, 44, 147, 87, 252, 37, 203, 217, 6, 192, 78, 78, 222, 157, 14, 131, 147, 154, 147, 12, 179, 121, 40, 222, 193, 114, 201, 122, 250, 220, 149, 160, 140, 153, 134, 88, 148, 228, 14, 6, 106, 253, 8, 229, 89, 7, 5, 61, 200, 105, 182, 26, 146, 161, 65, 204, 182, 53, 241, 213, 72, 240, 239, 255, 194, 45, 125, 77, 194, 154, 223, 6, 155, 94, 54, 125, 187, 12, 96 } });
        }
    }
}
