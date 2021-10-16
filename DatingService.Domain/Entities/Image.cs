using System;

namespace DatingService.Domain.Entities
{
    public class Image : FileEntity<Guid>
    {
        public Guid PostId { get; set; }

        public Post Post { get; set; }
    }
}
