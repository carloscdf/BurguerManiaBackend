using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurguerMania.Migrations
{
    /// <inheritdoc />
    public partial class DbUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoria",
                table: "Produtos");

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "id", "desc", "imagem", "nome", "tipo" },
                values: new object[] { 1, "Hambúrgueres veganos saborosos", "assets/burguers/burguer2.png", "Vegan", "Vegan" });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Aguardando Finalização" },
                    { 2, "Finalizado" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id", "email", "nome", "senha" },
                values: new object[] { 1, "teste@teste.com", "Usuário Teste", 123456 });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "id", "StatusId", "valor" },
                values: new object[] { 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "id", "CategoriaId", "baseDesc", "fullDesc", "imagem", "nome", "preco" },
                values: new object[] { 1, 1, "Pão brioche, hambúrguer duplo, bacon crocante, queijo cheddar e molho especial", "Uma explosão de sabores em um pão brioche fofinho, recheado com dois hambúrgueres suculentos, bacon crocante no ponto perfeito, queijo cheddar derretido e um molho especial irresistível. Feito para os verdadeiros amantes de bacon que não dispensam uma experiência gastronômica intensa.", "assets/burguers/burguer1.png", "X-Baconator", 19.90m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pedidos",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "categoria",
                table: "Produtos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
