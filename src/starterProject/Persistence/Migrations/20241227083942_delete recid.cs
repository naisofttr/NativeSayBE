using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deleterecid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("d6b07d8d-515c-49e9-bcd9-a9400a1c47f4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 76, 221, 29, 175, 46, 139, 237, 41, 187, 166, 4, 228, 140, 15, 195, 194, 161, 185, 112, 90, 69, 41, 176, 132, 173, 245, 219, 104, 42, 45, 71, 26, 43, 172, 220, 40, 89, 149, 79, 199, 81, 109, 93, 179, 150, 109, 128, 6, 181, 189, 131, 224, 10, 168, 180, 129, 161, 152, 199, 214, 252, 74, 63, 229 }, new byte[] { 144, 214, 123, 52, 193, 220, 92, 112, 15, 18, 176, 91, 67, 22, 249, 146, 240, 234, 72, 223, 149, 229, 32, 155, 248, 61, 95, 121, 75, 232, 213, 231, 173, 140, 146, 35, 103, 63, 69, 54, 238, 70, 13, 10, 17, 8, 239, 113, 139, 29, 44, 162, 163, 206, 74, 120, 251, 228, 233, 48, 74, 2, 212, 103, 152, 112, 4, 13, 81, 69, 222, 178, 80, 54, 252, 45, 126, 65, 208, 137, 205, 102, 236, 137, 200, 9, 180, 62, 56, 42, 186, 233, 48, 103, 197, 70, 21, 17, 174, 235, 65, 161, 116, 204, 65, 214, 185, 66, 190, 235, 150, 179, 81, 94, 186, 231, 129, 178, 25, 32, 56, 110, 63, 168, 149, 97, 151, 188 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("73be2beb-dc87-4a58-ae23-327b69ee4d70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d6b07d8d-515c-49e9-bcd9-a9400a1c47f4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
