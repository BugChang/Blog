using Blog.Application.DTOs;
using Blog.Application.Interfaces;
using Blog.Domain.Interfaces;

namespace Blog.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
