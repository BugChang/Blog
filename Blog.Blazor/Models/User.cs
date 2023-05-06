namespace Blog.Blazor.Models
{
    public class User : ModelBase
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string DisplayName { get; set; }

        public Role Role { get; set; }
    }
}
