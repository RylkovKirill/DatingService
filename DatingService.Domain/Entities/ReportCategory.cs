using System;

namespace DatingService.Domain.Entities
{
    public class ReportCategory : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
