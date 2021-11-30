using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MatchTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "parentId",
                table: "Organizations",
                newName: "ParentId");

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Match",
                columns: new[] { "Id", "Explanation" },
                values: new object[,]
                {
                    { (short)1, "Target" },
                    { (short)2, "Action" },
                    { (short)3, "SubAction" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 17, 110, 150, 156, 145, 207, 196, 247, 29, 42, 113, 96, 65, 132, 49, 230, 206, 241, 252, 251, 150, 13, 53, 124, 110, 107, 26, 1, 107, 117, 56, 88, 61, 32, 182, 21, 25, 79, 107, 107, 160, 72, 246, 55, 106, 124, 70, 123, 8, 192, 41, 76, 116, 53, 8, 88, 93, 101, 97, 149, 78, 218, 146, 48 }, new byte[] { 136, 217, 75, 213, 202, 179, 220, 105, 13, 26, 190, 176, 232, 72, 52, 120, 26, 35, 65, 211, 68, 123, 74, 191, 227, 109, 234, 135, 138, 32, 209, 234, 98, 154, 69, 34, 240, 30, 192, 131, 159, 124, 221, 253, 44, 157, 194, 245, 70, 225, 151, 61, 223, 6, 81, 26, 26, 118, 243, 46, 154, 219, 100, 60, 82, 161, 245, 230, 21, 153, 163, 118, 161, 253, 11, 45, 96, 79, 113, 72, 171, 114, 81, 16, 68, 55, 172, 81, 147, 229, 245, 129, 2, 49, 9, 65, 227, 51, 91, 112, 39, 162, 126, 202, 223, 104, 26, 135, 107, 236, 70, 11, 43, 1, 118, 100, 198, 211, 232, 221, 170, 145, 116, 159, 132, 238, 17, 34 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Organizations",
                newName: "parentId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 234, 65, 52, 206, 48, 209, 245, 84, 54, 29, 158, 198, 75, 84, 21, 141, 54, 34, 46, 17, 66, 1, 124, 255, 245, 143, 207, 4, 225, 207, 240, 5, 238, 69, 66, 101, 104, 204, 172, 0, 35, 236, 117, 86, 29, 204, 236, 86, 69, 180, 185, 202, 47, 193, 178, 120, 192, 194, 23, 224, 234, 245, 155 }, new byte[] { 127, 168, 21, 26, 222, 91, 23, 207, 35, 111, 193, 114, 188, 3, 63, 129, 142, 19, 113, 10, 142, 148, 107, 49, 133, 172, 140, 246, 7, 190, 80, 227, 114, 238, 185, 94, 130, 71, 8, 153, 236, 44, 253, 89, 160, 42, 66, 63, 160, 168, 150, 206, 254, 83, 209, 63, 59, 25, 129, 110, 29, 210, 70, 69, 51, 220, 195, 143, 44, 154, 145, 231, 63, 128, 125, 203, 164, 253, 156, 116, 143, 136, 69, 249, 42, 65, 245, 8, 222, 158, 112, 176, 213, 210, 188, 41, 57, 143, 82, 70, 226, 197, 63, 178, 101, 61, 241, 149, 121, 145, 42, 214, 85, 215, 90, 97, 197, 212, 160, 236, 20, 162, 198, 197, 245, 173, 36, 225 } });
        }
    }
}
