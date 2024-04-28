namespace MediumBooks.Readings;

public interface IBookRepository
{
    Task<Book?> GetBookAsync(int id);
    Task<bool> UpdateAuthorAsync(int userId, string author);
}
