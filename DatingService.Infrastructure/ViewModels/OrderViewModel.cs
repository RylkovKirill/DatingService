using System;

namespace DatingService.Infrastructure.ViewModels
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Nonce { get; set; }
        public decimal Price { get; set; }
    }
}
