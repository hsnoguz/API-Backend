using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ManaulPageCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsManual",
                table: "LeftMenu",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ManualPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriotId = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "ntext", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualPages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 92, 21, 53, 37, 246, 221, 228, 99, 83, 179, 25, 3, 67, 228, 247, 23, 8, 119, 30, 115, 10, 251, 248, 76, 5, 45, 81, 50, 94, 47, 92, 216, 34, 167, 91, 1, 225, 210, 96, 101, 96, 7, 68, 205, 67, 72, 1, 91, 150, 249, 71, 74, 85, 144, 158, 193, 12, 64, 4, 132, 68, 104, 114, 55 }, new byte[] { 198, 190, 218, 255, 34, 136, 85, 84, 86, 115, 132, 165, 176, 54, 6, 104, 103, 112, 195, 90, 134, 171, 230, 183, 205, 92, 156, 100, 204, 56, 202, 135, 21, 41, 61, 69, 145, 233, 53, 198, 136, 206, 68, 27, 101, 178, 93, 139, 169, 79, 178, 49, 157, 9, 127, 145, 51, 44, 253, 201, 201, 73, 214, 65, 223, 175, 79, 62, 140, 16, 135, 149, 88, 122, 158, 93, 179, 102, 249, 119, 227, 133, 69, 144, 238, 122, 188, 195, 117, 163, 214, 199, 45, 148, 109, 55, 134, 138, 208, 38, 172, 25, 219, 22, 119, 15, 138, 153, 158, 83, 84, 248, 52, 140, 11, 209, 6, 127, 202, 48, 122, 71, 76, 163, 73, 173, 58, 233 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManualPages");

            migrationBuilder.DropColumn(
                name: "IsManual",
                table: "LeftMenu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 135, 9, 96, 194, 208, 121, 159, 93, 31, 115, 210, 187, 142, 98, 129, 114, 234, 39, 239, 219, 235, 35, 25, 183, 219, 18, 214, 76, 36, 53, 146, 68, 241, 176, 176, 64, 222, 109, 35, 142, 22, 246, 84, 106, 27, 53, 129, 81, 255, 36, 121, 10, 6, 155, 42, 43, 102, 105, 174, 105, 127, 232, 170 }, new byte[] { 235, 241, 234, 122, 139, 236, 91, 118, 0, 218, 71, 107, 24, 133, 85, 62, 51, 65, 170, 58, 46, 139, 158, 152, 146, 220, 168, 14, 236, 2, 160, 65, 30, 176, 205, 156, 136, 239, 64, 226, 110, 117, 7, 85, 151, 118, 31, 39, 94, 198, 123, 22, 195, 189, 45, 202, 133, 227, 251, 248, 129, 204, 125, 16, 37, 238, 199, 229, 48, 126, 212, 81, 15, 134, 138, 140, 110, 243, 5, 11, 7, 211, 32, 62, 99, 220, 86, 24, 49, 154, 171, 78, 247, 187, 2, 54, 199, 145, 71, 221, 104, 159, 69, 216, 73, 47, 176, 239, 38, 54, 154, 24, 61, 96, 240, 112, 94, 84, 191, 30, 107, 28, 18, 110, 142, 157, 238, 6 } });
        }
    }
}
