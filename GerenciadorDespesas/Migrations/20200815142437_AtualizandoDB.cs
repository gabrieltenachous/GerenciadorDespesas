using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDespesas.Migrations
{
    public partial class AtualizandoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoDespesasId",
                table: "TipoDespesas",
                newName: "TipoDespesaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoDespesaId",
                table: "TipoDespesas",
                newName: "TipoDespesasId");
        }
    }
}
