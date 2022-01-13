using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectSetting_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSettings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProjectSettings",
                columns: new[] { "Id", "Name", "Value", "projectID" },
                values: new object[] { 1, "Analiz Count", "0", 0 });

            migrationBuilder.InsertData(
                table: "ProjectSettings",
                columns: new[] { "Id", "Name", "Value", "projectID" },
                values: new object[] { 2, "Analiz DateTime", null, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 114, 79, 216, 9, 151, 59, 130, 156, 249, 82, 70, 39, 52, 33, 173, 0, 208, 167, 137, 147, 198, 36, 176, 5, 129, 69, 247, 240, 166, 6, 215, 123, 59, 223, 98, 211, 41, 88, 4, 104, 16, 185, 21, 18, 107, 99, 90, 235, 136, 32, 55, 50, 114, 36, 35, 58, 57, 176, 13, 127, 177, 97, 174 }, new byte[] { 118, 123, 235, 46, 1, 96, 72, 159, 19, 49, 187, 94, 116, 35, 82, 60, 135, 165, 231, 155, 203, 197, 191, 135, 5, 218, 186, 146, 104, 194, 184, 246, 202, 56, 18, 178, 19, 190, 186, 225, 26, 58, 43, 32, 235, 107, 72, 38, 155, 132, 111, 99, 70, 35, 151, 182, 220, 194, 96, 35, 127, 40, 245, 135, 37, 19, 27, 170, 105, 225, 192, 50, 74, 73, 134, 206, 96, 125, 148, 28, 180, 187, 5, 232, 50, 171, 214, 183, 125, 232, 218, 10, 107, 235, 148, 87, 118, 11, 131, 178, 97, 103, 106, 228, 192, 41, 226, 48, 165, 38, 64, 55, 234, 4, 41, 108, 178, 107, 58, 125, 114, 122, 130, 3, 148, 164, 81, 39 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectSettings");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 65, 54, 239, 65, 97, 133, 129, 207, 212, 109, 36, 183, 226, 252, 121, 64, 157, 212, 9, 73, 228, 177, 237, 124, 109, 33, 171, 6, 237, 5, 211, 10, 52, 165, 127, 126, 242, 255, 230, 110, 54, 130, 67, 37, 61, 189, 76, 190, 173, 140, 139, 23, 35, 82, 208, 117, 253, 160, 212, 42, 168, 152, 167, 69 }, new byte[] { 83, 248, 194, 141, 6, 157, 34, 101, 7, 65, 109, 52, 185, 175, 206, 197, 190, 91, 179, 39, 103, 45, 230, 183, 220, 148, 168, 214, 219, 157, 71, 233, 224, 13, 177, 215, 151, 17, 57, 212, 211, 56, 155, 148, 190, 212, 8, 105, 98, 154, 100, 196, 102, 181, 174, 133, 218, 29, 138, 14, 196, 169, 4, 55, 22, 85, 210, 32, 39, 211, 109, 225, 196, 131, 230, 198, 158, 97, 32, 57, 255, 45, 126, 89, 122, 173, 158, 132, 45, 46, 165, 86, 251, 35, 112, 192, 245, 204, 194, 41, 224, 135, 22, 188, 254, 107, 126, 252, 249, 54, 25, 241, 54, 223, 213, 25, 205, 253, 78, 175, 91, 102, 160, 219, 201, 65, 136, 181 } });
        }
    }
}
