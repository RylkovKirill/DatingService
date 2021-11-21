using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Domain.Entities
{
    public class Product:BaseEntity<Guid>
    {
        
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
