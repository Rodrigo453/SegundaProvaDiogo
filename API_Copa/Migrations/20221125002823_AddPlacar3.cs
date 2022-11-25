using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class AddPlacar3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_valorAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_valorBId",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_valorAId",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_valorBId",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "valorAId",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "valorBId",
                table: "Jogos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "valorAId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "valorBId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_valorAId",
                table: "Jogos",
                column: "valorAId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_valorBId",
                table: "Jogos",
                column: "valorBId");

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
    }
}
