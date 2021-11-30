using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class DBChangeControl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PerformancePeriots",
                columns: new[] { "Id", "Explanation" },
                values: new object[,]
                {
                    { 1, (short)1 },
                    { 2, (short)2 },
                    { 3, (short)3 },
                    { 4, (short)4 },
                    { 5, (short)5 },
                    { 6, (short)6 },
                    { 7, (short)7 },
                    { 8, (short)8 },
                    { 9, (short)9 },
                    { 10, (short)10 },
                    { 11, (short)11 },
                    { 12, (short)12 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 99, 51, 129, 182, 102, 97, 181, 123, 120, 50, 35, 26, 18, 60, 185, 183, 16, 186, 94, 60, 127, 213, 171, 115, 69, 207, 149, 235, 13, 117, 120, 133, 224, 22, 137, 24, 112, 45, 129, 60, 86, 75, 47, 244, 94, 27, 220, 232, 186, 239, 130, 117, 96, 159, 94, 243, 209, 211, 198, 122, 168, 5, 159, 58 }, new byte[] { 91, 125, 125, 196, 140, 185, 192, 78, 168, 137, 177, 201, 24, 95, 226, 75, 189, 211, 240, 244, 238, 15, 51, 137, 15, 229, 119, 154, 65, 242, 204, 113, 189, 187, 152, 159, 218, 238, 47, 22, 149, 77, 39, 45, 213, 46, 200, 111, 91, 156, 44, 147, 87, 252, 37, 203, 217, 6, 192, 78, 78, 222, 157, 14, 131, 147, 154, 147, 12, 179, 121, 40, 222, 193, 114, 201, 122, 250, 220, 149, 160, 140, 153, 134, 88, 148, 228, 14, 6, 106, 253, 8, 229, 89, 7, 5, 61, 200, 105, 182, 26, 146, 161, 65, 204, 182, 53, 241, 213, 72, 240, 239, 255, 194, 45, 125, 77, 194, 154, 223, 6, 155, 94, 54, 125, 187, 12, 96 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PerformancePeriots",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 226, 81, 85, 71, 76, 30, 125, 175, 35, 163, 88, 211, 141, 57, 137, 51, 249, 186, 3, 183, 63, 97, 16, 69, 80, 146, 120, 11, 218, 211, 38, 181, 193, 61, 223, 46, 134, 246, 245, 24, 189, 201, 141, 34, 4, 154, 108, 91, 152, 241, 226, 249, 55, 241, 146, 220, 41, 180, 241, 127, 172, 70, 249 }, new byte[] { 127, 40, 143, 116, 155, 168, 13, 104, 236, 173, 245, 249, 172, 164, 57, 168, 244, 2, 198, 206, 38, 240, 112, 67, 28, 242, 176, 241, 110, 157, 255, 79, 53, 6, 88, 62, 130, 11, 9, 22, 219, 242, 206, 227, 247, 53, 86, 29, 17, 127, 74, 80, 106, 14, 241, 121, 58, 133, 230, 186, 233, 140, 95, 246, 20, 217, 15, 71, 129, 229, 20, 250, 220, 183, 250, 178, 229, 24, 107, 251, 183, 99, 66, 99, 202, 200, 113, 49, 206, 240, 244, 154, 126, 14, 172, 95, 2, 217, 247, 10, 254, 224, 101, 99, 66, 73, 11, 196, 206, 180, 5, 170, 155, 48, 150, 155, 170, 16, 246, 206, 156, 109, 147, 121, 33, 0, 163, 174 } });
        }
    }
}
