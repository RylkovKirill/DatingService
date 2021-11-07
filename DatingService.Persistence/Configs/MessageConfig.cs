using DatingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class MessageConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.Property(c => c.Content).IsRequired().HasMaxLength(1024);

            builder.HasOne(m => m.Chat).WithMany(c => c.Messages).HasForeignKey(n => n.ChatId);
            builder.HasOne(m => m.User).WithMany(u => u.Messages).HasForeignKey(n => n.UserId);
        }
    }
}
