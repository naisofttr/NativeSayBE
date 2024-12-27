using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _1000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("931d3f77-4a6a-4c34-b079-f137c7b8a7be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10e4bfd4-410d-494c-96c3-989a2cf49d7f"));

            migrationBuilder.AlterColumn<int>(
                name: "Recid",
                table: "customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1000, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "customer",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("857569e7-93d2-493e-8eb5-ca1718999ffe"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 51, 57, 244, 134, 202, 88, 212, 103, 31, 59, 229, 150, 224, 186, 50, 248, 7, 89, 29, 209, 196, 76, 164, 105, 29, 54, 223, 53, 218, 207, 205, 190, 40, 139, 229, 133, 136, 238, 58, 113, 22, 197, 135, 181, 57, 189, 168, 27, 95, 37, 238, 108, 82, 17, 234, 0, 252, 48, 196, 133, 177, 124, 53, 60 }, new byte[] { 170, 116, 232, 124, 5, 126, 127, 179, 121, 89, 139, 195, 2, 193, 98, 208, 86, 62, 156, 131, 173, 216, 1, 69, 52, 172, 102, 22, 146, 91, 13, 190, 137, 115, 238, 242, 127, 133, 48, 229, 5, 119, 169, 232, 54, 201, 84, 221, 132, 241, 199, 238, 207, 95, 36, 250, 116, 253, 189, 232, 42, 119, 137, 111, 49, 193, 89, 81, 245, 239, 28, 177, 39, 17, 235, 134, 246, 224, 194, 131, 84, 255, 114, 72, 151, 61, 185, 89, 32, 196, 249, 97, 222, 65, 5, 40, 164, 100, 61, 47, 59, 27, 78, 36, 3, 174, 235, 99, 208, 111, 201, 18, 39, 62, 123, 107, 212, 180, 123, 132, 68, 149, 241, 248, 252, 185, 134, 45 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("355cdeb0-319d-4275-8b90-22575de2a024"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("857569e7-93d2-493e-8eb5-ca1718999ffe") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("355cdeb0-319d-4275-8b90-22575de2a024"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("857569e7-93d2-493e-8eb5-ca1718999ffe"));

            migrationBuilder.AlterColumn<int>(
                name: "Recid",
                table: "customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1000, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("10e4bfd4-410d-494c-96c3-989a2cf49d7f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 218, 242, 93, 42, 103, 201, 169, 224, 199, 94, 248, 67, 97, 227, 184, 82, 247, 107, 169, 217, 208, 87, 82, 181, 115, 83, 150, 188, 34, 99, 17, 222, 41, 10, 86, 207, 143, 207, 232, 156, 178, 188, 49, 189, 51, 163, 185, 238, 31, 216, 2, 90, 77, 118, 123, 137, 237, 152, 118, 59, 77, 189, 8, 119 }, new byte[] { 175, 255, 43, 143, 140, 184, 204, 202, 200, 243, 164, 245, 228, 109, 210, 148, 34, 245, 255, 29, 189, 50, 7, 79, 181, 118, 7, 252, 10, 69, 12, 105, 27, 60, 2, 183, 241, 215, 135, 127, 188, 2, 30, 1, 79, 170, 139, 1, 222, 194, 124, 101, 219, 1, 77, 170, 77, 131, 73, 137, 167, 248, 169, 94, 61, 123, 253, 196, 168, 82, 244, 227, 77, 30, 173, 176, 225, 63, 177, 106, 64, 36, 186, 206, 186, 198, 121, 94, 176, 14, 91, 150, 104, 168, 72, 243, 49, 11, 30, 236, 115, 80, 210, 42, 237, 67, 143, 20, 47, 135, 71, 43, 110, 3, 50, 94, 162, 240, 186, 177, 168, 55, 144, 202, 91, 205, 162, 247 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("931d3f77-4a6a-4c34-b079-f137c7b8a7be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("10e4bfd4-410d-494c-96c3-989a2cf49d7f") });
        }
    }
}
