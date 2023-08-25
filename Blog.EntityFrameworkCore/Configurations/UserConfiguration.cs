using Blog.Domain.Entities;
using Blog.Utility;
using Blog.Web.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.EntityFrameworkCore.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.Password).HasMaxLength(255);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Name).HasMaxLength(20);
            builder.Property(p => p.Avatar).HasMaxLength(255);
            builder.Property(p => p.Phone).HasMaxLength(20);

            builder.HasData(new User
            {
                Id = 1,
                Name = "Admin",
                CreateBy = "system",
                Email = "admin@admin.com",
                CreateOn = DateTime.Now,
                Role = UserRole.Admin,
                Password = HashHelper.ComputeSha256Hash("admin")
            });
        }
    }
}
