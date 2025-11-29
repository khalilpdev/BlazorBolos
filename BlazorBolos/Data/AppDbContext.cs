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
                ImagemUrl = "https://marcoratti.net/Imagens/bolos/bolo_banana.jpg"
            },
            new Bolo
            {
                Id = 2,
                Nome = "Bolo de Brigadeiro",
                Descricao = "Delicioso bolo de Brigadeiro",
                Preco = 31.50m,
                ImagemUrl = "https://marcoratti.net/Imagens/bolos/bolo_brigadeiro.jpg"
            },
            new Bolo
            {
                Id = 3,
                Nome = "Bolo de Chocolate",
                Descricao = "Delicioso bolo de Chocolate",
                Preco = 41.00m,
                ImagemUrl = "https://marcoratti.net/Imagens/bolos/bolo_chocolate.jpg"
            },
            new Bolo
            {
                Id = 4,
                Nome = "Bolo de Laranja",
                Descricao = "Delicioso bolo de Laranja",
                Preco = 35.00m,
                ImagemUrl = "https://marcoratti.net/Imagens/bolos/bolo_laranja.jpg"
            }
        );
    }
}
