﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class May16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 126, 190, 41, 100, 80, 191, 251, 97, 5, 208, 252, 66, 61, 65, 188, 140, 112, 130, 241, 122, 145, 40, 188, 192, 86, 16, 45, 133, 57, 115, 1, 248, 199, 90, 126, 103, 230, 45, 7, 75, 107, 99, 197, 88, 157, 55, 129, 37, 127, 43, 201, 90, 41, 207, 53, 41, 22, 27, 169, 26, 92, 86, 43 }, new byte[] { 161, 68, 73, 91, 233, 233, 84, 107, 253, 74, 239, 129, 56, 82, 240, 215, 204, 231, 225, 254, 70, 5, 241, 166, 123, 40, 53, 58, 70, 63, 101, 253, 214, 154, 225, 79, 17, 138, 190, 224, 111, 213, 163, 228, 121, 56, 28, 220, 179, 53, 145, 16, 99, 188, 36, 20, 219, 24, 157, 119, 96, 160, 101, 87, 130, 180, 85, 221, 250, 128, 9, 122, 83, 243, 232, 200, 185, 61, 89, 159, 172, 26, 157, 173, 100, 170, 210, 186, 190, 241, 196, 118, 170, 197, 60, 29, 125, 151, 175, 63, 169, 130, 99, 74, 137, 66, 111, 17, 214, 255, 24, 112, 207, 39, 132, 133, 118, 228, 235, 92, 68, 31, 97, 204, 151, 122, 14, 6 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 70, 229, 81, 57, 22, 221, 65, 183, 147, 34, 14, 118, 170, 100, 210, 224, 189, 225, 77, 31, 205, 102, 226, 220, 24, 160, 72, 107, 166, 7, 170, 2, 211, 202, 86, 140, 20, 92, 179, 13, 54, 238, 24, 210, 73, 77, 96, 19, 162, 206, 155, 117, 65, 99, 92, 58, 209, 176, 54, 0, 2, 47, 226 }, new byte[] { 129, 71, 222, 57, 237, 26, 234, 80, 175, 167, 12, 159, 57, 178, 126, 124, 178, 98, 124, 245, 227, 170, 116, 212, 108, 8, 70, 57, 61, 251, 21, 246, 99, 71, 58, 37, 114, 86, 102, 187, 145, 114, 246, 221, 122, 201, 197, 96, 101, 39, 86, 137, 69, 250, 211, 191, 193, 82, 162, 58, 110, 106, 47, 176, 70, 223, 61, 92, 164, 169, 198, 33, 23, 109, 157, 247, 180, 74, 162, 28, 122, 39, 81, 143, 104, 141, 50, 196, 174, 251, 85, 53, 220, 115, 54, 177, 55, 69, 145, 173, 56, 16, 99, 129, 69, 219, 202, 199, 234, 151, 79, 46, 155, 101, 227, 72, 221, 249, 72, 63, 228, 60, 106, 72, 156, 5, 175, 152 } });
        }
    }
}
