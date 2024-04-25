
using Microsoft.EntityFrameworkCore;

namespace MediumBooks.Users;

public class UserRepository : IUserRepository
{
    private readonly UsersDbContext _dbContext;

    public UserRepository(UsersDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User?> GetUserAsync(int userId)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == userId);
    }
}
