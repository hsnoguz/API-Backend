using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SignTables5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SignPeriots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<short>(type: "smallint", maxLength: 50, nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignPeriots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 244, 245, 216, 217, 241, 108, 232, 33, 184, 64, 120, 64, 79, 56, 241, 120, 146, 197, 40, 138, 128, 6, 214, 173, 36, 60, 204, 181, 8, 189, 218, 191, 195, 67, 171, 15, 103, 163, 109, 208, 170, 239, 131, 206, 13, 154, 75, 161, 63, 222, 192, 115, 219, 32, 65, 97, 198, 98, 96, 96, 48, 221, 77, 210 }, new byte[] { 74, 45, 143, 167, 35, 245, 114, 95, 8, 229, 96, 117, 39, 103, 230, 91, 227, 103, 45, 178, 106, 107, 65, 49, 164, 128, 137, 255, 252, 83, 177, 106, 231, 63, 30, 248, 70, 74, 25, 176, 227, 29, 232, 121, 114, 227, 149, 232, 58, 46, 217, 83, 243, 94, 181, 75, 120, 225, 215, 150, 198, 206, 45, 55, 6, 204, 74, 69, 255, 240, 7, 74, 46, 22, 129, 81, 124, 205, 143, 51, 71, 82, 70, 13, 51, 95, 44, 219, 216, 55, 238, 36, 150, 161, 177, 32, 119, 214, 73, 116, 16, 155, 211, 173, 98, 121, 38, 203, 180, 74, 107, 187, 151, 182, 135, 30, 208, 155, 171, 59, 174, 239, 192, 179, 243, 99, 207, 180 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignPeriots");

            migrationBuilder.DropTable(
                name: "SignTypes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 137, 5, 226, 90, 171, 165, 154, 145, 162, 18, 134, 197, 4, 39, 43, 83, 180, 148, 36, 104, 165, 187, 134, 182, 36, 118, 51, 48, 104, 212, 210, 24, 173, 86, 132, 70, 153, 116, 246, 174, 139, 32, 102, 179, 93, 204, 203, 52, 226, 150, 137, 251, 220, 98, 0, 166, 169, 32, 46, 37, 52, 238, 43 }, new byte[] { 89, 236, 184, 67, 240, 19, 64, 226, 200, 104, 207, 130, 144, 17, 163, 82, 25, 131, 220, 78, 14, 238, 216, 246, 187, 206, 105, 26, 72, 14, 62, 193, 77, 176, 207, 225, 60, 236, 116, 134, 170, 51, 117, 221, 252, 240, 95, 2, 35, 83, 219, 110, 164, 56, 1, 172, 250, 74, 181, 103, 130, 233, 6, 34, 131, 69, 53, 130, 57, 224, 154, 191, 220, 35, 15, 136, 175, 248, 59, 183, 79, 162, 16, 38, 142, 160, 229, 38, 130, 103, 125, 41, 255, 150, 77, 39, 207, 42, 36, 43, 127, 143, 99, 144, 75, 252, 62, 21, 125, 237, 141, 54, 225, 47, 23, 10, 155, 91, 6, 16, 165, 91, 117, 99, 247, 19, 117, 120 } });
        }
    }
}
