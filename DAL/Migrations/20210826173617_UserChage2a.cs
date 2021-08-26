using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UserChage2a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubeID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Index",
                table: "QuestionVerticals");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JopId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "QuestionHorizontals",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SuccesCount",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 26, 20, 36, 16, 967, DateTimeKind.Local).AddTicks(9564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 24, 22, 48, 14, 854, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    parentId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.Id);
                });

         
            migrationBuilder.CreateTable(
                name: "Jops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    parentId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jops", x => x.Id);
                });

         

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    parentId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 112, 170, 119, 22, 158, 102, 76, 62, 6, 137, 76, 47, 255, 116, 151, 213, 226, 150, 89, 246, 137, 107, 57, 164, 166, 63, 223, 179, 250, 238, 254, 185, 227, 86, 218, 213, 101, 179, 11, 140, 237, 174, 145, 51, 51, 223, 92, 202, 207, 80, 31, 93, 158, 153, 222, 244, 158, 97, 112, 48, 226, 126, 30, 156 }, new byte[] { 52, 116, 209, 110, 149, 232, 118, 53, 77, 177, 144, 67, 1, 147, 223, 131, 132, 185, 211, 26, 209, 165, 195, 165, 162, 43, 82, 14, 100, 244, 134, 88, 84, 57, 213, 83, 24, 29, 211, 49, 180, 34, 66, 188, 7, 230, 198, 153, 216, 231, 14, 141, 194, 220, 46, 107, 128, 133, 125, 204, 242, 143, 233, 204, 155, 128, 220, 179, 72, 30, 115, 70, 7, 140, 56, 138, 101, 51, 155, 216, 131, 214, 181, 25, 255, 236, 230, 117, 225, 128, 51, 223, 143, 129, 162, 47, 136, 62, 49, 81, 226, 29, 171, 252, 113, 11, 100, 198, 149, 203, 148, 172, 107, 212, 147, 252, 203, 199, 29, 32, 206, 112, 212, 149, 28, 134, 95, 53 } });

            migrationBuilder.CreateIndex(
                name: "IX_Users2_BranchId",
                table: "Users",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Users2_JopId",
                table: "Users",
                column: "JopId");

            migrationBuilder.CreateIndex(
                name: "IX_Users2_OrganizationId",
                table: "Users",
                column: "OrganizationId");

     
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
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "Jop");

            migrationBuilder.DropTable(
                name: "Jops");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Users_BranchId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_JopId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OrganizationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "JopId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "QuestionHorizontals");

            migrationBuilder.AddColumn<short>(
                name: "SubeID",
                table: "Users",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "Index",
                table: "QuestionVerticals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SuccesCount",
                table: "Projects",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 24, 22, 48, 14, 854, DateTimeKind.Local).AddTicks(1639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 26, 20, 36, 16, 967, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 7, 132, 216, 78, 28, 42, 113, 97, 76, 247, 254, 52, 151, 19, 162, 211, 206, 8, 26, 97, 107, 245, 226, 202, 153, 246, 253, 160, 65, 32, 12, 75, 141, 138, 56, 190, 212, 27, 210, 193, 199, 3, 68, 144, 68, 147, 107, 141, 154, 28, 90, 172, 119, 239, 169, 116, 139, 120, 51, 86, 38, 88, 35, 40 }, new byte[] { 35, 92, 201, 80, 252, 255, 183, 194, 10, 253, 160, 189, 155, 124, 181, 142, 238, 31, 128, 221, 37, 238, 84, 9, 254, 99, 11, 123, 99, 201, 204, 157, 67, 64, 156, 41, 255, 0, 162, 246, 233, 51, 199, 71, 178, 186, 34, 32, 238, 17, 0, 218, 181, 118, 9, 79, 199, 134, 37, 190, 64, 104, 18, 66, 35, 217, 184, 109, 87, 112, 96, 40, 74, 55, 124, 211, 145, 70, 195, 248, 15, 117, 215, 61, 75, 57, 84, 72, 56, 215, 186, 175, 166, 109, 105, 98, 251, 210, 56, 212, 212, 150, 128, 21, 119, 136, 39, 104, 120, 92, 215, 154, 171, 212, 248, 16, 220, 13, 168, 55, 139, 210, 99, 19, 172, 79, 249, 205 } });
        }
    }
}
