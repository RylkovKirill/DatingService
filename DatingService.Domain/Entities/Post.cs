using System;

namespace DatingService.Domain.Entities
{
    public class Post : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        
        public Guid ImageId { get; set; }
        public Guid UserId { get; set; }
    }
}
