using Microsoft.EntityFrameworkCore.Migrations;

namespace BelediyeUlasimProjesi.Migrations
{
    public partial class UpdateStops3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Durak_9",
                table: "Stations",
                newName: "Durak9");

            migrationBuilder.RenameColumn(
                name: "Durak_8",
                table: "Stations",
                newName: "Durak8");

            migrationBuilder.RenameColumn(
                name: "Durak_7",
                table: "Stations",
                newName: "Durak7");

            migrationBuilder.RenameColumn(
                name: "Durak_6",
                table: "Stations",
                newName: "Durak6");

            migrationBuilder.RenameColumn(
                name: "Durak_5",
                table: "Stations",
                newName: "Durak5");

            migrationBuilder.RenameColumn(
                name: "Durak_4",
                table: "Stations",
                newName: "Durak4");

            migrationBuilder.RenameColumn(
                name: "Durak_3",
                table: "Stations",
                newName: "Durak3");

            migrationBuilder.RenameColumn(
                name: "Durak_2",
                table: "Stations",
                newName: "Durak2");

            migrationBuilder.RenameColumn(
                name: "Durak_15",
                table: "Stations",
                newName: "Durak15");

            migrationBuilder.RenameColumn(
                name: "Durak_14",
                table: "Stations",
                newName: "Durak14");

            migrationBuilder.RenameColumn(
                name: "Durak_13",
                table: "Stations",
                newName: "Durak13");

            migrationBuilder.RenameColumn(
                name: "Durak_12",
                table: "Stations",
                newName: "Durak12");

            migrationBuilder.RenameColumn(
                name: "Durak_11",
                table: "Stations",
                newName: "Durak11");

            migrationBuilder.RenameColumn(
                name: "Durak_10",
                table: "Stations",
                newName: "Durak10");

            migrationBuilder.RenameColumn(
                name: "Durak_1",
                table: "Stations",
                newName: "Durak1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Durak9",
                table: "Stations",
                newName: "Durak_9");

            migrationBuilder.RenameColumn(
                name: "Durak8",
                table: "Stations",
                newName: "Durak_8");

            migrationBuilder.RenameColumn(
                name: "Durak7",
                table: "Stations",
                newName: "Durak_7");

            migrationBuilder.RenameColumn(
                name: "Durak6",
                table: "Stations",
                newName: "Durak_6");

            migrationBuilder.RenameColumn(
                name: "Durak5",
                table: "Stations",
                newName: "Durak_5");

            migrationBuilder.RenameColumn(
                name: "Durak4",
                table: "Stations",
                newName: "Durak_4");

            migrationBuilder.RenameColumn(
                name: "Durak3",
                table: "Stations",
                newName: "Durak_3");

            migrationBuilder.RenameColumn(
                name: "Durak2",
                table: "Stations",
                newName: "Durak_2");

            migrationBuilder.RenameColumn(
                name: "Durak15",
                table: "Stations",
                newName: "Durak_15");

            migrationBuilder.RenameColumn(
                name: "Durak14",
                table: "Stations",
                newName: "Durak_14");

            migrationBuilder.RenameColumn(
                name: "Durak13",
                table: "Stations",
                newName: "Durak_13");

            migrationBuilder.RenameColumn(
                name: "Durak12",
                table: "Stations",
                newName: "Durak_12");

            migrationBuilder.RenameColumn(
                name: "Durak11",
                table: "Stations",
                newName: "Durak_11");

            migrationBuilder.RenameColumn(
                name: "Durak10",
                table: "Stations",
                newName: "Durak_10");

            migrationBuilder.RenameColumn(
                name: "Durak1",
                table: "Stations",
                newName: "Durak_1");
        }
    }
}
