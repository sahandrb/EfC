using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MelisaLeft : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MmModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MmModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MmModel",
                columns: new[] { "Id", "Age", "College", "Name" },
                values: new object[,]
                {
                    { 1, 33, "Completed", "Melisa" },
                    { 2, 34, "Compleft00ed", "Melisa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MmModel");
        }
    }
}
