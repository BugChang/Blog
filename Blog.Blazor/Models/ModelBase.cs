namespace Blog.Blazor.Models
{
    public class ModelBase
    {
        public int Id { get; set; }

        public DateTime CreateOn { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public string UpdateBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
