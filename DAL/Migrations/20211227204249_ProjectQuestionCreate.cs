﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectQuestionCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 254, 173, 178, 112, 144, 185, 244, 42, 52, 209, 69, 230, 24, 10, 204, 155, 159, 88, 103, 93, 169, 185, 27, 102, 234, 150, 164, 25, 220, 208, 3, 76, 188, 172, 39, 253, 160, 11, 54, 206, 140, 14, 160, 209, 163, 228, 188, 53, 244, 144, 200, 253, 211, 2, 207, 120, 227, 161, 106, 84, 223, 253, 127 }, new byte[] { 57, 107, 134, 107, 73, 53, 86, 50, 45, 225, 78, 230, 190, 61, 70, 138, 58, 196, 136, 33, 196, 72, 250, 253, 164, 162, 228, 153, 229, 115, 195, 235, 160, 112, 105, 155, 124, 227, 148, 44, 139, 118, 207, 6, 120, 85, 6, 220, 213, 165, 4, 9, 192, 64, 168, 193, 139, 106, 202, 30, 196, 62, 78, 216, 121, 38, 235, 183, 133, 89, 152, 32, 226, 218, 133, 41, 55, 230, 59, 243, 140, 54, 160, 48, 133, 33, 100, 93, 19, 186, 83, 60, 8, 8, 70, 197, 164, 33, 189, 113, 190, 165, 4, 62, 171, 221, 138, 35, 193, 237, 99, 138, 230, 222, 15, 0, 72, 162, 147, 37, 109, 204, 97, 189, 61, 67, 112, 19 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 67, 10, 144, 231, 209, 191, 78, 179, 115, 185, 97, 237, 140, 92, 252, 243, 229, 115, 199, 187, 41, 127, 113, 7, 202, 17, 187, 19, 207, 200, 162, 200, 211, 157, 172, 10, 29, 133, 23, 35, 18, 244, 31, 80, 128, 39, 60, 142, 55, 139, 169, 175, 62, 7, 208, 191, 26, 217, 179, 202, 188, 192, 155 }, new byte[] { 110, 229, 22, 220, 191, 166, 173, 86, 130, 153, 181, 166, 21, 212, 44, 173, 208, 208, 120, 13, 72, 102, 118, 23, 221, 83, 212, 78, 129, 52, 71, 235, 87, 75, 224, 91, 156, 93, 218, 139, 30, 245, 244, 160, 72, 245, 158, 214, 71, 17, 100, 10, 7, 19, 170, 110, 14, 187, 6, 11, 162, 45, 194, 81, 39, 189, 122, 86, 233, 17, 251, 139, 136, 140, 101, 175, 116, 130, 235, 43, 92, 88, 29, 172, 231, 38, 253, 169, 35, 164, 136, 6, 237, 89, 82, 47, 223, 84, 80, 108, 183, 34, 254, 187, 171, 238, 204, 161, 16, 214, 30, 111, 5, 240, 255, 242, 36, 70, 215, 92, 221, 222, 20, 15, 106, 68, 83, 25 } });
        }
    }
}
