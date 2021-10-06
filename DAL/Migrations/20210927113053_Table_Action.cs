using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Table_Action : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Explanation",
                table: "Targets",
                type: "nvarchar(700)",
                maxLength: 700,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 700);

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    TargetId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actions_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    TargetId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ActionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 12, 31, 201, 251, 125, 43, 115, 79, 157, 36, 18, 71, 19, 50, 237, 89, 48, 172, 45, 1, 4, 245, 253, 140, 55, 206, 33, 119, 232, 94, 132, 117, 100, 113, 117, 54, 231, 242, 61, 187, 126, 137, 217, 2, 229, 25, 33, 133, 161, 35, 137, 90, 139, 254, 127, 198, 99, 146, 101, 49, 81, 169, 225, 2 }, new byte[] { 122, 212, 223, 125, 42, 73, 253, 162, 133, 92, 140, 144, 121, 241, 64, 184, 43, 140, 10, 71, 232, 65, 183, 199, 156, 212, 193, 37, 34, 53, 248, 53, 125, 241, 229, 165, 199, 137, 131, 133, 225, 2, 227, 206, 61, 229, 236, 26, 68, 15, 16, 84, 139, 12, 167, 31, 79, 14, 239, 97, 140, 245, 224, 197, 90, 180, 80, 75, 122, 250, 241, 4, 75, 30, 200, 138, 100, 24, 62, 16, 52, 11, 224, 56, 181, 166, 94, 252, 247, 13, 21, 105, 251, 222, 212, 165, 180, 199, 8, 50, 8, 223, 175, 150, 246, 161, 168, 27, 252, 99, 170, 233, 146, 30, 169, 30, 240, 14, 6, 238, 64, 156, 151, 239, 132, 40, 94, 108 } });

            migrationBuilder.CreateIndex(
                name: "IX_Actions_TargetId",
                table: "Actions",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_SubActions_ActionId",
                table: "SubActions",
                column: "ActionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubActions");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.AlterColumn<int>(
                name: "Explanation",
                table: "Targets",
                type: "int",
                maxLength: 700,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(700)",
                oldMaxLength: 700,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 78, 157, 43, 28, 111, 126, 109, 133, 33, 135, 133, 16, 230, 177, 224, 58, 8, 74, 61, 171, 127, 85, 34, 179, 141, 205, 90, 221, 173, 167, 163, 65, 57, 109, 27, 213, 162, 166, 11, 108, 213, 104, 119, 137, 95, 218, 198, 34, 62, 126, 164, 232, 4, 212, 159, 43, 11, 59, 44, 183, 147, 57, 20 }, new byte[] { 204, 37, 44, 224, 78, 105, 115, 220, 63, 111, 201, 33, 213, 185, 205, 75, 212, 72, 160, 172, 122, 193, 233, 9, 127, 157, 151, 1, 245, 116, 236, 168, 223, 55, 250, 31, 237, 118, 182, 76, 112, 227, 60, 227, 174, 150, 154, 80, 79, 130, 234, 191, 116, 179, 93, 205, 22, 73, 251, 60, 25, 23, 31, 129, 10, 101, 122, 166, 6, 140, 163, 66, 218, 172, 170, 10, 138, 0, 168, 67, 73, 223, 129, 247, 246, 142, 2, 174, 210, 12, 220, 252, 80, 254, 185, 39, 46, 235, 199, 199, 240, 12, 169, 219, 236, 69, 128, 18, 193, 187, 116, 211, 170, 128, 248, 200, 205, 205, 213, 66, 224, 216, 168, 243, 134, 93, 148, 205 } });
        }
    }
}
