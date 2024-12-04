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

        //Configuração de Categoria
        modelBuilder.Entity<Categoria>().HasData(
             new Categoria
             {
                 id = 1,
                 nome = "Vegan",
                 desc = "Hambúrgueres veganos saborosos",
                 tipo = "Vegan",
                 imagem = "assets/burguers/burguer2.png"
             }
         );

        //Configuração de produto
        modelBuilder.Entity<Produto>().HasData(
       new Produto
       {
           id = 1,
           nome = "X-Baconator",
           baseDesc = "Pão brioche, hambúrguer duplo, bacon crocante, queijo cheddar e molho especial",
           fullDesc = "Uma explosão de sabores em um pão brioche fofinho, recheado com dois hambúrgueres suculentos, bacon crocante no ponto perfeito, queijo cheddar derretido e um molho especial irresistível. Feito para os verdadeiros amantes de bacon que não dispensam uma experiência gastronômica intensa.",
           preco = 19.90M,
           imagem = "assets/burguers/burguer1.png",
           CategoriaId = 1
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

        //Configuração do pedido
        modelBuilder.Entity<Pedido>().HasData(
    new Pedido { id = 1, valor = 0, StatusId = 1 }
);

        // Configuração de ProdutoPedido (tabela de associação Produto x Pedido)
        modelBuilder.Entity<ProdutoPedido>()
            .HasKey(pp => new { pp.ProdutoId, pp.PedidoId });

        modelBuilder.Entity<ProdutoPedido>()
            .HasOne<Produto>()
            .WithMany()
            .HasForeignKey(pp => pp.ProdutoId);

        modelBuilder.Entity<ProdutoPedido>()
            .HasOne<Pedido>()
            .WithMany()
            .HasForeignKey(pp => pp.PedidoId);

        // Configuração de PedidoUsuario (tabela de associação Pedido x Usuario)
        modelBuilder.Entity<PedidoUsuario>()
            .HasKey(up => new { up.UsuarioId, up.PedidoId });

        modelBuilder.Entity<PedidoUsuario>()
            .HasOne<Usuario>()
            .WithMany()
            .HasForeignKey(up => up.UsuarioId);

        modelBuilder.Entity<PedidoUsuario>()
            .HasOne<Pedido>()
            .WithMany()
            .HasForeignKey(up => up.PedidoId);

        // Configuração de Pedido -> Status
        modelBuilder.Entity<Pedido>()
            .HasOne<Status>()
            .WithMany()
            .HasForeignKey(p => p.StatusId);


        //Configuração de Status
        modelBuilder.Entity<Status>().HasData(
       new Status { id = 1, nome = "Aguardando Finalização" },
       new Status { id = 2, nome = "Finalizado" }
   );

        base.OnModelCreating(modelBuilder);
    }
}
