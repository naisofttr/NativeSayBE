using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class idtokenremovedoncustomertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f3a92baa-8acc-4258-821d-e012c3d8f911"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("375eb22f-7ca1-474e-a07a-143e10013e51"));

            migrationBuilder.DropColumn(
                name: "IdToken",
                table: "customer");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("8cf66c12-7c8e-4514-a312-b973ebe28316"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 184, 29, 218, 175, 170, 218, 238, 92, 158, 59, 48, 233, 144, 123, 116, 57, 115, 37, 62, 136, 169, 158, 205, 219, 88, 143, 177, 102, 240, 222, 157, 129, 140, 66, 228, 62, 207, 147, 200, 28, 86, 168, 36, 104, 40, 186, 15, 80, 143, 99, 15, 216, 200, 45, 76, 134, 130, 234, 235, 73, 228, 72, 25, 244 }, new byte[] { 41, 138, 112, 122, 216, 195, 59, 171, 104, 88, 90, 132, 245, 75, 58, 181, 48, 224, 121, 3, 163, 245, 213, 132, 30, 249, 149, 39, 75, 161, 180, 30, 198, 135, 58, 230, 179, 44, 136, 101, 247, 215, 221, 62, 75, 173, 179, 251, 197, 27, 231, 63, 45, 80, 21, 128, 232, 78, 132, 222, 136, 87, 61, 242, 106, 171, 15, 114, 70, 49, 45, 183, 39, 23, 196, 170, 253, 245, 31, 3, 95, 50, 23, 148, 32, 106, 5, 220, 186, 67, 99, 185, 12, 191, 129, 146, 130, 244, 217, 53, 24, 212, 22, 177, 143, 190, 71, 23, 116, 154, 208, 142, 74, 214, 217, 164, 139, 39, 248, 200, 100, 61, 125, 21, 51, 121, 244, 2 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("f71bfaae-c011-4245-9d64-b68d98e5c644"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("8cf66c12-7c8e-4514-a312-b973ebe28316") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f71bfaae-c011-4245-9d64-b68d98e5c644"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cf66c12-7c8e-4514-a312-b973ebe28316"));

            migrationBuilder.AddColumn<string>(
                name: "IdToken",
                table: "customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("375eb22f-7ca1-474e-a07a-143e10013e51"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 194, 231, 58, 27, 74, 95, 137, 185, 245, 170, 250, 17, 92, 229, 102, 131, 252, 150, 43, 7, 238, 73, 6, 244, 224, 236, 133, 113, 229, 203, 237, 65, 232, 98, 198, 98, 30, 128, 229, 126, 121, 1, 216, 214, 89, 242, 46, 117, 167, 178, 170, 196, 122, 0, 159, 50, 54, 79, 222, 137, 222, 120, 223, 95 }, new byte[] { 137, 125, 48, 55, 190, 199, 162, 64, 161, 73, 89, 206, 77, 157, 58, 145, 137, 94, 138, 149, 248, 44, 120, 59, 199, 30, 168, 8, 86, 183, 27, 76, 67, 133, 130, 114, 145, 213, 104, 82, 115, 27, 26, 92, 205, 175, 25, 236, 46, 238, 31, 1, 126, 236, 253, 27, 229, 5, 94, 87, 39, 125, 66, 204, 84, 211, 48, 152, 243, 8, 140, 153, 21, 73, 246, 235, 113, 39, 60, 81, 56, 196, 5, 28, 255, 240, 93, 56, 210, 115, 162, 107, 162, 73, 25, 26, 167, 243, 57, 165, 240, 185, 134, 225, 169, 159, 78, 142, 190, 92, 1, 115, 79, 67, 25, 136, 12, 137, 90, 190, 140, 199, 68, 6, 239, 23, 95, 50 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("f3a92baa-8acc-4258-821d-e012c3d8f911"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("375eb22f-7ca1-474e-a07a-143e10013e51") });
        }
    }
}
