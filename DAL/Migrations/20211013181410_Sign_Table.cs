using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Sign_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SignPeriots",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
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
                    Id = table.Column<short>(type: "smallint", nullable: false)
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
                values: new object[] { new byte[] { 176, 3, 98, 57, 163, 20, 148, 233, 110, 113, 3, 77, 31, 13, 224, 119, 249, 0, 184, 82, 15, 153, 47, 118, 167, 43, 165, 255, 105, 3, 4, 220, 95, 47, 155, 51, 197, 40, 242, 120, 31, 184, 142, 176, 25, 164, 168, 55, 0, 119, 16, 43, 2, 145, 171, 186, 36, 30, 173, 146, 65, 32, 101, 32 }, new byte[] { 131, 153, 83, 73, 39, 101, 208, 164, 106, 65, 253, 119, 35, 38, 178, 123, 176, 226, 93, 224, 166, 186, 132, 217, 145, 235, 147, 139, 33, 14, 61, 182, 244, 151, 240, 65, 105, 230, 202, 75, 156, 72, 80, 98, 185, 104, 90, 203, 136, 4, 136, 190, 22, 33, 15, 60, 98, 173, 106, 224, 143, 83, 96, 212, 20, 22, 218, 206, 208, 124, 95, 174, 252, 81, 30, 176, 72, 127, 65, 238, 151, 27, 105, 84, 121, 58, 85, 26, 110, 31, 245, 228, 189, 45, 183, 77, 113, 56, 125, 230, 218, 67, 108, 59, 34, 238, 223, 170, 63, 73, 249, 239, 235, 1, 89, 142, 10, 25, 63, 70, 215, 36, 199, 80, 192, 13, 241, 166 } });
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
                values: new object[] { new byte[] { 46, 184, 7, 154, 209, 169, 20, 123, 241, 210, 161, 252, 9, 8, 12, 18, 3, 122, 208, 14, 201, 3, 8, 216, 46, 250, 57, 24, 41, 17, 10, 127, 175, 77, 14, 171, 45, 12, 70, 27, 203, 85, 194, 159, 153, 154, 98, 37, 138, 48, 36, 32, 192, 58, 132, 110, 69, 177, 11, 84, 171, 52, 102, 146 }, new byte[] { 39, 141, 58, 233, 72, 232, 174, 45, 175, 130, 150, 25, 108, 125, 132, 139, 154, 217, 1, 188, 252, 100, 43, 180, 216, 12, 227, 38, 176, 206, 250, 22, 19, 210, 42, 218, 5, 24, 207, 188, 181, 237, 91, 43, 148, 97, 105, 100, 244, 91, 116, 228, 20, 226, 43, 74, 111, 105, 228, 162, 215, 47, 106, 77, 196, 39, 15, 120, 74, 155, 240, 32, 191, 25, 39, 73, 223, 77, 50, 42, 255, 68, 8, 72, 13, 147, 117, 226, 182, 177, 128, 59, 129, 89, 229, 195, 9, 64, 202, 141, 196, 133, 187, 49, 173, 31, 94, 6, 154, 247, 142, 3, 106, 44, 47, 142, 100, 134, 225, 186, 191, 184, 29, 129, 181, 179, 87, 156 } });
        }
    }
}
