using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class PerformanceStart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SignTypes",
                table: "SignTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignPeriots",
                table: "SignPeriots");

            migrationBuilder.RenameTable(
                name: "SignTypes",
                newName: "PerformanceTypes");

            migrationBuilder.RenameTable(
                name: "SignPeriots",
                newName: "PerformancePeriots");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerformanceTypes",
                table: "PerformanceTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerformancePeriots",
                table: "PerformancePeriots",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PerformanceAims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceAims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PeriotId = table.Column<int>(type: "int", nullable: false),
                    PerformancePeriotId = table.Column<int>(type: "int", nullable: false),
                    PerformanceTypeId = table.Column<int>(type: "int", nullable: false),
                    PerformanceAimId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    StopYear = table.Column<int>(type: "int", nullable: false),
                    StartMonth = table.Column<int>(type: "int", nullable: false),
                    StartDay = table.Column<int>(type: "int", nullable: false),
                    BaseValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TargetValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_PerformanceAims_PerformanceAimId",
                        column: x => x.PerformanceAimId,
                        principalTable: "PerformanceAims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_PerformancePeriots_PerformancePeriotId",
                        column: x => x.PerformancePeriotId,
                        principalTable: "PerformancePeriots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_PerformanceTypes_PerformanceTypeId",
                        column: x => x.PerformanceTypeId,
                        principalTable: "PerformanceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_Periots_PeriotId",
                        column: x => x.PeriotId,
                        principalTable: "Periots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Performance_Target_Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformanceId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<short>(type: "smallint", nullable: false),
                    TargetActionId = table.Column<int>(type: "int", nullable: false),
                    Target = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performance_Target_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performance_Target_Results_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PerformanceAims",
                columns: new[] { "Id", "Explanation", "InsertTime" },
                values: new object[,]
                {
                    { 1, "Yüzdesel Artış", null },
                    { 2, "Rakamsal Artış", null },
                    { 3, "Eşit", null },
                    { 4, "Rakamsal Azalış", null },
                    { 5, "Yüzdesel Artış", null }
                });

            migrationBuilder.InsertData(
                table: "PerformanceTypes",
                columns: new[] { "Id", "Explanation" },
                values: new object[,]
                {
                    { 1, "kg" },
                    { 2, "m2" },
                    { 3, "m3" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 234, 65, 52, 206, 48, 209, 245, 84, 54, 29, 158, 198, 75, 84, 21, 141, 54, 34, 46, 17, 66, 1, 124, 255, 245, 143, 207, 4, 225, 207, 240, 5, 238, 69, 66, 101, 104, 204, 172, 0, 35, 236, 117, 86, 29, 204, 236, 86, 69, 180, 185, 202, 47, 193, 178, 120, 192, 194, 23, 224, 234, 245, 155 }, new byte[] { 127, 168, 21, 26, 222, 91, 23, 207, 35, 111, 193, 114, 188, 3, 63, 129, 142, 19, 113, 10, 142, 148, 107, 49, 133, 172, 140, 246, 7, 190, 80, 227, 114, 238, 185, 94, 130, 71, 8, 153, 236, 44, 253, 89, 160, 42, 66, 63, 160, 168, 150, 206, 254, 83, 209, 63, 59, 25, 129, 110, 29, 210, 70, 69, 51, 220, 195, 143, 44, 154, 145, 231, 63, 128, 125, 203, 164, 253, 156, 116, 143, 136, 69, 249, 42, 65, 245, 8, 222, 158, 112, 176, 213, 210, 188, 41, 57, 143, 82, 70, 226, 197, 63, 178, 101, 61, 241, 149, 121, 145, 42, 214, 85, 215, 90, 97, 197, 212, 160, 236, 20, 162, 198, 197, 245, 173, 36, 225 } });

            migrationBuilder.CreateIndex(
                name: "IX_Performance_Target_Results_PerformanceId",
                table: "Performance_Target_Results",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_OrganizationId",
                table: "Performances",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PerformanceAimId",
                table: "Performances",
                column: "PerformanceAimId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PerformancePeriotId",
                table: "Performances",
                column: "PerformancePeriotId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PerformanceTypeId",
                table: "Performances",
                column: "PerformanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PeriotId",
                table: "Performances",
                column: "PeriotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Performance_Target_Results");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "PerformanceAims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerformanceTypes",
                table: "PerformanceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerformancePeriots",
                table: "PerformancePeriots");

            migrationBuilder.DeleteData(
                table: "PerformanceTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PerformanceTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PerformanceTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "PerformanceTypes",
                newName: "SignTypes");

            migrationBuilder.RenameTable(
                name: "PerformancePeriots",
                newName: "SignPeriots");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignTypes",
                table: "SignTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignPeriots",
                table: "SignPeriots",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 20, 125, 206, 122, 27, 60, 147, 159, 73, 54, 248, 0, 5, 115, 16, 0, 100, 78, 55, 117, 228, 204, 248, 175, 225, 4, 1, 104, 90, 13, 51, 121, 112, 41, 169, 142, 65, 53, 16, 132, 30, 245, 85, 212, 32, 125, 201, 196, 9, 81, 228, 47, 160, 64, 132, 163, 81, 30, 77, 163, 6, 221, 39, 178 }, new byte[] { 85, 15, 227, 184, 30, 248, 77, 61, 43, 194, 13, 13, 73, 108, 37, 0, 207, 133, 94, 140, 26, 87, 226, 79, 99, 5, 41, 85, 174, 20, 187, 131, 18, 26, 47, 104, 55, 172, 28, 74, 61, 68, 64, 229, 119, 236, 213, 28, 11, 120, 22, 100, 56, 11, 253, 5, 14, 37, 60, 138, 14, 49, 65, 97, 7, 11, 223, 107, 46, 121, 236, 63, 28, 231, 231, 67, 117, 92, 7, 228, 220, 46, 230, 228, 146, 20, 141, 69, 200, 38, 44, 167, 76, 104, 130, 195, 137, 240, 239, 143, 135, 88, 238, 23, 218, 125, 39, 123, 121, 37, 209, 49, 132, 62, 2, 19, 248, 62, 162, 232, 75, 207, 88, 199, 47, 21, 227, 60 } });
        }
    }
}
