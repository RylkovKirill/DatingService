using DatingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class GenderConfig : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(g => g.Id);
            builder.HasIndex(g => g.Name).IsUnique();

            builder.Property(g => g.Name).IsRequired().HasMaxLength(64);
        }
    }
}
