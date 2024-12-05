using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Categoria> Categorias { get; set; } = null!;
    public DbSet<Produto> Produtos { get; set; } = null!;
    public DbSet<Pedido> Pedidos { get; set; } = null!;
    public DbSet<ProdutoPedido> ProdutosPedidos { get; set; } = null!;
    public DbSet<PedidoUsuario> PedidosUsuario { get; set; } = null!;
    public DbSet<Status> Status { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Configuração de usuário
        modelBuilder.Entity<Usuario>().HasData(
       new Usuario { id = 1, nome = "Usuário Teste", email = "teste@teste.com", senha = 123456 }
   );

        // Configuração de Categoria
        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { id = 1, nome = "Vegan", desc = "Hambúrgueres veganos", tipo = "vegan", imagem = "assets/burguers/burguer4.png" },
            new Categoria { id = 2, nome = "Fitness", desc = "Hambúrgueres fitness", tipo = "fitness", imagem = "assets/burguers/burguer5.png" },
            new Categoria { id = 3, nome = "Infarto", desc = "Os maiores e mais suculentos hambúrgueres", tipo = "infarto", imagem = "assets/burguers/burguer1.png" },
            new Categoria { id = 4, nome = "Maiorais", desc = "O gigantescos e os suculentos", tipo = "maiorais", imagem = "assets/burguers/burguer2.png" },
            new Categoria { id = 5, nome = "Tudões", desc = "O MAIS SUPREMOS e os suculentos", tipo = "tudões", imagem = "assets/burguers/burguer3.png" }
        );

        // Configuração de Produto
        modelBuilder.Entity<Produto>().HasData(
            new Produto
            {
                id = 1,
                nome = "X-Avocado",
                baseDesc = "Pão integral, hambúrguer de grão-de-bico, alface, tomate, queijo vegano e avocado",
                fullDesc = "Pão integral macio que envolve um hambúrguer suculento de grão-de-bico, enriquecido com alface fresca, tomate maduro, queijo vegano cremoso e avocado perfeitamente temperado. Uma combinação saudável que une sabor e nutrição em cada mordida, ideal para quem busca uma refeição leve e deliciosa.",
                preco = 12.99M,
                imagem = "assets/burguers/burguer1.png",
                CategoriaId = 1
            },
            new Produto
            {
                id = 2,
                nome = "X-Baconator",
                baseDesc = "Pão brioche, hambúrguer duplo, bacon crocante, queijo cheddar e molho especial",
                fullDesc = "Uma explosão de sabores em um pão brioche fofinho, recheado com dois hambúrgueres suculentos, bacon crocante no ponto perfeito, queijo cheddar derretido e um molho especial irresistível. Feito para os verdadeiros amantes de bacon que não dispensam uma experiência gastronômica intensa.",
                preco = 18.99M,
                imagem = "assets/burguers/burguer2.png",
                CategoriaId = 3
            },
            new Produto
            {
                id = 3,
                nome = "X-Verde",
                baseDesc = "Pão integral, hambúrguer de espinafre, rúcula, tomate seco e molho pesto",
                fullDesc = "O sabor da natureza em um hambúrguer único. Um pão integral artesanal combinado com um hambúrguer de espinafre, rúcula fresca, tomate seco de sabor marcante e um molho pesto aromático. Uma escolha que traz leveza e frescor para sua refeição.",
                preco = 14.99M,
                imagem = "assets/burguers/burguer3.png",
                CategoriaId = 1
            },
            new Produto
            {
                id = 4,
                nome = "X-Coração Atacado",
                baseDesc = "Pão brioche, hambúrguer triplo, queijo cheddar, bacon e maionese trufada",
                fullDesc = "Desafie seu apetite com este colosso. Pão brioche, hambúrguer triplo suculento, camadas generosas de queijo cheddar derretido, bacon crocante e maionese trufada. Uma verdadeira indulgência para quem não tem medo de exagerar no sabor.",
                preco = 21.99M,
                imagem = "assets/burguers/burguer4.png",
                CategoriaId = 3
            },
            new Produto
            {
                id = 5,
                nome = "X-Semente",
                baseDesc = "Pão com sementes, hambúrguer de quinoa, alface, tomate, cenoura ralada e molho tahine",
                fullDesc = "Nutrição e sabor em perfeita harmonia. Um pão rico em sementes com hambúrguer de quinoa temperado, alface crocante, tomate maduro, cenoura ralada fresca e um toque de molho tahine cremoso. Ideal para quem busca energia e leveza.",
                preco = 13.99M,
                imagem = "assets/burguers/burguer5.png",
                CategoriaId = 1
            },
            new Produto
            {
                id = 6,
                nome = "X-Protein Boost",
                baseDesc = "Pão low carb, hambúrguer de frango grelhado, espinafre, queijo cottage e molho de iogurte",
                fullDesc = "O parceiro perfeito para quem busca reforçar a dieta com proteínas. Um pão low carb leve, recheado com hambúrguer de frango grelhado, folhas frescas de espinafre, queijo cottage cremoso e um molho de iogurte refrescante. Completo, saudável e saboroso.",
                preco = 15.99M,
                imagem = "assets/burguers/burguer1.png",
                CategoriaId = 2
            },
            new Produto
            {
                id = 7,
                nome = "X-Explosão",
                baseDesc = "Pão tradicional recheado com hambúrguer duplo suculento, bacon crocante, queijo cheddar derretido, cebola caramelizada e molho barbecue",
                fullDesc = "Prepare-se para uma explosão de sabores. Pão tradicional recheado com hambúrguer duplo suculento, bacon crocante, queijo cheddar derretido, cebola caramelizada e um molho barbecue irresistível. Cada mordida é uma festa para o paladar.",
                preco = 19.99M,
                imagem = "assets/burguers/burguer2.png",
                CategoriaId = 3
            },
            new Produto
            {
                id = 8,
                nome = "X-Light",
                baseDesc = "Pão integral, hambúrguer de frango grelhado, alface americana, tomate e molho de limão",
                fullDesc = "Uma opção leve, mas cheia de sabor. Pão integral recheado com hambúrguer de frango grelhado, alface americana crocante, tomate suculento e um molho de limão refrescante que realça todos os sabores. Perfeito para uma refeição saudável e deliciosa.",
                preco = 12.49M,
                imagem = "assets/burguers/burguer3.png",
                CategoriaId = 2
            },
            new Produto
            {
                id = 9,
                nome = "X-Gourmet Vegan",
                baseDesc = "Pão artesanal, hambúrguer de lentilha, queijo vegano, rúcula e molho de ervas",
                fullDesc = "Uma experiência vegana sofisticada. Pão artesanal combinado com hambúrguer de lentilha, queijo vegano de sabor suave, rúcula fresca e um molho de ervas aromático. Uma opção elaborada que une elegância e sabor em cada detalhe.",
                preco = 16.99M,
                imagem = "assets/burguers/burguer4.png",
                CategoriaId = 1
            },
            new Produto
            {
                id = 10,
                nome = "X-Crossfit",
                baseDesc = "Pão integral, hambúrguer de carne magra, queijo de búfala, espinafre e ovo poché",
                fullDesc = "Ideal para quem leva um estilo de vida ativo. Pão integral saudável recheado com hambúrguer de carne magra, queijo de búfala suave, folhas frescas de espinafre e um ovo poché perfeitamente preparado. Energia e sabor para o seu dia.",
                preco = 17.49M,
                imagem = "assets/burguers/burguer5.png",
                CategoriaId = 2
            }
        );


        // Configuração de Produto -> Categoria
        modelBuilder.Entity<Produto>()
            .HasOne<Categoria>()
            .WithMany()
            .HasForeignKey(p => p.CategoriaId);

        // Configuração de precisão do preço em Produto
        modelBuilder.Entity<Produto>()
            .Property(p => p.preco)
            .HasPrecision(16, 2);

        // Configuração de Pedido
        modelBuilder.Entity<Pedido>().HasData(
            new Pedido { id = 1, valor = 0, StatusId = 1 }
        );

        // Configuração de ProdutoPedido (tabela de associação Produto x Pedido)
        modelBuilder.Entity<ProdutoPedido>(entity =>
        {
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.HasOne<Produto>()
                .WithMany()
                .HasForeignKey(e => e.ProdutoId);
            entity.HasOne<Pedido>()
                .WithMany()
                .HasForeignKey(e => e.PedidoId);
        });

        // Configuração de PedidoUsuario (tabela de associação Pedido x Usuario)
        modelBuilder.Entity<PedidoUsuario>(entity =>
        {
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(e => e.UsuarioId);
            entity.HasOne<Pedido>()
                .WithMany()
                .HasForeignKey(e => e.PedidoId);
        });

        // Configuração de Pedido -> Status
        modelBuilder.Entity<Pedido>()
            .HasOne<Status>()
            .WithMany()
            .HasForeignKey(p => p.StatusId);

        // Configuração de Status
        modelBuilder.Entity<Status>().HasData(
            new Status { id = 1, nome = "Aguardando Finalização" },
            new Status { id = 2, nome = "Finalizado" }
        );

        base.OnModelCreating(modelBuilder);
    }
}