using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityFrameworkCore.DesignTimeDbContextFactory
{
    public class BlogDbContextFactory: IDesignTimeDbContextFactory<BlogDbContext>
    {
        public BlogDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogDbContext>();
            optionsBuilder.UseMySql(ServerVersion.Parse("8.0"), b => b.MigrationsAssembly("Blog.EntityFrameworkCore"));
            return new BlogDbContext(optionsBuilder.Options);
        }
    }
}
