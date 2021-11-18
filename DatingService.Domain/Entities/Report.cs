using DatingService.Domain.Auth;
using System;

namespace DatingService.Domain.Entities
{
    public class Report : BaseEntity<Guid>
    {
        public string Content { get; set; }

        public Guid ReportCategoryId { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }

        public ReportCategory Category { get; set; }
        public ApplicationUser Sender { get; set; }
        public ApplicationUser Receiver { get; set; }
    }
}
