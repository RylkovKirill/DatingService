using DatingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class ReportConfig : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.Property(r => r.Content).HasMaxLength(4096);
            builder.HasOne(r => r.Sender).WithMany(u => u.SentReports).HasForeignKey(r => r.SenderId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(r => r.Category).WithMany(u => u.Reports).HasForeignKey(r => r.ReportCategoryId);
            builder.HasOne(r => r.Receiver).WithMany(u => u.ReceivedReports).HasForeignKey(r => r.ReceiverId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
