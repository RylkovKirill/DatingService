using DatingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class ImageConfig : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(g => g.Id);
            builder.HasIndex(g => g.Path).IsUnique();

            builder.Property(g => g.Name).IsRequired().HasMaxLength(64);
            builder.Property(g => g.Path).IsRequired().HasMaxLength(256);
        }
    }
}
