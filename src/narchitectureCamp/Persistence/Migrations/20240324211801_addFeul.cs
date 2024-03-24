using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addFeul : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("19cae32d-4ffe-4aa9-b3d9-7f2244403a26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7de5958-ccf0-44f7-bfd9-155c2c58e68a"));

            migrationBuilder.DropColumn(
                name: "TransmissionId",
                table: "Models");

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Admin", null },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Read", null },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Write", null },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Create", null },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Update", null },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("901a1620-75b7-41c2-a5ab-4f319af52394"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 183, 97, 74, 0, 34, 60, 195, 185, 117, 105, 40, 226, 129, 196, 62, 194, 75, 173, 171, 117, 59, 29, 100, 98, 123, 55, 204, 40, 27, 150, 144, 167, 49, 225, 120, 141, 250, 183, 213, 25, 171, 201, 53, 81, 24, 193, 179, 6, 157, 142, 201, 68, 66, 111, 89, 116, 41, 212, 217, 98, 227, 193, 104, 45 }, new byte[] { 152, 146, 89, 35, 46, 163, 125, 55, 135, 53, 198, 3, 237, 60, 99, 129, 169, 207, 83, 64, 140, 170, 49, 74, 201, 170, 186, 129, 41, 239, 166, 171, 75, 247, 151, 52, 249, 4, 179, 233, 162, 243, 220, 159, 110, 77, 7, 130, 199, 34, 188, 100, 5, 151, 54, 147, 193, 26, 224, 46, 96, 159, 110, 137, 26, 3, 77, 108, 178, 63, 199, 220, 201, 193, 215, 124, 48, 170, 105, 177, 229, 175, 99, 112, 234, 106, 215, 235, 247, 99, 53, 71, 54, 56, 77, 192, 94, 133, 124, 15, 236, 209, 194, 118, 32, 42, 56, 145, 14, 41, 27, 9, 27, 239, 161, 98, 222, 48, 194, 85, 84, 136, 48, 144, 140, 190, 113, 35 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("a3139779-f474-4e78-ab2a-b6886d0b4961"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("901a1620-75b7-41c2-a5ab-4f319af52394") });

            migrationBuilder.CreateIndex(
                name: "IX_Models_FuelId",
                table: "Models",
                column: "FuelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropIndex(
                name: "IX_Models_FuelId",
                table: "Models");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a3139779-f474-4e78-ab2a-b6886d0b4961"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("901a1620-75b7-41c2-a5ab-4f319af52394"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransmissionId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d7de5958-ccf0-44f7-bfd9-155c2c58e68a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 87, 171, 0, 25, 123, 242, 164, 168, 228, 228, 130, 197, 207, 138, 173, 219, 194, 115, 108, 79, 213, 176, 226, 51, 106, 219, 44, 252, 238, 3, 135, 144, 41, 248, 173, 237, 116, 61, 162, 244, 243, 106, 222, 68, 75, 171, 133, 141, 16, 106, 208, 48, 212, 138, 122, 247, 78, 149, 253, 193, 189, 209, 18, 201 }, new byte[] { 111, 125, 182, 143, 114, 247, 79, 252, 72, 156, 186, 213, 172, 65, 212, 228, 17, 102, 87, 160, 2, 146, 96, 251, 116, 243, 92, 36, 153, 244, 1, 133, 113, 201, 132, 20, 222, 190, 196, 155, 248, 212, 226, 216, 217, 46, 126, 28, 255, 202, 119, 23, 114, 39, 44, 43, 45, 220, 127, 241, 71, 29, 211, 51, 10, 129, 199, 96, 181, 104, 117, 6, 27, 253, 239, 74, 32, 45, 234, 0, 254, 193, 187, 86, 252, 70, 173, 164, 52, 199, 71, 2, 120, 188, 194, 205, 75, 86, 13, 114, 140, 135, 113, 241, 119, 191, 84, 97, 240, 216, 198, 238, 33, 254, 25, 9, 254, 235, 42, 55, 209, 26, 47, 217, 153, 133, 150, 222 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("19cae32d-4ffe-4aa9-b3d9-7f2244403a26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d7de5958-ccf0-44f7-bfd9-155c2c58e68a") });
        }
    }
}
