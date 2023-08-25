using AutoMapper;
using Blog.Application.DTOs;
using Blog.Domain.Entities;

namespace Blog.Application.AutoMapper
{
    public class EntityToDtoProfile:Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
