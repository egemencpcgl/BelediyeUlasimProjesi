using Microsoft.EntityFrameworkCore.Migrations;

namespace BelediyeUlasimProjesi.Migrations
{
    public partial class UpdateStops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Durak_1",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_10",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_11",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_12",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_13",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_14",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_15",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_2",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_3",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_4",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_5",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_6",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_7",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_8",
                table: "Stations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durak_9",
                table: "Stations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durak_1",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_10",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_11",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_12",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_13",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_14",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_15",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_2",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_3",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_4",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_5",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_6",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_7",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_8",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Durak_9",
                table: "Stations");
        }
    }
}
