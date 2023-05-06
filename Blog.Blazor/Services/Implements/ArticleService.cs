using Blog.Blazor.Models;
using Blog.Blazor.Services.Interfaces;

namespace Blog.Blazor.Services.Implements
{
    public class ArticleService : IArticleService
    {
        public Task CreateAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public Task<Article> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Article>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
