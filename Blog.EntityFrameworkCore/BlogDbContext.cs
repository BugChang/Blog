using Blog.Domain.Entities;
using Blog.EntityFrameworkCore.Configurations;
using Blog.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore
{
    public class BlogDbContext : DbContext
    {

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
