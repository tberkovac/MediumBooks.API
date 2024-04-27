namespace MediumBooks.Readings;

public interface IBookRepository
{
    Task<Book?> GetBookAsync(int id);
}
