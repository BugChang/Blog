using Blog.Domain.Entities;
using Blog.Web.Entities;

namespace Blog.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByEmail(string email);
    }
}
