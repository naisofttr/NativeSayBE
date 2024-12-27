using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class recidlastest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("73be2beb-dc87-4a58-ae23-327b69ee4d70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6b07d8d-515c-49e9-bcd9-a9400a1c47f4"));

            migrationBuilder.AddColumn<int>(
                name: "Recid",
                table: "customer",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3a72a1eb-f15a-437d-a98e-10895e2df1ce"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 238, 146, 134, 170, 248, 189, 192, 64, 172, 79, 255, 43, 18, 139, 236, 134, 66, 218, 71, 144, 113, 115, 185, 26, 100, 71, 165, 100, 84, 34, 189, 101, 11, 160, 240, 83, 27, 89, 190, 158, 35, 225, 93, 29, 19, 93, 189, 92, 204, 218, 89, 250, 164, 1, 46, 171, 142, 174, 202, 109, 62, 181, 16, 216 }, new byte[] { 79, 37, 240, 141, 238, 5, 64, 189, 235, 10, 203, 221, 7, 89, 167, 88, 169, 158, 186, 144, 165, 69, 56, 12, 181, 79, 50, 20, 158, 125, 29, 26, 49, 56, 21, 107, 79, 114, 235, 60, 3, 56, 159, 192, 201, 164, 157, 49, 114, 95, 45, 15, 145, 202, 97, 178, 126, 138, 99, 240, 168, 222, 178, 143, 100, 77, 207, 242, 95, 5, 12, 28, 198, 3, 188, 87, 193, 229, 163, 210, 14, 179, 240, 242, 99, 54, 156, 232, 124, 3, 244, 54, 101, 89, 165, 19, 142, 111, 211, 133, 31, 178, 181, 34, 90, 195, 131, 217, 248, 77, 215, 46, 218, 21, 64, 93, 141, 63, 246, 83, 213, 200, 253, 115, 220, 234, 194, 57 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("d2c77c02-5de5-49f6-95cb-25f73df68c82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3a72a1eb-f15a-437d-a98e-10895e2df1ce") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d2c77c02-5de5-49f6-95cb-25f73df68c82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a72a1eb-f15a-437d-a98e-10895e2df1ce"));

            migrationBuilder.DropColumn(
                name: "Recid",
                table: "customer");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d6b07d8d-515c-49e9-bcd9-a9400a1c47f4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 76, 221, 29, 175, 46, 139, 237, 41, 187, 166, 4, 228, 140, 15, 195, 194, 161, 185, 112, 90, 69, 41, 176, 132, 173, 245, 219, 104, 42, 45, 71, 26, 43, 172, 220, 40, 89, 149, 79, 199, 81, 109, 93, 179, 150, 109, 128, 6, 181, 189, 131, 224, 10, 168, 180, 129, 161, 152, 199, 214, 252, 74, 63, 229 }, new byte[] { 144, 214, 123, 52, 193, 220, 92, 112, 15, 18, 176, 91, 67, 22, 249, 146, 240, 234, 72, 223, 149, 229, 32, 155, 248, 61, 95, 121, 75, 232, 213, 231, 173, 140, 146, 35, 103, 63, 69, 54, 238, 70, 13, 10, 17, 8, 239, 113, 139, 29, 44, 162, 163, 206, 74, 120, 251, 228, 233, 48, 74, 2, 212, 103, 152, 112, 4, 13, 81, 69, 222, 178, 80, 54, 252, 45, 126, 65, 208, 137, 205, 102, 236, 137, 200, 9, 180, 62, 56, 42, 186, 233, 48, 103, 197, 70, 21, 17, 174, 235, 65, 161, 116, 204, 65, 214, 185, 66, 190, 235, 150, 179, 81, 94, 186, 231, 129, 178, 25, 32, 56, 110, 63, 168, 149, 97, 151, 188 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("73be2beb-dc87-4a58-ae23-327b69ee4d70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d6b07d8d-515c-49e9-bcd9-a9400a1c47f4") });
        }
    }
}
