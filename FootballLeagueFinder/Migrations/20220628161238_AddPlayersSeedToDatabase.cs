using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeagueFinder.Migrations
{
    public partial class AddPlayersSeedToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "Photo", "Position", "ShirtNumber", "TeamId" },
                values: new object[,]
                {
                    { 1, "Jim", "Jones", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 0, "1", 1 },
                    { 2, "Dave", "Digby", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "2", 1 },
                    { 3, "Simon", "Jeffries", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "3", 1 },
                    { 4, "Les", "Formby", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "4", 1 },
                    { 5, "Jim", "Jones", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "5", 1 },
                    { 6, "Albert", "Albert", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "6", 1 },
                    { 7, "Mitch", "Walker", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "7", 1 },
                    { 8, "Dave", "Jones", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "8", 1 },
                    { 9, "Richard", "Smith", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "9", 1 },
                    { 10, "Fred", "Astaire", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "10", 1 },
                    { 11, "Jim", "Jones", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "11", 1 },
                    { 12, "Eric", "Erikson", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 0, "1", 3 },
                    { 13, "Claus", "Jensen", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "2", 3 },
                    { 14, "Steve", "Brown", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "3", 3 },
                    { 15, "Clive", "Fink", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "4", 3 },
                    { 16, "Ted", "Smith", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "5", 3 },
                    { 17, "Phil", "Smith", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "6", 3 },
                    { 18, "Jack", "Jones", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "7", 3 },
                    { 19, "Tony", "Toblerone", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "8", 3 },
                    { 20, "Sid", "Kitkat", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "9", 3 },
                    { 21, "Arnold", "Gates", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "10", 3 },
                    { 22, "Simon", "Finch", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "11", 3 },
                    { 31, "Cedric", "Pinkerton", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 0, "1", 2 },
                    { 32, "Rupert", "Bear", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "2", 2 },
                    { 33, "Calvin", "Blackberry", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "3", 2 },
                    { 34, "Dean", "Cheese", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "4", 2 },
                    { 35, "Peter", "Kadiri", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "5", 2 },
                    { 36, "Scott", "Dobson", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "6", 2 },
                    { 37, "Keith", "Fry", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "7", 2 },
                    { 38, "Paul", "Perry", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "8", 2 },
                    { 39, "Sal", "Silver", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "9", 2 },
                    { 40, "Del", "Gold", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "10", 2 },
                    { 41, "Paul", "Fry", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "11", 2 },
                    { 42, "Tony", "Montana", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 0, "1", 4 },
                    { 43, "Oz", "Floss", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "2", 4 },
                    { 44, "Si", "Brown", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "3", 4 },
                    { 45, "Keith", "Beef", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "4", 4 },
                    { 46, "Morgan", "Telford", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "5", 4 },
                    { 47, "Caz", "Log", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "6", 4 },
                    { 48, "Richard", "Richardson", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "7", 4 },
                    { 49, "Ken", "Bruce", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "8", 4 },
                    { 50, "Ray", "Light", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "9", 4 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "Photo", "Position", "ShirtNumber", "TeamId" },
                values: new object[,]
                {
                    { 51, "Jason", "Gates", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "10", 4 },
                    { 52, "Simon", "Finch", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "11", 4 },
                    { 53, "John", "Phillips", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "2", 5 },
                    { 54, "Barry", "Brown", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "3", 5 },
                    { 55, "Mason", "Fred", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "4", 5 },
                    { 56, "Eric", "Gonzo", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "5", 5 },
                    { 57, "Les", "Wood", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "6", 5 },
                    { 58, "Alfie", "Gooch", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "7", 5 },
                    { 59, "Ron", "Bonne", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "8", 5 },
                    { 60, "Malcolm", "Lightfoot", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "9", 5 },
                    { 61, "Terry", "Ronford", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "10", 5 },
                    { 62, "Tim", "Docherty", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "11", 5 },
                    { 63, "Alex", "Cod", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 0, "1", 5 },
                    { 64, "Barnie", "Rubble", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "3", 6 },
                    { 65, "Len", "Fredson", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "4", 6 },
                    { 66, "Igor", "Vasalivitch", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "5", 6 },
                    { 67, "Gordon", "Smith", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "6", 6 },
                    { 68, "Cuthbert", "Dibble", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "7", 6 },
                    { 69, "Eldridge", "Coolerson", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "8", 6 },
                    { 70, "Zack", "Pow", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 2, "9", 6 },
                    { 71, "Ben", "Boom", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "10", 6 },
                    { 72, "Sid", "Fortesque", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 3, "11", 6 },
                    { 73, "Colin", "Clarke", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 1, "2", 6 },
                    { 74, "Paul", "Derk", "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg", 0, "1", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
