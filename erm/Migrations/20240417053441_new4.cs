using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace erm.Migrations
{
    /// <inheritdoc />
    public partial class new4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "MyTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "first"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "Id", "AssignedTo", "EndDate", "Name", "StartDate" },
                values: new object[] { new Guid("f1147870-4945-4494-90d6-2e9d607884ec"), "John Doe", new DateTime(2015, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first task", new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3c255e8e-33a4-414a-9739-3e118b1c43c9"), null, "Worker", "second", "last1", "222", "refresh_token_value1", "some_responsibility1", "editor", "baha" },
                    { new Guid("e1034f1a-d25f-4049-bdc3-89eb05caeb60"), null, "Worker", "first", "last", "123", "refresh_token_value", "some_responsibility", "admin", "maga" }
                });

            migrationBuilder.InsertData(
                table: "Risk",
                columns: new[] { "Id", "Description", "Impact", "Name", "Probability" },
                values: new object[,]
                {
                    { new Guid("6b2561bc-4e15-40cf-9616-6eb74b72b921"), "Description of second risk", 2, "Second Risk", 1 },
                    { new Guid("7f30607d-9b24-4ca5-afe8-a9b06c920660"), "descriptionInContext", 1, "firstRiskInContext", 2 },
                    { new Guid("b5c90224-8d60-4245-b5a5-92c355fe1448"), "Description of first risk", 3, "First Risk", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyTasks");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3c255e8e-33a4-414a-9739-3e118b1c43c9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e1034f1a-d25f-4049-bdc3-89eb05caeb60"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("6b2561bc-4e15-40cf-9616-6eb74b72b921"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("7f30607d-9b24-4ca5-afe8-a9b06c920660"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("b5c90224-8d60-4245-b5a5-92c355fe1448"));

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
    }
}
