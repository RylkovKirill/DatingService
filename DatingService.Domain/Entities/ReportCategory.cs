using System;
using System.Collections.Generic;

namespace DatingService.Domain.Entities
{
    public class ReportCategory : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}
