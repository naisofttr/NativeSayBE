using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class customerupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "customer_pkey",
                table: "customer");

            //migrationBuilder.DeleteData(
            //    table: "UserOperationClaims",
            //    keyColumn: "Id",
            //    keyValue: new Guid("d95d9cdc-1015-4c0e-81ad-8825742e1396"));

            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: new Guid("7ce291e0-e6e9-4815-976a-dea15eb1b775"));

            migrationBuilder.DropColumn(
                name: "recid",
                table: "customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer",
                table: "customer",
                column: "Id");

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
            //    values: new object[] { new Guid("48f03c0e-1f8e-4881-a809-c8710cf3fc15"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 170, 171, 101, 184, 173, 61, 145, 217, 146, 239, 15, 75, 13, 22, 122, 250, 112, 202, 123, 64, 248, 44, 25, 152, 254, 173, 244, 132, 148, 222, 51, 138, 145, 163, 109, 20, 133, 35, 254, 1, 162, 241, 24, 186, 57, 20, 148, 144, 102, 6, 114, 97, 225, 98, 95, 62, 153, 82, 89, 65, 228, 15, 75, 237 }, new byte[] { 185, 166, 26, 231, 48, 71, 199, 146, 166, 239, 229, 48, 138, 98, 46, 242, 142, 104, 119, 239, 208, 23, 137, 241, 33, 173, 5, 63, 179, 248, 245, 176, 129, 254, 208, 105, 164, 186, 195, 160, 105, 44, 94, 223, 93, 150, 239, 74, 175, 128, 154, 218, 106, 20, 216, 9, 49, 108, 58, 202, 235, 85, 39, 140, 29, 103, 82, 174, 58, 212, 37, 134, 214, 27, 156, 181, 31, 6, 215, 250, 37, 245, 255, 243, 11, 202, 195, 185, 138, 242, 172, 72, 182, 248, 89, 101, 5, 55, 147, 240, 117, 195, 231, 31, 220, 156, 45, 124, 159, 119, 140, 59, 236, 47, 17, 132, 116, 139, 123, 247, 45, 157, 167, 68, 248, 144, 131, 246 }, null });

            //migrationBuilder.InsertData(
            //    table: "UserOperationClaims",
            //    columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
            //    values: new object[] { new Guid("018be9c4-4110-4af4-be63-6447d3defb1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("48f03c0e-1f8e-4881-a809-c8710cf3fc15") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_customer",
                table: "customer");

            //migrationBuilder.DeleteData(
            //    table: "UserOperationClaims",
            //    keyColumn: "Id",
            //    keyValue: new Guid("018be9c4-4110-4af4-be63-6447d3defb1a"));

            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: new Guid("48f03c0e-1f8e-4881-a809-c8710cf3fc15"));

            migrationBuilder.AddColumn<Guid>(
                name: "recid",
                table: "customer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "uuid_generate_v1()");

            migrationBuilder.AddPrimaryKey(
                name: "customer_pkey",
                table: "customer",
                column: "recid");

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
            //    values: new object[] { new Guid("7ce291e0-e6e9-4815-976a-dea15eb1b775"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@tr", new byte[] { 39, 124, 3, 55, 170, 88, 147, 42, 135, 3, 196, 33, 209, 246, 214, 94, 119, 217, 179, 101, 141, 237, 99, 138, 63, 18, 84, 236, 92, 152, 254, 78, 117, 2, 169, 41, 27, 245, 65, 97, 131, 209, 160, 94, 213, 255, 235, 206, 151, 190, 48, 180, 155, 161, 10, 238, 131, 167, 192, 146, 58, 21, 253, 96 }, new byte[] { 113, 185, 217, 153, 124, 98, 188, 148, 255, 129, 35, 51, 124, 208, 219, 8, 122, 120, 41, 242, 246, 78, 205, 35, 211, 208, 41, 35, 13, 18, 82, 136, 112, 233, 250, 118, 199, 48, 136, 206, 175, 73, 158, 223, 173, 188, 182, 43, 196, 145, 74, 79, 174, 70, 10, 45, 221, 78, 133, 34, 73, 10, 63, 31, 93, 226, 152, 230, 0, 204, 38, 72, 85, 100, 220, 123, 103, 240, 201, 172, 192, 176, 190, 104, 205, 61, 117, 63, 230, 133, 212, 191, 6, 226, 127, 58, 208, 56, 152, 220, 229, 136, 73, 203, 41, 195, 13, 74, 53, 64, 73, 70, 199, 95, 229, 238, 231, 139, 233, 155, 67, 197, 55, 126, 166, 130, 200, 124 }, null });

            //migrationBuilder.InsertData(
            //    table: "UserOperationClaims",
            //    columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
            //    values: new object[] { new Guid("d95d9cdc-1015-4c0e-81ad-8825742e1396"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("7ce291e0-e6e9-4815-976a-dea15eb1b775") });
        }
    }
}
