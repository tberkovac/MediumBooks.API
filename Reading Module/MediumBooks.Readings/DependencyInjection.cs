using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MediumBooks.Readings;

public static class DependencyInjection
{
    public static IServiceCollection ImplementReadingModule(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddControllers();

        services.AddDbContext<BooksDbContext>(p => p.UseNpgsql(configuration.GetConnectionString("DatabaseConnection")));
        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<IBookService, BookService>();

        return services;
    }
}
