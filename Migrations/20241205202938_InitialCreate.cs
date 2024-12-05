using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurguerMania.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    desc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    imagem = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    baseDesc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fullDesc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    preco = table.Column<decimal>(type: "decimal(16,2)", precision: 16, scale: 2, nullable: false),
                    imagem = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PedidosUsuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosUsuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_PedidosUsuario_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosUsuario_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutosPedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosPedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProdutosPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutosPedidos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "id", "desc", "imagem", "nome", "tipo" },
                values: new object[,]
                {
                    { 1, "Hambúrgueres veganos", "assets/burguers/burguer4.png", "Vegan", "vegan" },
                    { 2, "Hambúrgueres fitness", "assets/burguers/burguer5.png", "Fitness", "fitness" },
                    { 3, "Os maiores e mais suculentos hambúrgueres", "assets/burguers/burguer1.png", "Infarto", "infarto" },
                    { 4, "O gigantescos e os suculentos", "assets/burguers/burguer2.png", "Maiorais", "maiorais" },
                    { 5, "O MAIS SUPREMOS e os suculentos", "assets/burguers/burguer3.png", "Tudões", "tudões" }
                });

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
                values: new object[] { 1, 1, 0m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "id", "CategoriaId", "baseDesc", "fullDesc", "imagem", "nome", "preco" },
                values: new object[,]
                {
                    { 1, 1, "Pão integral, hambúrguer de grão-de-bico, alface, tomate, queijo vegano e avocado", "Pão integral macio que envolve um hambúrguer suculento de grão-de-bico, enriquecido com alface fresca, tomate maduro, queijo vegano cremoso e avocado perfeitamente temperado. Uma combinação saudável que une sabor e nutrição em cada mordida, ideal para quem busca uma refeição leve e deliciosa.", "assets/burguers/burguer1.png", "X-Avocado", 12.99m },
                    { 2, 3, "Pão brioche, hambúrguer duplo, bacon crocante, queijo cheddar e molho especial", "Uma explosão de sabores em um pão brioche fofinho, recheado com dois hambúrgueres suculentos, bacon crocante no ponto perfeito, queijo cheddar derretido e um molho especial irresistível. Feito para os verdadeiros amantes de bacon que não dispensam uma experiência gastronômica intensa.", "assets/burguers/burguer2.png", "X-Baconator", 18.99m },
                    { 3, 1, "Pão integral, hambúrguer de espinafre, rúcula, tomate seco e molho pesto", "O sabor da natureza em um hambúrguer único. Um pão integral artesanal combinado com um hambúrguer de espinafre, rúcula fresca, tomate seco de sabor marcante e um molho pesto aromático. Uma escolha que traz leveza e frescor para sua refeição.", "assets/burguers/burguer3.png", "X-Verde", 14.99m },
                    { 4, 3, "Pão brioche, hambúrguer triplo, queijo cheddar, bacon e maionese trufada", "Desafie seu apetite com este colosso. Pão brioche, hambúrguer triplo suculento, camadas generosas de queijo cheddar derretido, bacon crocante e maionese trufada. Uma verdadeira indulgência para quem não tem medo de exagerar no sabor.", "assets/burguers/burguer4.png", "X-Coração Atacado", 21.99m },
                    { 5, 1, "Pão com sementes, hambúrguer de quinoa, alface, tomate, cenoura ralada e molho tahine", "Nutrição e sabor em perfeita harmonia. Um pão rico em sementes com hambúrguer de quinoa temperado, alface crocante, tomate maduro, cenoura ralada fresca e um toque de molho tahine cremoso. Ideal para quem busca energia e leveza.", "assets/burguers/burguer5.png", "X-Semente", 13.99m },
                    { 6, 2, "Pão low carb, hambúrguer de frango grelhado, espinafre, queijo cottage e molho de iogurte", "O parceiro perfeito para quem busca reforçar a dieta com proteínas. Um pão low carb leve, recheado com hambúrguer de frango grelhado, folhas frescas de espinafre, queijo cottage cremoso e um molho de iogurte refrescante. Completo, saudável e saboroso.", "assets/burguers/burguer1.png", "X-Protein Boost", 15.99m },
                    { 7, 3, "Pão tradicional recheado com hambúrguer duplo suculento, bacon crocante, queijo cheddar derretido, cebola caramelizada e molho barbecue", "Prepare-se para uma explosão de sabores. Pão tradicional recheado com hambúrguer duplo suculento, bacon crocante, queijo cheddar derretido, cebola caramelizada e um molho barbecue irresistível. Cada mordida é uma festa para o paladar.", "assets/burguers/burguer2.png", "X-Explosão", 19.99m },
                    { 8, 2, "Pão integral, hambúrguer de frango grelhado, alface americana, tomate e molho de limão", "Uma opção leve, mas cheia de sabor. Pão integral recheado com hambúrguer de frango grelhado, alface americana crocante, tomate suculento e um molho de limão refrescante que realça todos os sabores. Perfeito para uma refeição saudável e deliciosa.", "assets/burguers/burguer3.png", "X-Light", 12.49m },
                    { 9, 1, "Pão artesanal, hambúrguer de lentilha, queijo vegano, rúcula e molho de ervas", "Uma experiência vegana sofisticada. Pão artesanal combinado com hambúrguer de lentilha, queijo vegano de sabor suave, rúcula fresca e um molho de ervas aromático. Uma opção elaborada que une elegância e sabor em cada detalhe.", "assets/burguers/burguer4.png", "X-Gourmet Vegan", 16.99m },
                    { 10, 2, "Pão integral, hambúrguer de carne magra, queijo de búfala, espinafre e ovo poché", "Ideal para quem leva um estilo de vida ativo. Pão integral saudável recheado com hambúrguer de carne magra, queijo de búfala suave, folhas frescas de espinafre e um ovo poché perfeitamente preparado. Energia e sabor para o seu dia.", "assets/burguers/burguer5.png", "X-Crossfit", 17.49m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_StatusId",
                table: "Pedidos",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosUsuario_PedidoId",
                table: "PedidosUsuario",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosUsuario_UsuarioId",
                table: "PedidosUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPedidos_PedidoId",
                table: "ProdutosPedidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPedidos_ProdutoId",
                table: "ProdutosPedidos",
                column: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidosUsuario");

            migrationBuilder.DropTable(
                name: "ProdutosPedidos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
