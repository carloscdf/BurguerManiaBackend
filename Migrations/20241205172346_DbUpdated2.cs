using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurguerMania.Migrations
{
    /// <inheritdoc />
    public partial class DbUpdated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "ProdutosPedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "PedidosUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "Pedidos",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "desc", "imagem", "tipo" },
                values: new object[] { "Hambúrgueres veganos", "assets/burguers/burguer4.png", "vegan" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "id", "desc", "imagem", "nome", "tipo" },
                values: new object[,]
                {
                    { 2, "Hambúrgueres fitness", "assets/burguers/burguer5.png", "Fitness", "fitness" },
                    { 3, "Os maiores e mais suculentos hambúrgueres", "assets/burguers/burguer1.png", "Infarto", "infarto" },
                    { 4, "O gigantescos e os suculentos", "assets/burguers/burguer2.png", "Maiorais", "maiorais" },
                    { 5, "O MAIS SUPREMOS e os suculentos", "assets/burguers/burguer3.png", "Tudões", "tudões" }
                });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "id",
                keyValue: 1,
                column: "valor",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "baseDesc", "fullDesc", "nome", "preco" },
                values: new object[] { "Pão integral, hambúrguer de grão-de-bico, alface, tomate, queijo vegano e avocado", "Pão integral macio que envolve um hambúrguer suculento de grão-de-bico, enriquecido com alface fresca, tomate maduro, queijo vegano cremoso e avocado perfeitamente temperado. Uma combinação saudável que une sabor e nutrição em cada mordida, ideal para quem busca uma refeição leve e deliciosa.", "X-Avocado", 12.99m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "id", "CategoriaId", "baseDesc", "fullDesc", "imagem", "nome", "preco" },
                values: new object[,]
                {
                    { 3, 1, "Pão integral, hambúrguer de espinafre, rúcula, tomate seco e molho pesto", "O sabor da natureza em um hambúrguer único. Um pão integral artesanal combinado com um hambúrguer de espinafre, rúcula fresca, tomate seco de sabor marcante e um molho pesto aromático. Uma escolha que traz leveza e frescor para sua refeição.", "assets/burguers/burguer3.png", "X-Verde", 14.99m },
                    { 5, 1, "Pão com sementes, hambúrguer de quinoa, alface, tomate, cenoura ralada e molho tahine", "Nutrição e sabor em perfeita harmonia. Um pão rico em sementes com hambúrguer de quinoa temperado, alface crocante, tomate maduro, cenoura ralada fresca e um toque de molho tahine cremoso. Ideal para quem busca energia e leveza.", "assets/burguers/burguer5.png", "X-Semente", 13.99m },
                    { 9, 1, "Pão artesanal, hambúrguer de lentilha, queijo vegano, rúcula e molho de ervas", "Uma experiência vegana sofisticada. Pão artesanal combinado com hambúrguer de lentilha, queijo vegano de sabor suave, rúcula fresca e um molho de ervas aromático. Uma opção elaborada que une elegância e sabor em cada detalhe.", "assets/burguers/burguer4.png", "X-Gourmet Vegan", 16.99m },
                    { 2, 3, "Pão brioche, hambúrguer duplo, bacon crocante, queijo cheddar e molho especial", "Uma explosão de sabores em um pão brioche fofinho, recheado com dois hambúrgueres suculentos, bacon crocante no ponto perfeito, queijo cheddar derretido e um molho especial irresistível. Feito para os verdadeiros amantes de bacon que não dispensam uma experiência gastronômica intensa.", "assets/burguers/burguer2.png", "X-Baconator", 18.99m },
                    { 4, 3, "Pão brioche, hambúrguer triplo, queijo cheddar, bacon e maionese trufada", "Desafie seu apetite com este colosso. Pão brioche, hambúrguer triplo suculento, camadas generosas de queijo cheddar derretido, bacon crocante e maionese trufada. Uma verdadeira indulgência para quem não tem medo de exagerar no sabor.", "assets/burguers/burguer4.png", "X-Coração Atacado", 21.99m },
                    { 6, 2, "Pão low carb, hambúrguer de frango grelhado, espinafre, queijo cottage e molho de iogurte", "O parceiro perfeito para quem busca reforçar a dieta com proteínas. Um pão low carb leve, recheado com hambúrguer de frango grelhado, folhas frescas de espinafre, queijo cottage cremoso e um molho de iogurte refrescante. Completo, saudável e saboroso.", "assets/burguers/burguer1.png", "X-Protein Boost", 15.99m },
                    { 7, 3, "Pão tradicional recheado com hambúrguer duplo suculento, bacon crocante, queijo cheddar derretido, cebola caramelizada e molho barbecue", "Prepare-se para uma explosão de sabores. Pão tradicional recheado com hambúrguer duplo suculento, bacon crocante, queijo cheddar derretido, cebola caramelizada e um molho barbecue irresistível. Cada mordida é uma festa para o paladar.", "assets/burguers/burguer2.png", "X-Explosão", 19.99m },
                    { 8, 2, "Pão integral, hambúrguer de frango grelhado, alface americana, tomate e molho de limão", "Uma opção leve, mas cheia de sabor. Pão integral recheado com hambúrguer de frango grelhado, alface americana crocante, tomate suculento e um molho de limão refrescante que realça todos os sabores. Perfeito para uma refeição saudável e deliciosa.", "assets/burguers/burguer3.png", "X-Light", 12.49m },
                    { 10, 2, "Pão integral, hambúrguer de carne magra, queijo de búfala, espinafre e ovo poché", "Ideal para quem leva um estilo de vida ativo. Pão integral saudável recheado com hambúrguer de carne magra, queijo de búfala suave, folhas frescas de espinafre e um ovo poché perfeitamente preparado. Energia e sabor para o seu dia.", "assets/burguers/burguer5.png", "X-Crossfit", 17.49m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "id",
                table: "ProdutosPedidos");

            migrationBuilder.DropColumn(
                name: "id",
                table: "PedidosUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "valor",
                table: "Pedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "desc", "imagem", "tipo" },
                values: new object[] { "Hambúrgueres veganos saborosos", "assets/burguers/burguer2.png", "Vegan" });

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "id",
                keyValue: 1,
                column: "valor",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "baseDesc", "fullDesc", "nome", "preco" },
                values: new object[] { "Pão brioche, hambúrguer duplo, bacon crocante, queijo cheddar e molho especial", "Uma explosão de sabores em um pão brioche fofinho, recheado com dois hambúrgueres suculentos, bacon crocante no ponto perfeito, queijo cheddar derretido e um molho especial irresistível. Feito para os verdadeiros amantes de bacon que não dispensam uma experiência gastronômica intensa.", "X-Baconator", 19.90m });
        }
    }
}
