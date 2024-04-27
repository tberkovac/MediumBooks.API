namespace MediumBooks.Readings;

public interface IBookService
{
    Task<Book> GetBookAsync(int id);
}
