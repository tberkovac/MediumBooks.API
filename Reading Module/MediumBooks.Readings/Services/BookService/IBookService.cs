namespace MediumBooks.Readings;

public interface IBookService
{
    Task<Book> GetBookAsync(int id);
    Task<bool> UpdateBooksAuthor(int userId, string author);
}
