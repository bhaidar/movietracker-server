using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieWatcher.Server.Migrations
{
    public partial class FixMovieIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { 1, null, 0, "Sweet November", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { 2, null, 0, "Sweet November", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { -1, null, 0, "Sweet November", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Rating", "Title", "WatchedOn" },
                values: new object[] { -2, null, 0, "Sweet November", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
