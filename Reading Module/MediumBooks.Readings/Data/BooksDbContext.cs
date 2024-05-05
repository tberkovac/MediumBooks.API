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

        modelBuilder.Entity<Book>().HasData(GetBooks());
    }

    public DbSet<Book> Books { get; set;}

    private List<Book> GetBooks(){
        return Enumerable.Range(1, 100).Select(index => new Book{
            BookId = index,
            AuthorId = index % 10 + 1,
            Name = $"Interesting book {index}",
            AuthorName = $"Name {index % 10 + 1}",
        }).ToList();
    }
}
