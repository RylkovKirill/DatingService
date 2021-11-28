using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public Order Get(Guid id)
        {
            return _repository.GetAll()
                .Include(o => o.User)
                .Where(o => o.Id == id).First();
        }

        public IQueryable<Order> GetAll()
        {
            return _repository.GetAll()
                .Include(o => o.User);
        }

        public IQueryable<Order> GetAll(ApplicationUser user)
        {
            return _repository.GetAll()
                .Include(o => o.User)
                .Where(c => c.UserId == user.Id);
        }


        public void Add(Order order)
        {
            _repository.Add(order);
        }

        public void Update(Order order)
        {
            _repository.Update(order);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }
    }
}
