using DatingService.Domain.Entities;
using System.Linq;

namespace DatingService.Infrastructure.ViewModels
{
    public class RequestViewModel
    {
        public IQueryable<Request> OutgoingRequests { get; set; }
        public IQueryable<Request> IncomingRequests { get; set; }
    }
}
