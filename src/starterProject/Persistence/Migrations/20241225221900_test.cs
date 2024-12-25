using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8afcac04-2c7f-4295-8417-adb158e64539"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f43ce19d-4f27-4cdf-b00f-75e287b95157"));

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "customer",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "customer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("a7306764-9b68-4b79-b907-f25109f3b5ff"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 25, 80, 177, 63, 86, 201, 81, 193, 254, 52, 84, 222, 112, 75, 86, 148, 207, 181, 44, 102, 4, 0, 147, 38, 137, 58, 172, 192, 6, 128, 26, 145, 66, 102, 142, 71, 153, 22, 195, 249, 103, 192, 34, 96, 33, 118, 177, 162, 7, 200, 39, 220, 241, 19, 159, 211, 174, 72, 196, 171, 153, 193, 242, 7 }, new byte[] { 108, 203, 146, 132, 13, 172, 65, 140, 115, 41, 161, 37, 76, 196, 91, 234, 164, 212, 251, 86, 153, 187, 177, 35, 48, 98, 85, 104, 92, 193, 182, 108, 96, 32, 152, 211, 121, 221, 32, 187, 11, 69, 220, 178, 156, 82, 146, 76, 130, 225, 11, 240, 185, 182, 219, 190, 176, 137, 139, 67, 37, 112, 115, 123, 229, 245, 216, 199, 17, 41, 228, 128, 90, 174, 86, 125, 148, 235, 65, 128, 120, 108, 63, 210, 81, 214, 25, 30, 40, 47, 110, 23, 116, 78, 19, 203, 177, 101, 117, 25, 31, 16, 46, 150, 54, 102, 203, 215, 213, 112, 224, 241, 76, 93, 231, 51, 174, 115, 87, 249, 120, 84, 97, 87, 26, 205, 177, 228 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("173c50b2-f671-49e0-8a87-71b74522710f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("a7306764-9b68-4b79-b907-f25109f3b5ff") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("173c50b2-f671-49e0-8a87-71b74522710f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7306764-9b68-4b79-b907-f25109f3b5ff"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "IdToken",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "ProfilePhotoUrl",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "customer");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "customer",
                newName: "CreatedAt");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("f43ce19d-4f27-4cdf-b00f-75e287b95157"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 171, 108, 14, 202, 224, 23, 136, 123, 243, 68, 49, 5, 120, 57, 47, 244, 189, 139, 86, 61, 153, 165, 7, 245, 124, 74, 66, 62, 86, 136, 233, 10, 107, 209, 151, 108, 146, 68, 213, 103, 153, 151, 78, 88, 54, 103, 242, 92, 59, 19, 189, 96, 52, 237, 158, 82, 97, 29, 247, 9, 90, 94, 124, 100 }, new byte[] { 153, 32, 218, 55, 109, 140, 124, 66, 124, 249, 155, 216, 189, 31, 107, 208, 170, 39, 117, 68, 39, 88, 19, 136, 6, 105, 42, 28, 133, 1, 9, 99, 168, 247, 180, 230, 187, 219, 90, 172, 19, 60, 88, 178, 64, 167, 79, 46, 62, 185, 169, 29, 225, 27, 189, 185, 63, 42, 81, 106, 225, 250, 17, 222, 31, 220, 218, 155, 143, 188, 234, 162, 107, 167, 100, 62, 21, 68, 118, 149, 46, 205, 77, 140, 209, 104, 130, 234, 214, 26, 112, 27, 121, 236, 86, 1, 78, 131, 1, 236, 107, 146, 201, 193, 220, 63, 28, 190, 106, 26, 208, 4, 64, 13, 50, 172, 123, 227, 173, 214, 51, 64, 25, 145, 27, 51, 238, 67 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8afcac04-2c7f-4295-8417-adb158e64539"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("f43ce19d-4f27-4cdf-b00f-75e287b95157") });
        }
    }
}
