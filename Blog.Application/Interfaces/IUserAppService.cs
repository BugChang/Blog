using Blog.Application.DTOs;

namespace Blog.Application.Interfaces
{
    public interface IUserAppService
    {
        UserDto GetByEmail(string email);
    }
}
