﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class PerformanceStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 20, 125, 206, 122, 27, 60, 147, 159, 73, 54, 248, 0, 5, 115, 16, 0, 100, 78, 55, 117, 228, 204, 248, 175, 225, 4, 1, 104, 90, 13, 51, 121, 112, 41, 169, 142, 65, 53, 16, 132, 30, 245, 85, 212, 32, 125, 201, 196, 9, 81, 228, 47, 160, 64, 132, 163, 81, 30, 77, 163, 6, 221, 39, 178 }, new byte[] { 85, 15, 227, 184, 30, 248, 77, 61, 43, 194, 13, 13, 73, 108, 37, 0, 207, 133, 94, 140, 26, 87, 226, 79, 99, 5, 41, 85, 174, 20, 187, 131, 18, 26, 47, 104, 55, 172, 28, 74, 61, 68, 64, 229, 119, 236, 213, 28, 11, 120, 22, 100, 56, 11, 253, 5, 14, 37, 60, 138, 14, 49, 65, 97, 7, 11, 223, 107, 46, 121, 236, 63, 28, 231, 231, 67, 117, 92, 7, 228, 220, 46, 230, 228, 146, 20, 141, 69, 200, 38, 44, 167, 76, 104, 130, 195, 137, 240, 239, 143, 135, 88, 238, 23, 218, 125, 39, 123, 121, 37, 209, 49, 132, 62, 2, 19, 248, 62, 162, 232, 75, 207, 88, 199, 47, 21, 227, 60 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 191, 16, 31, 243, 138, 145, 177, 4, 79, 206, 230, 2, 75, 71, 55, 53, 95, 74, 5, 7, 120, 172, 192, 165, 78, 118, 72, 143, 124, 59, 177, 51, 128, 16, 10, 160, 82, 141, 60, 83, 30, 209, 225, 132, 91, 192, 25, 53, 159, 7, 48, 113, 66, 54, 100, 8, 156, 84, 35, 104, 13, 227, 166 }, new byte[] { 92, 211, 129, 13, 214, 157, 44, 220, 135, 214, 96, 71, 80, 23, 219, 80, 159, 85, 127, 56, 79, 160, 134, 19, 186, 224, 1, 201, 251, 183, 243, 118, 71, 132, 168, 125, 63, 144, 95, 62, 162, 187, 87, 171, 97, 97, 203, 33, 230, 187, 229, 197, 208, 239, 125, 5, 217, 229, 220, 121, 193, 81, 34, 97, 232, 35, 208, 18, 143, 104, 159, 161, 221, 55, 185, 57, 93, 107, 220, 87, 202, 79, 124, 176, 28, 112, 70, 239, 49, 94, 157, 201, 170, 73, 40, 76, 15, 197, 172, 13, 40, 37, 51, 88, 19, 240, 175, 23, 175, 129, 112, 71, 94, 168, 41, 206, 31, 203, 42, 128, 104, 67, 69, 31, 239, 67, 158, 22 } });
        }
    }
}
