using MediumBooks.Users;
using MediumBooks.Readings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ImplementUsersModule(builder.Configuration);
builder.Services.ImplementReadingModule(builder.Configuration);

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies([typeof(UpdateBooksAuthorCommandHandler).Assembly]
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using var scope = app.Services.CreateScope();
    var usersDbContext = scope.ServiceProvider.GetRequiredService<UsersDbContext>();
    var booksDbContext = scope.ServiceProvider.GetRequiredService<BooksDbContext>();    
    //publishing module does not implement anything yet
    usersDbContext.Database.Migrate();
    booksDbContext.Database.Migrate();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
