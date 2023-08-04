namespace Blog.Web.Models
{
    public class ModelBase
    {
        public int Id { get; set; }

        public DateTime CreateTime { get; set; }

        public int CreateBy { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int UpdateBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
