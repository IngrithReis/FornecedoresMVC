using Microsoft.EntityFrameworkCore.Migrations;

namespace FornecedoresMVC.Migrations
{
    public partial class alteradoFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoriaId",
                table: "Fornecedores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_categoriaId",
                table: "Fornecedores",
                column: "categoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Categorias_categoriaId",
                table: "Fornecedores",
                column: "categoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Categorias_categoriaId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedores_categoriaId",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "categoriaId",
                table: "Fornecedores");
        }
    }
}
