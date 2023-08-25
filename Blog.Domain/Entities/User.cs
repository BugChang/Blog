using Blog.Utility;
using Blog.Web.Entities;

namespace Blog.Domain.Entities
{
    public class User : EntityBase
    {
        public string Avatar { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public UserRole Role { get; set; }

        public string EncryptPassword => HashHelper.ComputeSha256Hash(Password);

    }

    public enum UserRole
    {
        Admin,
        Guest
    }
}
