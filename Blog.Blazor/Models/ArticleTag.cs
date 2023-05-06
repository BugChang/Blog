namespace Blog.Blazor.Models
{
    public class ArticleTag : ModelBase
    {
        public Article Article { get; set; }

        public Tag Tag { get; set; }
    }
}
