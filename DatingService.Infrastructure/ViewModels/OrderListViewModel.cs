using DatingService.Domain.Entities;
using System.Collections.Generic;

namespace DatingService.Infrastructure.ViewModels
{
    public class OrderListViewModel
    {
        public string Filter { get; set; }
        public PageViewModel PageViewModel { get; set; }

        public List<Order> Orders { get; set; }
    }
}
