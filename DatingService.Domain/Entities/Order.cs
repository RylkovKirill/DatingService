using DatingService.Domain.Auth;
using System;


namespace DatingService.Domain.Entities
{
    public class Order : BaseEntity<Guid>
    {
        public decimal Price { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
