using DatingService.Domain.Auth;
using System;

namespace DatingService.Domain.Entities
{
    public class Report : BaseEntity<Guid>
    {
        //public string Content { get; set; }

        public Guid ReportCategoryId { get; set; }
        //public Guid UserId { get; set; }

        //public ReportCategory Category { get; set; }
        //public ApplicationUser User { get; set; }
    }
}
