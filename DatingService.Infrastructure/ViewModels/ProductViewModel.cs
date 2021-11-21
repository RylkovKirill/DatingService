using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Infrastructure.ViewModels
{
    public class ProductViewModel: Product
    {
        public string Nonce { get; set; }
    }
}
