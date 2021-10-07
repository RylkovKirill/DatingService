using DatingService.Domain.Auth;
using System;

namespace DatingService.Domain.Entities
{
    public class Avatar : File
    {
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
