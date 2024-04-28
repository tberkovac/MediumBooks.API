
using System.Net;
using MediatR;
using MediumBooks.Readings.Contracts;

namespace MediumBooks.Users;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMediator _mediator;

    public UserService(IUserRepository userRepository, IMediator mediator) 
    {
        _userRepository = userRepository;
        _mediator = mediator;
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

    public async Task<User> UpdateUser(User user)
    {
        var result = await _userRepository.GetUserAsync(user.UserId);

        if (result == null) 
        {
            throw new Exception($"User with id {user.UserId} does not exist");
        }

        if (!result.Name.Equals(user.Name)) 
        {
            var command = new UpdateBooksAuthorCommand(user.UserId, user.Name);
            var result2 = await _mediator.Send(command);
        }

        result.Name = user.Name;
        result.Password = user.Password;

        await _userRepository.SaveChangesAsync();
        return user;
    }
}
