using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class M_BrachOrganizarionPArenId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
             migrationBuilder.RenameColumn(
                 name: "ColumnName",
                 table: "Questions",
                 newName: "Name");

             migrationBuilder.AlterColumn<short>(
                 name: "Value",
                 table: "QuestionVerticals",
                 type: "smallint",
                 nullable: true,
                 oldClrType: typeof(short),
                 oldType: "smallint");
            */
            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "QuestionVerticals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StopTime",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "parentId",
                table: "Organizations",
                type: "int",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "parentId",
                table: "Jops",
                type: "int",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "parentId",
                table: "Branchs",
                type: "int",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StopTime",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Questions",
                newName: "ColumnName");

            migrationBuilder.AlterColumn<short>(
                name: "Value",
                table: "QuestionVerticals",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "QuestionVerticals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "parentId",
                table: "Organizations",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "parentId",
                table: "Jops",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "parentId",
                table: "Branchs",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BranchId", "Email", "FirstName", "IsActive", "JopId", "LastName", "OrganizationId", "PasswordHash", "PasswordSalt", "RefreshTokenId", "Status", "Telephone", "UserName" },
                values: new object[] { 1, 0, "admin@arastirmaturk.com", "Admin", null, 0, "Admin", 0, new byte[] { 6, 106, 133, 64, 151, 126, 228, 105, 9, 165, 129, 147, 15, 233, 5, 198, 106, 21, 122, 169, 14, 42, 61, 242, 171, 15, 213, 146, 20, 63, 138, 135, 9, 22, 17, 82, 102, 22, 228, 170, 17, 25, 162, 110, 130, 73, 104, 157, 144, 46, 156, 221, 99, 214, 101, 137, 80, 142, 217, 47, 136, 79, 124, 231 }, new byte[] { 19, 13, 230, 240, 147, 117, 239, 2, 66, 249, 137, 148, 72, 231, 44, 112, 184, 233, 99, 39, 143, 179, 9, 237, 41, 176, 31, 25, 231, 90, 149, 116, 90, 93, 54, 56, 196, 192, 51, 39, 224, 183, 68, 70, 47, 233, 160, 137, 153, 55, 67, 150, 128, 246, 141, 165, 153, 112, 190, 254, 125, 76, 49, 227, 169, 116, 250, 221, 155, 152, 32, 153, 58, 69, 101, 135, 88, 53, 19, 153, 58, 24, 209, 207, 156, 173, 219, 37, 154, 220, 119, 215, 190, 158, 0, 41, 54, 182, 246, 250, 167, 170, 182, 158, 140, 8, 146, 62, 183, 236, 76, 197, 80, 225, 196, 215, 100, 28, 70, 205, 53, 255, 159, 48, 235, 40, 244, 196 }, null, true, null, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "OperationClaimId", "UserId" },
                values: new object[] { 1, 1, 1 });
        }
    }
}
