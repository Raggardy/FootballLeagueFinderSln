using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeagueFinder.Migrations
{
    public partial class AddedDescriptionFieldsForLeaguesAndTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The West Kent League, is a football competition based in Kent, England. The league has seven senior divisions – a Premier Division, Division One East and West, Division Two East and West and Division Three East and West. It sits below the Southern Counties East League Division One (step 6 of the National League System)  ");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The East Kent League, is a football competition based in Kent, England. The league has seven senior divisions – a Premier Division, Division One East and West, Division Two East and West and Division Three East and West. It sits below the Southern Counties East League Division One (step 6 of the National League System)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Leagues");
        }
    }
}
