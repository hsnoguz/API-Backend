using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Periots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    StopYear = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PeriotId = table.Column<int>(type: "int", nullable: false),
                    SuccesCount = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 8, 22, 17, 16, 1, 869, DateTimeKind.Local).AddTicks(2950))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Periots_PeriotId",
                        column: x => x.PeriotId,
                        principalTable: "Periots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Index = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionHorizontals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Index = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionHorizontals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionHorizontals_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionVerticals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Index = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Point = table.Column<decimal>(type: "decimal(9,4)", precision: 9, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionVerticals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionVerticals_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name", "UserOperationClaimId" },
                values: new object[] { 1, "Admin", null });

           /* migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "InsertTime", "IsActive", "LastName", "PasswordHash", "PasswordSalt", "Status", "SubeID", "Telephone", "UserName" },
                values: new object[] { 1, "admin@arastirmaturk.com", "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", new byte[] { 90, 184, 185, 230, 121, 254, 40, 152, 46, 210, 0, 194, 124, 200, 241, 185, 220, 255, 24, 15, 31, 126, 75, 165, 77, 70, 198, 5, 139, 70, 251, 230, 214, 141, 231, 100, 127, 173, 65, 36, 120, 140, 192, 44, 6, 67, 185, 223, 206, 141, 88, 21, 10, 37, 225, 48, 137, 240, 61, 115, 23, 254, 253, 239 }, new byte[] { 114, 215, 198, 55, 38, 133, 41, 41, 82, 31, 213, 96, 174, 253, 66, 85, 121, 22, 134, 200, 234, 47, 224, 160, 125, 113, 76, 26, 249, 215, 254, 194, 103, 50, 54, 64, 88, 147, 253, 213, 34, 121, 209, 46, 53, 30, 75, 148, 50, 214, 124, 167, 79, 99, 119, 225, 42, 66, 102, 17, 147, 236, 123, 2, 224, 215, 54, 142, 168, 157, 135, 192, 137, 43, 16, 8, 131, 73, 180, 205, 60, 158, 2, 231, 76, 240, 58, 17, 46, 93, 88, 11, 221, 94, 69, 20, 195, 52, 201, 19, 23, 60, 74, 128, 133, 56, 116, 48, 153, 29, 174, 160, 6, 240, 90, 184, 115, 44, 218, 59, 6, 88, 149, 228, 173, 57, 222, 215 }, true, (short)0, null, null });
           */
            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "OperationClaimId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PeriotId",
                table: "Projects",
                column: "PeriotId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionHorizontals_QuestionId",
                table: "QuestionHorizontals",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ProjectId",
                table: "Questions",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionVerticals_QuestionId",
                table: "QuestionVerticals",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionHorizontals");

            migrationBuilder.DropTable(
                name: "QuestionVerticals");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Periots");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
