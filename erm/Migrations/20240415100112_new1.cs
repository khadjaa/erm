using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace erm.Migrations
{
    /// <inheritdoc />
    public partial class new1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("1ce50ad1-bb41-429e-a512-18ee759f87d1"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("62482143-fb8b-479f-8937-d3f035458447"));

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: new Guid("fb9ecdd1-9125-4427-9575-6248019d642a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Risk",
                columns: new[] { "Id", "Description", "Impact", "Name", "Probability" },
                values: new object[,]
                {
                    { new Guid("1ce50ad1-bb41-429e-a512-18ee759f87d1"), "Description of first risk", 0, "First Risk", 0 },
                    { new Guid("62482143-fb8b-479f-8937-d3f035458447"), "descriptionInContext", 0, "firstRiskInContext", 2 },
                    { new Guid("fb9ecdd1-9125-4427-9575-6248019d642a"), "Description of second risk", 1, "Second Risk", 1 }
                });
        }
    }
}
