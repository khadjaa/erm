using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace erm.Migrations
{
    /// <inheritdoc />
    public partial class new3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8f58b886-dcef-46e6-b1e8-4e7d85b04d1a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("943c19a3-dbf5-4e2d-9738-29aabc7b79e7"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("5bafc0ed-6eaa-4ef5-a01a-ad94db4b6395"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("700a63b9-1c09-484f-877e-70d1d24b3c04"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("c720c286-a5f3-4779-8eaf-89dbd96f48f0"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("011bc8c2-bce6-4c81-96ec-8e101a52aada"), null, "Worker", "first", "last", "123", "refresh_token_value", "some_responsibility", "admin", "maga" },
                    { new Guid("b7cf44a7-12e6-4de6-beb7-83fd95a42211"), null, "Worker", "second", "last1", "222", "refresh_token_value1", "some_responsibility1", "editor", "baha" }
                });

            migrationBuilder.InsertData(
                table: "Risk",
                columns: new[] { "Id", "Description", "Impact", "Name", "Probability" },
                values: new object[,]
                {
                    { new Guid("07f00b46-d328-4ecc-bc36-97337c7ce87d"), "Description of first risk", 3, "First Risk", 2 },
                    { new Guid("6cab41f4-1833-4936-86ef-1da7a4f3af53"), "Description of second risk", 2, "Second Risk", 1 },
                    { new Guid("e26f2b0f-bfc7-4949-a397-9a7b370cbd75"), "descriptionInContext", 1, "firstRiskInContext", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("011bc8c2-bce6-4c81-96ec-8e101a52aada"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b7cf44a7-12e6-4de6-beb7-83fd95a42211"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("07f00b46-d328-4ecc-bc36-97337c7ce87d"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("6cab41f4-1833-4936-86ef-1da7a4f3af53"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("e26f2b0f-bfc7-4949-a397-9a7b370cbd75"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("8f58b886-dcef-46e6-b1e8-4e7d85b04d1a"), null, "Worker", "second", "last1", "222", "refresh_token_value1", "some_responsibility1", "editor", "baha" },
                    { new Guid("943c19a3-dbf5-4e2d-9738-29aabc7b79e7"), null, "Worker", "first", "last", "123", "refresh_token_value", "some_responsibility", "admin", "maga" }
                });

            migrationBuilder.InsertData(
                table: "Risk",
                columns: new[] { "Id", "Description", "Impact", "Name", "Probability" },
                values: new object[,]
                {
                    { new Guid("5bafc0ed-6eaa-4ef5-a01a-ad94db4b6395"), "Description of second risk", 2, "Second Risk", 1 },
                    { new Guid("700a63b9-1c09-484f-877e-70d1d24b3c04"), "descriptionInContext", 1, "firstRiskInContext", 2 },
                    { new Guid("c720c286-a5f3-4779-8eaf-89dbd96f48f0"), "Description of first risk", 3, "First Risk", 2 }
                });
        }
    }
}
