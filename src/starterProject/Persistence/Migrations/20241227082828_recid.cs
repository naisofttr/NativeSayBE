using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class recid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("018be9c4-4110-4af4-be63-6447d3defb1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48f03c0e-1f8e-4881-a809-c8710cf3fc15"));

            migrationBuilder.AddColumn<int>(
                name: "RecId",
                table: "customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3526a16d-9134-4abd-8f70-657d0df9b703"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 221, 124, 151, 194, 167, 165, 188, 30, 84, 138, 207, 128, 3, 10, 242, 10, 203, 165, 219, 78, 37, 239, 55, 210, 129, 200, 53, 123, 114, 226, 226, 233, 197, 195, 82, 92, 186, 172, 242, 133, 20, 8, 167, 226, 1, 70, 172, 61, 255, 170, 151, 244, 187, 237, 119, 48, 152, 66, 164, 241, 144, 97, 219, 90 }, new byte[] { 63, 250, 91, 154, 127, 25, 141, 137, 39, 202, 45, 164, 91, 24, 190, 151, 4, 149, 179, 237, 42, 21, 63, 163, 174, 37, 194, 141, 34, 115, 134, 97, 23, 0, 176, 236, 213, 84, 120, 57, 67, 165, 52, 128, 229, 52, 58, 77, 129, 217, 88, 70, 178, 10, 118, 52, 202, 126, 32, 190, 215, 86, 192, 221, 108, 175, 87, 166, 93, 246, 137, 79, 12, 249, 32, 2, 171, 255, 53, 216, 169, 197, 61, 6, 0, 11, 146, 9, 7, 148, 49, 97, 148, 234, 61, 107, 137, 242, 142, 47, 128, 205, 192, 77, 135, 35, 79, 0, 157, 111, 175, 81, 251, 142, 43, 251, 60, 217, 188, 160, 248, 20, 134, 58, 80, 192, 159, 185 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("013772cc-355e-44fb-a0d9-1aa76787e26c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3526a16d-9134-4abd-8f70-657d0df9b703") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("013772cc-355e-44fb-a0d9-1aa76787e26c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3526a16d-9134-4abd-8f70-657d0df9b703"));

            migrationBuilder.DropColumn(
                name: "RecId",
                table: "customer");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("48f03c0e-1f8e-4881-a809-c8710cf3fc15"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 170, 171, 101, 184, 173, 61, 145, 217, 146, 239, 15, 75, 13, 22, 122, 250, 112, 202, 123, 64, 248, 44, 25, 152, 254, 173, 244, 132, 148, 222, 51, 138, 145, 163, 109, 20, 133, 35, 254, 1, 162, 241, 24, 186, 57, 20, 148, 144, 102, 6, 114, 97, 225, 98, 95, 62, 153, 82, 89, 65, 228, 15, 75, 237 }, new byte[] { 185, 166, 26, 231, 48, 71, 199, 146, 166, 239, 229, 48, 138, 98, 46, 242, 142, 104, 119, 239, 208, 23, 137, 241, 33, 173, 5, 63, 179, 248, 245, 176, 129, 254, 208, 105, 164, 186, 195, 160, 105, 44, 94, 223, 93, 150, 239, 74, 175, 128, 154, 218, 106, 20, 216, 9, 49, 108, 58, 202, 235, 85, 39, 140, 29, 103, 82, 174, 58, 212, 37, 134, 214, 27, 156, 181, 31, 6, 215, 250, 37, 245, 255, 243, 11, 202, 195, 185, 138, 242, 172, 72, 182, 248, 89, 101, 5, 55, 147, 240, 117, 195, 231, 31, 220, 156, 45, 124, 159, 119, 140, 59, 236, 47, 17, 132, 116, 139, 123, 247, 45, 157, 167, 68, 248, 144, 131, 246 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("018be9c4-4110-4af4-be63-6447d3defb1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("48f03c0e-1f8e-4881-a809-c8710cf3fc15") });
        }
    }
}
