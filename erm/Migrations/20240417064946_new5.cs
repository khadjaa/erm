using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace erm.Migrations
{
    /// <inheritdoc />
    public partial class new5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: new Guid("f1147870-4945-4494-90d6-2e9d607884ec"));

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

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "first"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sprints = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Risks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "Id", "AssignedTo", "EndDate", "Name", "StartDate" },
                values: new object[] { new Guid("dce2aa6e-4f6b-4c64-802a-45c1696381c1"), "John Doe", new DateTime(2015, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first task", new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("94fceb05-a128-4bca-bb84-89f3aabc4dac"), null, "Worker", "first", "last", "123", "refresh_token_value", "some_responsibility", "admin", "maga" },
                    { new Guid("ec0fe01c-64ab-455e-a3ed-d22ff3b20611"), null, "Worker", "second", "last1", "222", "refresh_token_value1", "some_responsibility1", "editor", "baha" }
                });

            migrationBuilder.InsertData(
                table: "Risk",
                columns: new[] { "Id", "Description", "Impact", "Name", "Probability" },
                values: new object[,]
                {
                    { new Guid("44df0571-52a6-4405-836c-b3bf81a73b68"), "Description of first risk", 3, "First Risk", 2 },
                    { new Guid("e557ff39-c4a6-41f6-9cf1-700d0d9fc202"), "Description of second risk", 2, "Second Risk", 1 },
                    { new Guid("e74bfb9c-7625-4224-80bf-7f58b2741637"), "descriptionInContext", 1, "firstRiskInContext", 2 }
                });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "Id", "AssignedTo", "EndDate", "Name", "Risks", "Sprints", "StartDate" },
                values: new object[] { new Guid("fcb5110c-529e-4aea-b893-96accfbd4a5c"), "Scrum", new DateTime(2016, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first Project", "risks", "3", new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DeleteData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: new Guid("dce2aa6e-4f6b-4c64-802a-45c1696381c1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("94fceb05-a128-4bca-bb84-89f3aabc4dac"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ec0fe01c-64ab-455e-a3ed-d22ff3b20611"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("44df0571-52a6-4405-836c-b3bf81a73b68"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("e557ff39-c4a6-41f6-9cf1-700d0d9fc202"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("e74bfb9c-7625-4224-80bf-7f58b2741637"));

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
    }
}
