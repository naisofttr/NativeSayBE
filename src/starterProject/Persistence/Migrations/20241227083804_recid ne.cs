using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class recidne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "recid",
                table: "customer",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("5e95ffa5-68d3-4b0b-9dbc-7794fa0c0117"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 201, 32, 2, 33, 1, 161, 28, 208, 236, 233, 153, 33, 104, 99, 104, 207, 184, 97, 165, 217, 146, 145, 118, 48, 181, 47, 93, 71, 200, 39, 71, 27, 1, 20, 107, 173, 165, 0, 218, 59, 218, 124, 173, 90, 193, 40, 95, 138, 183, 35, 116, 113, 105, 222, 47, 127, 121, 187, 228, 202, 135, 52, 63, 4 }, new byte[] { 226, 219, 76, 43, 131, 20, 208, 179, 217, 157, 37, 159, 25, 113, 106, 62, 11, 175, 138, 170, 85, 164, 117, 56, 96, 47, 116, 164, 34, 219, 179, 135, 12, 84, 51, 133, 73, 246, 134, 90, 108, 50, 184, 217, 212, 111, 81, 201, 5, 250, 185, 206, 3, 130, 166, 55, 204, 117, 127, 77, 152, 184, 200, 161, 97, 6, 214, 3, 12, 182, 244, 237, 98, 93, 72, 90, 209, 79, 15, 213, 96, 94, 216, 177, 101, 178, 125, 81, 146, 236, 21, 156, 45, 200, 126, 42, 177, 243, 33, 158, 225, 228, 152, 181, 185, 159, 73, 176, 251, 61, 227, 70, 188, 113, 140, 138, 118, 96, 255, 192, 67, 146, 34, 112, 147, 6, 146, 35 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c07b2a16-3954-4fbe-8dfa-b57906386b15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("5e95ffa5-68d3-4b0b-9dbc-7794fa0c0117") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c07b2a16-3954-4fbe-8dfa-b57906386b15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e95ffa5-68d3-4b0b-9dbc-7794fa0c0117"));

            migrationBuilder.DropColumn(
                name: "recid",
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
    }
}
