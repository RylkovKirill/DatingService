using DatingService.Domain.Auth;
using System;
using System.Collections.Generic;

namespace DatingService.Domain.Entities
{
    public class Chat : BaseEntity<Guid>
    {
        public ICollection<Message> Messages { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
}
