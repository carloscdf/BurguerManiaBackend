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
        // Configuração de Produto -> Categoria
        modelBuilder.Entity<Produto>()
            .HasOne<Categoria>()
            .WithMany()
            .HasForeignKey(p => p.CategoriaId);

        // Configuração de precisão do preço em Produto
        modelBuilder.Entity<Produto>()
            .Property(p => p.preco)
            .HasPrecision(16, 2);

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

        base.OnModelCreating(modelBuilder);
    }
}
