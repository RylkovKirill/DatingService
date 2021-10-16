using System;

namespace DatingService.Domain
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}
