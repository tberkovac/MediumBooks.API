using System.Windows.Input;
using MediatR;

namespace MediumBooks.Readings.Contracts;

public record UpdateBooksAuthorCommand(int UserId, string Author) : IRequest<bool>
{
}
