using Microsoft.EntityFrameworkCore;

namespace MediumBooks.Users;

public class UsersDbContext : DbContext
{
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("user");

        modelBuilder.Entity<User>().HasData(GetUsers());
    }

    public DbSet<User> Users { get; set;}

    private List<User> GetUsers()
    {
        return Enumerable.Range(1, 10).Select(index => new User {
            UserId = index,
            Name = $"Name {index}",
            Password = $"password{index}",
        }).ToList();
    }
}
