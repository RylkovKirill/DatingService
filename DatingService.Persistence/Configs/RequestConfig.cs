using DatingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class RequestConfig : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasOne(r => r.Sender).WithMany(u => u.SentRequests).HasForeignKey(r => r.SenderId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(r => r.Receiver).WithMany(u => u.ReceivedRequests).HasForeignKey(r => r.ReceiverId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
