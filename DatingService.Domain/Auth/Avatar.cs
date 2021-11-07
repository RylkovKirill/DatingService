using System;

namespace DatingService.Domain.Auth
{
    public class Avatar : FileEntity<Guid>
    {
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
