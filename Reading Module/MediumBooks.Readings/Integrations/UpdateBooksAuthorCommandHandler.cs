using MediatR;
using MediumBooks.Readings.Contracts;

namespace MediumBooks.Readings;

public class UpdateBooksAuthorCommandHandler : IRequestHandler<UpdateBooksAuthorCommand, bool>
{
    private readonly IBookService _bookService;

    public UpdateBooksAuthorCommandHandler(IBookService bookService)
    {
        _bookService = bookService;
    }

    public async Task<bool> Handle(UpdateBooksAuthorCommand request, CancellationToken cancellationToken)
    {
        await _bookService.UpdateBooksAuthor(request.UserId, request.Author);
        return true;
    }
}
