using Microsoft.EntityFrameworkCore.Migrations;

namespace FornecedoresMVC.Migrations
{
    public partial class AlteracaoModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Fornecedores_FornecedorId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Categorias_categoriaId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_FornecedorId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "categoriaId",
                table: "Fornecedores",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedores_categoriaId",
                table: "Fornecedores",
                newName: "IX_Fornecedores_CategoriaId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Fornecedores",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Categorias_CategoriaId",
                table: "Fornecedores",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Categorias_CategoriaId",
                table: "Fornecedores");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Fornecedores",
                newName: "categoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedores_CategoriaId",
                table: "Fornecedores",
                newName: "IX_Fornecedores_categoriaId");

            migrationBuilder.AlterColumn<int>(
                name: "categoriaId",
                table: "Fornecedores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Categorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_FornecedorId",
                table: "Categorias",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Fornecedores_FornecedorId",
                table: "Categorias",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Categorias_categoriaId",
                table: "Fornecedores",
                column: "categoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
