using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _10001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("11e4a74b-ff5a-462b-97fe-f8a00f0363c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("125e3aac-cd74-468c-b6b7-cb4ffb86cc2b"));

            migrationBuilder.AddColumn<int>(
                name: "Recid",
                table: "customer",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1000, 1");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("375eb22f-7ca1-474e-a07a-143e10013e51"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 194, 231, 58, 27, 74, 95, 137, 185, 245, 170, 250, 17, 92, 229, 102, 131, 252, 150, 43, 7, 238, 73, 6, 244, 224, 236, 133, 113, 229, 203, 237, 65, 232, 98, 198, 98, 30, 128, 229, 126, 121, 1, 216, 214, 89, 242, 46, 117, 167, 178, 170, 196, 122, 0, 159, 50, 54, 79, 222, 137, 222, 120, 223, 95 }, new byte[] { 137, 125, 48, 55, 190, 199, 162, 64, 161, 73, 89, 206, 77, 157, 58, 145, 137, 94, 138, 149, 248, 44, 120, 59, 199, 30, 168, 8, 86, 183, 27, 76, 67, 133, 130, 114, 145, 213, 104, 82, 115, 27, 26, 92, 205, 175, 25, 236, 46, 238, 31, 1, 126, 236, 253, 27, 229, 5, 94, 87, 39, 125, 66, 204, 84, 211, 48, 152, 243, 8, 140, 153, 21, 73, 246, 235, 113, 39, 60, 81, 56, 196, 5, 28, 255, 240, 93, 56, 210, 115, 162, 107, 162, 73, 25, 26, 167, 243, 57, 165, 240, 185, 134, 225, 169, 159, 78, 142, 190, 92, 1, 115, 79, 67, 25, 136, 12, 137, 90, 190, 140, 199, 68, 6, 239, 23, 95, 50 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("f3a92baa-8acc-4258-821d-e012c3d8f911"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("375eb22f-7ca1-474e-a07a-143e10013e51") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Recid",
                table: "customer");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("125e3aac-cd74-468c-b6b7-cb4ffb86cc2b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 72, 181, 180, 156, 11, 9, 200, 218, 58, 145, 155, 190, 82, 190, 203, 160, 66, 69, 52, 146, 253, 228, 79, 92, 158, 133, 66, 122, 23, 239, 155, 125, 233, 79, 240, 214, 154, 34, 143, 202, 213, 159, 71, 225, 245, 169, 193, 48, 148, 50, 106, 223, 41, 90, 125, 38, 1, 180, 136, 75, 248, 7, 148, 188 }, new byte[] { 75, 174, 189, 228, 43, 45, 46, 152, 236, 109, 10, 14, 166, 198, 191, 245, 106, 6, 59, 80, 179, 105, 165, 112, 49, 76, 201, 12, 13, 143, 0, 154, 29, 212, 85, 157, 185, 245, 134, 85, 189, 234, 185, 221, 60, 246, 175, 121, 214, 238, 71, 21, 174, 110, 200, 176, 206, 236, 27, 47, 42, 247, 48, 59, 44, 90, 174, 208, 178, 109, 102, 228, 141, 4, 76, 45, 41, 133, 139, 167, 101, 145, 143, 140, 211, 116, 148, 214, 186, 207, 26, 6, 74, 183, 215, 93, 143, 106, 14, 234, 198, 224, 249, 18, 128, 143, 49, 39, 32, 40, 117, 80, 9, 137, 4, 77, 213, 194, 222, 73, 213, 1, 83, 198, 253, 233, 145, 19 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("11e4a74b-ff5a-462b-97fe-f8a00f0363c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("125e3aac-cd74-468c-b6b7-cb4ffb86cc2b") });
        }
    }
}
