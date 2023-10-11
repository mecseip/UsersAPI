namespace UsersAPI
{
    public record UserDto(Guid id, string Name, string Email, string Password, DateTime createdDate);
    public record CreateUserDto(string Name, string Email, string Password);
    public record UpdateUserDto(string Name, string Email, string Password);
}
