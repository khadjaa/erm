using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace erm.Migrations
{
    /// <inheritdoc />
    public partial class new7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Sprints",
                keyColumn: "Id",
                keyValue: new Guid("d47bc474-e10d-4250-ab0f-7d349953d4e9"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "Id",
                keyValue: new Guid("106aa3c7-e602-48c2-90d6-c57359aac7b8"));

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "first Issue"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FindByWorker = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "EndDate", "FindByWorker", "Name", "StartDate" },
                values: new object[] { new Guid("a2811b09-b8b3-4b7f-b530-ef8e4351a5cc"), new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Find By Worker", "first Issue", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "Id", "AssignedTo", "EndDate", "Name", "StartDate" },
                values: new object[] { new Guid("2d6cf9ad-f054-46d5-bc45-74dcfd8fda2a"), "John Doe", new DateTime(2015, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first task", new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Discriminator", "FirstName", "LastName", "Password", "RefreshToken", "Responsibility", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("83bab1c0-06a8-4a2d-a0f2-18d98f4306ed"), null, "Worker", "second", "last1", "222", "refresh_token_value1", "some_responsibility1", "editor", "baha" },
                    { new Guid("a514b60b-4b69-4621-9cf0-f1089dbdb8ba"), null, "Worker", "first", "last", "123", "refresh_token_value", "some_responsibility", "admin", "maga" }
                });

            migrationBuilder.InsertData(
                table: "Risk",
                columns: new[] { "Id", "Description", "Impact", "Name", "Probability" },
                values: new object[,]
                {
                    { new Guid("53c15d26-72fa-4225-8c91-403680d846c6"), "Description of second risk", 2, "Second Risk", 1 },
                    { new Guid("56e68e85-bdf7-4ede-b753-60a42a97521c"), "Description of first risk", 3, "First Risk", 2 },
                    { new Guid("e29d18e8-7ee1-4db9-9e6a-92a96f460878"), "descriptionInContext", 1, "firstRiskInContext", 2 }
                });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "Id", "EndDate", "Name", "StartDate", "Tasks" },
                values: new object[] { new Guid("dfaa20ac-6403-4b9c-ab1f-d81788088000"), new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first Sprint", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "tasks for sprint" });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "Id", "AssignedTo", "EndDate", "Name", "Risks", "Sprints", "StartDate" },
                values: new object[] { new Guid("bce8056e-ab00-4c47-82ed-431a60769a31"), "Scrum", new DateTime(2016, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "first Project", "risks", "3", new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DeleteData(
                table: "MyTasks",
                keyColumn: "Id",
                keyValue: new Guid("2d6cf9ad-f054-46d5-bc45-74dcfd8fda2a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("83bab1c0-06a8-4a2d-a0f2-18d98f4306ed"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a514b60b-4b69-4621-9cf0-f1089dbdb8ba"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("53c15d26-72fa-4225-8c91-403680d846c6"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("56e68e85-bdf7-4ede-b753-60a42a97521c"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("e29d18e8-7ee1-4db9-9e6a-92a96f460878"));

            migrationBuilder.DeleteData(
                table: "Sprints",
                keyColumn: "Id",
                keyValue: new Guid("dfaa20ac-6403-4b9c-ab1f-d81788088000"));

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "Id",
                keyValue: new Guid("bce8056e-ab00-4c47-82ed-431a60769a31"));

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
    }
}
