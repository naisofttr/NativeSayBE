using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class createddat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d2c77c02-5de5-49f6-95cb-25f73df68c82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a72a1eb-f15a-437d-a98e-10895e2df1ce"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("10e4bfd4-410d-494c-96c3-989a2cf49d7f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 218, 242, 93, 42, 103, 201, 169, 224, 199, 94, 248, 67, 97, 227, 184, 82, 247, 107, 169, 217, 208, 87, 82, 181, 115, 83, 150, 188, 34, 99, 17, 222, 41, 10, 86, 207, 143, 207, 232, 156, 178, 188, 49, 189, 51, 163, 185, 238, 31, 216, 2, 90, 77, 118, 123, 137, 237, 152, 118, 59, 77, 189, 8, 119 }, new byte[] { 175, 255, 43, 143, 140, 184, 204, 202, 200, 243, 164, 245, 228, 109, 210, 148, 34, 245, 255, 29, 189, 50, 7, 79, 181, 118, 7, 252, 10, 69, 12, 105, 27, 60, 2, 183, 241, 215, 135, 127, 188, 2, 30, 1, 79, 170, 139, 1, 222, 194, 124, 101, 219, 1, 77, 170, 77, 131, 73, 137, 167, 248, 169, 94, 61, 123, 253, 196, 168, 82, 244, 227, 77, 30, 173, 176, 225, 63, 177, 106, 64, 36, 186, 206, 186, 198, 121, 94, 176, 14, 91, 150, 104, 168, 72, 243, 49, 11, 30, 236, 115, 80, 210, 42, 237, 67, 143, 20, 47, 135, 71, 43, 110, 3, 50, 94, 162, 240, 186, 177, 168, 55, 144, 202, 91, 205, 162, 247 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("931d3f77-4a6a-4c34-b079-f137c7b8a7be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("10e4bfd4-410d-494c-96c3-989a2cf49d7f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("931d3f77-4a6a-4c34-b079-f137c7b8a7be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10e4bfd4-410d-494c-96c3-989a2cf49d7f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3a72a1eb-f15a-437d-a98e-10895e2df1ce"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 238, 146, 134, 170, 248, 189, 192, 64, 172, 79, 255, 43, 18, 139, 236, 134, 66, 218, 71, 144, 113, 115, 185, 26, 100, 71, 165, 100, 84, 34, 189, 101, 11, 160, 240, 83, 27, 89, 190, 158, 35, 225, 93, 29, 19, 93, 189, 92, 204, 218, 89, 250, 164, 1, 46, 171, 142, 174, 202, 109, 62, 181, 16, 216 }, new byte[] { 79, 37, 240, 141, 238, 5, 64, 189, 235, 10, 203, 221, 7, 89, 167, 88, 169, 158, 186, 144, 165, 69, 56, 12, 181, 79, 50, 20, 158, 125, 29, 26, 49, 56, 21, 107, 79, 114, 235, 60, 3, 56, 159, 192, 201, 164, 157, 49, 114, 95, 45, 15, 145, 202, 97, 178, 126, 138, 99, 240, 168, 222, 178, 143, 100, 77, 207, 242, 95, 5, 12, 28, 198, 3, 188, 87, 193, 229, 163, 210, 14, 179, 240, 242, 99, 54, 156, 232, 124, 3, 244, 54, 101, 89, 165, 19, 142, 111, 211, 133, 31, 178, 181, 34, 90, 195, 131, 217, 248, 77, 215, 46, 218, 21, 64, 93, 141, 63, 246, 83, 213, 200, 253, 115, 220, 234, 194, 57 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("d2c77c02-5de5-49f6-95cb-25f73df68c82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3a72a1eb-f15a-437d-a98e-10895e2df1ce") });
        }
    }
}
