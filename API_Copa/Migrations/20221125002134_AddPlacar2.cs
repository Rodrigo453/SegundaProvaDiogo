using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class AddPlacar2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_PlacarAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_PlacarBId",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "PlacarBId",
                table: "Jogos",
                newName: "valorBId");

            migrationBuilder.RenameColumn(
                name: "PlacarAId",
                table: "Jogos",
                newName: "valorAId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_PlacarBId",
                table: "Jogos",
                newName: "IX_Jogos_valorBId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_PlacarAId",
                table: "Jogos",
                newName: "IX_Jogos_valorAId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_valorAId",
                table: "Jogos",
                column: "valorAId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_valorBId",
                table: "Jogos",
                column: "valorBId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_valorAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_valorBId",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "valorBId",
                table: "Jogos",
                newName: "PlacarBId");

            migrationBuilder.RenameColumn(
                name: "valorAId",
                table: "Jogos",
                newName: "PlacarAId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_valorBId",
                table: "Jogos",
                newName: "IX_Jogos_PlacarBId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_valorAId",
                table: "Jogos",
                newName: "IX_Jogos_PlacarAId");

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
    }
}
