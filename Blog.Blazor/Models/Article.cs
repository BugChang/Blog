namespace Blog.Blazor.Models
{
    public class Article : ModelBase
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string CoverImgUrl { get; set; }

        public Category Category { get; set; }

        public int ClickCount { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

        public bool IsStick { get; set; }

    }
}
