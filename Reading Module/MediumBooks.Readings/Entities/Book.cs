using Microsoft.AspNetCore.Identity;

namespace MediumBooks.Readings;

public class Book
{
    public int BookId { get; set; }
    public required string Name { get; set; }
    public int AuthorId { get; set; }
    public required string AuthorName { get; set; }
}
