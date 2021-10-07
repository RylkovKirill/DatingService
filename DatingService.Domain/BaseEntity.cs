using System;

namespace DatingService.Domain
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}
