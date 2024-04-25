
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MediumBooks.Users;


public static class DependencyInjection
{
    public static IServiceCollection ImplementUsersModule(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddControllers();

        services.AddDbContext<UsersDbContext>(p => p.UseNpgsql(configuration.GetConnectionString("DatabaseConnection")));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
