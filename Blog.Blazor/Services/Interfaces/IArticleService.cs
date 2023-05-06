using Blog.Blazor.Models;

namespace Blog.Blazor.Services.Interfaces
{
    public interface IArticleService
    {
        public Task CreateAsync(Article article);

        public Task UpdateAsync(Article article);

        public Task DeleteAsync(Article article);

        public Task<Article> GetByIdAsync(int id);

        public Task<IEnumerable<Article>> GetAllAsync();
    }
}
