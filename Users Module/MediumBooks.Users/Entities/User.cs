namespace MediumBooks.Users;

public class User
{
    public int UserId { get; set; }
    public required string Name { get; set; }
    public required string Password { get; set; }
}
