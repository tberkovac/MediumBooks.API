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
    }

    public DbSet<User> Users { get; set;}

}
