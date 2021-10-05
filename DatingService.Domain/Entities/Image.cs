using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Domain.Entities
{
    public class Image : BaseEntity<Guid>
    {
        public string Path { get; set; }
    }
}
