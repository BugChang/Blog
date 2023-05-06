namespace Blog.Blazor.Models
{
    public class Comment : ModelBase
    {
        public Article Article { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Content { get; set; }
        public Comment Reply { get; set; }

    }
}
