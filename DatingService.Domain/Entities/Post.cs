using DatingService.Domain.Auth;
using System;
using System.Collections.Generic;

namespace DatingService.Domain.Entities
{
    public class Post : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsPublished { get; set; }
        
        public Guid? ImageId { get; set; }
        public Guid? UserId { get; set; }

        public Image Image { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
