namespace Blog.Web.Models
{
    public class UserModel : ModelBase
    {
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string DisplayName { get; set; }

        public UserRole Role { get; set; }

        public string Avatar { get; set; }

    }

    public enum UserRole
    {
        Manager,
        Writer,
        Normal
    }
}
