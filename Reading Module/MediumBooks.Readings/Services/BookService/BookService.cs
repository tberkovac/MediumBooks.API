
namespace MediumBooks.Readings;

public class BookService: IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Book> GetBookAsync(int bookId)
    {
        var result = await _bookRepository.GetBookAsync(bookId);

        if (result == null)
        {
            throw new Exception($"Book with id {bookId} is not found");
        }

        return result;
    }

    public async Task<bool> UpdateBooksAuthor(int userId, string author)
    {
        return await _bookRepository.UpdateAuthorAsync(userId, author);
    } 
}
