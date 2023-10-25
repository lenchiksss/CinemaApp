using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Showtime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Genre", "Showtime", "Title" },
                values: new object[,]
                {
                    { 1, "\"Blade Runner 2049\" is a sci-fi sequel directed by Denis Villeneuve, exploring a dystopian future where a police officer uncovers a long-buried secret that could change society. It delves into themes of identity and the blurred line between human and artificial.", "Denis Villeneuve", "SciFi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blade Runner 2049" },
                    { 2, "The movie features Dwayne Johnson as a former FBI hostage rescue team leader, who now assesses security for skyscrapers. When the tallest and safest building in the world suddenly catches fire, he finds himself framed for the catastrophe and must clear his name, rescue his family from the building's top floor, and take down the criminals responsible.", "Rawson Marshall Thurber", "Action", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skyscraper" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
