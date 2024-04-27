using Microsoft.AspNetCore.Mvc;

namespace MediumBooks.Readings;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("{bookId}")]
    public async Task<Book> GetBook(int bookId)
    {
        return await _bookService.GetBookAsync(bookId);
    }
}
