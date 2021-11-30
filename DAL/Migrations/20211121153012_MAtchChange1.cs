﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MAtchChange1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 46, 79, 85, 100, 132, 81, 113, 119, 150, 10, 164, 94, 47, 238, 6, 147, 98, 232, 11, 25, 189, 193, 166, 223, 214, 245, 144, 108, 143, 171, 12, 250, 163, 146, 101, 89, 120, 246, 128, 31, 251, 79, 245, 116, 196, 173, 191, 128, 37, 187, 73, 188, 13, 22, 108, 196, 227, 168, 13, 45, 47, 85, 37 }, new byte[] { 31, 251, 237, 221, 169, 208, 60, 140, 101, 219, 21, 105, 87, 199, 21, 97, 247, 27, 231, 174, 154, 38, 197, 159, 129, 223, 230, 101, 116, 188, 93, 122, 104, 249, 128, 131, 101, 54, 8, 203, 122, 80, 243, 130, 197, 103, 156, 15, 165, 249, 206, 5, 122, 143, 96, 58, 102, 251, 117, 167, 234, 130, 136, 63, 198, 82, 232, 235, 83, 169, 198, 212, 190, 88, 1, 241, 123, 206, 61, 206, 126, 30, 2, 237, 253, 168, 62, 68, 240, 184, 185, 98, 90, 109, 25, 185, 97, 255, 74, 172, 28, 170, 201, 43, 61, 200, 10, 160, 136, 3, 97, 233, 69, 165, 54, 234, 203, 48, 243, 205, 63, 243, 209, 142, 239, 124, 176, 24 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 39, 58, 145, 207, 214, 157, 172, 156, 34, 71, 134, 118, 222, 182, 40, 187, 124, 71, 158, 46, 212, 201, 143, 20, 122, 52, 97, 182, 147, 148, 64, 249, 55, 223, 49, 246, 115, 12, 77, 123, 17, 10, 55, 72, 176, 233, 102, 63, 187, 36, 30, 152, 13, 167, 171, 204, 75, 209, 96, 4, 26, 224, 153, 133 }, new byte[] { 133, 89, 14, 78, 62, 12, 187, 92, 127, 81, 232, 24, 14, 242, 207, 84, 243, 44, 2, 82, 113, 201, 149, 241, 197, 61, 188, 128, 143, 18, 104, 194, 118, 3, 75, 190, 171, 89, 166, 190, 104, 24, 90, 44, 243, 47, 137, 197, 63, 188, 53, 81, 139, 91, 227, 208, 213, 77, 195, 20, 33, 55, 9, 169, 122, 8, 148, 228, 29, 57, 31, 89, 25, 36, 149, 110, 4, 100, 156, 129, 72, 73, 249, 211, 105, 196, 226, 83, 12, 26, 49, 20, 178, 45, 137, 182, 226, 222, 7, 23, 51, 156, 143, 42, 174, 174, 58, 241, 182, 143, 8, 123, 254, 169, 60, 53, 202, 39, 185, 0, 167, 55, 169, 178, 7, 25, 242, 150 } });
        }
    }
}