using Microsoft.AspNetCore.Mvc;

namespace MediumBooks.Users;

[ApiController]
[Route("api/[controller]")]
public class UsersController: ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public async Task<User> GetUser(int id) 
    {
        return await _userService.GetUser(id);
    }
}
