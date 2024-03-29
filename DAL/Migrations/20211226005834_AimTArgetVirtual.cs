﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AimTArgetVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 121, 156, 75, 109, 130, 45, 89, 223, 233, 249, 161, 203, 36, 203, 243, 169, 168, 11, 238, 55, 126, 0, 164, 158, 22, 156, 2, 26, 86, 211, 93, 198, 74, 227, 104, 222, 117, 211, 10, 247, 101, 225, 254, 7, 124, 252, 219, 59, 189, 139, 197, 184, 183, 200, 242, 223, 152, 250, 151, 153, 255, 39, 244, 59 }, new byte[] { 61, 41, 5, 246, 43, 157, 136, 130, 137, 54, 127, 113, 23, 66, 76, 201, 213, 67, 77, 130, 174, 95, 114, 162, 188, 234, 145, 17, 21, 149, 100, 211, 40, 97, 209, 16, 34, 89, 133, 250, 138, 170, 3, 244, 220, 196, 33, 183, 252, 60, 174, 24, 82, 63, 246, 44, 141, 125, 188, 175, 91, 143, 183, 42, 9, 38, 30, 227, 246, 130, 92, 173, 203, 213, 117, 14, 58, 111, 143, 156, 29, 246, 11, 247, 53, 77, 98, 121, 189, 50, 211, 79, 243, 188, 115, 99, 90, 84, 200, 23, 16, 43, 165, 190, 200, 238, 25, 131, 214, 97, 46, 49, 240, 123, 1, 209, 129, 203, 200, 152, 153, 109, 190, 218, 21, 180, 67, 252 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 55, 28, 186, 175, 213, 126, 7, 117, 225, 115, 38, 143, 165, 146, 98, 196, 194, 250, 112, 208, 251, 121, 137, 135, 2, 169, 122, 30, 3, 169, 30, 146, 80, 89, 176, 104, 20, 28, 220, 88, 56, 140, 234, 144, 217, 1, 46, 192, 229, 199, 163, 185, 152, 57, 136, 57, 9, 1, 178, 63, 205, 123, 79, 68 }, new byte[] { 160, 144, 13, 164, 162, 242, 18, 235, 8, 113, 140, 234, 57, 163, 56, 46, 87, 172, 217, 250, 36, 101, 195, 183, 215, 123, 187, 84, 115, 129, 211, 183, 91, 32, 151, 250, 185, 4, 216, 236, 111, 7, 122, 87, 250, 164, 80, 87, 31, 122, 231, 224, 196, 68, 139, 196, 10, 26, 95, 147, 197, 44, 165, 176, 49, 194, 103, 182, 204, 245, 63, 171, 176, 190, 115, 139, 221, 114, 115, 19, 74, 147, 149, 220, 160, 97, 127, 224, 131, 212, 88, 245, 33, 171, 112, 229, 192, 35, 137, 96, 24, 205, 92, 124, 40, 229, 229, 240, 11, 105, 105, 159, 69, 247, 147, 141, 3, 75, 4, 10, 220, 160, 141, 147, 53, 58, 16, 7 } });
        }
    }
}
