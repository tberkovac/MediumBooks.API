namespace MediumBooks.Users;

public interface IUserService
{
    Task<User> GetUser(int userId);
    Task<User> UpdateUser(User user);
}
