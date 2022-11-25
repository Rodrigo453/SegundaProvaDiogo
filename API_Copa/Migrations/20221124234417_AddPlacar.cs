using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class AddPlacar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlacarAId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlacarBId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_PlacarAId",
                table: "Jogos",
                column: "PlacarAId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_PlacarBId",
                table: "Jogos",
                column: "PlacarBId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_PlacarAId",
                table: "Jogos",
                column: "PlacarAId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_PlacarBId",
                table: "Jogos",
                column: "PlacarBId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_PlacarAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_PlacarBId",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_PlacarAId",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_PlacarBId",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "PlacarAId",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "PlacarBId",
                table: "Jogos");
        }
    }
}
