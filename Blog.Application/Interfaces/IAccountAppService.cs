using Blog.Application.DTOs;

namespace Blog.Application.Interfaces
{
    public interface IAccountAppService
    {
        Task<UserDto> LoginAsync(string email,string password);
    }
}
