using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "UserOperationClaims",
            //    keyColumn: "Id",
            //    keyValue: new Guid("173c50b2-f671-49e0-8a87-71b74522710f"));

            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: new Guid("a7306764-9b68-4b79-b907-f25109f3b5ff"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
            //    values: new object[] { new Guid("a7306764-9b68-4b79-b907-f25109f3b5ff"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 25, 80, 177, 63, 86, 201, 81, 193, 254, 52, 84, 222, 112, 75, 86, 148, 207, 181, 44, 102, 4, 0, 147, 38, 137, 58, 172, 192, 6, 128, 26, 145, 66, 102, 142, 71, 153, 22, 195, 249, 103, 192, 34, 96, 33, 118, 177, 162, 7, 200, 39, 220, 241, 19, 159, 211, 174, 72, 196, 171, 153, 193, 242, 7 }, new byte[] { 108, 203, 146, 132, 13, 172, 65, 140, 115, 41, 161, 37, 76, 196, 91, 234, 164, 212, 251, 86, 153, 187, 177, 35, 48, 98, 85, 104, 92, 193, 182, 108, 96, 32, 152, 211, 121, 221, 32, 187, 11, 69, 220, 178, 156, 82, 146, 76, 130, 225, 11, 240, 185, 182, 219, 190, 176, 137, 139, 67, 37, 112, 115, 123, 229, 245, 216, 199, 17, 41, 228, 128, 90, 174, 86, 125, 148, 235, 65, 128, 120, 108, 63, 210, 81, 214, 25, 30, 40, 47, 110, 23, 116, 78, 19, 203, 177, 101, 117, 25, 31, 16, 46, 150, 54, 102, 203, 215, 213, 112, 224, 241, 76, 93, 231, 51, 174, 115, 87, 249, 120, 84, 97, 87, 26, 205, 177, 228 }, null });

            //migrationBuilder.InsertData(
            //    table: "UserOperationClaims",
            //    columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
            //    values: new object[] { new Guid("173c50b2-f671-49e0-8a87-71b74522710f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("a7306764-9b68-4b79-b907-f25109f3b5ff") });
        }
    }
}
