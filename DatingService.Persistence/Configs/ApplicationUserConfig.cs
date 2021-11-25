using DatingService.Domain.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(64);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(64);
            builder.Property(u => u.AvatarPath).HasMaxLength(64);
            builder.Property(u => u.PostCount).IsRequired().HasDefaultValue(10);
            builder.Property(u => u.DateOfBirth).IsRequired();

            builder.HasOne(u => u.Gender).WithMany(g => g.Users).HasForeignKey(u => u.GenderId);
        }
    }
}
