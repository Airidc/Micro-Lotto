using Microsoft.EntityFrameworkCore.Migrations;

namespace micro_lotto.Migrations
{
    public partial class SnakeCaseNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Draw");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "User",
                newName: "balance");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Draw",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ThirdNumber",
                table: "Draw",
                newName: "third_number");

            migrationBuilder.RenameColumn(
                name: "SecondNumber",
                table: "Draw",
                newName: "second_number");

            migrationBuilder.RenameColumn(
                name: "FourthNumber",
                table: "Draw",
                newName: "fourth_number");

            migrationBuilder.RenameColumn(
                name: "FirstNumber",
                table: "Draw",
                newName: "first_number");

            migrationBuilder.RenameColumn(
                name: "FifthNumber",
                table: "Draw",
                newName: "fifth_number");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bet",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ThirdNumber",
                table: "Bet",
                newName: "third_number");

            migrationBuilder.RenameColumn(
                name: "SecondNumber",
                table: "Bet",
                newName: "second_number");

            migrationBuilder.RenameColumn(
                name: "ISOTime",
                table: "Bet",
                newName: "iso_time");

            migrationBuilder.RenameColumn(
                name: "FourthNumber",
                table: "Bet",
                newName: "fourth_number");

            migrationBuilder.RenameColumn(
                name: "FirstNumber",
                table: "Bet",
                newName: "first_number");

            migrationBuilder.RenameColumn(
                name: "FifthNumber",
                table: "Bet",
                newName: "fifth_number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "User",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "balance",
                table: "User",
                newName: "Balance");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "User",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Draw",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "third_number",
                table: "Draw",
                newName: "ThirdNumber");

            migrationBuilder.RenameColumn(
                name: "second_number",
                table: "Draw",
                newName: "SecondNumber");

            migrationBuilder.RenameColumn(
                name: "fourth_number",
                table: "Draw",
                newName: "FourthNumber");

            migrationBuilder.RenameColumn(
                name: "first_number",
                table: "Draw",
                newName: "FirstNumber");

            migrationBuilder.RenameColumn(
                name: "fifth_number",
                table: "Draw",
                newName: "FifthNumber");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Bet",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "third_number",
                table: "Bet",
                newName: "ThirdNumber");

            migrationBuilder.RenameColumn(
                name: "second_number",
                table: "Bet",
                newName: "SecondNumber");

            migrationBuilder.RenameColumn(
                name: "iso_time",
                table: "Bet",
                newName: "ISOTime");

            migrationBuilder.RenameColumn(
                name: "fourth_number",
                table: "Bet",
                newName: "FourthNumber");

            migrationBuilder.RenameColumn(
                name: "first_number",
                table: "Bet",
                newName: "FirstNumber");

            migrationBuilder.RenameColumn(
                name: "fifth_number",
                table: "Bet",
                newName: "FifthNumber");

            migrationBuilder.AddColumn<string>(
                name: "Timestamp",
                table: "Draw",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
