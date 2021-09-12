using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InsertDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
    table: "Users",
    columns: new[] { "BranchId", "Email", "FirstName", "IsActive", "JopId", "LastName", "OrganizationId", "PasswordHash", "PasswordSalt", "RefreshTokenId", "Status", "Telephone", "UserName" },
    values: new object[] { 3, "admin@arastirmaturk.com", "Admin", null, 1, "Admin", 2, new byte[] { 61, 193, 209, 242, 87, 20, 167, 104, 113, 119, 133, 255, 144, 96, 185, 240, 192, 7, 49, 91, 198, 57, 196, 215, 119, 30, 151, 47, 203, 143, 71, 150, 98, 137, 94, 60, 251, 241, 144, 17, 203, 41, 184, 81, 68, 255, 181, 77, 97, 224, 178, 133, 254, 14, 159, 124, 35, 253, 125, 237, 219, 1, 83, 163 }, new byte[] { 112, 104, 19, 195, 59, 123, 91, 163, 24, 23, 34, 196, 195, 180, 26, 160, 56, 39, 155, 97, 158, 8, 134, 39, 117, 141, 226, 57, 174, 112, 21, 104, 82, 107, 10, 180, 195, 74, 235, 132, 146, 38, 219, 134, 24, 94, 140, 48, 33, 192, 48, 237, 44, 152, 83, 72, 25, 68, 68, 174, 113, 155, 235, 167, 39, 187, 249, 184, 209, 139, 241, 153, 253, 75, 90, 89, 56, 227, 108, 127, 112, 189, 143, 136, 64, 49, 95, 144, 17, 181, 177, 149, 202, 188, 136, 134, 190, 17, 220, 213, 95, 219, 240, 185, 245, 175, 44, 124, 141, 132, 53, 125, 102, 115, 82, 190, 34, 88, 140, 15, 75, 142, 207, 150, 78, 94, 66, 61 }, null, true, null, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "OperationClaimId", "UserId" },
                values: new object[] { 1, 1 });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 240, 72, 59, 123, 185, 16, 229, 237, 21, 200, 22, 174, 191, 178, 53, 41, 107, 63, 245, 164, 251, 152, 246, 208, 120, 12, 73, 215, 41, 205, 81, 236, 165, 65, 227, 118, 245, 31, 189, 150, 59, 152, 121, 25, 249, 110, 244, 191, 181, 255, 208, 197, 55, 87, 86, 96, 182, 1, 40, 245, 250, 254, 166, 68 }, new byte[] { 65, 22, 75, 217, 241, 13, 219, 249, 50, 133, 203, 24, 200, 81, 39, 53, 146, 188, 36, 108, 65, 21, 122, 86, 143, 218, 230, 59, 72, 8, 82, 178, 255, 52, 210, 139, 128, 176, 111, 12, 180, 109, 34, 209, 174, 78, 89, 245, 19, 238, 30, 134, 47, 159, 17, 47, 245, 9, 80, 148, 205, 204, 204, 5, 191, 96, 127, 59, 109, 95, 173, 35, 85, 44, 28, 67, 29, 102, 101, 122, 207, 179, 140, 194, 231, 196, 52, 144, 65, 250, 15, 154, 208, 56, 120, 110, 101, 39, 46, 27, 17, 20, 128, 12, 162, 80, 41, 52, 55, 69, 114, 155, 232, 251, 192, 48, 240, 250, 221, 89, 79, 246, 126, 123, 112, 118, 126, 144 } });
        }
    }
}
