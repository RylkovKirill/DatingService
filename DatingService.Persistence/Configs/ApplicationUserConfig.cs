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
            builder.Property(u => u.DateOfBirth).IsRequired();

            builder.HasOne(u => u.Avatar).WithOne(a => a.User).HasForeignKey<ApplicationUser>(u => u.AvatarId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(u => u.Gender).WithMany(g => g.Users).HasForeignKey(u => u.GenderId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
