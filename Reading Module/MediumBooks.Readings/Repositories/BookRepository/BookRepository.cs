
using Microsoft.EntityFrameworkCore;

namespace MediumBooks.Readings;

public class BookRepository : IBookRepository
{
    private readonly BooksDbContext _dbContext;

    public BookRepository(BooksDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Book?> GetBookAsync(int bookId)
    {
        return await _dbContext.Books.FirstOrDefaultAsync(x => x.BookId == bookId);
    }

    public async Task<bool> UpdateAuthorAsync(int userId, string author)
    {
        return await _dbContext.Books
        .Where(book => book.AuthorId == userId)
        .ExecuteUpdateAsync(x => x.SetProperty(_ => _.AuthorName, author)) > 0;
    }
}
