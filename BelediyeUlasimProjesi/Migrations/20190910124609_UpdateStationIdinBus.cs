using Microsoft.EntityFrameworkCore.Migrations;

namespace BelediyeUlasimProjesi.Migrations
{
    public partial class UpdateStationIdinBus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buses_Stations_StationId",
                table: "Buses");

            migrationBuilder.AlterColumn<int>(
                name: "StationId",
                table: "Buses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Buses_Stations_StationId",
                table: "Buses",
                column: "StationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buses_Stations_StationId",
                table: "Buses");

            migrationBuilder.AlterColumn<int>(
                name: "StationId",
                table: "Buses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Buses_Stations_StationId",
                table: "Buses",
                column: "StationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
