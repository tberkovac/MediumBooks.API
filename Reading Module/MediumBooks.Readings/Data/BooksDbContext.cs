using Microsoft.EntityFrameworkCore;

namespace MediumBooks.Readings;

public class BooksDbContext: DbContext
{
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("reading");
    }

    public DbSet<Book> Books { get; set;}
}
