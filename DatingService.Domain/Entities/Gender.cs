using DatingService.Domain.Auth;
using System;
using System.Collections.Generic;

namespace DatingService.Domain.Entities
{
    public class Gender : BaseEntity<Guid>
    {
        public string Name { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
