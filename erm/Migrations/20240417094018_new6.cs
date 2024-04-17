using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace erm.Migrations
{
    /// <inheritdoc />
    public partial class new6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "Id",
                keyValue: new Guid("fcb5110c-529e-4aea-b893-96accfbd4a5c"));

            migrationBuilder.CreateTable(
                name: "Sprints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "first sprint"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tasks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "Id", "AssignedTo", "EndDate", "Name", "StartDate" },
                values: new object[] { new Guid("87e05d20-0717-4cd7-b471-6c69bbddf9d3"), "John Doe", new DateTime(2015, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first task", new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("5c00823a-b2b0-4b5c-a139-d7e8b6f81e38"), null, "Worker", "second", "last1", "222", "refresh_token_value1", "some_responsibility1", "editor", "baha" },
                    { new Guid("5e2ee89e-6e86-4c81-b80b-6daa449bd361"), null, "Worker", "first", "last", "123", "refresh_token_value", "some_responsibility", "admin", "maga" }
                });

            migrationBuilder.InsertData(
                table: "Risk",
                columns: new[] { "Id", "Description", "Impact", "Name", "Probability" },
                values: new object[,]
                {
                    { new Guid("2ceebe71-26b5-4a7a-8c85-dc0ee1431bd9"), "descriptionInContext", 1, "firstRiskInContext", 2 },
                    { new Guid("458d712c-7d4f-40b4-9526-b214589eefb1"), "Description of first risk", 3, "First Risk", 2 },
                    { new Guid("64c98460-5fe3-414f-9c89-ef94386abc69"), "Description of second risk", 2, "Second Risk", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "Id", "EndDate", "Name", "StartDate", "Tasks" },
                values: new object[] { new Guid("d47bc474-e10d-4250-ab0f-7d349953d4e9"), new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first Sprint", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "tasks for sprint" });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "Id", "AssignedTo", "EndDate", "Name", "Risks", "Sprints", "StartDate" },
                values: new object[] { new Guid("106aa3c7-e602-48c2-90d6-c57359aac7b8"), "Scrum", new DateTime(2016, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first Project", "risks", "3", new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sprints");

            migrationBuilder.DeleteData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: new Guid("87e05d20-0717-4cd7-b471-6c69bbddf9d3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5c00823a-b2b0-4b5c-a139-d7e8b6f81e38"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5e2ee89e-6e86-4c81-b80b-6daa449bd361"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("2ceebe71-26b5-4a7a-8c85-dc0ee1431bd9"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("458d712c-7d4f-40b4-9526-b214589eefb1"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("64c98460-5fe3-414f-9c89-ef94386abc69"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "Id",
                keyValue: new Guid("106aa3c7-e602-48c2-90d6-c57359aac7b8"));

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
    }
}
