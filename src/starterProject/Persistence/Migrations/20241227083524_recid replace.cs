using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class recidreplace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("737607ab-1a47-4a19-bcd4-45d9ab2717e7"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 212, 164, 178, 28, 205, 140, 38, 46, 60, 216, 113, 175, 143, 73, 203, 121, 22, 107, 215, 126, 248, 192, 215, 187, 192, 165, 84, 211, 112, 151, 49, 211, 79, 163, 152, 10, 119, 244, 45, 97, 112, 150, 123, 158, 114, 131, 149, 48, 226, 173, 40, 84, 38, 21, 142, 53, 88, 13, 55, 39, 244, 77, 96, 75 }, new byte[] { 30, 73, 70, 55, 126, 146, 199, 178, 94, 82, 43, 119, 163, 226, 184, 10, 149, 224, 59, 77, 193, 150, 104, 2, 203, 216, 51, 159, 13, 155, 76, 224, 10, 51, 54, 26, 248, 211, 219, 150, 195, 225, 242, 212, 225, 91, 104, 95, 202, 113, 107, 169, 69, 52, 89, 120, 192, 129, 108, 251, 73, 68, 163, 74, 137, 241, 143, 77, 137, 175, 54, 244, 51, 224, 62, 79, 124, 74, 113, 170, 90, 100, 40, 225, 40, 71, 60, 215, 108, 47, 247, 0, 201, 216, 63, 147, 163, 127, 254, 245, 250, 245, 248, 203, 23, 220, 26, 225, 186, 136, 20, 55, 181, 71, 54, 16, 253, 10, 42, 68, 166, 175, 197, 65, 56, 223, 195, 255 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("d1829b76-256e-443b-a4ac-06a8a65ff39c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("737607ab-1a47-4a19-bcd4-45d9ab2717e7") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d1829b76-256e-443b-a4ac-06a8a65ff39c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("737607ab-1a47-4a19-bcd4-45d9ab2717e7"));

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
    }
}
