﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class V_ATFAF_Plan_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 86, 79, 138, 48, 145, 68, 73, 127, 189, 177, 222, 9, 244, 207, 60, 118, 143, 202, 47, 50, 155, 80, 45, 125, 69, 172, 224, 47, 170, 150, 202, 27, 128, 49, 241, 177, 212, 251, 211, 184, 232, 63, 65, 11, 93, 251, 187, 117, 92, 10, 154, 1, 213, 216, 45, 166, 103, 156, 65, 6, 219, 115, 154, 86 }, new byte[] { 108, 170, 190, 114, 146, 35, 186, 169, 184, 35, 135, 70, 118, 31, 12, 230, 96, 88, 79, 126, 135, 100, 86, 239, 136, 147, 18, 244, 70, 81, 172, 248, 53, 3, 134, 68, 141, 92, 127, 201, 37, 213, 191, 112, 208, 64, 188, 17, 248, 5, 72, 31, 133, 89, 19, 52, 64, 231, 87, 26, 91, 84, 137, 249, 9, 43, 137, 204, 22, 19, 63, 164, 166, 142, 107, 35, 47, 110, 237, 128, 50, 118, 95, 171, 109, 73, 152, 234, 79, 156, 58, 239, 134, 160, 1, 167, 45, 220, 190, 121, 237, 91, 100, 8, 72, 157, 143, 179, 115, 181, 220, 216, 100, 146, 188, 120, 241, 177, 121, 101, 151, 228, 151, 1, 144, 11, 140, 48 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "V_ATFAF_Plans");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 69, 75, 156, 151, 165, 26, 104, 157, 232, 177, 182, 47, 249, 201, 217, 210, 240, 146, 18, 55, 87, 7, 55, 42, 89, 6, 119, 218, 126, 192, 0, 24, 249, 238, 214, 133, 27, 171, 240, 145, 37, 175, 24, 204, 26, 48, 225, 143, 165, 244, 44, 73, 86, 218, 179, 192, 5, 204, 6, 198, 62, 132, 62 }, new byte[] { 12, 8, 146, 26, 145, 80, 172, 102, 85, 92, 156, 220, 254, 217, 160, 89, 38, 134, 103, 88, 163, 117, 197, 14, 148, 23, 3, 45, 158, 161, 31, 206, 77, 54, 65, 189, 109, 105, 124, 120, 125, 1, 209, 60, 198, 151, 69, 103, 165, 249, 231, 106, 44, 180, 32, 173, 8, 209, 5, 169, 168, 132, 111, 126, 111, 152, 171, 184, 230, 9, 232, 150, 203, 96, 13, 109, 136, 28, 228, 20, 239, 91, 98, 98, 16, 247, 155, 223, 143, 231, 202, 79, 253, 186, 39, 143, 65, 157, 198, 5, 6, 93, 146, 5, 184, 169, 180, 90, 141, 1, 131, 87, 38, 89, 115, 82, 234, 38, 111, 24, 178, 217, 213, 200, 159, 184, 20, 39 } });
        }
    }
}