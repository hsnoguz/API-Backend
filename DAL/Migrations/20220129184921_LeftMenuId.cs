using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class LeftMenuId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
   
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 138, 54, 156, 255, 20, 11, 170, 199, 57, 248, 76, 178, 1, 87, 145, 81, 200, 49, 244, 189, 18, 150, 253, 44, 187, 75, 47, 178, 26, 101, 167, 175, 127, 67, 66, 58, 79, 229, 177, 191, 7, 27, 3, 65, 74, 136, 141, 64, 114, 4, 101, 149, 148, 33, 138, 127, 241, 219, 54, 40, 149, 95, 179, 23 }, new byte[] { 44, 251, 243, 138, 152, 115, 136, 249, 54, 33, 203, 145, 74, 210, 125, 60, 80, 219, 62, 208, 43, 73, 46, 17, 99, 117, 96, 60, 88, 57, 31, 139, 146, 210, 162, 18, 129, 19, 38, 34, 47, 177, 36, 248, 123, 9, 100, 50, 52, 170, 240, 70, 172, 156, 111, 81, 71, 132, 6, 9, 85, 175, 80, 93, 197, 133, 218, 217, 159, 181, 112, 191, 250, 234, 63, 37, 39, 85, 248, 30, 206, 22, 53, 84, 226, 53, 132, 210, 223, 237, 222, 64, 14, 218, 98, 51, 135, 12, 153, 150, 231, 104, 98, 70, 193, 22, 146, 73, 192, 83, 3, 66, 120, 89, 44, 213, 3, 205, 249, 202, 71, 238, 70, 11, 145, 151, 191, 151 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeftMenu",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "LeftMenu",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "LeftMenu",
                columns: new[] { "Id", "AccessRank", "Description", "ImageUrl", "ImageUrl2", "MenuId", "MenuIndex", "OnClick", "Src" },
                values: new object[] { (short)1, null, "Kullanıcı İşlemleri", "fa fa-user", null, (short)0, null, null, "/user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 192, 226, 236, 37, 41, 107, 38, 246, 191, 236, 39, 225, 184, 169, 15, 229, 115, 63, 62, 165, 225, 221, 171, 95, 136, 204, 246, 15, 239, 247, 64, 130, 239, 245, 93, 106, 142, 59, 41, 238, 152, 77, 27, 47, 179, 228, 238, 124, 158, 102, 59, 228, 135, 224, 84, 196, 72, 101, 89, 17, 55, 92, 35, 233 }, new byte[] { 75, 134, 138, 94, 13, 110, 215, 247, 144, 141, 240, 228, 161, 92, 253, 161, 51, 215, 71, 22, 101, 140, 141, 176, 165, 16, 170, 145, 203, 241, 71, 0, 6, 91, 132, 209, 60, 51, 190, 123, 178, 79, 204, 133, 146, 144, 130, 118, 134, 89, 252, 108, 227, 23, 175, 3, 121, 35, 41, 177, 100, 175, 86, 13, 50, 0, 217, 144, 151, 227, 50, 3, 135, 126, 89, 3, 109, 62, 0, 207, 20, 197, 165, 155, 2, 242, 123, 104, 11, 77, 28, 189, 158, 174, 25, 93, 68, 2, 94, 31, 146, 65, 115, 11, 177, 229, 194, 178, 17, 179, 182, 33, 155, 107, 179, 127, 166, 34, 223, 7, 177, 90, 245, 63, 30, 90, 175, 231 } });
        }
    }
}
