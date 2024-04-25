
namespace MediumBooks.Users;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository) 
    {
        _userRepository = userRepository;
    }

    public async Task<User> GetUser(int userId)
    {
        var result =  await _userRepository.GetUserAsync(userId);

        if (result == null)
        {
            throw new Exception($"Unable to find user with id {userId}");
        }

        return result;
    }
}
