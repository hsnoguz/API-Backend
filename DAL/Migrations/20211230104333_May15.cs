﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class May15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 70, 229, 81, 57, 22, 221, 65, 183, 147, 34, 14, 118, 170, 100, 210, 224, 189, 225, 77, 31, 205, 102, 226, 220, 24, 160, 72, 107, 166, 7, 170, 2, 211, 202, 86, 140, 20, 92, 179, 13, 54, 238, 24, 210, 73, 77, 96, 19, 162, 206, 155, 117, 65, 99, 92, 58, 209, 176, 54, 0, 2, 47, 226 }, new byte[] { 129, 71, 222, 57, 237, 26, 234, 80, 175, 167, 12, 159, 57, 178, 126, 124, 178, 98, 124, 245, 227, 170, 116, 212, 108, 8, 70, 57, 61, 251, 21, 246, 99, 71, 58, 37, 114, 86, 102, 187, 145, 114, 246, 221, 122, 201, 197, 96, 101, 39, 86, 137, 69, 250, 211, 191, 193, 82, 162, 58, 110, 106, 47, 176, 70, 223, 61, 92, 164, 169, 198, 33, 23, 109, 157, 247, 180, 74, 162, 28, 122, 39, 81, 143, 104, 141, 50, 196, 174, 251, 85, 53, 220, 115, 54, 177, 55, 69, 145, 173, 56, 16, 99, 129, 69, 219, 202, 199, 234, 151, 79, 46, 155, 101, 227, 72, 221, 249, 72, 63, 228, 60, 106, 72, 156, 5, 175, 152 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 204, 136, 101, 123, 60, 185, 42, 126, 128, 25, 138, 177, 1, 218, 137, 236, 39, 186, 219, 215, 11, 59, 228, 34, 36, 254, 96, 253, 223, 35, 199, 144, 149, 62, 201, 59, 225, 153, 227, 36, 22, 105, 94, 186, 91, 156, 73, 135, 116, 212, 143, 173, 187, 225, 160, 114, 108, 161, 193, 232, 207, 219, 249 }, new byte[] { 9, 88, 193, 218, 128, 248, 231, 193, 28, 203, 82, 255, 233, 114, 233, 56, 214, 190, 63, 89, 163, 222, 1, 174, 134, 189, 41, 29, 73, 179, 154, 68, 107, 20, 164, 238, 171, 197, 155, 150, 145, 130, 116, 113, 111, 245, 206, 153, 218, 87, 190, 45, 68, 126, 75, 70, 97, 249, 9, 185, 196, 174, 148, 171, 173, 102, 31, 12, 192, 94, 182, 199, 207, 20, 58, 211, 138, 141, 60, 63, 0, 175, 147, 219, 178, 20, 69, 180, 24, 56, 149, 179, 134, 29, 126, 91, 160, 201, 28, 156, 227, 197, 223, 64, 62, 84, 17, 210, 66, 72, 28, 122, 251, 35, 13, 254, 73, 112, 153, 107, 44, 11, 81, 183, 95, 212, 12, 36 } });
        }
    }
}