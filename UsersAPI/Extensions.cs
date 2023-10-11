using UsersAPI.Models;

namespace UsersAPI
{
    public static class Extensions
    {
        public static UserDto AsDto(this User user)
        {
            return new(user.Id,user.Name,user.Email,user.Password,user.CreatedDate);
        }
    }
}
