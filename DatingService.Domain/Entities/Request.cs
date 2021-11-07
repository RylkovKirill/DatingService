using DatingService.Domain.Auth;
using DatingService.Domain.Enums;
using System;

namespace DatingService.Domain.Entities
{
    public class Request : BaseEntity<Guid>
    {
        public RequestStatus RequestStatus { get; set; } = RequestStatus.Considered;

        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }

        public ApplicationUser Sender { get; set; }
        public ApplicationUser Receiver { get; set; }
    }
}
