using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resorts",
                columns: table => new
                {
                    ResortId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerticalDrop = table.Column<int>(type: "int", nullable: false),
                    NumberOfRuns = table.Column<int>(type: "int", nullable: false),
                    AnnualSnowfall = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resorts", x => x.ResortId);
                });

            migrationBuilder.InsertData(
                table: "Resorts",
                columns: new[] { "ResortId", "AnnualSnowfall", "Difficulty", "Name", "NumberOfRuns", "State", "VerticalDrop" },
                values: new object[,]
                {
                    { 1, 354, "Advanced", "Vail", 195, "Colorado", 3450 },
                    { 2, 355, "Intermediate", "Park City Mountain", 341, "Utah", 3226 },
                    { 3, 300, "Intermediate", "Breckenridge", 187, "Colorado", 3398 },
                    { 4, 400, "Advanced", "Mammoth Mountain", 175, "California", 3100 },
                    { 5, 459, "Expert", "Jackson Hole", 131, "Wyoming", 4139 },
                    { 6, 349, "Intermediate", "Steamboat Springs", 169, "Colorado", 3668 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resorts");
        }
    }
}
