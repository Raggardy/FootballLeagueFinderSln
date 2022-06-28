using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeagueFinder.Migrations
{
    public partial class SeededTeamsAndLeagues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Location", "Name", "Photo" },
                values: new object[] { 1, "Kent", "West Kent League", "https://www.pngkey.com/png/full/233-2332677_ega-png.png" });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Location", "Name", "Photo" },
                values: new object[] { 2, "Kent", "East Kent League", "https://www.pngkey.com/png/full/233-2332677_ega-png.png" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "Manager", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, 1, "Sid Bananas", "West Kent United", "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                    { 2, 1, "Dave Turnip", "Jongo Town", "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                    { 3, 1, "Jay Apple", "Dunkirk Athletic", "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                    { 4, 2, "Fred Grape", "Dels Dynamos", "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                    { 5, 2, "Chris Pommegranette", "Hammly Rangers", "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                    { 6, 2, "Tom Potato", "Keebo United", "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
