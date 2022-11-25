using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class AddPlacar5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_Selecao",
                table: "Jogos");

            migrationBuilder.DropIndex(
                name: "IX_Jogos_Selecao",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "Selecao",
                table: "Jogos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Selecao",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_Selecao",
                table: "Jogos",
                column: "Selecao");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_Selecao",
                table: "Jogos",
                column: "Selecao",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
