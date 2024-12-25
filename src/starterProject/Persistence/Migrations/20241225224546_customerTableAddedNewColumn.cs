using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class customerTableAddedNewColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "UserOperationClaims",
            //    keyColumn: "Id",
            //    keyValue: new Guid("a43f5b97-5b92-43dd-b608-137678cf32c1"));

            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: new Guid("537b7976-f016-446d-b7c4-2737f601f54f"));

            migrationBuilder.AddColumn<string>(
                name: "IdToken",
                table: "customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhotoUrl",
                table: "customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
            //    values: new object[] { new Guid("7ce291e0-e6e9-4815-976a-dea15eb1b775"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 39, 124, 3, 55, 170, 88, 147, 42, 135, 3, 196, 33, 209, 246, 214, 94, 119, 217, 179, 101, 141, 237, 99, 138, 63, 18, 84, 236, 92, 152, 254, 78, 117, 2, 169, 41, 27, 245, 65, 97, 131, 209, 160, 94, 213, 255, 235, 206, 151, 190, 48, 180, 155, 161, 10, 238, 131, 167, 192, 146, 58, 21, 253, 96 }, new byte[] { 113, 185, 217, 153, 124, 98, 188, 148, 255, 129, 35, 51, 124, 208, 219, 8, 122, 120, 41, 242, 246, 78, 205, 35, 211, 208, 41, 35, 13, 18, 82, 136, 112, 233, 250, 118, 199, 48, 136, 206, 175, 73, 158, 223, 173, 188, 182, 43, 196, 145, 74, 79, 174, 70, 10, 45, 221, 78, 133, 34, 73, 10, 63, 31, 93, 226, 152, 230, 0, 204, 38, 72, 85, 100, 220, 123, 103, 240, 201, 172, 192, 176, 190, 104, 205, 61, 117, 63, 230, 133, 212, 191, 6, 226, 127, 58, 208, 56, 152, 220, 229, 136, 73, 203, 41, 195, 13, 74, 53, 64, 73, 70, 199, 95, 229, 238, 231, 139, 233, 155, 67, 197, 55, 126, 166, 130, 200, 124 }, null });

            //migrationBuilder.InsertData(
            //    table: "UserOperationClaims",
            //    columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
            //    values: new object[] { new Guid("d95d9cdc-1015-4c0e-81ad-8825742e1396"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("7ce291e0-e6e9-4815-976a-dea15eb1b775") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "UserOperationClaims",
            //    keyColumn: "Id",
            //    keyValue: new Guid("d95d9cdc-1015-4c0e-81ad-8825742e1396"));

            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: new Guid("7ce291e0-e6e9-4815-976a-dea15eb1b775"));

            migrationBuilder.DropColumn(
                name: "IdToken",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "ProfilePhotoUrl",
                table: "customer");

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
            //    values: new object[] { new Guid("537b7976-f016-446d-b7c4-2737f601f54f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 151, 44, 50, 51, 4, 185, 238, 157, 211, 213, 189, 33, 59, 117, 209, 103, 195, 156, 11, 120, 106, 3, 135, 160, 9, 229, 166, 223, 11, 56, 139, 43, 85, 152, 104, 102, 54, 91, 85, 123, 209, 152, 180, 245, 218, 118, 9, 79, 200, 157, 18, 53, 130, 17, 139, 165, 42, 144, 128, 225, 91, 238, 73, 36 }, new byte[] { 251, 188, 132, 103, 224, 68, 210, 12, 49, 238, 159, 198, 177, 246, 159, 204, 9, 222, 89, 37, 146, 110, 174, 178, 4, 138, 106, 15, 194, 124, 31, 128, 200, 238, 245, 246, 181, 252, 116, 171, 251, 190, 21, 14, 113, 149, 134, 67, 101, 36, 70, 191, 35, 203, 73, 183, 174, 119, 23, 116, 91, 7, 192, 238, 251, 60, 48, 45, 26, 58, 81, 48, 255, 175, 234, 198, 90, 90, 87, 85, 245, 17, 183, 217, 193, 29, 255, 203, 198, 237, 30, 97, 132, 251, 214, 17, 11, 92, 72, 85, 223, 254, 103, 219, 225, 30, 76, 167, 253, 247, 49, 8, 68, 148, 38, 110, 250, 32, 63, 9, 130, 63, 73, 53, 120, 142, 55, 188 }, null });

            //migrationBuilder.InsertData(
            //    table: "UserOperationClaims",
            //    columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
            //    values: new object[] { new Guid("a43f5b97-5b92-43dd-b608-137678cf32c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("537b7976-f016-446d-b7c4-2737f601f54f") });
        }
    }
}
