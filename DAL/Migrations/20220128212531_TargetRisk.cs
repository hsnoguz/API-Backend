﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class TargetRisk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 13, 145, 48, 81, 191, 183, 228, 26, 36, 208, 70, 85, 83, 208, 180, 142, 92, 157, 219, 86, 235, 143, 23, 121, 113, 219, 203, 125, 212, 100, 239, 194, 54, 31, 253, 249, 236, 78, 229, 16, 87, 10, 25, 39, 69, 7, 59, 139, 64, 121, 11, 248, 135, 27, 164, 27, 169, 51, 75, 245, 175, 196, 109, 78 }, new byte[] { 181, 163, 22, 37, 96, 107, 252, 127, 119, 108, 222, 193, 210, 31, 138, 196, 118, 100, 6, 229, 24, 137, 224, 101, 174, 126, 223, 7, 108, 0, 168, 153, 123, 188, 34, 83, 139, 15, 183, 149, 2, 19, 186, 23, 81, 159, 190, 178, 206, 189, 201, 216, 95, 226, 118, 10, 69, 243, 247, 138, 82, 163, 60, 201, 34, 158, 159, 172, 229, 4, 200, 47, 76, 161, 156, 164, 1, 31, 228, 159, 86, 157, 209, 245, 108, 206, 61, 163, 157, 234, 86, 84, 68, 43, 244, 216, 156, 230, 3, 181, 129, 80, 148, 26, 76, 197, 21, 44, 95, 68, 16, 47, 127, 19, 249, 27, 250, 111, 216, 123, 63, 255, 78, 88, 36, 30, 16, 152 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 211, 58, 215, 134, 67, 175, 197, 72, 9, 93, 164, 173, 116, 230, 74, 5, 246, 105, 253, 91, 35, 154, 172, 16, 176, 170, 167, 250, 114, 14, 95, 219, 56, 121, 173, 158, 147, 17, 150, 78, 21, 216, 41, 67, 231, 204, 152, 222, 83, 43, 17, 207, 215, 51, 67, 163, 82, 59, 3, 173, 112, 108, 175 }, new byte[] { 179, 164, 3, 190, 88, 154, 25, 163, 231, 20, 245, 14, 143, 138, 30, 127, 161, 72, 111, 161, 185, 4, 191, 223, 53, 138, 232, 244, 64, 201, 156, 242, 147, 207, 215, 222, 210, 4, 247, 101, 112, 16, 10, 243, 221, 40, 81, 216, 35, 87, 183, 222, 239, 165, 151, 21, 72, 7, 11, 222, 24, 9, 90, 249, 237, 7, 182, 170, 251, 116, 240, 31, 30, 36, 101, 108, 193, 185, 118, 104, 109, 103, 112, 231, 120, 130, 243, 88, 60, 158, 88, 41, 44, 225, 80, 177, 85, 104, 31, 201, 58, 65, 60, 253, 115, 229, 237, 168, 152, 252, 248, 112, 172, 50, 86, 225, 175, 48, 100, 63, 162, 241, 63, 69, 251, 200, 217, 177 } });
        }
    }
}
