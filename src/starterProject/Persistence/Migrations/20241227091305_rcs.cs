using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class rcs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("355cdeb0-319d-4275-8b90-22575de2a024"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("857569e7-93d2-493e-8eb5-ca1718999ffe"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("857569e7-93d2-493e-8eb5-ca1718999ffe"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 51, 57, 244, 134, 202, 88, 212, 103, 31, 59, 229, 150, 224, 186, 50, 248, 7, 89, 29, 209, 196, 76, 164, 105, 29, 54, 223, 53, 218, 207, 205, 190, 40, 139, 229, 133, 136, 238, 58, 113, 22, 197, 135, 181, 57, 189, 168, 27, 95, 37, 238, 108, 82, 17, 234, 0, 252, 48, 196, 133, 177, 124, 53, 60 }, new byte[] { 170, 116, 232, 124, 5, 126, 127, 179, 121, 89, 139, 195, 2, 193, 98, 208, 86, 62, 156, 131, 173, 216, 1, 69, 52, 172, 102, 22, 146, 91, 13, 190, 137, 115, 238, 242, 127, 133, 48, 229, 5, 119, 169, 232, 54, 201, 84, 221, 132, 241, 199, 238, 207, 95, 36, 250, 116, 253, 189, 232, 42, 119, 137, 111, 49, 193, 89, 81, 245, 239, 28, 177, 39, 17, 235, 134, 246, 224, 194, 131, 84, 255, 114, 72, 151, 61, 185, 89, 32, 196, 249, 97, 222, 65, 5, 40, 164, 100, 61, 47, 59, 27, 78, 36, 3, 174, 235, 99, 208, 111, 201, 18, 39, 62, 123, 107, 212, 180, 123, 132, 68, 149, 241, 248, 252, 185, 134, 45 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("355cdeb0-319d-4275-8b90-22575de2a024"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("857569e7-93d2-493e-8eb5-ca1718999ffe") });
        }
    }
}
