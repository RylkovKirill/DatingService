using System;

namespace DatingService.Domain.Entities
{
    public class File : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
