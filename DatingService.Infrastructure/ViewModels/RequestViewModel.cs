using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Infrastructure.ViewModels
{
    public class RequestViewModel
    {
        public IQueryable<Request> OutgoingRequests { get; set; }
        public IQueryable<Request> IncomingRequests { get; set; }
    }
}
