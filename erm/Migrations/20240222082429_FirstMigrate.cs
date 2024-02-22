using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace erm.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Risk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Probability = table.Column<int>(type: "int", nullable: false),
                    Impact = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risk", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Risk");
        }
    }
}
