using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class mg_RefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationClaims_UserOperationClaims_UserOperationClaimId",
                table: "OperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_OperationClaims_UserOperationClaimId",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "UserOperationClaimId",
                table: "OperationClaims");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Users",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "RefreshTokenId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RefreshTokenId1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 26, 21, 50, 15, 519, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsUsing = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 3, 232, 7, 206, 61, 225, 104, 90, 73, 240, 97, 247, 119, 163, 246, 92, 147, 9, 200, 240, 20, 103, 93, 199, 56, 248, 50, 143, 19, 176, 165, 214, 137, 107, 174, 145, 8, 41, 169, 117, 220, 113, 82, 2, 171, 83, 231, 124, 206, 87, 221, 75, 48, 222, 86, 113, 41, 144, 7, 65, 157, 12, 76, 194 }, new byte[] { 6, 175, 147, 44, 188, 38, 136, 17, 39, 202, 156, 63, 193, 96, 201, 161, 247, 101, 92, 61, 36, 209, 123, 235, 71, 160, 213, 121, 143, 158, 26, 33, 50, 237, 231, 93, 11, 218, 250, 9, 101, 238, 126, 215, 8, 69, 81, 51, 53, 195, 58, 151, 205, 124, 69, 101, 35, 241, 135, 55, 74, 140, 29, 135, 96, 225, 10, 205, 90, 29, 243, 13, 246, 75, 118, 254, 112, 191, 103, 190, 53, 39, 92, 38, 68, 144, 242, 31, 255, 103, 43, 176, 208, 143, 141, 57, 18, 161, 210, 160, 250, 209, 161, 218, 166, 142, 161, 113, 95, 226, 225, 123, 61, 6, 44, 149, 31, 206, 113, 72, 201, 141, 149, 81, 143, 90, 85, 13 } });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RefreshTokenId1",
                table: "Users",
                column: "RefreshTokenId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId",
                principalTable: "OperationClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_RefreshToken_RefreshTokenId1",
                table: "Users",
                column: "RefreshTokenId1",
                principalTable: "RefreshToken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                table: "UserOperationClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_RefreshToken_RefreshTokenId1",
                table: "Users");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropIndex(
                name: "IX_Users_RefreshTokenId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "RefreshTokenId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenId1",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 26, 21, 50, 15, 519, DateTimeKind.Local).AddTicks(861),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<int>(
                name: "UserOperationClaimId",
                table: "OperationClaims",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 200, 185, 38, 114, 175, 33, 125, 226, 154, 148, 7, 134, 192, 105, 246, 31, 39, 36, 173, 196, 150, 129, 93, 43, 66, 89, 76, 110, 176, 29, 14, 138, 245, 55, 235, 201, 99, 197, 128, 158, 199, 19, 93, 77, 121, 55, 4, 4, 163, 131, 153, 186, 96, 8, 105, 171, 64, 133, 154, 62, 227, 123, 13, 15 }, new byte[] { 5, 252, 36, 212, 206, 245, 246, 192, 214, 85, 35, 216, 0, 74, 137, 45, 209, 40, 59, 155, 128, 205, 162, 250, 255, 17, 96, 19, 29, 227, 197, 227, 250, 187, 255, 169, 4, 247, 125, 75, 89, 116, 154, 183, 143, 38, 31, 202, 165, 176, 183, 5, 246, 164, 178, 27, 39, 225, 236, 171, 168, 239, 91, 238, 116, 217, 146, 225, 255, 211, 118, 157, 144, 88, 234, 250, 211, 182, 7, 205, 189, 80, 40, 120, 78, 119, 180, 214, 55, 233, 34, 124, 192, 17, 163, 118, 81, 103, 200, 214, 139, 124, 54, 35, 23, 33, 181, 254, 238, 236, 141, 225, 134, 164, 169, 223, 157, 222, 38, 131, 42, 64, 120, 106, 57, 80, 214, 31 } });

            migrationBuilder.CreateIndex(
                name: "IX_OperationClaims_UserOperationClaimId",
                table: "OperationClaims",
                column: "UserOperationClaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationClaims_UserOperationClaims_UserOperationClaimId",
                table: "OperationClaims",
                column: "UserOperationClaimId",
                principalTable: "UserOperationClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
