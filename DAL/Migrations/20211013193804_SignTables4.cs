using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SignTables4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new byte[] { 192, 152, 23, 4, 25, 237, 144, 212, 239, 235, 185, 191, 72, 19, 186, 157, 208, 181, 131, 161, 106, 11, 60, 99, 94, 212, 103, 145, 171, 85, 53, 61, 15, 243, 139, 187, 151, 238, 167, 210, 203, 83, 96, 171, 49, 200, 167, 249, 255, 52, 65, 34, 238, 140, 240, 55, 49, 103, 253, 154, 37, 169, 113, 56 }, new byte[] { 38, 9, 87, 32, 203, 52, 92, 105, 19, 146, 163, 221, 95, 71, 82, 58, 198, 185, 232, 225, 25, 43, 85, 143, 54, 64, 137, 177, 169, 239, 254, 157, 0, 238, 178, 72, 0, 255, 229, 41, 237, 175, 92, 80, 84, 32, 145, 205, 44, 145, 228, 134, 24, 147, 214, 25, 65, 103, 129, 70, 193, 239, 184, 39, 177, 254, 110, 199, 86, 28, 220, 209, 101, 215, 60, 107, 214, 164, 141, 206, 103, 56, 118, 224, 1, 185, 110, 70, 225, 160, 205, 55, 160, 138, 132, 7, 104, 141, 18, 219, 17, 1, 27, 137, 143, 249, 72, 215, 252, 33, 45, 219, 31, 152, 60, 49, 24, 204, 224, 18, 119, 166, 9, 23, 169, 157, 152, 110 } });
        }
    }
}
