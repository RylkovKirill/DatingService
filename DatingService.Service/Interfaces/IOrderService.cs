using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using System;
using System.Linq;


namespace DatingService.Service.Interfaces
{
    public interface IOrderService
    {
        Order Get(Guid id);
        IQueryable<Order> GetAll();
        IQueryable<Order> GetAll(ApplicationUser user);
        void Add(Order order);
        void Update(Order order);
        void Remove(Guid id);
    }
}
