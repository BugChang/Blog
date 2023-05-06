using Blog.Blazor.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Blazor
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<ArticleTag> ArticleTags { get; set; }
    }
}
