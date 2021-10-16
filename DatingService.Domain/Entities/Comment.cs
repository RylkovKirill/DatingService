using DatingService.Domain.Auth;
using System;

namespace DatingService.Domain.Entities
{
    public class Comment : BaseEntity<Guid>
    {
        public string Content { get; set; }

        public Guid PostId { get; set; }
        public Guid UserId { get; set; }

        public Post Post { get; set; }
        public ApplicationUser User { get; set; }
    }
}
