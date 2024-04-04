using CardSort.Models;
using Microsoft.EntityFrameworkCore;

namespace CardSort.Database;

public class CardSortContext : DbContext
{
    public DbSet<Deck> Decks { get; set; }
    public DbSet<Card> Cards { get; set; }

    private string DbPath { get; }

    public CardSortContext()
    {
        DbPath = "Server=localhost;Database=CardSort;TrustServerCertificate=True;Integrated Security=SSPI";
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Deck>(builder =>
        {
            builder.HasKey(d => d.DeckId);
            
        });
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(DbPath);
        base.OnConfiguring(optionsBuilder);
    }
}