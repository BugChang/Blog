using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Application.DTOs;
using Blog.Application.Interfaces;
using Blog.Domain;
using Blog.Domain.Interfaces;

namespace Blog.Application.Services
{
    public class AccountAppService : IAccountAppService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AccountAppService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> LoginAsync(string email, string password)
        {
            var user = await _userRepository.GetByEmail(email);
            if (user == null || !user.EncryptPassword.Equals(password))
            {
                throw new BusinessException(ErrorCode.ValidateFail, "用户名或密码错误.");
            }
            return _mapper.Map<UserDto>(user);
        }
    }
}
