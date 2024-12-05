﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurguerMania.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Categoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("imagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            id = 1,
                            desc = "Hambúrgueres veganos",
                            imagem = "assets/burguers/burguer4.png",
                            nome = "Vegan",
                            tipo = "vegan"
                        },
                        new
                        {
                            id = 2,
                            desc = "Hambúrgueres fitness",
                            imagem = "assets/burguers/burguer5.png",
                            nome = "Fitness",
                            tipo = "fitness"
                        },
                        new
                        {
                            id = 3,
                            desc = "Os maiores e mais suculentos hambúrgueres",
                            imagem = "assets/burguers/burguer1.png",
                            nome = "Infarto",
                            tipo = "infarto"
                        },
                        new
                        {
                            id = 4,
                            desc = "O gigantescos e os suculentos",
                            imagem = "assets/burguers/burguer2.png",
                            nome = "Maiorais",
                            tipo = "maiorais"
                        },
                        new
                        {
                            id = 5,
                            desc = "O MAIS SUPREMOS e os suculentos",
                            imagem = "assets/burguers/burguer3.png",
                            nome = "Tudões",
                            tipo = "tudões"
                        });
                });

            modelBuilder.Entity("Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("id");

                    b.HasIndex("StatusId");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            StatusId = 1,
                            valor = 0m
                        });
                });

            modelBuilder.Entity("PedidoUsuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PedidosUsuario");
                });

            modelBuilder.Entity("Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("baseDesc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("fullDesc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("imagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("preco")
                        .HasPrecision(16, 2)
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CategoriaId = 1,
                            baseDesc = "Pão integral, hambúrguer de grão-de-bico, alface, tomate, queijo vegano e avocado",
                            fullDesc = "Pão integral macio que envolve um hambúrguer suculento de grão-de-bico, enriquecido com alface fresca, tomate maduro, queijo vegano cremoso e avocado perfeitamente temperado. Uma combinação saudável que une sabor e nutrição em cada mordida, ideal para quem busca uma refeição leve e deliciosa.",
                            imagem = "assets/burguers/burguer1.png",
                            nome = "X-Avocado",
                            preco = 12.99m
                        },
                        new
                        {
                            id = 2,
                            CategoriaId = 3,
                            baseDesc = "Pão brioche, hambúrguer duplo, bacon crocante, queijo cheddar e molho especial",
                            fullDesc = "Uma explosão de sabores em um pão brioche fofinho, recheado com dois hambúrgueres suculentos, bacon crocante no ponto perfeito, queijo cheddar derretido e um molho especial irresistível. Feito para os verdadeiros amantes de bacon que não dispensam uma experiência gastronômica intensa.",
                            imagem = "assets/burguers/burguer2.png",
                            nome = "X-Baconator",
                            preco = 18.99m
                        },
                        new
                        {
                            id = 3,
                            CategoriaId = 1,
                            baseDesc = "Pão integral, hambúrguer de espinafre, rúcula, tomate seco e molho pesto",
                            fullDesc = "O sabor da natureza em um hambúrguer único. Um pão integral artesanal combinado com um hambúrguer de espinafre, rúcula fresca, tomate seco de sabor marcante e um molho pesto aromático. Uma escolha que traz leveza e frescor para sua refeição.",
                            imagem = "assets/burguers/burguer3.png",
                            nome = "X-Verde",
                            preco = 14.99m
                        },
                        new
                        {
                            id = 4,
                            CategoriaId = 3,
                            baseDesc = "Pão brioche, hambúrguer triplo, queijo cheddar, bacon e maionese trufada",
                            fullDesc = "Desafie seu apetite com este colosso. Pão brioche, hambúrguer triplo suculento, camadas generosas de queijo cheddar derretido, bacon crocante e maionese trufada. Uma verdadeira indulgência para quem não tem medo de exagerar no sabor.",
                            imagem = "assets/burguers/burguer4.png",
                            nome = "X-Coração Atacado",
                            preco = 21.99m
                        },
                        new
                        {
                            id = 5,
                            CategoriaId = 1,
                            baseDesc = "Pão com sementes, hambúrguer de quinoa, alface, tomate, cenoura ralada e molho tahine",
                            fullDesc = "Nutrição e sabor em perfeita harmonia. Um pão rico em sementes com hambúrguer de quinoa temperado, alface crocante, tomate maduro, cenoura ralada fresca e um toque de molho tahine cremoso. Ideal para quem busca energia e leveza.",
                            imagem = "assets/burguers/burguer5.png",
                            nome = "X-Semente",
                            preco = 13.99m
                        },
                        new
                        {
                            id = 6,
                            CategoriaId = 2,
                            baseDesc = "Pão low carb, hambúrguer de frango grelhado, espinafre, queijo cottage e molho de iogurte",
                            fullDesc = "O parceiro perfeito para quem busca reforçar a dieta com proteínas. Um pão low carb leve, recheado com hambúrguer de frango grelhado, folhas frescas de espinafre, queijo cottage cremoso e um molho de iogurte refrescante. Completo, saudável e saboroso.",
                            imagem = "assets/burguers/burguer1.png",
                            nome = "X-Protein Boost",
                            preco = 15.99m
                        },
                        new
                        {
                            id = 7,
                            CategoriaId = 3,
                            baseDesc = "Pão tradicional recheado com hambúrguer duplo suculento, bacon crocante, queijo cheddar derretido, cebola caramelizada e molho barbecue",
                            fullDesc = "Prepare-se para uma explosão de sabores. Pão tradicional recheado com hambúrguer duplo suculento, bacon crocante, queijo cheddar derretido, cebola caramelizada e um molho barbecue irresistível. Cada mordida é uma festa para o paladar.",
                            imagem = "assets/burguers/burguer2.png",
                            nome = "X-Explosão",
                            preco = 19.99m
                        },
                        new
                        {
                            id = 8,
                            CategoriaId = 2,
                            baseDesc = "Pão integral, hambúrguer de frango grelhado, alface americana, tomate e molho de limão",
                            fullDesc = "Uma opção leve, mas cheia de sabor. Pão integral recheado com hambúrguer de frango grelhado, alface americana crocante, tomate suculento e um molho de limão refrescante que realça todos os sabores. Perfeito para uma refeição saudável e deliciosa.",
                            imagem = "assets/burguers/burguer3.png",
                            nome = "X-Light",
                            preco = 12.49m
                        },
                        new
                        {
                            id = 9,
                            CategoriaId = 1,
                            baseDesc = "Pão artesanal, hambúrguer de lentilha, queijo vegano, rúcula e molho de ervas",
                            fullDesc = "Uma experiência vegana sofisticada. Pão artesanal combinado com hambúrguer de lentilha, queijo vegano de sabor suave, rúcula fresca e um molho de ervas aromático. Uma opção elaborada que une elegância e sabor em cada detalhe.",
                            imagem = "assets/burguers/burguer4.png",
                            nome = "X-Gourmet Vegan",
                            preco = 16.99m
                        },
                        new
                        {
                            id = 10,
                            CategoriaId = 2,
                            baseDesc = "Pão integral, hambúrguer de carne magra, queijo de búfala, espinafre e ovo poché",
                            fullDesc = "Ideal para quem leva um estilo de vida ativo. Pão integral saudável recheado com hambúrguer de carne magra, queijo de búfala suave, folhas frescas de espinafre e um ovo poché perfeitamente preparado. Energia e sabor para o seu dia.",
                            imagem = "assets/burguers/burguer5.png",
                            nome = "X-Crossfit",
                            preco = 17.49m
                        });
                });

            modelBuilder.Entity("ProdutoPedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutosPedidos");
                });

            modelBuilder.Entity("Status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Aguardando Finalização"
                        },
                        new
                        {
                            id = 2,
                            nome = "Finalizado"
                        });
                });

            modelBuilder.Entity("Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("senha")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "teste@teste.com",
                            nome = "Usuário Teste",
                            senha = 123456
                        });
                });

            modelBuilder.Entity("Pedido", b =>
                {
                    b.HasOne("Status", null)
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PedidoUsuario", b =>
                {
                    b.HasOne("Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Produto", b =>
                {
                    b.HasOne("Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProdutoPedido", b =>
                {
                    b.HasOne("Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
