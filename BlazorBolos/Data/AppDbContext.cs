using Microsoft.EntityFrameworkCore;

namespace BlazorBolos.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        :base(options)
    {
    }

    public DbSet<Bolo> Bolos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bolo>().HasData(
            new Bolo
            {
                Id = 1,
                Nome = "Bolo de Banana",
                Descricao = "Delicioso bolo de banana",
                Preco = 23.00m,
                ImagemUrl = "https://static1.minhavida.com.br/articles/db/c4/45/9a/foto-de-bolo-de-banana-article-1.jpg"
            },
            new Bolo
            {
                Id = 2,
                Nome = "Bolo de Brigadeiro",
                Descricao = "Delicioso bolo de Brigadeiro",
                Preco = 31.50m,
                ImagemUrl = "https://img.cybercook.com.br/receitas/717/cobertura-para-bolo-de-brigadeiro-1-840x480.jpeg"
            },
            new Bolo
            {
                Id = 3,
                Nome = "Bolo de Chocolate",
                Descricao = "Delicioso bolo de Chocolate",
                Preco = 41.00m,
                ImagemUrl = "https://static.itdg.com.br/images/640-400/f0fe1b5e14c2c6368a70b757e2627107/bolo-de-chocolate-de-liquidificador.jpg"
            },
            new Bolo
            {
                Id = 4,
                Nome = "Bolo de Laranja",
                Descricao = "Delicioso bolo de Laranja",
                Preco = 35.00m,
                ImagemUrl = "https://pt.vecteezy.com/foto/16117499-bolo-tradicional-de-baunilha-com-extrato-de-laranja-bolo-bundt"
            }
        );
    }
}
