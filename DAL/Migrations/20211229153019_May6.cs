﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class May6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "Aims");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 11, 77, 170, 112, 157, 122, 254, 188, 23, 237, 31, 137, 100, 243, 26, 30, 210, 209, 186, 56, 200, 220, 108, 179, 222, 22, 141, 232, 41, 189, 254, 83, 171, 222, 120, 218, 178, 196, 145, 180, 218, 240, 17, 25, 39, 217, 83, 150, 240, 58, 122, 30, 60, 146, 200, 227, 171, 37, 253, 249, 224, 34, 166, 87 }, new byte[] { 22, 60, 179, 87, 65, 106, 36, 150, 121, 80, 123, 114, 137, 129, 14, 119, 221, 165, 130, 206, 244, 28, 184, 111, 99, 146, 89, 124, 8, 172, 76, 180, 20, 135, 107, 31, 143, 220, 174, 14, 219, 105, 30, 100, 186, 253, 85, 151, 147, 233, 62, 252, 181, 254, 28, 10, 235, 45, 105, 59, 150, 208, 45, 142, 230, 180, 183, 191, 166, 125, 211, 197, 144, 35, 0, 249, 38, 48, 104, 230, 46, 227, 152, 84, 29, 118, 164, 49, 58, 234, 155, 232, 200, 134, 102, 112, 168, 185, 183, 108, 187, 20, 181, 233, 178, 18, 37, 23, 6, 152, 100, 191, 163, 225, 114, 9, 45, 144, 72, 85, 137, 190, 216, 93, 11, 39, 250, 189 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TargetId",
                table: "Aims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 106, 236, 114, 92, 173, 50, 23, 178, 181, 97, 34, 194, 49, 45, 215, 23, 204, 195, 84, 97, 215, 86, 209, 191, 79, 55, 220, 163, 165, 65, 250, 244, 1, 157, 174, 47, 244, 231, 189, 251, 27, 33, 211, 57, 64, 70, 153, 167, 122, 25, 47, 32, 16, 121, 222, 73, 216, 108, 244, 122, 226, 97, 63 }, new byte[] { 140, 251, 71, 203, 250, 199, 74, 156, 204, 170, 113, 126, 20, 8, 131, 154, 245, 194, 255, 110, 122, 67, 172, 121, 206, 166, 150, 238, 143, 189, 102, 221, 155, 31, 139, 53, 118, 33, 165, 73, 24, 181, 20, 58, 176, 202, 92, 25, 18, 123, 138, 19, 255, 48, 213, 192, 79, 20, 193, 35, 142, 174, 57, 177, 32, 248, 59, 213, 115, 182, 247, 89, 94, 72, 164, 197, 238, 200, 231, 172, 15, 12, 176, 162, 141, 18, 30, 192, 109, 3, 137, 117, 52, 73, 136, 86, 175, 183, 110, 57, 159, 144, 151, 152, 206, 176, 242, 75, 227, 105, 1, 105, 164, 212, 242, 233, 127, 55, 13, 162, 162, 216, 69, 38, 246, 29, 234, 121 } });
        }
    }
}
