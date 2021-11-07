using DatingService.Domain.Auth;
using System;

namespace DatingService.Domain.Entities
{
    public class Message : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
         
        public string Content { get; set; }

        public ApplicationUser User { get; set; }
        public Chat Chat { get; set; }
    }
}
