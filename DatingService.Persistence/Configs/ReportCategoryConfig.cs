using DatingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class ReportCategoryConfig : IEntityTypeConfiguration<ReportCategory>
    {
        public void Configure(EntityTypeBuilder<ReportCategory> builder)
        {
            builder.Property(r => r.Name).IsRequired().HasMaxLength(256);
            builder.Property(r => r.Description).HasMaxLength(1024);

            builder.HasMany(r => r.Reports).WithOne(r => r.Category).HasForeignKey(r => r.ReportCategoryId);
        }
    }
}
