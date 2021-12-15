using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class LeftMenu1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeftMenu",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Src = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MenuId = table.Column<short>(type: "smallint", nullable: true),
                    MenuIndex = table.Column<short>(type: "smallint", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true),
                    ImageUrl2 = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true),
                    OnClick = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    AccessRank = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Left_Menu", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "UserLeftMenuClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false),
                    LeftMenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLeftMenuClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLeftMenuClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LeftMenu",
                columns: new[] { "Id", "AccessRank", "Description", "ImageUrl", "ImageUrl2", "MenuId", "MenuIndex", "OnClick", "Src" },
                values: new object[] { (short)1, null, "Kullanıcı İşlemleri", "fa fa-user", null, (short)0, null, null, "/user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 71, 170, 18, 34, 233, 144, 147, 102, 58, 59, 138, 75, 119, 172, 126, 113, 118, 98, 141, 9, 22, 203, 93, 79, 70, 210, 183, 104, 29, 71, 23, 41, 33, 126, 177, 106, 246, 15, 143, 63, 89, 174, 88, 16, 163, 184, 132, 48, 117, 66, 30, 82, 68, 117, 142, 172, 66, 69, 216, 57, 107, 238, 119, 4 }, new byte[] { 194, 88, 213, 23, 135, 170, 153, 47, 113, 146, 50, 184, 83, 135, 117, 164, 35, 147, 3, 210, 191, 47, 180, 30, 164, 129, 18, 236, 4, 119, 6, 142, 87, 136, 112, 201, 73, 119, 241, 199, 228, 121, 188, 31, 17, 211, 110, 247, 15, 70, 246, 236, 7, 86, 50, 198, 89, 171, 108, 99, 72, 20, 68, 57, 131, 12, 57, 15, 30, 147, 242, 120, 231, 151, 41, 71, 145, 118, 194, 4, 10, 145, 252, 177, 108, 82, 153, 195, 193, 226, 34, 132, 91, 83, 199, 142, 250, 124, 38, 193, 74, 237, 62, 217, 247, 40, 61, 94, 146, 213, 98, 200, 137, 66, 66, 222, 69, 62, 126, 66, 43, 116, 35, 102, 124, 120, 214, 42 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserLeftMenuClaims_OperationClaimId",
                table: "UserLeftMenuClaims",
                column: "OperationClaimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeftMenu");

            migrationBuilder.DropTable(
                name: "UserLeftMenuClaims");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 197, 21, 196, 188, 8, 182, 239, 30, 96, 79, 133, 186, 91, 234, 245, 23, 226, 116, 233, 53, 158, 170, 96, 60, 143, 119, 74, 177, 100, 95, 192, 217, 26, 30, 86, 60, 124, 173, 140, 214, 57, 149, 229, 8, 161, 160, 211, 122, 18, 183, 124, 222, 227, 67, 123, 74, 255, 209, 38, 78, 72, 165, 53 }, new byte[] { 247, 143, 55, 22, 6, 72, 103, 242, 130, 14, 75, 70, 104, 21, 182, 240, 99, 44, 222, 16, 165, 2, 79, 185, 145, 49, 23, 22, 11, 119, 177, 50, 18, 196, 194, 169, 34, 151, 221, 250, 217, 95, 182, 244, 94, 208, 116, 20, 155, 160, 201, 187, 150, 30, 149, 151, 175, 172, 116, 66, 198, 40, 38, 198, 233, 193, 60, 130, 8, 76, 54, 72, 88, 185, 122, 145, 45, 132, 101, 100, 114, 242, 156, 232, 98, 124, 162, 191, 213, 118, 199, 227, 43, 247, 46, 184, 75, 102, 255, 59, 3, 161, 133, 167, 42, 116, 42, 171, 63, 207, 162, 70, 176, 58, 204, 122, 103, 193, 86, 143, 170, 204, 241, 197, 93, 177, 242, 183 } });
        }
    }
}
