using DatingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingService.Persistence.Configs
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(m => m.Price).IsRequired().HasPrecision(14, 2);

            builder.HasOne(m => m.User).WithMany(c => c.Orders).HasForeignKey(n => n.UserId);
        }
    }
}
