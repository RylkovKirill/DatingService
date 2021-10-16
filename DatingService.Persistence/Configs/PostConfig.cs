using DatingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(256);
            builder.Property(p => p.Content).IsRequired().HasMaxLength(2048);

            builder.HasOne(p => p.Image).WithOne(i => i.Post).HasForeignKey<Post>(i => i.ImageId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.User).WithMany().HasForeignKey(i => i.UserId);
        }
    }
}
