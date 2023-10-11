using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersAPI.Models;

namespace UsersAPI.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ActionResult<UserDto> AddUser(CreateUserDto createUserDto)
        {
            using (var context = new UserDbContext())
            {
                var request = new User()
                {
                    Id = Guid.NewGuid(),
                    Name = createUserDto.Name,
                    Email = createUserDto.Email,
                    Password = createUserDto.Password,
                    CreatedDate = DateTime.Now,
                };
                context.Users.Add(request);
                context.SaveChanges();

                return Ok(request.AsDto());
            };
        }
    }
}
