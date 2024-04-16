using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace erm.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("551df029-5aef-4426-a618-11e1e421e010"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("6a4db473-f697-4dd7-98ce-d99f7079d360"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("93acb856-5b8b-4931-b258-c1b008ee3927"));

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "first"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Responsibility = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Username",
                table: "Persons",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

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
                table: "Risk",
                columns: new[] { "Id", "Description", "Impact", "Name", "Probability" },
                values: new object[,]
                {
                    { new Guid("551df029-5aef-4426-a618-11e1e421e010"), "Description of first risk", 3, "First Risk", 2 },
                    { new Guid("6a4db473-f697-4dd7-98ce-d99f7079d360"), "descriptionInContext", 1, "firstRiskInContext", 2 },
                    { new Guid("93acb856-5b8b-4931-b258-c1b008ee3927"), "Description of second risk", 2, "Second Risk", 1 }
                });
        }
    }
}
