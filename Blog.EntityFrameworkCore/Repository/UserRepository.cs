using Blog.Domain.Entities;
using Blog.Domain.Interfaces;
using Blog.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(BlogDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<User> GetByEmail(string email)
        {
            return await DbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
