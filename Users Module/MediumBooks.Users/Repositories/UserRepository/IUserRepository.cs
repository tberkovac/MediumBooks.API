namespace MediumBooks.Users;

public interface IUserRepository
{
    Task<User?> GetUserAsync(int userId);
}
