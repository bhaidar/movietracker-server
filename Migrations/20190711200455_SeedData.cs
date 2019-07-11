using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieWatcher.Server.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "Rating", "Title" },
                values: new object[] { "Drama", 4, "The Shawshank Redemption" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { "Drama", 2, "The Godfather", new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "Rating", "Title" },
                values: new object[] { null, 0, "Sweet November" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { null, 0, "Sweet November", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
