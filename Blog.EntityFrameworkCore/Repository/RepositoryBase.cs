using Blog.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repository
{
    public class RepositoryBase<TEntity> where TEntity : EntityBase
    {
        public DbSet<TEntity> DbSet { get; set; }
        public RepositoryBase(BlogDbContext dbContext)
        {
            DbSet = dbContext.Set<TEntity>();
        }
    }
}
