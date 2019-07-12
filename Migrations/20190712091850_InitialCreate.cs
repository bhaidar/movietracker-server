using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieWatcher.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    WatchedOn = table.Column<DateTime>(type: "date", nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { 1, "Drama", 4, "The Shawshank Redemption", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { 2, "Drama", 2, "The Godfather", new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { 3, "Drama, Action", 3, "The Dark Knight", new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { 4, "Drama", 1, "The Godfather: Part II ", new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { 5, "Adventure, Drama, Fantasy", 5, "The Lord of the Rings: The Return of the King", new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { 6, "Crime, Drama", 3, "Pulp Fiction", new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
